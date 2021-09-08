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
        public static string Save_Path_Msbt = "None";
        public static string Save_Path_Msbf = "None";
        public static string Save_Path_Arc  = "None";
        public static string Temp_Path_Arc  = "None";
        public static List<string> ArcInsideMsbtAndMsbfPath;

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
                Filter = "メッセージファイル(*.msbt;*.Msbt)|*.msbt;*.Msbt|メッセージフローファイル(*.msbf;*.Msbf)|*.msbf;*.Msbf|nintendoアーカイブファイル(*.arc;*.Arc)|*.arc;*.Arc|すべてのファイル(*.*)|*.*",
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

        

        public static void Save(string filePath, int fileNum)
        {
            
            var hasPath = CheckSavePath(filePath);
            if (hasPath) return;
            FileSave(filePath,fileNum);
            //MSBTH.Write(Save_Path_Msbt);
            //SaveStatusPathString.Text = Save_Path_Msbt;
            //SaveStatusPathString.ForeColor = Color.Green;
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
            string[] FileNameStrings = {string.Empty, "新しいファイル.msbt" , "新しいファイル.msbf" , "NewFile.arc"};
            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = FileNameStrings[filenum],
                InitialDirectory = @"C:\",
                Filter = "メッセージファイル(*.msbt;*.Msbt)|*.msbt;*.Msbt|メッセージフローファイル(*.msbf;*.Msbf)|*.msbf;*.Msbf|nintendoアーカイブファイル(*.arc;*.Arc)|*.arc;*.Arc",
                FilterIndex = filenum,
                Title = "保存先のファイルを選択してください",
                RestoreDirectory = true,
                OverwritePrompt = true,
                CheckPathExists = true
            };
            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileSave(sfd.FileName,filenum);
            }
        }

        public static void FileSave(string fileName,int fileNum) {
            switch (fileNum)
            {
                case 1:
                    if(MSBT_Item_And_ListItem_Checker() == false) break;
                    MSBT_Header msbth = new MSBT_Header();
                    msbth.Write(fileName);
                    Save_Path_Msbt = fileName;
                    SaveStatusPathString.Text = Save_Path_Msbt;
                    SaveStatusPathString.ForeColor = Color.Green;
                    break;
                case 2:
                    if (MSBF_Item_And_ListItem_Checker() == false) break;
                    MSBF_Header msbfh = new MSBF_Header();
                    msbfh.Write(fileName);
                    Save_Path_Msbf = fileName;
                    SaveStatusPathString.ForeColor = Color.Green;
                    SaveStatusPathString.Text = Save_Path_Msbf;
                    break;
                case 3:
                    ArcSave(fileName);
                    break;
                default:
                    MessageBox.Show("このメッセージが表示されている場合\n\r" + "アプリ製作者のミスの可能性が高いので\n\r" + "至急このバージョンの制作者に連絡してください\n\r" + "ErrorName StaffMiss001 ", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public static bool MSBF_Item_And_ListItem_Checker()
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
            return true;
        }

        public static bool MSBT_Item_And_ListItem_Checker()
        {
            var MsbtListCountZeroCheck  = MsbtListBox.Items.Count == 0;
            var MsbtAllItemDefaultCheck = MSBT_Data.MSBT_All_Data.Item == default;
            var MsbtAllTextDefaultCheck = MSBT_Data.MSBT_All_Data.Text == default;

            if (MsbtListCountZeroCheck || (MsbtAllItemDefaultCheck) || MsbtAllTextDefaultCheck)
            {
                MessageBox.Show("MSBTの項目が設定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        public static void FileCheck(string filePath)
        {
            var HasFile = File.Exists(filePath);
            var File_Extension = Path.GetExtension(filePath);

            var MSBF_File_Path = Path.ChangeExtension(filePath, "msbf");


            if (HasFile == false)
            {
                MessageBox.Show("ファイルが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //拡張子の種類を判別
            switch (File_Extension.ToLower())
            {
                case ".msbt":
                    Save_Path_Msbt = filePath;
                    tssl2.Text = "";
                    MSBT_Header msbth = new MSBT_Header();
                    msbth.Read(filePath);
                    tssl2.Text = Path.GetFileName(filePath);
                    break;
                case ".msbf":
                    Save_Path_Msbf = filePath;
                    tssl4.Text = "";
                    MSBF_Header msbfh = new MSBF_Header();
                    msbfh.Read(MSBF_File_Path);
                    tssl4.Text = Path.GetFileName(MSBF_File_Path);
                    break;
                case ".arc":
                    if (Form1.UseDevelopMenue == false) break;
                    var IsYaz0 = MagicChecker(filePath, "Yaz0");
                    if (IsYaz0 == true) return;
                    ARCListBox.Items.Clear();
                    
                    
                    Save_Path_Arc = filePath;
                    tssl7.Text = "";

                    var FileName = Path.GetFileName(filePath);
                    var TempARCPath = Path.GetDirectoryName(Application.ExecutablePath) + "\\res\\" + "ARC\\" +FileName;
                    Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + "\\res");
                    Directory.CreateDirectory(Path.GetDirectoryName(Application.ExecutablePath) + "\\res\\" + "ARC");
                    Console.WriteLine(TempARCPath);
                    File.Copy(filePath,TempARCPath,true);
                    ExternalFileExecutor.ARCToolExecutor(TempARCPath/*filepath*/);

                    string[] DirectoryPathStrings = Directory.GetDirectories(Directory.GetParent(TempARCPath/*filepath*/).FullName + @"\" + Path.GetFileNameWithoutExtension(TempARCPath/*filepath*/), "*", SearchOption.AllDirectories);
                    string[] FilePathStrings = Directory.GetFiles(Directory.GetParent(TempARCPath/*filepath*/).FullName + @"\" + Path.GetFileNameWithoutExtension(TempARCPath/*filepath*/), "*", SearchOption.AllDirectories);
                    
                    var DirConcatFile = DirectoryPathStrings.Concat(FilePathStrings);
                    DirConcatFile = DirConcatFile.OrderBy(sort => sort);
                    var SortedDirConcatFile = DirConcatFile.ToArray();

                    ArcInsideMsbtAndMsbfPath = new List<string>();
                    foreach (var FilePath in FilePathStrings) {
                        var FilePathExtension = Path.GetExtension(FilePath).ToLower();
                        if (FilePathExtension == ".msbt" || FilePathExtension == ".msbf")
                        {
                            ArcInsideMsbtAndMsbfPath.Add(FilePath);
                            ARCListBox.Items.Add(Path.GetFileName(FilePath));
                                
                        }
                    }
                    Temp_Path_Arc = TempARCPath;
                    tssl7.Text = Path.GetFileName(Save_Path_Arc);
                    break;

                default:
                    MessageBox.Show("未対応のファイルです" + "\r\n" + "MSBTファイルのみ読み込めます", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

            }




        }

        public static void ArcSave(string newArcSavePath = "") {
            if (ARCListBox.Items.Count < 1) return;
            if (ArcInsideMsbtAndMsbfPath.Count < 1) return;
            if (newArcSavePath != string.Empty) Save_Path_Arc = newArcSavePath;

            ExternalFileExecutor.ARCToolExecutor(Temp_Path_Arc);
            File.Copy(Temp_Path_Arc, Save_Path_Arc, true);
            Console.WriteLine("ARCを保存しました");
        }

        private static bool MagicChecker(string filePath , string checkString) {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            var Magic = Calculation_System.Byte2Char(br);
            br.Close();
            fs.Close();
            if (Magic == checkString) return true;
            return false;
        }
    }
}
