using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSBT_Editor.Formsys
{
    public class Langage : objects
    {
        public static void Langage_Check() {
            switch (Properties.Settings.Default.言語) {
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
            combo5.SelectedIndex = 0;
            combo6.SelectedIndex = 0;
            combo7.SelectedIndex = 0;
        }

        public static string FLW2_List_Langage(int num) {
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
                    str = "Conversation decision and jump？";
                    break;
                case 0x0002:
                    str = "Branch？";
                    break;
                case 0x0003:
                    str = "Event control？";
                    break;
                case 0x0004:
                    str = "Message entry point";
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

            tabp6.Text = "汎用タグ";
            tabp7.Text = "数値必須タグ";
            tabp8.Text = "特殊タグ";
            tabp9.Text = "アイコンタグ";
            //label
            labeltxt01.Text = "NPCボイス";
            labeltxt02.Text = "カメラ";
            labeltxt03.Text = "ダイアログタイプ";
            labeltxt04.Text = "ウィンドウタイプ";
            labeltxt05.Text = "イベントカメラID";
            labeltxt06.Text = "会話制御エリア Obj_arg0";
            labeltxt07.Text = "分からない6";
            labeltxt08.Text = "特殊テキストオフセット";
            labeltxt09.Text = "特殊テキスト(基本null) ※上級者以外触らない";
            labeltxt10.Text = "タグインデックス？";
            labeltxt11.Text = "追加するMSBTリスト名";
            labeltxt12.Text = "削除は対象のリスト選択後に" + Environment.NewLine + "右の削除ボタンを押す";
            labeltxt13.Text = "※ゲームの命名規則を守ってください";
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

            labeltxt29.Text = "ジャンプ先1";
            labeltxt30.Text = "ジャンプ先2";
            labeltxt33.Text = "※まだすべての機能が解明できていないので" + Environment.NewLine + "不具合が発生する可能性があります";
            labeltxt34.Text = "この項目は名前が不要です";
            labeltxt35.Text = "名前必須(Flowなどを省いた名前)";
            labeltxt31.Text = "不明";
            labeltxt32.Text = "FLW2開始インデックス";
            labeltxt39.Text = "この項目が　0　の場合"+ Environment.NewLine +"ゲームにテキストが認識されません";

            //groupbox
            groupbox3.Text = "各セクションのエントリーサイズ";
            groupbox4.Text = "ルビ";
            groupbox5.Text = "タイマー";
            groupbox6.Text = "システムメッセージ専用(その他で使えるか不明)";
            groupbox8.Text = "フロータイプ2の場合のみ";
            

            //button
            button1.Text = "カラータグ挿入";
            button2.Text = "行制御タグ挿入";
            button3.Text = "サイズタグ挿入";
            button4.Text = "センタリングタグ挿入";
            button5.Text = "ルビタグ挿入";
            button6.Text = "タイマータグ挿入";
            button7.Text = "プレイキャラクター";
            button8.Text = "星船不明タグ";
            button9.Text = "リザルトギャラクシー名";


            button10.Text = "リザルトシナリオ名";
            button11.Text = "NPC,キャラタグ挿入";
            button12.Text = "アイテム,オブジェクトタグ挿入";
            button13.Text = "操作,その他タグ挿入";
            button14.Text = "年01？";
            button15.Text = "年02？";
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

            combo5.Items.AddRange(Form1.IconNameJP01);
            combo6.Items.AddRange(Form1.IconNameJP02);
            combo7.Items.AddRange(Form1.IconNameJP03);
        }

        public static void EN()
        {
            tssl1.Text = "OpenFile：";
            tssl6.Text = "SaveFile：";
            tlmi_file.Text = "File";
            tlmi_msbt_open.Text = "MSBT Open";
            tlmi_msbt_save.Text = "MSBT Save";
            tlmi_msbt_save_as.Text = "MSBT Save As";
            tlmi_msbf_open.Text = "MSBF Open";
            tlmi_msbf_save.Text = "MSBF Save";
            tlmi_msbf_save_as.Text = "MSBF Save As";
            //tab
            tabp1.Text = "MSBT Text Settings";
            tabp2.Text = "MSBT Text Editing";
            tabp3.Text = "List Editing";
            tabp4.Text = "MSBF Settings";

            tabp6.Text = "Generic Tags";
            tabp7.Text = "Numeric-Required Tags";
            tabp8.Text = "Special Tags";
            tabp9.Text = "Icon Tags";
            //label
            labeltxt01.Text = "NPC Voice";
            labeltxt02.Text = "Camera";
            labeltxt03.Text = "Dialog Type";
            labeltxt04.Text = "Window Type";
            labeltxt05.Text = "Event Camera ID";
            labeltxt06.Text = "MessageArea Obj_arg0";
            labeltxt07.Text = "Unknown6";
            labeltxt08.Text = "Special Text Offset";
            labeltxt09.Text = "Unique text (Basically null) ※Don't touch it except advanced users";
            labeltxt10.Text = "Tag index？？";
            labeltxt11.Text = "MSBT List name you add";
            labeltxt12.Text = "Press delete after" + Environment.NewLine + "selecting list to delete it";
            labeltxt13.Text = "Press delete after selecting the list";

            labeltxt15.Text = "※Don't touch this" + Environment.NewLine + "Data may break";
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

            labeltxt29.Text = "Jump destination 1";
            labeltxt30.Text = "Jump destination 2";
            labeltxt31.Text = "Unknown";
            labeltxt32.Text = "FLW2 start index";
            labeltxt33.Text = "※Not all features have been figured out yet," + Environment.NewLine + "　　so there may be some glitches.";
            labeltxt34.Text = "This item doesn't require a name.";
            labeltxt35.Text = "Name required (name without Flow, etc.)";
            labeltxt39.Text = "This item must not be 0";

            //groupbox
            groupbox3.Text = "Entry size for each section";
            groupbox4.Text = "Rubi";
            groupbox5.Text = "Timer";
            groupbox6.Text = "For system messages only (not sure if it can be used for others)";
            groupbox8.Text = "Only case of flow type 2";

            //button
            button1.Text = "Insert color tag";
            button2.Text = "Insert line control tag"; 
            button3.Text = "Insert size tag";
            button4.Text = "Insert centering tag";
            button5.Text = "Insert Rubi";
            button6.Text = "Insert Timer";
            button7.Text = "Player";
            button8.Text = "StarshipUnknown";
            button9.Text = "ResultGalaxyName";
            button10.Text = "ResultScenarioName";
            button11.Text = "InsertCharacterTag";
            button12.Text = "InsertItem,ObjectTag";
            button13.Text = "InsertOperationTag";
            button14.Text = "Year01?";
            button15.Text = "Year02?";
            button16.Text = "Hour";
            button17.Text = "Minute";
            button18.Text = "Second";
            button19.Text = "NumberOfDecimals";
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

            combo5.Items.AddRange(Form1.IconNameEN01);
            combo6.Items.AddRange(Form1.IconNameEN02);
            combo7.Items.AddRange(Form1.IconNameEN03);
        }
    }
}
