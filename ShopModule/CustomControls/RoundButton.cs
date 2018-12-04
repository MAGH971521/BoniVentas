using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ShopModule.CustomControls
{
    class RoundButton : Button
    {
        public RoundButton()
        {
            this.ForeColor = Color.White;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 152, 219);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(graphicsPath);
            base.OnPaint(pevent);
        }
    }
}
