using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShopModule.CustomControls
{
    class BBLabel : Label
    { 
        public BBLabel()
        {
            AutoSize = false;
            Controls.Add(
                new Label()
                {
                    Height = 2,
                    Dock = DockStyle.Bottom,
                    BackColor = Color.FromArgb(41, 128, 185)
                });
        }
    }
}
