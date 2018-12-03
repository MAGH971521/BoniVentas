using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopModule.CustomControls
{
    class CustomComboBox : ComboBox
    {
        public CustomComboBox()
        {
            FlatStyle = FlatStyle.Flat;
            AutoSize = false;
            Controls.Add(
                new Label()
                {
                    Height = 2,
                    Dock = DockStyle.Bottom,
                    BackColor = Color.FromArgb(41, 128, 185)
                });
            Controls.Add(
                new Label()
                {
                    Width = 2,
                    Dock = DockStyle.Right,
                    BackColor = Color.FromArgb(41, 128, 185)
                });
        }
    }
}
