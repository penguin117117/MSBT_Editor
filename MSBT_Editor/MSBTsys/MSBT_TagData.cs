using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSBT_Editor.MSBTsys
{
    public class MSBT_TagData
    {
        /// <summary>
        /// タグを決めるインターフェース
        /// </summary>
        public interface ITagDecide
        {
            string TagDecideText(int Index);
        }

        /// <summary>
        /// MSBTタグを挿入する処理の直前に必ず設置する必要があります。<br/>
        /// リストデータの存在と、コンボボックスのアイテムが選択されているかをチェックします。
        /// </summary>
        /// <param name="msbtList"></param>
        /// <param name="comboBox"></param>
        /// <returns></returns>
        public static bool CanTextInsert(ListBox msbtList, ComboBox comboBox)
        {
            if (msbtList.Items.Count < 1) return false;
            var Index = comboBox.SelectedIndex;
            if (Index == -1) return false;
            return true;
        }

        public static void TextBoxTagInsert(TextBox tb, string str)
        {
            if (str == string.Empty) return;
            tb.SelectedText = str;
        }

        /// <summary>
        /// ラインコントロールタグを設定するクラス
        /// </summary>
        public class LineControlTag : ITagDecide
        {
            private readonly string[] LineControl =
            {
                "</br>" + Environment.NewLine,
                "</New_Page>" + Environment.NewLine + Environment.NewLine,
                "</End>"
            };
            public string TagDecideText(int Index)
            {
                var Tag = LineControl[Index];
                return Tag;
            }
        }


        /// <summary>
        /// カラータグを設定するクラス
        /// </summary>
        public class ColorTag : ITagDecide
        {
            private readonly string[] Color =
            {
                "<Color=\"Black\">",
                "<Color=\"Red\">",
                "<Color=\"Green\">",
                "<Color=\"Blue\">",
                "<Color=\"Yellow\">",
                "<Color=\"Purple\">",
                "<Color=\"Orange\">",
                "<Color=\"Gray\">",
                "</Color>"
            };
            public string TagDecideText(int Index)
            {
                var Tag = Color[Index];
                return Tag;
            }
        }

        public class FontSizeTag : ITagDecide
        {
            private readonly string[] FontSize =
            {
                "<Size=\"Small\">",
                "<Size=\"Normal\">",
                "<Size=\"Large\">"
            };
            public string TagDecideText(int Index)
            {
                var Tag = FontSize[Index];
                return Tag;
            }
        }

        public class CenterTag : ITagDecide
        {
            private readonly string[] Center = {
                "</XCenter>",
                "</YCenter>"
            };
            public string TagDecideText(int Index)
            {
                var Tag = Center[Index];
                return Tag;
            }
        }

        /// <summary>
        /// タグを決定しMSBTのテキストに挿入するクラス
        /// </summary>
        public class TagInsertModified
        {
            private readonly ITagDecide _decideTag;
            public TextBox MsbtTextBox { get; set; }
            public ListBox MsbtListBox { get; set; }
            public ComboBox TagComboBox { get; set; }
            public TagInsertModified(ITagDecide tagDecide)
            {
                _decideTag = tagDecide;
            }
            public void ToMsbtTextBoxInsert()
            {
                if (CanTextInsert(MsbtListBox, TagComboBox)
                    == false) return;

                string Tag
                    = _decideTag.TagDecideText(TagComboBox.SelectedIndex);

                if (Tag == "</End>")
                {
                    if (MsbtTextBox.Text.IndexOf("</End>") != -1)
                    {

                        MessageBox.Show("</End>が二つ以上あるとデータが" + "\n\r" + "破損するので挿入をキャンセルしました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                TextBoxTagInsert(MsbtTextBox, Tag);
            }


        }
    }
}
