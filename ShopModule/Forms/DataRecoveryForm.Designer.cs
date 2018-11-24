namespace ShopModule.Forms
{
    partial class DataRecoveryForm
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
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new ShopModule.CustomControls.CustomTextBox();
            this.btnSender = new ShopModule.CustomControls.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 67);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(141, 21);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "Correo Electronico:";
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Location = new System.Drawing.Point(159, 67);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(179, 21);
            this.txtMail.TabIndex = 2;
            // 
            // btnSender
            // 
            this.btnSender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSender.FlatAppearance.BorderSize = 0;
            this.btnSender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSender.ForeColor = System.Drawing.Color.White;
            this.btnSender.Location = new System.Drawing.Point(100, 150);
            this.btnSender.Name = "btnSender";
            this.btnSender.Size = new System.Drawing.Size(150, 30);
            this.btnSender.TabIndex = 3;
            this.btnSender.Text = "Enviar solicitud";
            this.btnSender.UseVisualStyleBackColor = true;
            this.btnSender.Click += new System.EventHandler(this.btnSender_Click);
            // 
            // DataRecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.btnSender);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Name = "DataRecoveryForm";
            this.Text = "DataRecoveryForm";
            this.Controls.SetChildIndex(this.lblMail, 0);
            this.Controls.SetChildIndex(this.txtMail, 0);
            this.Controls.SetChildIndex(this.btnSender, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMail;
        private CustomControls.CustomTextBox txtMail;
        private CustomControls.FlatButton btnSender;
    }
}