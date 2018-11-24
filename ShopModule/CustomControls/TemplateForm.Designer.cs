namespace ShopModule
{
    partial class TemplateForm
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
            this.WindowBorder = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.WindowName = new System.Windows.Forms.Label();
            this.WindowBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowBorder
            // 
            this.WindowBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.WindowBorder.Controls.Add(this.pbLogo);
            this.WindowBorder.Controls.Add(this.btnMinimize);
            this.WindowBorder.Controls.Add(this.btnClose);
            this.WindowBorder.Controls.Add(this.WindowName);
            this.WindowBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.WindowBorder.Location = new System.Drawing.Point(0, 0);
            this.WindowBorder.Name = "WindowBorder";
            this.WindowBorder.Size = new System.Drawing.Size(950, 35);
            this.WindowBorder.TabIndex = 0;
            this.WindowBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuForm_MouseDown);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo.Image = global::ShopModule.Properties.Resources.BoniVentasLogo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(35, 35);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.Location = new System.Drawing.Point(880, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 3;
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
            this.btnClose.Location = new System.Drawing.Point(915, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // WindowName
            // 
            this.WindowName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.WindowName.ForeColor = System.Drawing.Color.White;
            this.WindowName.Location = new System.Drawing.Point(0, 0);
            this.WindowName.Name = "WindowName";
            this.WindowName.Size = new System.Drawing.Size(950, 35);
            this.WindowName.TabIndex = 0;
            this.WindowName.Text = "Window Text";
            this.WindowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WindowName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuForm_MouseDown);
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.WindowBorder);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.WindowBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WindowBorder;
        protected System.Windows.Forms.Label WindowName;
        protected System.Windows.Forms.Button btnMinimize;
        protected System.Windows.Forms.Button btnClose;
        protected System.Windows.Forms.PictureBox pbLogo;
    }
}