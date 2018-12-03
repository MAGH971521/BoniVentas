using System.Drawing;
using System.Windows.Forms;

namespace ShopModule.CustomControls
{
    public class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            BorderStyle = BorderStyle.None;
            AutoSize = false;
            Controls.Add(
                new Label()
                {
                    Height = 2, Dock = DockStyle.Bottom, BackColor = Color.FromArgb(41, 128, 185)
                });
        }
    }
}
