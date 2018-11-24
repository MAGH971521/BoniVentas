using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopModule.CustomControls
{
    class FlatButton : Button
    {
        public FlatButton()
        {
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
            this.BackColor = Color.FromArgb(41, 128, 185);
        }
    }
}
