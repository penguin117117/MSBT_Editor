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
using System.Drawing;

namespace MSBT_Editor.FileSys
{
    /// <summary>
    /// ダイアログクラス
    /// </summary>
    /// <remarks>ファイルを開いたり保存する</remarks>
    public class Dialog : objects
    {
        private static string Save_Path_Msbt = "None";
        private static string Save_Path_Msbf = "None";
        private static string Save_Path_Arc  = "None";
        /// <summary>
        /// ファイルを選択して開く
        /// </summary>
        /// <param name="filenum">「1の場合MSBT」「2の場合MSBF」</param>
        /// <remarks></remarks>
        public static void Open(int filenum)
        {
            //nintendoアーカイブファイル(*.arc;*.Arc)|*.arc;*.Arc|
            OpenFileDialog ofd = new OpenFileDialog
            {
                FileName = "default.msbt",
                InitialDirectory = @"C:\",
                Filter = "メッセージファイル(*.msbt;*.Msbt)|*.msbt;*.Msbt|メッセージフローファイル(*.msbf;*.Msbf)|*.msbf;*.Msbf|すべてのファイル(*.*)|*.*",
                FilterIndex = filenum,
                Title = "開くファイルを選択してください",
                RestoreDirectory = true,
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileCheck(ofd.FileName);
            }
        }


        /// <summary>
        /// ファイルパスが設定されているかをチェックします。
        /// </summary>
        /// <param name="path">Noneの場合trueを返す</param>
        /// <returns>path == "None"の場合true</returns>
        private static bool CheckSavePath(string path)
        {
            if (path == "None")
            {
                MessageBox.Show("ファイルを開くまたは保存先を指定してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        //public static void Save(object obj) {
        //    if (obj is MSBF_Header) {
        //        MSBF_Header MSBFH = (MSBF_Header)obj;
        //        MSBFH.Write(Save_Path_Msbf);

        //        Console.WriteLine("MSBFです");

        //    } 


        //}

        public static void Save(MSBT_Header MSBTH)
        {

            var hasPath = CheckSavePath(Save_Path_Msbt);
            if (hasPath) return;
            MSBTH.Write(Save_Path_Msbt);
            SaveStatusPathString.Text = Save_Path_Msbt;
            SaveStatusPathString.ForeColor = Color.Green;
        }


        public static void Save(MSBF_Header MSBFH)
        {
            bool hasNotPath = CheckSavePath(Save_Path_Msbf);
            if (hasNotPath) return;
            //var OldMsbfBytes = File.ReadAllBytes(Save_Path_Msbf);

            //try
            //{
            MSBFH.Write(Save_Path_Msbf);
            //}
            //catch
            //{
            //    File.WriteAllBytes(Save_Path_Msbf, OldMsbfBytes);
            //}
            SaveStatusPathString.Text = Save_Path_Msbf;
            SaveStatusPathString.ForeColor = Color.Green;
        }

        public static void SaveAs(int filenum)
        {
            //SaveFileDialogクラスのインスタンスを作成
            string[] FileNameStrings = {string.Empty, "新しいファイル.msbt" , "新しいファイル.msbf" };
            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = FileNameStrings[filenum],
                InitialDirectory = @"C:\",
                Filter = "メッセージファイル(*.msbt;*.Msbt)|*.msbt;*.Msbt|メッセージフローファイル(*.msbf;*.Msbf)|*.msbf;*.Msbf",
                FilterIndex = filenum,
                Title = "保存先のファイルを選択してください",
                RestoreDirectory = true,
                OverwritePrompt = true,
                CheckPathExists = true
            };
            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                switch (filenum)
                {
                    case 1:
                        MSBT_Header msbth = new MSBT_Header();
                        //try
                        //{

                        msbth.Write(sfd.FileName);
                        Save_Path_Msbt = sfd.FileName;
                        SaveStatusPathString.Text = Save_Path_Msbt;
                        SaveStatusPathString.ForeColor = Color.Green;
                        //}
                        //catch
                        //{

                        //}

                        break;
                    case 2:
                        MSBF_Header msbfh = new MSBF_Header();
                        msbfh.Write(sfd.FileName);
                        Save_Path_Msbf = sfd.FileName;
                        SaveStatusPathString.ForeColor = Color.Green;
                        SaveStatusPathString.Text = Save_Path_Msbf;
                        break;
                    default:
                        MessageBox.Show("このメッセージが表示されている場合\n\r" + "アプリ製作者のミスの可能性が高いので\n\r" + "至急このバージョンの制作者に連絡してください\n\r" + "ErrorName StaffMiss001 ", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        public static bool MSBF_Item_And_ListItem_Checker(Action action)
        {
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
            //var msbf = action;
            action();
            return true;
        }

        public static bool MSBT_Item_And_ListItem_Checker(Action action)
        {
            //FLW2 flw2 = new FLW2();
            //FEN1 fen1 = new FEN1();

            var list1_counter = MsbtListBox.Items.Count == 0;
            var msbt_all_item = MSBT_Data.MSBT_All_Data.Item == default;
            var msbt_all_text = MSBT_Data.MSBT_All_Data.Text == default;

            if (list1_counter || (msbt_all_item) || msbt_all_text)
            {
                MessageBox.Show("MSBTの項目が設定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //var msbt = action;
            action();
            return true;
        }


        public static void FileCheck(string filepath)
        {
            var file_flag = File.Exists(filepath);
            var File_Extension = Path.GetExtension(filepath);

            var MSBF_File_Path = Path.ChangeExtension(filepath, "msbf");


            if (file_flag == false)
            {
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
                //case ".arc":
                //    var IsYaz0 = MagicChecker(filepath,"Yaz0");
                //    if (IsYaz0 == true) return;
                //    Save_Path_Arc = filepath;
                //    tssl7.Text = "";
                //    ExternalFileExecutor.ARCToolExecutor(filepath);
                //    string[] DirectoryPathStrings = Directory.GetDirectories(Directory.GetParent(filepath).FullName+@"\"+Path.GetFileNameWithoutExtension(filepath), "*", SearchOption.AllDirectories);
                //    string[] FilePathStrings = Directory.GetFiles(Directory.GetParent(filepath).FullName + @"\" + Path.GetFileNameWithoutExtension(filepath), "*", SearchOption.AllDirectories);
                //    var DirConcatFile = DirectoryPathStrings.Concat(FilePathStrings);

                //    DirConcatFile = DirConcatFile.OrderBy(sort => sort);
                //    var SortedDirConcatFile = DirConcatFile.ToArray();

                //    foreach (var Dir in SortedDirConcatFile) Console.WriteLine(Dir);
                //    tssl7.Text = Path.GetFileName(Save_Path_Arc);
                //    break;

                default:
                    MessageBox.Show("未対応のファイルです" + "\r\n" + "MSBTファイルのみ読み込めます", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

            }




        }

        private static bool MagicChecker(string filePath , string checkString) {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            var Magic = Calculation_System.Byte2Char(br);
            if (Magic == checkString)
            {
                br.Close();
                fs.Close();
                return true;
            }
            br.Close();
            fs.Close();
            return false;
        }
    }
}
