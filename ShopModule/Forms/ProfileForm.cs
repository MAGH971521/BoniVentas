using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopModule.Classes.Models;
using ShopModule.Classes.Misc;
using ShopModule.Forms.UsersActions;

namespace ShopModule.Forms
{
    public partial class ProfileForm : UserControl
    {
        private User user;
        public ProfileForm(User user)
        {
            InitializeComponent();
            this.user = user;
            lblProfileTitle.Text = lblProfileTitle.Text + " " + user.Username;
            txtName.Text = user.Name;
            txtLastName.Text = user.LastName;
            txtMail.Text = user.EmailAddress;
            dpBirth.Value = user.Birthday;
            txtUser.Text = user.Username;
            txtPswd.Text = txtConfirm.Text = Miscs.DecryptPassword(user.Pswd);
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            UserModifyForm UMF = new UserModifyForm(user);
            if(UMF.ShowDialog() == DialogResult.OK)
            {
                txtName.Text = UMF.oldUser.Name;
                txtLastName.Text = UMF.oldUser.LastName;
                txtMail.Text = UMF.oldUser.EmailAddress;
                dpBirth.Value = UMF.oldUser.Birthday;
                txtUser.Text = UMF.oldUser.Username;
                txtPswd.Text = txtConfirm.Text = Miscs.DecryptPassword(UMF.oldUser.Pswd);
            }
        }
    }
}
