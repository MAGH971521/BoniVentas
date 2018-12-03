namespace ShopModule
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.RPanel = new System.Windows.Forms.Panel();
            this.lnkDataRecovery = new System.Windows.Forms.LinkLabel();
            this.WindowPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPswd = new ShopModule.CustomControls.CustomTextBox();
            this.txtUsername = new ShopModule.CustomControls.CustomTextBox();
            this.lblPswd = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnAccess = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.LPanel = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.RPanel.SuspendLayout();
            this.WindowPanel.SuspendLayout();
            this.LPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // RPanel
            // 
            this.RPanel.BackColor = System.Drawing.Color.White;
            this.RPanel.Controls.Add(this.lnkDataRecovery);
            this.RPanel.Controls.Add(this.WindowPanel);
            this.RPanel.Controls.Add(this.txtPswd);
            this.RPanel.Controls.Add(this.txtUsername);
            this.RPanel.Controls.Add(this.lblPswd);
            this.RPanel.Controls.Add(this.lblUsername);
            this.RPanel.Controls.Add(this.btnAccess);
            this.RPanel.Controls.Add(this.lblTitle);
            this.RPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RPanel.Location = new System.Drawing.Point(350, 0);
            this.RPanel.Name = "RPanel";
            this.RPanel.Size = new System.Drawing.Size(350, 450);
            this.RPanel.TabIndex = 0;
            this.RPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            // 
            // lnkDataRecovery
            // 
            this.lnkDataRecovery.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lnkDataRecovery.BackColor = System.Drawing.Color.Transparent;
            this.lnkDataRecovery.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lnkDataRecovery.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lnkDataRecovery.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lnkDataRecovery.Location = new System.Drawing.Point(0, 405);
            this.lnkDataRecovery.Name = "lnkDataRecovery";
            this.lnkDataRecovery.Size = new System.Drawing.Size(350, 45);
            this.lnkDataRecovery.TabIndex = 7;
            this.lnkDataRecovery.TabStop = true;
            this.lnkDataRecovery.Text = "¿Se te olvidaron tus datos?";
            this.lnkDataRecovery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkDataRecovery.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lnkDataRecovery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDataRecovery_LinkClicked);
            // 
            // WindowPanel
            // 
            this.WindowPanel.Controls.Add(this.btnMinimize);
            this.WindowPanel.Controls.Add(this.btnClose);
            this.WindowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowPanel.Location = new System.Drawing.Point(0, 0);
            this.WindowPanel.Name = "WindowPanel";
            this.WindowPanel.Size = new System.Drawing.Size(350, 35);
            this.WindowPanel.TabIndex = 6;
            this.WindowPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.Location = new System.Drawing.Point(280, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "___";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.DarkGray;
            this.btnClose.Location = new System.Drawing.Point(315, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPswd
            // 
            this.txtPswd.BackColor = System.Drawing.Color.White;
            this.txtPswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPswd.Location = new System.Drawing.Point(50, 256);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.PasswordChar = '*';
            this.txtPswd.Size = new System.Drawing.Size(250, 25);
            this.txtPswd.TabIndex = 5;
            this.txtPswd.TextChanged += new System.EventHandler(this.txtPswd_onChangeText);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(50, 180);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 25);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_onChangeText);
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.Location = new System.Drawing.Point(50, 224);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(89, 21);
            this.lblPswd.TabIndex = 3;
            this.lblPswd.Text = "Contraseña";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(50, 150);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(64, 21);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Usuario";
            // 
            // btnAccess
            // 
            this.btnAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAccess.FlatAppearance.BorderSize = 0;
            this.btnAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccess.ForeColor = System.Drawing.Color.White;
            this.btnAccess.Location = new System.Drawing.Point(50, 320);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(250, 40);
            this.btnAccess.TabIndex = 1;
            this.btnAccess.Text = "Acceder";
            this.btnAccess.UseVisualStyleBackColor = false;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblTitle.Location = new System.Drawing.Point(100, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Iniciar Sesion";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LPanel
            // 
            this.LPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.LPanel.Controls.Add(this.pbLogo);
            this.LPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LPanel.Location = new System.Drawing.Point(0, 0);
            this.LPanel.Name = "LPanel";
            this.LPanel.Size = new System.Drawing.Size(350, 450);
            this.LPanel.TabIndex = 1;
            this.LPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::ShopModule.Properties.Resources.BoniVentasLogo;
            this.pbLogo.Location = new System.Drawing.Point(25, 75);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(300, 300);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnAccess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.LPanel);
            this.Controls.Add(this.RPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(700, 450);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.RPanel.ResumeLayout(false);
            this.RPanel.PerformLayout();
            this.WindowPanel.ResumeLayout(false);
            this.LPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RPanel;
        private System.Windows.Forms.Button btnAccess;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel LPanel;
        private System.Windows.Forms.Label lblPswd;
        private System.Windows.Forms.Label lblUsername;
        private CustomControls.CustomTextBox txtPswd;
        private CustomControls.CustomTextBox txtUsername;
        private System.Windows.Forms.Panel WindowPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.LinkLabel lnkDataRecovery;
    }
}

