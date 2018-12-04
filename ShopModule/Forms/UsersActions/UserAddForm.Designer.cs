namespace ShopModule.Forms.UsersActions
{
    partial class UserAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new ShopModule.CustomControls.BorderPanel();
            this.txtMail = new ShopModule.CustomControls.FieldBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnCancel = new ShopModule.CustomControls.FlatButton();
            this.btnAccept = new ShopModule.CustomControls.FlatButton();
            this.txtConfirm = new ShopModule.CustomControls.FieldBox();
            this.txtPswd = new ShopModule.CustomControls.FieldBox();
            this.cbUserType = new ShopModule.CustomControls.CustomComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblPswd = new System.Windows.Forms.Label();
            this.txtUser = new ShopModule.CustomControls.CustomTextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.dpBirth = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new ShopModule.CustomControls.CustomTextBox();
            this.txtFirstName = new ShopModule.CustomControls.CustomTextBox();
            this.pbImageUser = new ShopModule.CustomControls.RoundImage();
            this.lblProfileBirthDate = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageUser)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowName
            // 
            this.WindowName.Size = new System.Drawing.Size(700, 35);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Location = new System.Drawing.Point(630, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(665, 0);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtMail);
            this.pnlMain.Controls.Add(this.lblMail);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnAccept);
            this.pnlMain.Controls.Add(this.txtConfirm);
            this.pnlMain.Controls.Add(this.txtPswd);
            this.pnlMain.Controls.Add(this.cbUserType);
            this.pnlMain.Controls.Add(this.lblType);
            this.pnlMain.Controls.Add(this.lblConfirm);
            this.pnlMain.Controls.Add(this.lblPswd);
            this.pnlMain.Controls.Add(this.txtUser);
            this.pnlMain.Controls.Add(this.lblUsername);
            this.pnlMain.Controls.Add(this.dpBirth);
            this.pnlMain.Controls.Add(this.txtLastName);
            this.pnlMain.Controls.Add(this.txtFirstName);
            this.pnlMain.Controls.Add(this.pbImageUser);
            this.pnlMain.Controls.Add(this.lblProfileBirthDate);
            this.pnlMain.Controls.Add(this.lblLastName);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Location = new System.Drawing.Point(34, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(632, 270);
            this.pnlMain.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Location = new System.Drawing.Point(303, 77);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '*';
            this.txtMail.Size = new System.Drawing.Size(301, 20);
            this.txtMail.TabIndex = 25;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(156, 76);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(141, 21);
            this.lblMail.TabIndex = 24;
            this.lblMail.Text = "Correo Electronico:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(504, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(382, 226);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 30);
            this.btnAccept.TabIndex = 22;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtConfirm
            // 
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Location = new System.Drawing.Point(308, 184);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(296, 20);
            this.txtConfirm.TabIndex = 21;
            // 
            // txtPswd
            // 
            this.txtPswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPswd.Location = new System.Drawing.Point(308, 149);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.PasswordChar = '*';
            this.txtPswd.Size = new System.Drawing.Size(296, 20);
            this.txtPswd.TabIndex = 20;
            // 
            // cbUserType
            // 
            this.cbUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Location = new System.Drawing.Point(511, 104);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(93, 29);
            this.cbUserType.TabIndex = 19;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(388, 112);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(122, 21);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "Tipo de Usuario:";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(156, 184);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(146, 21);
            this.lblConfirm.TabIndex = 16;
            this.lblConfirm.Text = "Repetir Contraseña:";
            // 
            // lblPswd
            // 
            this.lblPswd.AutoSize = true;
            this.lblPswd.Location = new System.Drawing.Point(156, 149);
            this.lblPswd.Name = "lblPswd";
            this.lblPswd.Size = new System.Drawing.Size(92, 21);
            this.lblPswd.TabIndex = 14;
            this.lblPswd.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(229, 113);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(153, 20);
            this.txtUser.TabIndex = 13;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(156, 112);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(67, 21);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Usuario:";
            // 
            // dpBirth
            // 
            this.dpBirth.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dpBirth.Location = new System.Drawing.Point(366, 40);
            this.dpBirth.Name = "dpBirth";
            this.dpBirth.Size = new System.Drawing.Size(199, 29);
            this.dpBirth.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Location = new System.Drawing.Point(459, 9);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Location = new System.Drawing.Point(250, 9);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(110, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // pbImageUser
            // 
            this.pbImageUser.BackColor = System.Drawing.Color.DarkGray;
            this.pbImageUser.Location = new System.Drawing.Point(16, 17);
            this.pbImageUser.Name = "pbImageUser";
            this.pbImageUser.Size = new System.Drawing.Size(100, 100);
            this.pbImageUser.TabIndex = 8;
            this.pbImageUser.TabStop = false;
            // 
            // lblProfileBirthDate
            // 
            this.lblProfileBirthDate.AutoSize = true;
            this.lblProfileBirthDate.Location = new System.Drawing.Point(202, 46);
            this.lblProfileBirthDate.Name = "lblProfileBirthDate";
            this.lblProfileBirthDate.Size = new System.Drawing.Size(158, 21);
            this.lblProfileBirthDate.TabIndex = 7;
            this.lblProfileBirthDate.Text = "Fecha de Nacimiento:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(366, 8);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(87, 21);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Apellido(s):";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(156, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 21);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nombre(s):";
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.pnlMain);
            this.Name = "UserAddForm";
            this.Text = "UserAddForm";
            this.Controls.SetChildIndex(this.pnlMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.BorderPanel pnlMain;
        private CustomControls.FieldBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private CustomControls.FlatButton btnCancel;
        private CustomControls.FlatButton btnAccept;
        private CustomControls.FieldBox txtConfirm;
        private CustomControls.FieldBox txtPswd;
        private CustomControls.CustomComboBox cbUserType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblPswd;
        private CustomControls.CustomTextBox txtUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DateTimePicker dpBirth;
        private CustomControls.CustomTextBox txtLastName;
        private CustomControls.CustomTextBox txtFirstName;
        private CustomControls.RoundImage pbImageUser;
        private System.Windows.Forms.Label lblProfileBirthDate;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
    }
}