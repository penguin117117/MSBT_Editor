using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using MSBT_Editor.Formsys;
using EN = System.Environment;

namespace MSBT_Editor.FileSys
{
    public class Debugger : Objects
    {
        public static void Text(string txt, bool txttop = false)
        {
            if (txttop == true)
            {
                msbtdebugtxt.Text = txt;
            }
            else
            {
                msbtdebugtxt.AppendText(EN.NewLine + txt);
            }
        }

        public static void MSBF_Text(string txt, bool txttop = false, bool newline = true)
        {
            if (txttop == true)
            {
                txtb2.Text = txt;
            }
            else
            {
                if (newline == true)
                {
                    txtb2.AppendText(EN.NewLine + txt);
                }
                else
                {
                    txtb2.AppendText(txt);
                }
            }
        }

        public static void HashTxt(string txt, bool txttop = false, bool newline = true)
        {
            if (txttop == true)
            {
                txtb13.Text = txt;
            }
            else
            {
                //txtb13.AppendText(EN.NewLine + txt);
                if (newline == true)
                {
                    txtb13.AppendText(EN.NewLine + txt);
                }
                else
                {
                    txtb13.AppendText(txt);
                }
            }
        }

        public static void Unknowntagwriter(string str,bool dupeDelete = false)
        {
            //var spl = str.Split('_');
            //spl = spl.Replace("_End","");

            //var rem = Regex.Replace(str, "([0-9][0-9][0-9$])|((_End|_Flow|_sub)[0-9][0-9][0-9$])", "");
            var rem = Regex.Replace(str, "([0-9][0-9][0-9$])", "XXX");
            //var match = Regex.Match(str, "([0-9][0-9][0-9$])|((_End|_Flow|_sub)[0-9][0-9][0-9$])");

            //if (match == Match.Empty) return;

            if (dupeDelete)
            {
                var find = unknowntag.Text.IndexOf(rem+"\r\n");
                //Console.WriteLine(spl[0] + find);
                if (find != -1)
                {
                    return;
                }
            }
            unknowntag.AppendText(rem + EN.NewLine);
        }
    }
}
