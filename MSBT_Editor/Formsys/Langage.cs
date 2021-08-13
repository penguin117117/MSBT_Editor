using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

            /*
             *Translations done by Evanbowl. 
             * However, I am not the best at programming.
             * This code can definitely be improved, but this is the best I can do.
             * It works well an I am proud at how it turned out.
            */

namespace MSBT_Editor.Formsys
{
    public class Langage : objects
    {
        public static void Langage_Check()
        {
            switch (Properties.Settings.Default.言語)
            {
                case "日本語":
                    JP();
                    break;
                case "EN":
                    EN();
                    break;
                default:
                    JP();
                    break;
            }
        }

        public static string FLW2_List_Langage(int num)
        {
            switch (Properties.Settings.Default.言語)
            {
                case "日本語":
                    return FLW_List_JP(num);
                case "EN":
                    return FLW_List_EN(num);
                default:
                    return FLW_List_JP(num);
            }
        }

        public static string FLW_List_JP(int num)
        {
            string str = "";
            switch (num)
            {
                case 0x0001:
                    str = "会話決定とジャンプ？";
                    break;
                case 0x0002:
                    str = "分岐？";
                    break;
                case 0x0003:
                    str = "イベント制御？";
                    break;
                case 0x0004:
                    str = "メッセージエントリーポイント？";
                    break;

            }
            return str;
        }

        public static string FLW_List_EN(int num)
        {
            string str = "";
            switch (num)
            {
                case 0x0001:
                    str = "Message Flow";
                    break;
                case 0x0002:
                    str = "Condition Flow";
                    break;
                case 0x0003:
                    str = "Event Flow";
                    break;
                case 0x0004:
                    str = "Initializer Flow";
                    break;

            }
            return str;
        }

