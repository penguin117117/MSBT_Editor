using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace MSBT_Editor.Formsys
{
    /// <summary>
    /// KeyPressEventの補助をします。
    /// </summary>
    public class KeyPressEventSupport
    {

        /// <summary>
        /// KeyPressEventArgのKeyCharの入力を16進数しか入力できないようにします。
        /// </summary>
        /// <param name="e">TextBoxのKeyPressEventArgs</param>
        /// <param name="isALLUpper">trueですべて大文字にします</param>
        public static void OnlyHexChar(KeyPressEventArgs e, bool isALLUpper = false)
        {
            var IncludeAtoF = (e.KeyChar < 'A' || 'F' < e.KeyChar);
            var Includeatof = (e.KeyChar < 'a' || 'f' < e.KeyChar);
            var Include0to9 = (e.KeyChar < '0' || '9' < e.KeyChar);
            e.Handled = true;
            if (!(IncludeAtoF && Includeatof && Include0to9) || e.KeyChar == '\b')
            {
                if (!Includeatof && isALLUpper)
                {
                    e.KeyChar = char.ToUpper(e.KeyChar);
                }
                e.Handled = false;
            }
        }

        /// <summary>
        /// KeyPressEventArgのKeyCharの入力を10進数しか入力できないようにします。
        /// </summary>
        /// <param name="e">TextBoxのKeyPressEventArgs</param>
        public static void OnlyDecChar(KeyPressEventArgs e) {
            var Include0to9 = (e.KeyChar < '0' || '9' < e.KeyChar);
            e.Handled = true;
            if (!(Include0to9) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        /// <summary>
        /// KeyPressEventArgのKeyCharの書き込みを制限します
        /// </summary>
        /// <param name="e">TextBoxのKeyPressEventArgs</param>
        /// <param name="canWrite">Trueで書き込みが可能になります</param>
        public static void CanWriteChar(KeyPressEventArgs e ,bool canWrite)
        {
            e.Handled = !canWrite;
        }
    }
}
