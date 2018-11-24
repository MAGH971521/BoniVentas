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
    public partial class DataRecoveryForm : CustomControls.DialogForm
    {
        public DataRecoveryForm(string Caption)
        {
            this.WindowName.Text = Caption;
            this.Width = 350;
            this.Height = 250;
            InitializeComponent();
        }

        private void btnSender_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