        public static void JP()
        {
            tssl1.Text = "状態：";
            //menue
            tlmi_file.Text = "ファイル";
            tlmi_msbt_open.Text = "MSBT開く";
            tlmi_msbt_save.Text = "MSBT保存";
            tlmi_msbt_save_as.Text = "MSBT上書き保存";
            tlmi_msbf_open.Text = "MSBF開く";
            tlmi_msbf_save.Text = "MSBF保存";
            tlmi_msbf_save_as.Text = "MSBF上書き保存";
            //tab
            tabp1.Text = "MSBTテキストの詳細設定";
            tabp2.Text = "MSBTテキスト編集";
            tabp3.Text = "リスト編集";
            tabp4.Text = "MSBFの設定";
            //label
            labeltxt01.Text = "NPCボイス";
            labeltxt02.Text = "カメラ";
            labeltxt03.Text = "ダイアログタイプ";
            labeltxt04.Text = "ウィンドウタイプ";
            labeltxt05.Text = "イベントカメラID";
            labeltxt06.Text = "会話制御エリア Obj_arg1";
            labeltxt07.Text = "分からない6";
            labeltxt08.Text = "特殊テキストオフセット";
            labeltxt09.Text = "特殊テキスト(基本null) ※上級者以外触らない";
            labeltxt10.Text = "タグインデックス？";
            labeltxt11.Text = "追加するMSBTリスト名";
            labeltxt12.Text = "削除は対象のリスト選択後に" + Environment.NewLine + "右の削除ボタンを押す";
            labeltxt13.Text = "※ゲームの命名規則を守ってください";
            labeltxt15.Text = "※初心者は触らないでください" + Environment.NewLine + "データが破損する恐れあり";

            labeltxt23.Text = "フロータイプ";
            labeltxt24.Text = "パディング";

            labeltxt29.Text = "ジャンプ先1";
            labeltxt30.Text = "ジャンプ先2";
            labeltxt34.Text = "この項目は名前が不要です";
            labeltxt35.Text = "名前必須(Flowなどを省いた名前)";
            labeltxt31.Text = "不明";
            labeltxt32.Text = "FLW2開始インデックス";
            labeltxt39.Text = "この項目が　0　の場合" + Environment.NewLine + "ゲームにテキストが認識されません";

            //groupbox
            groupbox8.Text = "フロータイプ2の場合のみ";

            //button
            listadd.Text = "追加";
            listdelete.Text = "削除";
            button21.Text = "追加";
            button22.Text = "削除";
            button23.Text = "追加";
            button24.Text = "削除";

            //New Translations

            //Text Options Tab
            button1.Text = "カラータグ挿入";
            button2.Text = "行制御タグ挿入";
            button3.Text = "サイズタグ挿入";
            button4.Text = "センタリングタグ挿入";
            tabp6.Text = "汎用タグ";

            box1text.Items.Clear();
            box2text.Items.Clear();
            box3text.Items.Clear();
            box4text.Items.Clear();

            box1text.Items.AddRange(new object[] {
            "ブラック",
            "レッド",
            "グリーン",
            "ブルー",
            "イエロー",
            "パープル",
            "オレンジ",
            "グレー",
            "エンドタグ"});
            box1text.Text = "ブラック";

            box2text.Items.AddRange(new object[] {
            "改行",
            "次のページ",
            "終了"});
            box2text.Text = "改行";

            box3text.Items.AddRange(new object[] {
            "小",
            "普通",
            "大"});
            box3text.Text = "小";

            box4text.Items.AddRange(new object[] {
            "横方向",
            "縦方向"});

            box4text.Text = "横方向";


            //Ruby Tab

            tabpage7.Text = "数値必要タグ";

            //Other Tags Tab

            tabpage8.Text = "特殊タグ";

            button7.Text = "プレイキャラクター";
            button8.Text = "星船不明タグ";
            button9.Text = "リザルトギャラクシー名";
            button10.Text = "リザルトシナリオ名";
            button14.Text = "年01？";
            button15.Text = "年02？";
            button16.Text = "時間";
            button17.Text = "分";
            button18.Text = "秒";
            button19.Text = "小数点以下";

            //Icon Tab

            IconBox1.Items.Clear();
            IconBox2.Items.Clear();
            IconBox3.Items.Clear();

            IconBox1.Text = "ピーチ";
            IconBox2.Text = "彗星メダル";
            IconBox3.Text = "ポインター";

            IconBox1.Items.AddRange(new object[] { "ピーチ", "クッパ", "キノピオ", "マリオ", "マリオ2", "チコ", "ヨッシー", "腹ペコチコ", "ルイージ", "ベビーチコ", "アシストチコ", "ベーゴマン", "クリボー" });
            IconBox2.Items.AddRange(new object[] { "彗星メダル", "コイン×3", "カラフルスターピース", "イエローチップ", "スターピース紫", "シルバースター", "スター", "グランドスター", "ブロンズスター", "コイン", "パープルコイン", "1UPキノコ", "ライフアップキノコ", "ブルースター", "スターリング", "ヨッシーキャプチャー花" });
            IconBox3.Items.AddRange(new object[] { "ポインター", "2Pポインター", "ハンドポインター", "Wiiリモコン", "Aボタン", "Bボタン", "Cボタン", "Zボタン", "十字ボタン", "十字ボタン下", "十字ボタン上", "スティック", "ヌンチャク", "照準", "マイナスボタン", "プラスボタン", "×(かける)アイコン", "グリーンコメット", "銀の王冠", "銀の王冠宝石付き", "金の王冠", "手紙", "矢印下", "ストップウォッチ" });


            IconBox2.Show();
            IconBox3.Show();

            label20.Text = "キャラクター系";
            label21.Text = "アイテム、オブジェクト";
            label22.Text = "操作、その他";

            button11.Text = "NPC,キャラタグ挿入";
            button12.Text = "アイテム.オブジェクトタグ挿入";
            button13.Text = "操作,その他タグ挿入";

            tabpage9.Text = "アイコンタグ";

            label21.Show();
            label22.Show();

            button12.Show();
            button13.Show();

            box3.Text = "各セクションのエントリーサイズ";

            if (tssl2.Text == "  " || tssl2.Text == "No MSBT Open")
                tssl2.Text = "NA";

            if (tssl4.Text == "  " || tssl4.Text == "No MSBF Open")
                tssl4.Text = "NA";
        }

