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
            dgUsers.ReadOnly = true;
            HideColumns();
        }

        private void HideColumns()
        {
            dgUsers.Columns[0].Visible = false;
            dgUsers.Columns["Pswd"].Visible = false;
            dgUsers.Columns["Birthday"].Visible = false;
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtFirstPattern.Text = "";
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
            if(dgUsers.SelectedRows.Count > 0)
            {
                var helper = dgUsers.SelectedRows[0].Cells;
                UserType type;
                Enum.TryParse(helper[7].ToString(), out type);


                User user = new User();
                user.Id = Convert.ToInt32(helper[0].Value.ToString());
                user.Username = helper[1].Value.ToString();
                user.Pswd = helper[2].Value.ToString();
                user.EmailAddress = helper[3].Value.ToString();
                user.Name = helper[4].Value.ToString();
                user.LastName = helper[5].Value.ToString();
                user.Birthday = Convert.ToDateTime(helper[6].Value.ToString());
                user.Type = type;
                UserModifyForm UMF = new UserModifyForm(user);
                UMF.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgUsers.SelectedRows.Count > 0)
            {
                var cells = dgUsers.SelectedRows[0].Cells;
                UserController controller = new UserController();


                var helper = dgUsers.SelectedRows[0].Cells;
                UserType type;
                Enum.TryParse(helper[7].ToString(), out type);
                
                User user = new User();
                user.Id = Convert.ToInt32(helper[0].Value.ToString());

                if(MessageBox.Show("¿Esta seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    controller.Delete(user);
                    dgUsers.SelectedRows[0].Visible = false;
                } else
                {
                    user = null;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            if (txtFirstPattern.Text != "" && chckUserType2.CheckState == CheckState.Checked && chckUserType.CheckState == CheckState.Checked)
            {
                dgUsers.DataSource = controller.Select(Query.And(Query.StartsWith("Username", txtFirstPattern.Text)));
            }
            else if (txtFirstPattern.Text != "" && chckUserType2.CheckState == CheckState.Checked)
            {
                dgUsers.DataSource = controller.Select(Query.And(Query.StartsWith("Username", txtFirstPattern.Text), Query.EQ("Type", "Admon")));
            }
            else if (txtFirstPattern.Text != "" && chckUserType.CheckState == CheckState.Checked)
            {
                dgUsers.DataSource = controller.Select(Query.And(Query.StartsWith("Username", txtFirstPattern.Text), Query.EQ("Type", "Employee")));
            }
            else if (chckUserType2.CheckState == CheckState.Checked && txtFirstPattern.Text == "")
            {
                dgUsers.DataSource = controller.Select(Query.EQ("Type", "Admon"));
            }
            else if (chckUserType.CheckState == CheckState.Checked && txtFirstPattern.Text == "")
            {
                dgUsers.DataSource = controller.Select(Query.EQ("Type", "Employee"));
            }
            else
            {
                dgUsers.DataSource = controller.Select(Query.All());
            }
            dgUsers.Refresh();
        }
    }
}
