using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopModule.Forms
{
    public partial class DataRecoveryForm : CustomControls.DialogForm
    {
        private const string Pattern = "^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$";

        public DataRecoveryForm(string Caption)
        {
            this.WindowName.Text = Caption;
            this.Width = 350;
            this.Height = 250;
            InitializeComponent();
        }

        private bool ValidateEmail(string mail)
        {
            return (mail != null && Regex.IsMatch(mail, Pattern));
        }

        private void btnSender_Click(object sender, EventArgs e)
        {
            if(ValidateEmail(txtMail.Text))
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");


                    mail.From = new MailAddress("magh1521@gmail.com");
                    mail.To.Add(txtMail.Text);
                    mail.Subject = "Recovery Password";
                    mail.Body = "Your password is: ";

                    smtpServer.Port = 587;
                    smtpServer.Credentials = new System.Net.NetworkCredential("magh1521@gmail.com", "15211476");
                    smtpServer.Send(mail);
                }
                catch (Exception ex)
                {

                }
                this.Close();
            }
            else
            {
                this.txtMail.Controls[0].BackColor = Color.FromArgb(192, 57, 43);
                this.txtMail.Focus();
            }
            
        }

        private void btnSender_onChangeText(object sender, EventArgs e)
        {
            if(ValidateEmail(txtMail.Text))
            {
                this.txtMail.Controls[0].BackColor = Color.FromArgb(39, 174, 96);
            }
            else
            {
                this.txtMail.Controls[0].BackColor = Color.FromArgb(192, 57, 43);
            }
        }
    }
}
