using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MSBT_Editor.MSBTsys;
using MSBT_Editor.Formsys;
using MSBT_Editor.MSBFsys;
using MSBT_Editor.Sectionsys;

namespace MSBT_Editor.FileSys
{
    /// <summary>
    /// ダイアログクラス
    /// </summary>
    /// <remarks>ファイルを開いたり保存する</remarks>
    public class Dialog:objects
    {
        private static string Save_Path_Msbt = "None";
        private static string Save_Path_Msbf = "None";

        /// <summary>
        /// ファイルを選択して開く
        /// </summary>
        /// <param name="filenum">「1の場合MSBT」「2の場合MSBF」</param>
        /// <remarks></remarks>
        public static void Open(int filenum) {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "default.msbt";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "メッセージファイル(*.msbt;*.Msbt)|*.msbt;*.Msbt|メッセージフローファイル(*.msbf;*.Msbf)|*.msbf;*.Msbf|すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = filenum;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK){
                FileCheck(ofd.FileName);
            }
        }

        

        private static bool SaveErrorMessage(string path) {
            if (path == "None")
            {
                MessageBox.Show("ファイルを開くまたは保存先を指定してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public static void Save(MSBT_Header MSBTH) {

            var flag = SaveErrorMessage(Save_Path_Msbt);
            if (flag) return;
            MSBTH.Write(Save_Path_Msbt);
        }


        public static void Save(MSBF_Header MSBFH)
        {
            var flag = SaveErrorMessage(Save_Path_Msbf);
            if (flag) return;
            MSBFH.Write(Save_Path_Msbf);
        }

        public static void SaveAs(int filenum)
        {
            //SaveFileDialogクラスのインスタンスを作成
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "新しいファイル.msbt";
            if (filenum == 2) sfd.FileName = "新しいファイル.msbf";
            sfd.InitialDirectory = @"C:\";
            sfd.Filter = "メッセージファイル(*.msbt;*.Msbt)|*.msbt;*.Msbt|メッセージフローファイル(*.msbf;*.Msbf)|*.msbf;*.Msbf";
            sfd.FilterIndex = filenum;
            sfd.Title = "保存先のファイルを選択してください";
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;
            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                switch (filenum) {
                    case 1:
                        MSBT_Header msbth = new MSBT_Header();
                        msbth.Write(sfd.FileName);
                        Save_Path_Msbt = sfd.FileName;
                    break;
                    case 2:
                        MSBF_Header msbfh = new MSBF_Header();
                        msbfh.Write(sfd.FileName);
                        Save_Path_Msbf = sfd.FileName;
                        break;
                    default:
                        MessageBox.Show("このメッセージが表示されている場合\n\r"+"アプリ製作者のミスの可能性が高いので\n\r"+"至急このバージョンの制作者に連絡してください\n\r"+"ErrorName StaffMiss001 ", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        public static bool MSBF_Item_And_ListItem_Checker(Action action) {
            FLW2 flw2 = new FLW2();
            FEN1 fen1 = new FEN1();


            if (list2.Items.Count == 0 || (flw2.Item.Count == 0))
            {
                MessageBox.Show("MSBFのFLW2の項目が設定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (list3.Items.Count == 0 || (fen1.Hashes.Count == 0) || (fen1.Item2.Count == 0))
            {
                MessageBox.Show("MSBFのFEN1の項目が設定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            var msbf = action;
            action();
            return true;
        }

        public static bool MSBT_Item_And_ListItem_Checker(Action action)
        {
            FLW2 flw2 = new FLW2();
            FEN1 fen1 = new FEN1();

            var list1_counter = list1.Items.Count == 0;
            var msbt_all_item = MSBT_Data.MSBT_All_Data.Item == default;
            var msbt_all_text = MSBT_Data.MSBT_All_Data.Text == default;

            if (list1_counter|| (msbt_all_item) || msbt_all_text) {
                MessageBox.Show("MSBTの項目が設定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var msbt = action;
            action();
            return true;
        }


        public static void FileCheck(string filepath)
        {
            var file_flag = File.Exists(filepath);
            var File_Extension = Path.GetExtension(filepath);
           
            var MSBF_File_Path = Path.ChangeExtension(filepath,"msbf");


            if (file_flag == false) {
                MessageBox.Show("ファイルが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }



            //拡張子の種類を判別
            switch (File_Extension.ToLower())
            {
                case ".msbt":
                    Save_Path_Msbt = filepath;
                    tssl2.Text = "";
                    MSBT_Header msbth = new MSBT_Header();
                    msbth.Read(filepath);
                    tssl2.Text = Path.GetFileName(filepath);
                    break;
                case ".msbf":
                    Save_Path_Msbf = filepath;
                    tssl4.Text = "";
                    MSBF_Header msbfh = new MSBF_Header();
                    msbfh.Read(MSBF_File_Path);
                    tssl4.Text = Path.GetFileName(MSBF_File_Path);
                    break;

                default:
                    MessageBox.Show("未対応のファイルです" + "\r\n" + "MSBTファイルのみ読み込めます", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

            }




        }
    }
}
