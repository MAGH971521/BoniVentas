using ShopModule.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopModule.Forms
{
    public partial class MenuForm : TemplateForm
    {
        public MenuForm(string WindowName, Image Logo)
        {
            this.WindowName.Text = WindowName;
            pbLogo.Image = Logo;
            InitializeComponent();

            btnAccess_Compras.Controls[0].BackColor = Color.FromArgb(243, 156, 18);
            btnAccess_Ventas.Controls[0].BackColor = Color.FromArgb(22, 160, 133);
            btnAccess_Productos.Controls[0].BackColor = Color.FromArgb(142, 68, 173);

            btnAccess_Productos.MouseEnter += (object sender, EventArgs e) =>
            {
                LButton btn = sender as LButton;
                btn.BackColor = Color.FromArgb(155, 89, 182);
            };
            btnAccess_Productos.MouseLeave += (object sender, EventArgs e) =>
            {
                LButton btn = sender as LButton;
                btn.BackColor = Color.Transparent;
            };

            btnAccess_Compras.MouseEnter += (object sender, EventArgs e) =>
            {
                LButton btn = sender as LButton;
                btn.BackColor = Color.FromArgb(243, 156, 18);
            };
            btnAccess_Compras.MouseLeave += (object sender, EventArgs e) =>
            {
                LButton btn = sender as LButton;
                btn.BackColor = Color.Transparent;
            };
        }

        public override void btnClose_Click(object sender, EventArgs e)
        {
            base.btnClose_Click(sender, e);
        }
    }
}
