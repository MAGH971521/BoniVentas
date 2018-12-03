namespace ShopModule.Forms
{
    partial class ProfileForm
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl = new ShopModule.CustomControls.BorderPanel();
            this.dpBirth = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new ShopModule.CustomControls.CustomTextBox();
            this.txtName = new ShopModule.CustomControls.CustomTextBox();
            this.lblProfileBirthDate = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProfileTitle = new ShopModule.CustomControls.BBLabel();
            this.lblCommonData = new ShopModule.CustomControls.BBLabel();
            this.borderPanel1 = new ShopModule.CustomControls.BorderPanel();
            this.txtConfirm = new ShopModule.CustomControls.CustomTextBox();
            this.txtPswd = new ShopModule.CustomControls.CustomTextBox();
            this.txtUser = new ShopModule.CustomControls.CustomTextBox();
            this.txtMail = new ShopModule.CustomControls.FieldBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bbLabel1 = new ShopModule.CustomControls.BBLabel();
            this.pbUserImage2 = new System.Windows.Forms.PictureBox();
            this.btnMod = new ShopModule.CustomControls.FlatButton();
            this.pnl.SuspendLayout();
            this.borderPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.dpBirth);
            this.pnl.Controls.Add(this.txtLastName);
            this.pnl.Controls.Add(this.txtName);
            this.pnl.Controls.Add(this.lblProfileBirthDate);
            this.pnl.Controls.Add(this.lblLastName);
            this.pnl.Controls.Add(this.lblName);
            this.pnl.Location = new System.Drawing.Point(230, 125);
            this.pnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(350, 120);
            this.pnl.TabIndex = 5;
            // 
            // dpBirth
            // 
            this.dpBirth.Enabled = false;
            this.dpBirth.Location = new System.Drawing.Point(164, 67);
            this.dpBirth.Name = "dpBirth";
            this.dpBirth.Size = new System.Drawing.Size(167, 29);
            this.dpBirth.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(110, 41);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(221, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(110, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(221, 20);
            this.txtName.TabIndex = 5;
            // 
            // lblProfileBirthDate
            // 
            this.lblProfileBirthDate.AutoSize = true;
            this.lblProfileBirthDate.Location = new System.Drawing.Point(0, 72);
            this.lblProfileBirthDate.Name = "lblProfileBirthDate";
            this.lblProfileBirthDate.Size = new System.Drawing.Size(158, 21);
            this.lblProfileBirthDate.TabIndex = 4;
            this.lblProfileBirthDate.Text = "Fecha de Nacimiento:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(0, 40);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(87, 21);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Apellido(s):";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(0, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 21);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre(s):";
            // 
            // lblProfileTitle
            // 
            this.lblProfileTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProfileTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblProfileTitle.Location = new System.Drawing.Point(0, 0);
            this.lblProfileTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileTitle.Name = "lblProfileTitle";
            this.lblProfileTitle.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.lblProfileTitle.Size = new System.Drawing.Size(700, 70);
            this.lblProfileTitle.TabIndex = 3;
            this.lblProfileTitle.Text = "Perfil de ";
            this.lblProfileTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCommonData
            // 
            this.lblCommonData.Location = new System.Drawing.Point(230, 100);
            this.lblCommonData.Name = "lblCommonData";
            this.lblCommonData.Size = new System.Drawing.Size(175, 25);
            this.lblCommonData.TabIndex = 6;
            this.lblCommonData.Text = "Datos Basicos:";
            // 
            // borderPanel1
            // 
            this.borderPanel1.Controls.Add(this.btnMod);
            this.borderPanel1.Controls.Add(this.txtConfirm);
            this.borderPanel1.Controls.Add(this.txtPswd);
            this.borderPanel1.Controls.Add(this.txtUser);
            this.borderPanel1.Controls.Add(this.txtMail);
            this.borderPanel1.Controls.Add(this.label4);
            this.borderPanel1.Controls.Add(this.label3);
            this.borderPanel1.Controls.Add(this.label2);
            this.borderPanel1.Controls.Add(this.label1);
            this.borderPanel1.Location = new System.Drawing.Point(35, 273);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(624, 187);
            this.borderPanel1.TabIndex = 7;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Enabled = false;
            this.txtConfirm.Location = new System.Drawing.Point(432, 64);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(173, 20);
            this.txtConfirm.TabIndex = 15;
            // 
            // txtPswd
            // 
            this.txtPswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPswd.Enabled = false;
            this.txtPswd.Location = new System.Drawing.Point(116, 63);
            this.txtPswd.Name = "txtPswd";
            this.txtPswd.PasswordChar = '*';
            this.txtPswd.Size = new System.Drawing.Size(166, 20);
            this.txtPswd.TabIndex = 14;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(91, 15);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(119, 20);
            this.txtUser.TabIndex = 13;
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(361, 14);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(244, 20);
            this.txtMail.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Repetir contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Correo Electronico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario:";
            // 
            // bbLabel1
            // 
            this.bbLabel1.AutoSize = true;
            this.bbLabel1.Location = new System.Drawing.Point(31, 249);
            this.bbLabel1.Name = "bbLabel1";
            this.bbLabel1.Size = new System.Drawing.Size(0, 21);
            this.bbLabel1.TabIndex = 8;
            // 
            // pbUserImage2
            // 
            this.pbUserImage2.BackColor = System.Drawing.Color.Transparent;
            this.pbUserImage2.Image = global::ShopModule.Properties.Resources.Users;
            this.pbUserImage2.Location = new System.Drawing.Point(82, 100);
            this.pbUserImage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbUserImage2.Name = "pbUserImage2";
            this.pbUserImage2.Size = new System.Drawing.Size(141, 145);
            this.pbUserImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUserImage2.TabIndex = 4;
            this.pbUserImage2.TabStop = false;
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.ForeColor = System.Drawing.Color.White;
            this.btnMod.Location = new System.Drawing.Point(505, 138);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(100, 30);
            this.btnMod.TabIndex = 16;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bbLabel1);
            this.Controls.Add(this.borderPanel1);
            this.Controls.Add(this.lblCommonData);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.pbUserImage2);
            this.Controls.Add(this.lblProfileTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfileForm";
            this.Size = new System.Drawing.Size(700, 590);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.borderPanel1.ResumeLayout(false);
            this.borderPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.BorderPanel pnl;
        private System.Windows.Forms.PictureBox pbUserImage2;
        private CustomControls.BBLabel lblProfileTitle;
        private CustomControls.BBLabel lblCommonData;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProfileBirthDate;
        private System.Windows.Forms.DateTimePicker dpBirth;
        private CustomControls.CustomTextBox txtLastName;
        private CustomControls.CustomTextBox txtName;
        private CustomControls.BorderPanel borderPanel1;
        private CustomControls.CustomTextBox txtConfirm;
        private CustomControls.CustomTextBox txtPswd;
        private CustomControls.CustomTextBox txtUser;
        private CustomControls.FieldBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.BBLabel bbLabel1;
        private CustomControls.FlatButton btnMod;
    }
}
