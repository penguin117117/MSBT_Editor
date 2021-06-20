using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSBT_Editor.FileSys;
using MSBT_Editor.Formsys;
using MSBT_Editor.Sectionsys;

namespace MSBT_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private static Form1 _form1Instance;


        public static Form1 Form1Instance
        {
            get
            { return _form1Instance; }
            set
            { _form1Instance = value; }
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog.Open();
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0 && (MSBTsys.MSBT_Data.MSBT_All_Data.Item.Count != 0) && MSBTsys.MSBT_Data.MSBT_All_Data.Text.Count != 0)
                Dialog.Save();
        }

        private void 上書き保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialog.SaveAs();
        }

        public readonly string[] IconNameJP01 = { "ピーチ", "クッパ", "キノピオ", "マリオ", "マリオ2", "チコ", "ヨッシー", "腹ペコチコ", "ルイージ", "ベビーチコ", "アシストチコ", "ベーゴマン", "クリボー" };
        public readonly string[] IconNameJP02 = { "彗星メダル", "コイン×3", "カラフルスターピース", "イエローチップ", "スターピース紫", "シルバースター", "スター", "グランドスター", "ブロンズスター", "コイン", "パープルコイン", "1UPキノコ", "ライフアップキノコ", "ブルースター", "スターリング", "ヨッシーキャプチャー花" };
        public readonly string[] IconNameJP03 = { "ポインター", "2Pポインター", "ハンドポインター", "Wiiリモコン", "Aボタン", "Bボタン", "Cボタン", "Zボタン", "十字ボタン", "十字ボタン下", "十字ボタン上", "スティック", "ヌンチャク", "照準", "マイナスボタン", "プラスボタン", "×(かける)アイコン", "グリーンコメット", "銀の王冠", "銀の王冠宝石付き", "金の王冠", "手紙", "矢印下", "ストップウォッチ" };
        private void Form1_Load(object sender, EventArgs e)
        {
            Form1.Form1Instance = this;

            
            comboBox5.Items.AddRange(IconNameJP01);
            comboBox6.Items.AddRange(IconNameJP02);
            comboBox7.Items.AddRange(IconNameJP03);
            //コマンドライン引数を配列で取得する
            string[] files = System.Environment.GetCommandLineArgs();

            if (files.Length > 1) FileSys.Dialog.FileCheck(files[1]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //if (MSBT_Editor.MSBTsys.MSBT_Data.Txt2_Text_List.Count > 0)
            if (MSBT_Editor.MSBTsys.MSBT_Data.MSBT_All_Data.Text.Count > 0)
            {
                if (listBox1.SelectedIndex < 0) listBox1.SelectedIndex = 0;
                var selectnum = listBox1.SelectedIndex;
                MSBTsys.MSBT_Data.Data_List mad = MSBTsys.MSBT_Data.MSBT_All_Data;
                List<string> nulldata =  MSBTsys.MSBT_Data.atr_nulldata;
                textBox1.Text = mad.Text[selectnum];
                textBox3.Text = mad.Item[selectnum].unknown1.ToString("X2");
                textBox4.Text = mad.Item[selectnum].unknown2.ToString("X2");
                textBox5.Text = mad.Item[selectnum].Dialog_Type.ToString("X2");
                textBox6.Text = mad.Item[selectnum].unknown3.ToString("X2");
                textBox7.Text = mad.Item[selectnum].unknown4.ToString("X4");
                textBox8.Text = mad.Item[selectnum].unknown5.ToString("X2");
                textBox9.Text = mad.Item[selectnum].unknown6.ToString("X2");
                textBox10.Text = mad.Item[selectnum].null_offset.ToString("X8");
                textBox11.Text = nulldata[selectnum];

                var liststrs = listBox1.Text;
                //Console.WriteLine(liststrs+ LBL1.list_name.IndexOf(liststrs)+"_"+LBL1.list_name.Count());
                if (-1 != LBL1.list_name.IndexOf(liststrs))
                {
                    //Console.WriteLine("OK");
                    var unknownlbldata = LBL1.unknownpos[LBL1.list_name.IndexOf(liststrs)].ToString("X");
                    textBox12.Text = LBL1.unknown[LBL1.list_name.IndexOf(liststrs)].ToString("X8");
                }
                else {
                    textBox12.Text = "";
                }
            }
            else 
            {
                textBox1.Text = "null";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(textBox3);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(textBox4);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(textBox5);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(textBox6);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(textBox7);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(textBox8);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            ATR1.ATR1_Change(textBox9);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            ATR1.nulldata[listBox1.SelectedIndex] = textBox11.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            var liststrs = listBox1.Text;
            if (-1 != LBL1.list_name.IndexOf(liststrs))
            {
                var unknownlbldata = LBL1.unknownpos[LBL1.list_name.IndexOf(liststrs)].ToString("X");
                LBL1.unknown[LBL1.list_name.IndexOf(liststrs)] = Int32.Parse(textBox12.Text,System.Globalization.NumberStyles.HexNumber);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (listBox1.Items.Count != 0)
            {
                MSBTsys.MSBT_Data.MSBT_All_Data.Text[listBox1.SelectedIndex] = textBox1.Text;
            }
        }

        private void AddListText_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                if (ListNameText.Text != "")
                {
                    listBox1.Items.Add(ListNameText.Text);
                    MSBTsys.MSBT_Data.MSBT_All_Data.Text.Add("テキスト</End>");
                    MSBTsys.MSBT_Data.MSBT_All_Data.Item.Add(new ATR1.Item(0x1, 0x0, 0x0, 0x0, 0x0, 0xFF, 0xFF, 0x00));
                    MSBTsys.MSBT_Data.atr_nulldata.Add("");
                }
            }
            else {
                if (ListNameText.Text != "")
                {
                    MSBTsys.MSBT_Data.Data_List msbtdatalist = new MSBTsys.MSBT_Data.Data_List();
                    msbtdatalist.Item = new List<ATR1.Item>();
                    msbtdatalist.Text = new List<string>();
                    MSBTsys.MSBT_Data.atr_nulldata = new List<string>() ;
                    LBL1.list_name = new List<string>();
                    LBL1.unknown = new List<int>();
                    LBL1.unknownpos = new List<long>();

                    listBox1.Items.Add(ListNameText.Text);
                    LBL1.list_name.Add(ListNameText.Text);
                    LBL1.unknown.Add(1);
                    LBL1.unknownpos.Add(0);


                    MSBTsys.MSBT_Data.atr_nulldata.Add("");
                    MSBTsys.MSBT_Data.MSBT_All_Data = msbtdatalist;
                    
                    MSBTsys.MSBT_Data.MSBT_All_Data.Text.Add("テキスト</End>");
                    MSBTsys.MSBT_Data.MSBT_All_Data.Item.Add(new ATR1.Item(0x1, 0x0, 0x0, 0x0, 0x0, 0xFF, 0xFF, 0x00));
                }
            }
        }

        private void DeleteListText_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0 && (MSBTsys.MSBT_Data.MSBT_All_Data.Item.Count !=0) && MSBTsys.MSBT_Data.MSBT_All_Data.Text.Count != 0)
            {
                MSBTsys.MSBT_Data.MSBT_All_Data.Item.RemoveRange(listBox1.SelectedIndex,1);
                MSBTsys.MSBT_Data.MSBT_All_Data.Text.RemoveRange(listBox1.SelectedIndex, 1);
                MSBTsys.MSBT_Data.atr_nulldata.RemoveRange(listBox1.SelectedIndex , 1);
                LBL1.list_name.RemoveRange(listBox1.SelectedIndex , 1);
                LBL1.unknown.RemoveRange(listBox1.SelectedIndex , 1);
                LBL1.unknownpos.RemoveRange(listBox1.SelectedIndex , 1);
                var listselect = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(listselect);
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            LBL1 lbl1 = new LBL1();
            lbl1.Entries = Int32.Parse(textBox14.Text);
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            ATR1 atr1 = new ATR1();
            atr1.Entries = Int32.Parse(textBox15.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1 ) return ;

            string color = "";

            switch (comboBox1.Text) {
                case "ブラック":
                    color = "Black";
                    break;
                case "レッド":
                    color = "Red";
                    break;
                case "グリーン":
                    color = "Green";
                    break;
                case "ブルー":
                    color = "Blue";
                    break;
                case "イエロー":
                    color = "Yellow";
                    break;
                case "パープル":
                    color = "Purple";
                    break;
                case "オレンジ":
                    color = "Orange";
                    break;
                case "グレー":
                    color = "Gray";
                    break;
                case "エンドタグ":
                    Calculation_System.TextBoxInsert(textBox1, "</Color>");
                    return;
                default:
                    color = "Black";
                    break;
            }

            string tag = "<Color=\"" + color +"\">";

            Calculation_System.TextBoxInsert(textBox1,tag);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;

            string tag = "";

            switch (comboBox2.Text) {
                case "改行":
                    tag = "</br>" + Environment.NewLine;
                    break;
                case "次のページ":
                    tag = "</New_Page>"+Environment.NewLine + Environment.NewLine;
                    break;
                case "終了":
                    tag = "</End>";
                    break;
                default:
                    tag = "</br>" + Environment.NewLine;
                    break;
            }
            if (tag == "</End>") {
                if (textBox1.Text.IndexOf("</End>") != -1) {
                    MessageBox.Show("</End>が二つ以上あるとデータが"+ "\n\r" +"破損するので挿入をキャンセルしました", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
                
            }
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;

            string tag = "";

            switch (comboBox3.Text)
            {
                case "小":
                    tag = "<Size=\"Small\">";
                    break;
                case "普通":
                    tag = "<Size=\"Normal\">";
                    break;
                case "大":
                    tag = "<Size=\"Large\">";
                    break;
                default:
                    tag = "<Size=\"Normal\">";
                    break;
            }

            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;

            string tag = "";

            switch (comboBox4.Text)
            {
                case "横方向":
                    tag = "</XCenter>";
                    break;
                case "縦方向":
                    tag = "</YCenter>";
                    break;
                default:
                    tag = "</XCenter>";
                    break;
            }

            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;
            if (textBox16.Text == "" || textBox17.Text == "") return;
            string furigana = textBox16.Text;
            string kanji = textBox17.Text;
            string tag = "<Rubi=\"" + furigana + "\" Target=\"" + kanji + "\">";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;
            if (textBox18.Text == "" ) return;
            string time = textBox18.Text;
            string tag = "</Timer=\"" + time + "\">";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;
            string tag = "</PlayCharacter>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;
            string tag = "</StarShipTag>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;
            string tag = "</ResultGalaxyName>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;
            string tag = "</ResultScenarioName>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            //if (listBox1.Items.Count < 1) return;
            //if (comboBox5.Items.Count == -1) return;
            //if (comboBox5.SelectedIndex == -1) comboBox5.SelectedIndex = 0 ;
            string[] IconTag = { "<Icon=\"Peach\">", "<Icon=\"Koopa\">", "<Icon=\"Kinopio\">", "<Icon=\"Mario\">", "<Icon=\"Mario2\">", "<Icon=\"Tico\">", "<Icon=\"Yoshi\">", "<Icon=\"HarapekoTico\">", "<Icon=\"Luigi\">", "<Icon=\"MasterTico\">", "<Icon=\"Columa\">", "<Icon=\"Begoman\">", "<Icon=\"Kuribo\">" };
            Calculation_System.TextBoxTagAdder(listBox1,textBox1,comboBox5,IconTag);
            //int index = comboBox5.SelectedIndex;
            //string tag = IconTag[index];
            //Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //if (listBox1.Items.Count < 1) return;
            //if (comboBox6.Items.Count == -1) return;
            //if (comboBox6.SelectedIndex == -1) comboBox6.SelectedIndex = 0;
            string[] IconTag = { "<Icon=\"CometMedal\">", "<Icon=\"Coins\">", "<Icon=\"Starbit\">", "<Icon=\"StarPiece\">", "<Icon=\"PurpleStarbit\">", "<Icon=\"SilverStar\">", "<Icon=\"Star\">", "<Icon=\"GrandStar\">", "<Icon=\"BronzeStar\">", "<Icon=\"Coin\">", "<Icon=\"PurpleCoin\">", "<Icon=\"1UPMushroom\">", "<Icon=\"LifeUpMushroom\">", "<Icon=\"BlueStar\">", "<Icon=\"StarRing\">", "<Icon=\"Flower\">" };
            Calculation_System.TextBoxTagAdder(listBox1, textBox1, comboBox6, IconTag);
            //int index = comboBox6.SelectedIndex;
            //string tag = IconTag[index];
            //Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string[] IconTag = { "<Icon=\"Pointer\">", "<Icon=\"PointerYellow\">", "<Icon=\"PointerHand\">", "<Icon=\"WiiMote\">", "<Icon=\"AButton\">", "<Icon=\"BButton\">", "<Icon=\"CButton\">", "<Icon=\"ZButton\">", "<Icon=\"DPad\">", "<Icon=\"DPadDown\">", "<Icon=\"DPadUp\">", "<Icon=\"JoyStick\">", "<Icon=\"Nunchuck\">", "<Icon=\"Aim\">", "<Icon=\"MButton\">", "<Icon=\"PButton\">", "<Icon=\"XIcon\">", "<Icon=\"GreenComet\">", "<Icon=\"SilverCrown\">", "<Icon=\"SilverCrownwJewel\">", "<Icon=\"GoldCrown\">", "<Icon=\"Letter\">", "<Icon=\"ArrowDown\">", "<Icon=\"StopWatch\">" };
            Calculation_System.TextBoxTagAdder(listBox1, textBox1, comboBox7, IconTag);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;
            string tag = "</Year01>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;
            string tag = "</Year02>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;
            string tag = "</Hour>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;
            string tag = "</Minutes>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;
            string tag = "</Seconds>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 1) return;
            string tag = "</AfterTheDecimalPoint>";
            Calculation_System.TextBoxInsert(textBox1, tag);
        }
    }
}
