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
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProfileTitle = new ShopModule.CustomControls.BBLabel();
            this.pbUserImage2 = new System.Windows.Forms.PictureBox();
            this.lblCommonData = new ShopModule.CustomControls.BBLabel();
            this.lblProfileBirthDate = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.lblProfileBirthDate);
            this.pnl.Controls.Add(this.lblLastName);
            this.pnl.Controls.Add(this.lblName);
            this.pnl.Location = new System.Drawing.Point(230, 125);
            this.pnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(350, 120);
            this.pnl.TabIndex = 5;
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
            // pbUserImage2
            // 
            this.pbUserImage2.BackColor = System.Drawing.Color.Black;
            this.pbUserImage2.Location = new System.Drawing.Point(35, 90);
            this.pbUserImage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbUserImage2.Name = "pbUserImage2";
            this.pbUserImage2.Size = new System.Drawing.Size(150, 150);
            this.pbUserImage2.TabIndex = 4;
            this.pbUserImage2.TabStop = false;
            // 
            // lblCommonData
            // 
            this.lblCommonData.Location = new System.Drawing.Point(230, 100);
            this.lblCommonData.Name = "lblCommonData";
            this.lblCommonData.Size = new System.Drawing.Size(175, 25);
            this.lblCommonData.TabIndex = 6;
            this.lblCommonData.Text = "Datos Basicos:";
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
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.BorderPanel pnl;
        private System.Windows.Forms.PictureBox pbUserImage2;
        private CustomControls.BBLabel lblProfileTitle;
        private CustomControls.BBLabel lblCommonData;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProfileBirthDate;
    }
}
