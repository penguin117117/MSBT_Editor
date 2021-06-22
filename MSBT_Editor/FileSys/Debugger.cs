using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSBT_Editor.Formsys;
using EN = System.Environment;
namespace MSBT_Editor.FileSys
{
    public class Debugger:objects
    {
        public static void Text(string txt , bool txttop = false) {
            if (txttop == true)
            {
                msbtdebugtxt.Text = txt;
            }
            else
            {
                msbtdebugtxt.AppendText(EN.NewLine + txt);
            }
        }

        public static void MSBF_Text(string txt, bool txttop = false , bool newline = true) {
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
                else {
                    txtb2.AppendText( txt);
                }
                
            }
        }

        public static void HashTxt(string txt, bool txttop = false , bool newline = true)
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
    }
}
