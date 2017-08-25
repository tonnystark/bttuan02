using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan02
{
    public class UpperTextbox : TextBox
    {
        public UpperTextbox()
        {
            this.KeyPress += UpperTextbox_KeyPress;
        }

        private void UpperTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsUpper(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