    public static void EN()
        {
            tssl1.Text = "State：";
            tlmi_file.Text = "File";
            tlmi_msbt_open.Text = "MSBT Open";
            tlmi_msbt_save.Text = "MSBT Save";
            tlmi_msbt_save_as.Text = "MSBT Save As";
            tlmi_msbf_open.Text = "MSBF Open";
            tlmi_msbf_save.Text = "MSBF Save";
            tlmi_msbf_save_as.Text = "MSBF Save As";

            box3.Text = "LBL1/ATR1 Entry Size Settings";
            //tab
            tabp1.Text = "MSBT Text Settings";
            tabp2.Text = "MSBT Text Editing";
            tabp3.Text = "List Editing";
            tabp4.Text = "MSBF Settings";
            //label
            labeltxt01.Text = "NPC Sound";
            labeltxt02.Text = "Camera";
            labeltxt03.Text = "Dialog Type";
            labeltxt04.Text = "Window Type";
            labeltxt05.Text = "Event Camera ID";
            labeltxt06.Text = "MessageArea Obj_arg0";
            labeltxt07.Text = "Unknown6";
            labeltxt08.Text = "Special Text Offset";
            labeltxt09.Text = "Unique text (Basically null) ※Don't touch it except advanced users";
            labeltxt10.Text = "Tag index？？";
            labeltxt11.Text = "Add Entry";
            labeltxt12.Text = "Delete the selected entry";
            labeltxt13.Text = "";

            labeltxt15.Text = "※Don't touch this, data may break";

            labeltxt23.Text = "Flow Type";
            labeltxt24.Text = "Padding";

            labeltxt29.Text = "Jump destination 1";
            labeltxt30.Text = "Jump destination 2";
            labeltxt31.Text = "Unknown";
            labeltxt32.Text = "FLW2 start index";
            labeltxt34.Text = "This item doesn't require a name.";
            labeltxt35.Text = "Name required (name without Flow, etc.)";
            labeltxt39.Text = "This item must not be 0";

            //groupbox
            groupbox8.Text = "Condition Flows";
            listadd.Text = "Add";
            listdelete.Text = "Delete";
            button21.Text = "Add";
            button22.Text = "Delete";
            button23.Text = "Add";
            button24.Text = "Delete";

            // Added EN Translations start here.

            //Text Options Tab
            button1.Text = "Apply Color Tag";
            button2.Text = "Apply Text Behavior Tag";
            button3.Text = "Apply Size Tag";
            button4.Text = "Apply Position Tag";

            tabp6.Text = "Text Options";

            box1text.Items.Clear(); //Clears all Combo Boxes to prevent option duplication.
            box2text.Items.Clear();
            box3text.Items.Clear();
            box4text.Items.Clear();
            //Adds the new English text.

            //comboBox1
            box1text.Items.AddRange(new object[] {"Black", "Red", "Green", "Blue", "Yellow", "Purple", "Orange", "Gray"});
            box1text.Text = "Black";

            //comboBox2
            box2text.Items.AddRange(new object[] {"End", "Next Line", "New Page"});
            box2text.Text = "End";

            //comboBox3
            box3text.Items.AddRange(new object[] {"Small", "Normal", "Large"});
            box3text.Text = "Small";

            //comboBox4
            box4text.Items.AddRange(new object[] {"X Center", "Y Center"});
            box4text.Text = "X Center";

            //Ruby Tab
            tabpage7.Text = "Ruby";

            //Other Tags Tab
            button7.Text = "Character Name";
            button8.Text = "Starship Tag";
            button9.Text = "Result Galaxy Name";
            button10.Text = "Result Scenario Name";
            button14.Text = "Year 1";
            button15.Text = "Year 2";
            button16.Text = "Hour";
            button17.Text = "Minutes";
            button18.Text = "Seconds";
            button19.Text = "Result Galaxy Name";
            button19.Text = "After Decimal";

            tabpage8.Text = "Other Tags";

            //Icons
            IconBox1.Text = "A Button";
            IconBox2.Hide();
            IconBox3.Hide();
            label20.Text = "All Icons";
            button11.Text = "Apply Icon";
            tabpage9.Text = "Icons";
            IconBox1.Items.Clear();
            IconBox2.Items.Clear();
            IconBox3.Items.Clear();

            //Icon List (sorry for long string!)
            IconBox1.Items.AddRange(new object[] { "A Button", "B Button", "C Button", "Wii Remote", "Nunchuck", "1 Button", "2 Button", "Power Star", "Launch Star", "Pull Star", "P1 Pointer", "Purple Star Bit", "Coconut", "Down Arrow", "Star Bunny", "Control Stick", "X Icon", "Coin", "Mario Icon", "D-Pad", "Pull Star Chip", "Star Chip", "HOME Button", "Minus Button", "Plus Button", "Z Button", "Silver Star", "Grand Star", "Luigi Icon", "P2 Pointer", "Purple Coin", "Green Comet", "Golden Crown", "Aim Target", "Bowser Icon", "Star Pointer Hand (Selected)", "Star Pointer Hand (Pointing)", "Star Pointer Hand (Selecting)", "Rainbow Star Bit", "Peach Icon", "Letter", "Question Mark", "One Up Mushroom", "Life Up Mushroom", "Hungry Luma", "Luma", "Power Star Comet", "Green Question Mark", "Timer Icon", "Young Master Luma", "Yoshi", "Comet Medal", "Silver Crown", "Yoshi Grapple", "Checkpoint Flag", "Empty Power Star", "Empty Comet Medal", "Empty Comet", "Empty Hidden Star", "Bronze Star", "Blimp Fruit", "Large Silver Crown", "Bronze Grand Star", "Topman", "Goomba", "Coin Stack", "D-Pad Up", "D-Pad Down", "Co-Star Luma", "Toad", "Bronze Comet" });

            //Custom icons- to be removed!
            IconBox1.Items.AddRange(new object[] { "Red Star", "Blue Star", "Legacy Green Star", "Red Comet", "Blue Comet", "Legacy Green Comet" });

            //Hide things
            label21.Hide();
            label22.Hide();
            button12.Hide();
            button13.Hide();

            //State

            if (tssl2.Text == "  " || tssl2.Text == "NA")
                tssl2.Text = "No MSBT Open";

            if (tssl4.Text == "  " || tssl4.Text == "NA")
                tssl4.Text = "No MSBF Open";

        }
    }
}
