using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopModule.Forms.UsersActions;
using ShopModule.Classes.Models;
using LiteDB;
using ShopModule.Classes.Controllers;

namespace ShopModule.Forms
{
    public partial class UserForm : UserControl
    {
        public UserForm()
        {
            UserController controller = new UserController();
            InitializeComponent();
            dgUsers.DataSource = controller.Select(Query.All());
            HideColumns();
        }

        private void HideColumns()
        {
            dgUsers.Columns["Pswd"].Visible = false;
            dgUsers.Columns["ImagePath"].Visible = false;
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtFirstPattern.Text = "";
            txtLastPattern.Text = "";
            chckUserType.CheckState = CheckState.Unchecked;
            chckUserType2.CheckState = CheckState.Unchecked;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UserAddForm UAF = new UserAddForm();
            UAF.Show();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            User user = new User()
            {

            };
            UserModifyForm UMF = new UserModifyForm(user);
            UMF.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
