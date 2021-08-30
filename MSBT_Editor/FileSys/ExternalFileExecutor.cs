﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace MSBT_Editor.FileSys
{
    /// <summary>
    /// 外部の実行ファイルを実行するクラス
    /// </summary>
    public class ExternalFileExecutor
    {
        /// <summary>
        /// リソースから、ARCToolの実行に必要なファイルを実行ファイルと同じ階層の<br/>
        /// resフォルダ内に生成します。
        /// </summary>
        /// <param name="ARCToolExecutorSetDirectoryPath"></param>
        /// <param name="ARCToolExecutorSetPath"></param>
        private static void ARCToolExeCutorCreator(ref string ARCToolExecutorSetDirectoryPath , ref string ARCToolExecutorSetPath) {

            var AppExePath                  = Application.ExecutablePath;
            var AppDirectoryPath            = Path.GetDirectoryName(AppExePath);
            var ARCToolExeBinaryData           = Properties.Resources.ARCTool_ver0_1_5_0;
            var ARCToolDllBinaryData = Properties.Resources.ARCTool_ver0_1_5_01;
            var ARCToolDepsJsonBinaryData = Properties.Resources.ARCTool_ver0_1_5_0_deps;
            var ARCToolRuntimeJsonBinaryData = Properties.Resources.ARCTool_ver0_1_5_0_runtimeconfig;

            ARCToolExecutorSetDirectoryPath = Path.Combine(AppDirectoryPath, "res");
            ARCToolExecutorSetPath = ARCToolExecutorSetDirectoryPath + @"\ARCTool_ver0.1.5.0.exe";
            var ARCToolDllSetPath = ARCToolExecutorSetDirectoryPath + @"\ARCTool_ver0.1.5.0.dll";
            var ARCToolDepsJsonSetPath = ARCToolExecutorSetDirectoryPath + @"\ARCTool_ver0.1.5.0.deps.json";
            var ARCToolRuntimeJsonSetPath = ARCToolExecutorSetDirectoryPath + @"\ARCTool_ver0.1.5.0.runtimeconfig.json";

            Directory.CreateDirectory(ARCToolExecutorSetDirectoryPath);
            File.WriteAllBytes(ARCToolExecutorSetPath, ARCToolExeBinaryData);
            File.WriteAllBytes(ARCToolDllSetPath, ARCToolDllBinaryData);
            File.WriteAllBytes(ARCToolDepsJsonSetPath, ARCToolDepsJsonBinaryData);
            File.WriteAllBytes(ARCToolRuntimeJsonSetPath, ARCToolRuntimeJsonBinaryData);
            Console.WriteLine("ok");
        }
        public static void ARCToolExecutor(string filepath) {
            string ARCToolExecutorSetDirectoryPath = string.Empty;
            string ARCToolExecutorSetPath = string.Empty;

            ARCToolExeCutorCreator(ref ARCToolExecutorSetDirectoryPath, ref ARCToolExecutorSetPath);
            //return;
            var dir = Directory.GetParent(filepath).FullName;
            

            
            

            ProcessStartInfo psi = new ProcessStartInfo();

            psi.FileName = ARCToolExecutorSetPath/*dir + @"\res" + @"\ARCTool_ver0.1.1.0.exe"*/;
            psi.WorkingDirectory = ARCToolExecutorSetDirectoryPath/*Path.Combine(dir, "res")*/;
            //スペースを含むパスの処理に"\""で挟み込む必要がある。
            //例：新しいフォルダー (11)など
            psi.Arguments = "\""+ filepath + "\"";
            psi.UseShellExecute = false;
            psi.RedirectStandardError = true;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;

            Process p = Process.Start(psi);

            var ErrorCMD = p.StandardError.ReadToEnd();
            var OutputCMD = p.StandardOutput.ReadToEnd();

            p.WaitForExit();
            

            Console.WriteLine(ErrorCMD);
            Console.WriteLine(OutputCMD);
            
        }
    }
}
