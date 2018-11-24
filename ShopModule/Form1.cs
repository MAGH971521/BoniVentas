using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ShopModule
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

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
            Forms.MenuForm menu = new Forms.MenuForm("BoniVentas - Menu", pbLogo.Image);
            menu.Show();
            this.Hide();
        }

        private void lnkDataRecovery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.DataRecoveryForm dF = new Forms.DataRecoveryForm("Recuperacion de Datos");
            dF.Show();
        }
    }
}
