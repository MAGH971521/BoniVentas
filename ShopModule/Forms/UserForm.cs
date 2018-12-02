using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopModule.Forms
{
    public partial class UserForm : UserControl
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtFirstPattern.Text = "";
            txtLastPattern.Text = "";
            chckUserType.CheckState = CheckState.Unchecked;
            chckUserType2.CheckState = CheckState.Unchecked;
        }
    }
}
