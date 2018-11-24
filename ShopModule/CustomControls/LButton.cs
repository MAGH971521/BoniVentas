using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopModule.CustomControls
{
    class LButton : Button
    {
        public LButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            AutoSize = false;
            
            TextAlign = ContentAlignment.MiddleLeft;
            Controls.Add(
                new Label()
                {
                    Width = 5, Dock = DockStyle.Left, BackColor = Color.FromArgb(39, 174, 96)
                });
        }
    }
}
