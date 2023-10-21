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
using MSBT_Editor.MSBX;
using System.Diagnostics;

namespace MSBT_Editor.FileSys
{
    /// <summary>
    /// ダイアログクラス
    /// </summary>
    /// <remarks>ファイルを開いたり保存する</remarks>
    public class Dialog : Objects
    {
        public static string Save_Path_Msbt = "None";
        public static string Save_Path_Msbf = "None";
        public static string Save_Path_Arc = "None";
        public static string Temp_Path_Arc = "None";
        public static List<string> ArcInsideMsbtAndMsbfPath;



        /// <summary>
        /// ファイルを選択して開く
        /// </summary>
        /// <param name="filenum">「1の場合MSBT」「2の場合MSBF」</param>
        /// <remarks></remarks>
        public static void Open(int filenum)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                FileName = "default.msbt",
                InitialDirectory = @"C:\",
                Filter = "メッセージファイル(*.msbt;*.Msbt)|*.msbt;*.Msbt|メッセージフローファイル(*.msbf;*.Msbf)|*.msbf;*.Msbf|nintendoアーカイブファイル(*.arc;*.Arc)|*.arc;*.Arc|すべてのファイル(*.*)|*.*",
                FilterIndex = 4,
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

        

        private static string SaveMissTime()
        {
            DateTime dt = DateTime.Now;
            return "｜失敗日時" + dt.ToString();
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
                MessageBox.Show
                (
                    "ファイルを開くまたは保存先を指定してください",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return true;
            }
            return false;
        }

        public static void Save(string filePath, int fileNum)
        {
            var hasPath = CheckSavePath(filePath);
            if (hasPath) return;
            FileSave(filePath, fileNum);
        }

        public static void Save(MSBF_Header MSBFH)
        {
            bool hasNotPath = CheckSavePath(Save_Path_Msbf);
            if (hasNotPath)
            {
                return;
            }
            MSBFH.Write(Save_Path_Msbf);
            SaveStatusPathString.Text = Save_Path_Msbf;
            SaveStatusPathString.ForeColor = Color.Green;
        }

        public static void SaveAs(int filenum)
        {
            string[] NewFileNames = { string.Empty, "新しいファイル.msbt", "新しいファイル.msbf", "NewFile.arc" };
            string[] SetFileNames = { string.Empty, Save_Path_Msbt, Save_Path_Msbf, Save_Path_Arc };
            string SetDirectoryPath = @"C:\";
            //string[] FileNameStrings = new string[4];
            //FileNameStrings = NewFileNames;
            if (SetFileNames[filenum] != "None" && SetFileNames[filenum] != string.Empty)
            {
                SetDirectoryPath = Path.GetDirectoryName(SetFileNames[filenum]) + "\\";
                Console.WriteLine(SetDirectoryPath);
                //return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = NewFileNames[filenum],
                InitialDirectory = SetDirectoryPath,
                Filter = "メッセージファイル(*.msbt;*.Msbt)|*.msbt;*.Msbt|メッセージフローファイル(*.msbf;*.Msbf)|*.msbf;*.Msbf|nintendoアーカイブファイル(*.arc;*.Arc)|*.arc;*.Arc",
                FilterIndex = filenum,
                Title = "保存先のファイルを選択してください",
                RestoreDirectory = true,
                OverwritePrompt = true,
                CheckPathExists = true
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileSave(sfd.FileName, filenum);
            }
            else
            {
                SaveStatusPathString.Text = "保存がキャンセルされました。" + SaveMissTime();
                SaveStatusPathString.ForeColor = Color.Red;
            }
        }

