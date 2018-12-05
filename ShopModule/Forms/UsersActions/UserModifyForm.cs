using LiteDB;
using ShopModule.Classes.Controllers;
using ShopModule.Classes.Misc;
using ShopModule.Classes.Models;
using ShopModule.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopModule.Forms.UsersActions
{
    public partial class UserModifyForm : TemplateForm
    {
        private const string Pattern = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";
        public User oldUser;

        public UserModifyForm(User user)
        {
            InitializeComponent();
            this.WindowName.Text = "Usuarios -  Modificar";
            oldUser = user;
            cbUserType.DataSource = Enum.GetNames(typeof(UserType));

            txtConfirm.Text = Miscs.DecryptPassword(oldUser.Pswd);
            txtPswd.Text = Miscs.DecryptPassword(oldUser.Pswd);
            txtUser.Text = oldUser.Username;
            txtFirstName.Text = oldUser.Name;
            txtLastName.Text = oldUser.LastName;
            dpBirth.Value = oldUser.Birthday;
            txtMail.Text = oldUser.EmailAddress;
            cbUserType.SelectedIndex = (oldUser.Type == UserType.Admon ? 0 : 1);
        }

        private bool ValidateEmail(string mail)
        {
            return (mail != null && Regex.IsMatch(mail, Pattern));
        }
        private void ClearFields()
        {
            pbImageUser.Image = null;
            txtConfirm.Text = "";
            txtPswd.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            dpBirth.Value = DateTime.Now;
            txtMail.Text = "";
            cbUserType.SelectedIndex = 0;
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (ValidateEmail(txtMail.Text)
                && (txtPswd.Text == txtConfirm.Text)
                && txtFirstName.Text != null
                && txtLastName.Text != null
                && txtPswd.Text != null
                && txtConfirm.Text != null)
            {
                UserController controller = new UserController();
                int Id = oldUser.Id;
                try
                {
                    UserType type;
                    Enum.TryParse(cbUserType.SelectedValue.ToString(), out type);
                    User user = new User()
                    {
                        Id = Id,
                        Name = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Birthday = dpBirth.Value,
                        EmailAddress = txtMail.Text,
                        Username = txtUser.Text,
                        Pswd = Miscs.EncryptPassword(txtPswd.Text),
                        Type = type
                    };

                    controller.Update(user);
                    this.Hide();
                    this.DialogResult = DialogResult.OK;
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Hide();
        }
    }
}
