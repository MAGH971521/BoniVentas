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
            this.pbLogo.Image = Logo;
            InitializeComponent();
        }

        public override void btnClose_Click(object sender, EventArgs e)
        {
            base.btnClose_Click(sender, e);
        }
    }
}