        public static void FileSave(string fileName, int fileNum)
        {
            switch (fileNum)
            {
                case 1:
                    SaveStatusPathString.Text = "MSBTを保存できませんでした" + SaveMissTime();
                    SaveStatusPathString.ForeColor = Color.Red;
                    
                    MSBT_Header msbth = new MSBT_Header();
                    if (MSBT_Item_And_ListItem_Checker() == false)
                    {
                        break;
                    }
                    msbth.Write(fileName);
                    Save_Path_Msbt = fileName;
                    SaveStatusPathString.Text = Save_Path_Msbt;
                    SaveStatusPathString.ForeColor = Color.Green;
                    break;
                case 2:
                    SaveStatusPathString.ForeColor = Color.Red;
                    SaveStatusPathString.Text = "MSBFを保存できませんでした。" + SaveMissTime();
                    if (MSBF_Item_And_ListItem_Checker() == false)
                    {
                        break;
                    }
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
                    MessageBox.Show
                    (
                        "このメッセージが表示されている場合\r\n" +
                        "アプリ製作者のミスの可能性が高いので\r\n" +
                        "至急このバージョンの制作者に連絡してください\r\n" +
                        "ErrorName StaffMiss001 ",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
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
            if (list3.Items.Count == 0 || ((fen1.Hashes.Count == 0) || (fen1.Item2.Count == 0)))
            {
                MessageBox.Show("MSBFのFEN1の項目が設定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool MSBT_Item_And_ListItem_Checker()
        {
            var MsbtListCountZeroCheck = MsbtListBox.Items.Count == 0;
            var MsbtAllItemDefaultCheck = MSBT_Data.MSBT_All_Data.Item == default;
            var MsbtAllTextDefaultCheck = MSBT_Data.MSBT_All_Data.Text == default;

            if (MsbtListCountZeroCheck && (MsbtAllItemDefaultCheck || MsbtAllTextDefaultCheck))
            {
                MessageBox.Show("MSBTの項目が設定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("★　★_" + MsbtListCountZeroCheck + "_" + MsbtAllItemDefaultCheck + "_" + MsbtAllTextDefaultCheck);
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
                    Language.DefaultStatusBarLabel(tssl2, Language.FileReadStatusJP[0], Language.FileReadStatusUS[0]);
                    MSBT_Header msbth = new MSBT_Header();
                    msbth.Read(filePath);
                    //ARCListBox.Items.Clear();
                    //Save_Path_Arc = "None";
                    //Temp_Path_Arc = "None";
                    //Language.DefaultStatusBarLabel(tssl7, Language.FileReadStatusJP[2], Language.FileReadStatusUS[2]);
                    tssl2.Text = Path.GetFileName(filePath);
                    break;
                case ".msbf":
                    Save_Path_Msbf = filePath;
                    Language.DefaultStatusBarLabel(tssl4, Language.FileReadStatusJP[1], Language.FileReadStatusUS[1]);
                    MSBF_Header msbfh = new MSBF_Header();
                    msbfh.Read(MSBF_File_Path);
                    //ARCListBox.Items.Clear();
                    //Save_Path_Arc = "None";
                    //Temp_Path_Arc = "None";
                    //Language.DefaultStatusBarLabel(tssl7, Language.FileReadStatusJP[2], Language.FileReadStatusUS[2]);
                    tssl4.Text = Path.GetFileName(MSBF_File_Path);
                    break;
                case ".arc":
                    Properties.Settings.Default.ARCListIndexOld = 0;
                    Properties.Settings.Default.Save();
                    Dialog.Save_Path_Msbt = "None";
                    Dialog.Save_Path_Msbf = "None";
                    tssl2.Text = Language.FileReadStatusJP[0];
                    tssl4.Text = Language.FileReadStatusJP[1];
                    if (Properties.Settings.Default.言語 == "EN") 
                    {
                        tssl2.Text = Language.FileReadStatusUS[0];
                        tssl4.Text = Language.FileReadStatusUS[1];
                    }
                    Language.StatusBarLabelChenger(tssl2, Language.FileReadStatusUS[0], Language.FileReadStatusJP[0]);
                    Language.StatusBarLabelChenger(tssl4, Language.FileReadStatusUS[1], Language.FileReadStatusJP[1]);
                    //if (Form1.EnableDevelopMenu == false) break;
                    var IsYaz0 = MagicChecker(filePath, "Yaz0");
                    if (IsYaz0 == true)
                    {
                        MessageBox.Show
                        (
                            "Yaz0は未対応です\r\n" +
                            "RARCタイプのARCファイルのみ読み込めます\r\n" +
                            "Yaz0 is not supported.\r\n" +
                            "Only RARC type ARC files can be read.",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }

                    //初期化
                    ARCListBox.Items.Clear();
                    Save_Path_Arc = filePath;
                    Language.DefaultStatusBarLabel(tssl7, Language.FileReadStatusJP[2], Language.FileReadStatusUS[2]);

                    //パスを取得
                    var FileName = Path.GetFileName(filePath);
                    var MsbtEditorExePath = Path.GetDirectoryName(Application.ExecutablePath);
                    var TempARCPath = MsbtEditorExePath + "\\res\\" + "ARC\\" + FileName;

                    //作業ディレクトリを作成しそこに、データをコピーする
                    Directory.CreateDirectory(MsbtEditorExePath + "\\res");
                    Directory.CreateDirectory(MsbtEditorExePath + "\\res\\" + "ARC");
                    File.Copy(filePath, TempARCPath, true);

                    //ARCToolの実行
                    ExternalFileExecutor efe = new ExternalFileExecutor();
                    efe.ARCToolExecutor(TempARCPath);

                    var TempParent = Directory.GetParent(TempARCPath).FullName;
                    var TempWorkingDirName = Path.GetFileNameWithoutExtension(TempARCPath);
                    string[] FilePathStrings = Directory.GetFiles(TempParent + @"\" + TempWorkingDirName, "*", SearchOption.AllDirectories);

                    ArcInsideMsbtAndMsbfPath = new List<string>();
                    foreach (var FilePath in FilePathStrings)
                    {
                        var FilePathExtension = Path.GetExtension(FilePath).ToLower();
                        if (FilePathExtension == ".msbt" || FilePathExtension == ".msbf")
                        {
                            ArcInsideMsbtAndMsbfPath.Add(FilePath);
                            ARCListBox.Items.Add(Path.GetFileName(FilePath));
                        }
                    }
                    Temp_Path_Arc = TempARCPath;

                    Console.WriteLine("★"+TempARCPath);
                    File.Delete(TempARCPath);
                    //MsbtListBox.Items.Clear();
                    //list2.Items.Clear();
                    //list3.Items.Clear();

                    tssl7.Text = Path.GetFileName(Save_Path_Arc);
                    break;

                default:
                    MessageBox.Show
                    (
                        "未対応のファイルです\r\n" +
                        "MSBT,MSBF,ARC(RARC)ファイルのみ読み込めます",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
            }
        }

        public static void ArcSave(string newArcSavePath = "")
        {
            SaveStatusPathString.ForeColor = Color.Red;
            SaveStatusPathString.Text = "Arcを保存できませんでした。" + SaveMissTime();
            if (ARCListBox.Items.Count < 1)
            {
                return;
            }
            if (ArcInsideMsbtAndMsbfPath.Count < 1)
            {
                return;
            }
            if (newArcSavePath != string.Empty)
            {
                Save_Path_Arc = newArcSavePath;
            }

            var PathReplace = Temp_Path_Arc.Substring(0, Temp_Path_Arc.Length - 4);
            //Console.WriteLine(PathReplace);
            //Console.ReadKey();
            //var PathReplace = path.Substring(0, path.Length - 1);
            //Console.WriteLine("pathreplace    "+PathReplace);
            //if (Directory.Exists(PathReplace))
            //{
            //    Console.WriteLine("圧縮フォルダパス" + PathReplace);
            //    var DirStrs = ARCTool.FileSys.DirectoryFileEdit.DirectoryNameSort(PathReplace)/*Directory.GetDirectories(PathReplace, "*", SearchOption.AllDirectories).OrderBy(sort => sort)*/;
            //    var FileStrs = ARCTool.FileSys.DirectoryFileEdit.FileNameSort(PathReplace);/*Directory.GetFiles(PathReplace, "*", SearchOption.AllDirectories).OrderBy(sort => sort)*/;
            //    //if (DirStrs.Count() < 1) continue;
            //    //if (FileStrs.Count() < 1) continue;

            //    var arcfile = Path.GetFileName(PathReplace);
            //    var arcfolder = Path.GetDirectoryName(PathReplace);

            //    ARCTool.FileSys.RARC rarc = new ARCTool.FileSys.RARC() ;

            //    //if (yesno == 'y')
            //    //{
            //    //    rarc.Archive(arcfolder + @"\" + arcfile + ".rarc", DirStrs, FileStrs);
            //    //    Console.WriteLine("yaz0処理に入りました");
            //    //    Yaz0 yaz0 = new();
            //    //    yaz0.Encode(arcfolder + @"\" + arcfile + ".rarc");
            //    //    Console.WriteLine("Yaz0圧縮できました");
            //    //    continue;
            //    //}
            //    //Console.WriteLine("path     " + arcfolder + @"\" + arcfile + ".arc", DirStrs, FileStrs);
            //    //Console.ReadKey();
            //    Console.WriteLine(arcfile.Count());
            //    rarc.Archive(arcfolder + @"\" + arcfile + ".arc", DirStrs, FileStrs);
            //    Console.WriteLine("Yaz0処理をしていません");
            //}

            ExternalFileExecutor efe = new ExternalFileExecutor();
            efe.ARCToolExecutor((Temp_Path_Arc.Substring(0, Temp_Path_Arc.Length - 4)), true);
            //RARC.Archive(Temp_Path_Arc.Substring(0, Temp_Path_Arc.Length - 4)));
            //System.Threading.Thread.Sleep(5000);
            File.Copy(Temp_Path_Arc, Save_Path_Arc, true);
            Console.WriteLine(Temp_Path_Arc);
            Console.WriteLine(Save_Path_Arc);
            SaveStatusPathString.ForeColor = Color.Green;
            SaveStatusPathString.Text = Save_Path_Arc;
            Console.WriteLine("ARCを保存しました");
        }

        private static bool MagicChecker(string filePath, string checkString)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            var Magic = Calculation_System.Byte2Char(br);
            br.Close();
            fs.Close();
            if (Magic == checkString)
            {
                return true;
            }
            return false;
        }
    }
}
