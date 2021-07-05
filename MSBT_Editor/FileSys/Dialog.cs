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

namespace MSBT_Editor.FileSys
{
    public class Dialog:objects
    {
        private static string Save_Path_Msbt = "None";
        private static string Save_Path_Msbf = "None";

        public string Path_Msbt {
            set => Save_Path_Msbt = value;
            get => Save_Path_Msbt;
        }

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

        public static void SaveAs() {
            if (Save_Path_Msbt == "None") {
                MessageBox.Show("ファイルを開くまたは保存先を指定してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MSBT_Header msbth = new MSBT_Header();
            msbth.Write(Save_Path_Msbt);
            //Console.WriteLine("MSBT_読み込み完了");
        }


        public static void SaveAs_Msbf()
        {
            if (Save_Path_Msbf == "None")
            {
                MessageBox.Show("ファイルを開くまたは保存先を指定してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MSBF_Header msbfh = new MSBF_Header();
            msbfh.Write(Save_Path_Msbf);
            //Console.WriteLine("MSBF_読み込み完了");
        }

        public static void Save(int filenum)
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
                        Console.WriteLine("MSBT_読み込み完了");
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

        public static void MSBF() {
        
        }


        public static void FileCheck(string filepath)
        {
            var file_flag = File.Exists(filepath);
            var File_Extension = Path.GetExtension(filepath);
           
            var MSBF_File_Path = Path.ChangeExtension(filepath,"msbf");

            
            if (file_flag == true)
            {
                
                
                //拡張子の種類を判別
                switch (File_Extension.ToLower())
                {
                    case ".msbt":
                        Save_Path_Msbt = filepath;
                        tssl2.Text = "";
                        MSBT_Header msbth = new MSBT_Header();
                        msbth.Read(filepath);
                        Console.WriteLine("MSBT_読み込み完了");
                        tssl2.Text = Path.GetFileName(filepath);

                        //if (File.Exists(MSBF_File_Path)==false) break;
                        //MSBF_Header msbfh = new MSBF_Header();
                        //msbfh.Read(MSBF_File_Path);
                        //Console.WriteLine("MSBF_読み込み完了");
                        //tssl4.Text = Path.GetFileName(MSBF_File_Path);

                        break;
                    case ".msbf":
                        Save_Path_Msbf = filepath;
                        tssl4.Text = "";
                        //if (File.Exists(MSBF_File_Path) == false) break;
                        MSBF_Header msbfh = new MSBF_Header();
                        msbfh.Read(MSBF_File_Path);
                        Console.WriteLine("MSBF_読み込み完了");
                        tssl4.Text = Path.GetFileName(MSBF_File_Path);
                        break;

                    default:
                        MessageBox.Show("未対応のファイルです" + "\r\n" + "MSBTファイルのみ読み込めます", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                }
            }
            else {
                MessageBox.Show("ファイルが存在しません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
