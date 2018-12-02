using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using LiteDB;
using ShopModule.Classes.Controllers;
using ShopModule.Classes.Models;

namespace ShopModule
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            User user = new User();
            user.Username = "admon01";
            user.Pswd = Classes.Misc.Miscs.EncryptPassword("temp123");
            user.EmailAddress = "magh1521@gmail.com";
            user.Name = "John";
            user.LastName = "Smith";
            user.Type = UserType.Admon;

            try
            {
                UserController controller = new UserController();
                controller.Add(user);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

            EffectEvents();
        }

        private void EffectEvents()
        {
            this.lblTitle.Hide();
            this.lblUsername.Hide();
            this.txtUsername.Hide();
            this.lblPswd.Hide();
            this.txtPswd.Hide();
            this.btnAccess.Hide();
            this.lnkDataRecovery.Hide();

            animateComponents.Show(lblTitle);
            animateComponents.Show(lblUsername);
            animateComponents.Show(txtUsername);
            animateComponents.Show(lblPswd);
            animateComponents.Show(txtPswd);
            animateComponents.Show(btnAccess);
            animateComponents.Show(lnkDataRecovery);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        static extern bool ReleaseCapture();

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtPswd.Text.Length > 0 )
            {

                UserController userController = new UserController();
                try
                {
                    User user = userController.Select(Query.EQ("Username", txtUsername.Text))[0];
                    if (user.Pswd == Classes.Misc.Miscs.EncryptPassword(txtPswd.Text))
                    {

                        Forms.MenuForm mF = new Forms.MenuForm("BoniVentas", pbLogo.Image, user);
                        mF.Show();
                        this.Hide();
                        txtUsername.Clear();
                        txtPswd.Clear();
                    } else
                    {
                        MessageBox.Show(user.Pswd + "\n" + Classes.Misc.Miscs.EncryptPassword(txtPswd.Text), "Error :(");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (txtUsername.Text.Length > 0 && txtPswd.Text.Length <= 0)
            {
                txtPswd.Controls[0].BackColor = Color.FromArgb(192, 57, 43);
                txtPswd.Focus();
            }
            else if (txtUsername.Text.Length <= 0 && txtPswd.Text.Length > 0)
            {
                txtUsername.Controls[0].BackColor = Color.FromArgb(192, 57, 43);
                txtUsername.Focus();
            }
            else
            {
                txtUsername.Controls[0].BackColor = Color.FromArgb(192, 57, 43);
                txtPswd.Controls[0].BackColor = Color.FromArgb(192, 57, 43);
            }
        }

        private void lnkDataRecovery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.DataRecoveryForm dF = new Forms.DataRecoveryForm("Recuperacion de Datos");
            dF.Show();
        }

        private void txtUsername_onChangeText(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0)
            {
                txtUsername.Controls[0].BackColor = Color.FromArgb(41, 128, 185);
            }
            else
            {
                txtUsername.Controls[0].BackColor = Color.FromArgb(192, 57, 43);
            }
        }

        private void txtPswd_onChangeText(object sender, EventArgs e)
        {
            if(txtPswd.Text.Length > 0)
            {
                txtPswd.Controls[0].BackColor = Color.FromArgb(41, 128, 185);
            }
            else
            {
                txtPswd.Controls[0].BackColor = Color.FromArgb(192, 57, 43);
            }
        }
    }
}
