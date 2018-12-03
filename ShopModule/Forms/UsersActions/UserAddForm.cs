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
    public partial class UserAddForm : TemplateForm
    {

        OpenFileDialog open = new OpenFileDialog();
        private const string Pattern = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";

        public UserAddForm()
        {
            InitializeComponent();
            cbUserType.DataSource = Enum.GetNames(typeof(UserType));
            this.WindowName.Text = "Usuarios - Agregar";
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
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Hide();
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
                int newId = controller.Count(Query.All()) + 1;
                try
                {
                    UserType type;
                    Enum.TryParse(cbUserType.SelectedValue.ToString(), out type);
                    User user = new User()
                    {
                        Id = newId,
                        Name = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Birthday = dpBirth.Value,
                        EmailAddress = txtMail.Text,
                        Username = txtUser.Text,
                        Pswd = Miscs.EncryptPassword(txtPswd.Text),
                        Type = type
                    };

                    controller.Add(user);
                    this.Hide();
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

        public override void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClearFields();
        }
    }
}
