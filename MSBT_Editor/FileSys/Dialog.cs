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
        private static string Save_Path = "None";

        public static void Open() {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "default.msbt";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "メッセージファイル(*.msbt;*.Msbt)|*.msbt;*.Msbt|メッセージフローファイル(*.msbf;*.Msbf)|*.msbf;*.Msbf|すべてのファイル(*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            if (ofd.ShowDialog() == DialogResult.OK){
                
                FileCheck(ofd.FileName);

            }



        }

        public static void SaveAs() {
            if (Save_Path == "None") {
                MessageBox.Show("ファイルを開くまたは保存先を指定してください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MSBT_Header msbth = new MSBT_Header();
            msbth.Write(Save_Path);
            Console.WriteLine("MSBT_読み込み完了");
        }

        public static void Save(){
            //SaveFileDialogクラスのインスタンスを作成
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "新しいファイル.msbt";
            sfd.InitialDirectory = @"C:\";
            sfd.Filter = "メッセージファイル(*.msbt)|*.msbt;*.MSBT";
            sfd.FilterIndex = 1;
            sfd.Title = "保存先のファイルを選択してください";
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;
            //ダイアログを表示する
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイルを保存

                MSBT_Header msbth = new MSBT_Header();
                msbth.Write(sfd.FileName);
                Save_Path = sfd.FileName;
                Console.WriteLine("MSBT_読み込み完了");
                //BCK bck = new BCK();
                //bck.Write(sfd.FileName);
            }
        }

        public static void MSBF() {
        
        }


        public static void FileCheck(string filepath)
        {
            var file_flag = File.Exists(filepath);
            var File_Extension = Path.GetExtension(filepath);
           
            var MSBF_File_Path = Path.ChangeExtension(filepath,"msbf");

            Save_Path = filepath;
            if (file_flag == true)
            {
                
                
                //拡張子の種類を判別
                switch (File_Extension.ToLower())
                {
                    case ".msbt":
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
