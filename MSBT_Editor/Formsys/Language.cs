using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSBT_Editor.Formsys
{
    public class Language : objects
    {
        private static readonly string[] IconNameJP01 = { "ピーチ", "クッパ", "キノピオ", "マリオ", "マリオ2", "チコ", "ヨッシー", "腹ペコチコ", "ルイージ", "ベビーチコ", "アシストチコ", "ベーゴマン", "クリボー", "星ウサギ" };
        private static readonly string[] IconNameJP02 = { "彗星メダル", "コイン×3", "カラフルスターピース", "イエローチップ", "スターピース紫", "シルバースター", "スター", "グランドスター", "ブロンズスター", "コイン", "パープルコイン", "1UPキノコ", "ライフアップキノコ", "ブルースター", "スターリング", "ヨッシーキャプチャー花", "ココナッツ", "ブルーチップ", "バルーンフルーツ", "中間ポイント", "グランドブロンズスター" };
        private static readonly string[] IconNameJP03 = { "ポインター", "2Pポインター", "ハンドポインター選択", "Wiiリモコン", "Aボタン", "Bボタン", "Cボタン", "Zボタン", "十字ボタン", "十字ボタン下", "十字ボタン上", "スティック", "ヌンチャク", "照準", "マイナスボタン", "プラスボタン", "×(かける)アイコン", "グリーンコメット", "銀の王冠", "銀の王冠宝石付き", "金の王冠", "手紙", "矢印下", "ストップウォッチ", "1ボタン", "2ボタン", "ホームボタン", "ハンドポインター握り", "ハンドポインター", "？マーク", "イエローコメット", "？マーク緑", "空のスター", "空の彗星メダル", "空の彗星", "隠しスター", "ブロンズコメット" };
        
        //<>で挟んでいる理由は、ファイル名に<>を付けることが出来ないので付けています。
        //<>を付けることにより、ファイルを読み込んでいるときにこの項目を削除させない意図があります。
        public static readonly string[] FileReadStatusJP = { "<MSBTファイルなし>","<MSBFファイルなし>","<ARCファイルなし>" } ;
        public static readonly string[] FileReadStatusUS = { "<No MSBT Open>", "<No MSBF Open>", "<No ARC Open>" };

        public static void Language_Check()
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
            if (Properties.Settings.Default.言語 == "日本語")
            {
                combo1.SelectedIndex = 0;
                combo2.SelectedIndex = 0;
                combo3.SelectedIndex = 0;
                combo4.SelectedIndex = 0;
                combo5.SelectedIndex = 0;
                combo6.SelectedIndex = 0;
                combo7.SelectedIndex = 0;
            }
        }

        public static string FLW2_List_Language(int num) {
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

        public static string FLW_List_JP(int num) {
            string str = "";
            switch (num) {
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
                default:
                    str ="エラー "+num.ToString();
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
                default:
                    str = "エラー " + num.ToString();
                    break;
            }
            return str;
        }

        public static void JP(){
            tssl1.Text = "開いたファイル：";
            tssl6.Text = "保存したファイル：";
            //menu
            tlmi_file.Text = "ファイル";
            tlmi_msbt_open.Text = "開く";
            tlmi_msbt_save.Text = "MSBT上書き保存";
            tlmi_msbt_save_as.Text = "MSBT保存";
            tlmi_msbf_open.Text = "MSBF開く";
            tlmi_msbf_save.Text = "MSBF上書き保存";
            tlmi_msbf_save_as.Text = "MSBF保存";
            tlmi_arc_open.Text = "ARC開く";
            tlmi_arc_save.Text = "ARC上書き保存";
            tlmi_arc_save_as.Text = "ARC保存";
            //tab
            tabp1.Text = "MSBTテキストの詳細設定";
            tabp2.Text = "MSBTテキスト編集";
            tabp3.Text = "リスト編集";
            tabp4.Text = "MSBFの設定";

            tabp6.Text = "汎用タグ";
            tabp7.Text = "数値必須タグ";
            tabp8.Text = "特殊タグ";
            tabp9.Text = "アイコンタグ";

            tabp12.Text = "ARCファイルの中身";
            tabp14.Text = "情報";

            AdvancedTagTabPage.Text = "上級者向けタグ";
            //label
            labeltxt01.Text = "NPCボイス";
            labeltxt02.Text = "カメラ";
            labeltxt03.Text = "ダイアログタイプ";
            labeltxt04.Text = "ウィンドウタイプ";
            labeltxt05.Text = "イベントカメラID";
            labeltxt06.Text = "会話制御エリア Obj_arg0";
            labeltxt07.Text = "不明6";
            labeltxt08.Text = "特殊テキストオフセット";
            labeltxt09.Text = "特殊テキスト(基本null) ※上級者以外触らない";
            labeltxt10.Text = "タグインデックス？";
            labeltxt11.Text = "追加するMSBTリスト名";
            labeltxt12.Text = "削除は対象のリスト選択後に" + Environment.NewLine + "右の削除ボタンを押す";
            labeltxt13.Text = "※ゲーム内での命名規則を守ってください";
            labeltxt15.Text = "※初心者は触らないでください" + Environment.NewLine + "データが破損する恐れあり";
            labeltxt17.Text = "ふりがなの数";
            labeltxt18.Text = "漢字の数";
            labeltxt19.Text = "時間";

            labeltxt20.Text = "キャラクター系";
            labeltxt21.Text = "アイテム、オブジェクト";
            labeltxt22.Text = "操作、その他";
            labeltxt23.Text = "フロータイプ";
            labeltxt24.Text = "パディング";
            labeltxt25.Text = "不明2";
            labeltxt26.Text = "不明3";
            labeltxt27.Text = "不明4";
            labeltxt28.Text = "不明5";

            labeltxt29.Text = "ジャンプ先1（真）";
            labeltxt30.Text = "ジャンプ先2（偽）";
            labeltxt33.Text = "※まだすべての機能を解明できていないため、" + Environment.NewLine + "　不具合が発生する可能性があります";
            labeltxt34.Text = "この項目は名前が不要です";
            labeltxt35.Text = "名前必須(Flowなどを省いた名前)";
            labeltxt31.Text = "不明";
            labeltxt32.Text = "FLW2開始インデックス";
            labeltxt39.Text = "この項目が　0　の場合"+ Environment.NewLine +"ゲームにテキストが認識されません";
            Label58.Text 
                = "ARCファイルから開いたMSBTやMSBFの" 
                + Environment.NewLine 
                + "内容を変更した際は、上書き保存をしてください。" 
                + Environment.NewLine 
                + "上書き保存してからリストを選択し直さないと、" 
                + Environment.NewLine 
                + "変更が保存されません。"
                + Environment.NewLine
                + "全ての変更が終わったらARCを保存してください。"
                + Environment.NewLine
                + "※MSBT, MSBF以外は表示されません";

            UserIconInsertLabel1.Text 
                = "アイコンを作成した場合のみ使用可能"
                + Environment.NewLine 
                + "それ以外の場合で使用するとフリーズします。";
            
            UserIconInsertLabel2.Text = "末尾6バイト(16進数)";
            
            SETagInsertLabel1.Text 
                = "使えないステージがあります。" 
                + Environment.NewLine 
                + "ハードコードされている可能性があります。";
            
            SETagInsertLabel2.Text 
                = "SEの名前を入力" 
                + Environment.NewLine 
                + "例： SE_BV_KOOPA_BURN_RUN";

            //groupbox
            Atr1GroupBox.Text = "選択されたMSBTメッセージの詳細設定";
            groupbox3.Text = "各セクションのエントリーサイズ";
            groupbox4.Text = "ルビ";
            groupbox5.Text = "タイマー";
            groupbox6.Text = "システムメッセージ専用(その他で使えるか不明)";
            groupbox8.Text = "フロータイプ2の場合のみ";

            groupbox15.Text = "カスタムアイコンタグ";
            groupbox16.Text = "SEタグ";

            //button
            button1.Text = "カラータグ挿入";
            button2.Text = "行制御タグ挿入";
            button3.Text = "サイズタグ挿入";
            button4.Text = "センタリングタグ挿入";
            button5.Text = "ルビタグ挿入";
            button6.Text = "タイマータグ挿入";
            button7.Text = "プレイキャラクター";
            button8.Text = "参照値1";
            button9.Text = "リザルトギャラクシー名";


            button10.Text = "リザルトシナリオ名";
            button11.Text = "NPC,キャラタグ挿入";
            button12.Text = "アイテム,オブジェクトタグ挿入";
            button13.Text = "操作,その他タグ挿入";
            button14.Text = "参照値2";
            button15.Text = "参照値3";
            button16.Text = "時間";
            button17.Text = "分";
            button18.Text = "秒";
            button19.Text = "小数点以下";
            listadd.Text = "追加";
            listdelete.Text = "削除";
            button21.Text = "追加";
            button22.Text = "削除";
            button23.Text = "追加";
            button24.Text = "削除";

            button26.Text = "ワールドナンバー";
            button27.Text = "スコア";
            button28.Text = "ユーザー名";
            button29.Text = "トータルプレイ時間";

            MsbtSETagInsertButton.Text = "SEタグ挿入";
            UserIconInsertButton.Text = "カスタムアイコン挿入";

            //combobox
            combo1.Items.Clear();
            combo2.Items.Clear();
            combo3.Items.Clear();
            combo4.Items.Clear();
            combo5.Items.Clear();
            combo6.Items.Clear();
            combo7.Items.Clear();
            string[] cb1 = { "ブラック" , "レッド" , "グリーン" , "ブルー" , "イエロー" , "パープル" , "オレンジ" , "グレー" , "カラーエンドタグ" };
            string[] cb2 = { "改行" , "次のページ" ,"終了" };
            string[] cb3 = { "小" , "普通" , "大" };
            string[] cb4 = { "横方向" , "縦方向"};
            combo1.Text = "ブラック";
            combo1.Items.AddRange(cb1);
            combo2.Text = "改行";
            combo2.Items.AddRange(cb2);
            combo3.Text = "普通";
            combo3.Items.AddRange(cb3);
            combo4.Text = "横方向";
            combo4.Items.AddRange(cb4);

            StatusBarLabelChenger(tssl2, FileReadStatusUS[0], FileReadStatusJP[0]);
            StatusBarLabelChenger(tssl4, FileReadStatusUS[1], FileReadStatusJP[1]);
            StatusBarLabelChenger(tssl7, FileReadStatusUS[2], FileReadStatusJP[2]);

            //show what was hidden for EN translation
            combo6.Show();
            combo7.Show();
            labeltxt21.Show();
            labeltxt22.Show();
            button12.Show();
            button13.Show();
            combo5.Text = "ピーチ";
            combo5.Items.AddRange(IconNameJP01);
            combo6.Items.AddRange(IconNameJP02);
            combo7.Items.AddRange(IconNameJP03);
        }

        public static void EN()
        {
            tssl1.Text = "OpenFile：";
            tssl6.Text = "SaveFile：";
            tlmi_file.Text = "File";
            tlmi_msbt_open.Text = "Open";
            tlmi_msbt_save.Text = "MSBT Save";
            tlmi_msbt_save_as.Text = "MSBT Save As";
            tlmi_msbf_open.Text = "MSBF Open";
            tlmi_msbf_save.Text = "MSBF Save";
            tlmi_msbf_save_as.Text = "MSBF Save As";
            tlmi_arc_open.Text = "ARC Open";
            tlmi_arc_save.Text = "ARC Save";
            tlmi_arc_save_as.Text = "ARC Save As";
            //tab
            tabp1.Text = "MSBT Text Settings";
            tabp2.Text = "MSBT Text Editing";
            tabp3.Text = "List Editing";
            tabp4.Text = "MSBF Settings";

            tabp6.Text = "Text Tags";
            tabp7.Text = "Numeric Tags";
            tabp8.Text = "Special Tags";
            tabp9.Text = "Icon Tags";

            tabp12.Text = "Contents of ARC file";
            tabp14.Text = "Info";

            AdvancedTagTabPage.Text = "Advanced Tags";
            //label
            labeltxt01.Text = "Sound ID";
            labeltxt02.Text = "Camera";
            labeltxt03.Text = "Dialog Type";
            labeltxt04.Text = "Window Type";
            labeltxt05.Text = "Event Camera ID";
            labeltxt06.Text = "MessageArea Obj_arg0";
            labeltxt07.Text = "Unknown6";
            labeltxt08.Text = "Special Text Offset";
            labeltxt09.Text = "Unique text (Basically null) ※Don't touch it except advanced users";
            labeltxt10.Text = "Index";
            labeltxt11.Text = "Add MSBT entry";
            labeltxt12.Text = "Delete the selected MSBT entry";
            //labeltxt13.Text = "Press delete after selecting the list";

            labeltxt15.Text = "※Don't touch this," + Environment.NewLine + "Data may break!";
            labeltxt17.Text = "FURIGANA_Num";
            labeltxt18.Text = "KANJI_Num";
            labeltxt19.Text = "Time";

            labeltxt20.Text = "Character-Based";
            labeltxt21.Text = "Item,Object";
            labeltxt22.Text = "Operation etc.";
            labeltxt23.Text = "Flow Type";
            labeltxt24.Text = "Padding";
            labeltxt25.Text = "Unknown2";
            labeltxt26.Text = "Unknown3";
            labeltxt27.Text = "Unknown4";
            labeltxt28.Text = "Unknown5";

            labeltxt29.Text = "Condition Jump True";
            labeltxt30.Text = "Condition Jump False";
            labeltxt31.Text = "Unknown";
            labeltxt32.Text = "FLW2 start index";
            labeltxt33.Text = "※Not all features have been figured out yet," + Environment.NewLine + "　　so there may be some glitches.";
            labeltxt34.Text = "This item doesn't require a name.";
            labeltxt35.Text = "Name required (name without Flow, etc.)";
            labeltxt39.Text = "This item must not be 0";
            Label58.Text 
                = "If you change the contents of Msbt or Msbf opened from an ARC file,"
                + Environment.NewLine 
                + "please overwrite and save the file."
                + Environment.NewLine 
                + "If you don't overwrite and then re-select the list, the changes will not be saved."
                + Environment.NewLine 
                + "When you are done making all the changes, save the ARC."
                + Environment.NewLine
                + "※Not displayed except for MSBT and MSBF.";

            UserIconInsertLabel1.Text 
                = "Can only be used if you have created an icon."
                + Environment.NewLine
                + "Otherwise it will freeze if used.";
            UserIconInsertLabel2.Text = "6 bytes at the end (Hex Num)";
            SETagInsertLabel1.Text 
                = "Some stages may not work."
                + Environment.NewLine 
                + "It may be hard-coded.";
            SETagInsertLabel2.Text 
                = "Enter the name of the SE"
                + Environment.NewLine
                + "Example： SE_BV_KOOPA_BURN_RUN"; ;

            //groupbox
            Atr1GroupBox.Text = "Settings for the selected Msbt message";
            groupbox3.Text = "Entry size for each section";
            groupbox4.Text = "Rubi";
            groupbox5.Text = "Timer";
            groupbox6.Text = "For system messages only (not sure if it can be used for others)";
            groupbox8.Text = "Condition Flow Jump Destinations";

            groupbox15.Text = "Custom Icon Tag";
            groupbox16.Text = "SE Tag";

            //button
            button1.Text = "Add Color";
            button2.Text = "Insert Command";
            button3.Text = "Insert Text Size";
            button4.Text = "Insert Position";
            button5.Text = "Insert Rubi";
            button6.Text = "Insert Timer";
            button7.Text = "Player";
            button8.Text = "Reference Value1";
            button9.Text = "Result Galaxy Name";
            button10.Text = "Result Scenario Name";
            button11.Text = "Insert Character Tag";
            button12.Text = "Insert Item,Object Tag";
            button13.Text = "Insert Operation Tag";
            button14.Text = "Reference Value2";
            button15.Text = "Reference Value3";
            button16.Text = "Hour";
            button17.Text = "Minute";
            button18.Text = "Second";
            button19.Text = "Number of Decimals";
            listadd.Text = "Add";
            listdelete.Text = "Delete";
            button21.Text = "Add";
            button22.Text = "Delete";
            button23.Text = "Add";
            button24.Text = "Delete";

            button26.Text = "World_Num";
            button27.Text = "Score";
            button28.Text = "UserName";
            button29.Text = "TotalPlayTime ";

            MsbtSETagInsertButton.Text = "Insert SE tag";
            UserIconInsertButton.Text = "Insert Custom Icon";

            //combobox
            combo1.Items.Clear();
            combo2.Items.Clear();
            combo3.Items.Clear();
            combo4.Items.Clear();
            combo5.Items.Clear();
            combo6.Items.Clear();
            combo7.Items.Clear();
            string[] cb1 = { "Black", "Red", "Green", "Blue", "Yellow", "Purple", "Orange", "Gray", "ColorEnd" };
            string[] cb2 = { "New Line", "Next Page", "End" };
            string[] cb3 = { "Small", "General", "Large" };
            string[] cb4 = { "Horizontal Direction", "Vertical direction" };
            combo1.Text = "Black";
            combo1.Items.AddRange(cb1);
            combo2.Text = "New Line";
            combo2.Items.AddRange(cb2);
            combo3.Text = "General";
            combo3.Items.AddRange(cb3);
            combo4.Text = "Horizontal Direction";
            combo4.Items.AddRange(cb4);

            combo5.Items.Clear();
            combo6.Items.Clear();
            combo7.Items.Clear();

            //hide what is not needed in EN translation
            combo6.Hide();
            combo7.Hide();
            labeltxt21.Hide();
            labeltxt22.Hide();
            button12.Hide();
            button13.Hide();

            //all icons in one combo
            combo5.Items.AddRange(new object[] { "A Button", "B Button", "C Button", "Wii Remote", "Nunchuck", "1 Button", "2 Button", "Power Star", "Launch Star", "Pull Star", "P1 Pointer", "Purple Star Bit", "Coconut", "Down Arrow", "Star Bunny", "Control Stick", "X Icon", "Coin", "Mario Icon", "D-Pad", "Pull Star Chip", "Star Chip", "HOME Button", "Minus Button", "Plus Button", "Z Button", "Silver Star", "Grand Star", "Luigi Icon", "P2 Pointer", "Purple Coin", "Green Comet", "Golden Crown", "Aim Target", "Bowser Icon", "Star Pointer Hand (Selected)", "Star Pointer Hand (Pointing)", "Star Pointer Hand (Selecting)", "Rainbow Star Bit", "Peach Icon", "Letter", "Question Mark", "One Up Mushroom", "Life Up Mushroom", "Hungry Luma", "Luma", "Power Star Comet", "Green Question Mark", "Timer Icon", "Young Master Luma", "Yoshi", "Comet Medal", "Silver Crown", "Yoshi Grapple", "Checkpoint Flag", "Empty Power Star", "Empty Comet Medal", "Empty Comet", "Empty Hidden Star", "Bronze Star", "Blimp Fruit", "Large Silver Crown", "Bronze Grand Star", "Topman", "Goomba", "Coin Stack", "D-Pad Up", "D-Pad Down", "Co-Star Luma", "Toad", "Bronze Comet" });
            combo5.Text = "A Button";
            StatusBarLabelChenger(tssl2, FileReadStatusJP[0], FileReadStatusUS[0]);
            StatusBarLabelChenger(tssl4, FileReadStatusJP[1], FileReadStatusUS[1]);
            StatusBarLabelChenger(tssl7, FileReadStatusJP[2], FileReadStatusUS[2]);

            //if (tssl2.Text == "  " || tssl2.Text == "NA")
            //    tssl2.Text = "No MSBT Open";

            //if (tssl4.Text == "  " || tssl4.Text == "NA")
            //    tssl4.Text = "No MSBF Open";
        }

        public static void StatusBarLabelChenger(ToolStripStatusLabel tssl,string defaultStr,string newStr) {
            if (tssl.Text != defaultStr) return;
            tssl.Text = newStr;
        }

        public static string DefaultStatusBarLabel(ToolStripStatusLabel tssl,string jp , string us) {
            tssl.Text = jp;
            if (Properties.Settings.Default.言語 == "日本語") return jp;
            tssl.Text = us;
            return us;
        }
    }
}
