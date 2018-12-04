namespace ShopModule.Forms
{
    partial class MenuForm
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
            this.slideMenu = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAccess_Profile = new ShopModule.CustomControls.LButton();
            this.btnAccess_Usuarios = new ShopModule.CustomControls.LButton();
            this.btnAccess_Productos = new ShopModule.CustomControls.LButton();
            this.btnAccess_Ventas = new ShopModule.CustomControls.LButton();
            this.btnAccess_Compras = new ShopModule.CustomControls.LButton();
            this.btnAccess_Reporte = new ShopModule.CustomControls.LButton();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.slideMenu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowName
            // 
            this.WindowName.Size = new System.Drawing.Size(960, 35);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Location = new System.Drawing.Point(890, 0);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Location = new System.Drawing.Point(925, 0);
            // 
            // slideMenu
            // 
            this.slideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.slideMenu.Controls.Add(this.pnlMenu);
            this.slideMenu.Controls.Add(this.pnlImage);
            this.slideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.slideMenu.Location = new System.Drawing.Point(0, 35);
            this.slideMenu.Name = "slideMenu";
            this.slideMenu.Size = new System.Drawing.Size(250, 590);
            this.slideMenu.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnAccess_Profile);
            this.pnlMenu.Controls.Add(this.btnAccess_Usuarios);
            this.pnlMenu.Controls.Add(this.btnAccess_Productos);
            this.pnlMenu.Controls.Add(this.btnAccess_Ventas);
            this.pnlMenu.Controls.Add(this.btnAccess_Compras);
            this.pnlMenu.Controls.Add(this.btnAccess_Reporte);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 189);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(250, 401);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnAccess_Profile
            // 
            this.btnAccess_Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccess_Profile.FlatAppearance.BorderSize = 0;
            this.btnAccess_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccess_Profile.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAccess_Profile.ForeColor = System.Drawing.Color.White;
            this.btnAccess_Profile.Location = new System.Drawing.Point(0, 225);
            this.btnAccess_Profile.Name = "btnAccess_Profile";
            this.btnAccess_Profile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccess_Profile.Size = new System.Drawing.Size(250, 45);
            this.btnAccess_Profile.TabIndex = 5;
            this.btnAccess_Profile.Text = "Perfil de Usuario";
            this.btnAccess_Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccess_Profile.UseVisualStyleBackColor = true;
            this.btnAccess_Profile.Click += new System.EventHandler(this.btnAccess_Profile_Click);
            // 
            // btnAccess_Usuarios
            // 
            this.btnAccess_Usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccess_Usuarios.FlatAppearance.BorderSize = 0;
            this.btnAccess_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccess_Usuarios.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAccess_Usuarios.ForeColor = System.Drawing.Color.White;
            this.btnAccess_Usuarios.Location = new System.Drawing.Point(0, 180);
            this.btnAccess_Usuarios.Name = "btnAccess_Usuarios";
            this.btnAccess_Usuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccess_Usuarios.Size = new System.Drawing.Size(250, 45);
            this.btnAccess_Usuarios.TabIndex = 4;
            this.btnAccess_Usuarios.Text = "Usuarios";
            this.btnAccess_Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccess_Usuarios.UseVisualStyleBackColor = true;
            this.btnAccess_Usuarios.Click += new System.EventHandler(this.btnAccess_Usuarios_Click);
            // 
            // btnAccess_Productos
            // 
            this.btnAccess_Productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccess_Productos.FlatAppearance.BorderSize = 0;
            this.btnAccess_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccess_Productos.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAccess_Productos.ForeColor = System.Drawing.Color.White;
            this.btnAccess_Productos.Location = new System.Drawing.Point(0, 135);
            this.btnAccess_Productos.Name = "btnAccess_Productos";
            this.btnAccess_Productos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccess_Productos.Size = new System.Drawing.Size(250, 45);
            this.btnAccess_Productos.TabIndex = 3;
            this.btnAccess_Productos.Text = "Productos";
            this.btnAccess_Productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccess_Productos.UseVisualStyleBackColor = true;
            // 
            // btnAccess_Ventas
            // 
            this.btnAccess_Ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccess_Ventas.FlatAppearance.BorderSize = 0;
            this.btnAccess_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccess_Ventas.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAccess_Ventas.ForeColor = System.Drawing.Color.White;
            this.btnAccess_Ventas.Location = new System.Drawing.Point(0, 90);
            this.btnAccess_Ventas.Name = "btnAccess_Ventas";
            this.btnAccess_Ventas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccess_Ventas.Size = new System.Drawing.Size(250, 45);
            this.btnAccess_Ventas.TabIndex = 2;
            this.btnAccess_Ventas.Text = "Ventas";
            this.btnAccess_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccess_Ventas.UseVisualStyleBackColor = true;
            // 
            // btnAccess_Compras
            // 
            this.btnAccess_Compras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccess_Compras.FlatAppearance.BorderSize = 0;
            this.btnAccess_Compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccess_Compras.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAccess_Compras.ForeColor = System.Drawing.Color.White;
            this.btnAccess_Compras.Location = new System.Drawing.Point(0, 45);
            this.btnAccess_Compras.Name = "btnAccess_Compras";
            this.btnAccess_Compras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccess_Compras.Size = new System.Drawing.Size(250, 45);
            this.btnAccess_Compras.TabIndex = 0;
            this.btnAccess_Compras.Text = "Compras";
            this.btnAccess_Compras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccess_Compras.UseVisualStyleBackColor = true;
            // 
            // btnAccess_Reporte
            // 
            this.btnAccess_Reporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccess_Reporte.FlatAppearance.BorderSize = 0;
            this.btnAccess_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccess_Reporte.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnAccess_Reporte.ForeColor = System.Drawing.Color.White;
            this.btnAccess_Reporte.Location = new System.Drawing.Point(0, 0);
            this.btnAccess_Reporte.Name = "btnAccess_Reporte";
            this.btnAccess_Reporte.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAccess_Reporte.Size = new System.Drawing.Size(250, 45);
            this.btnAccess_Reporte.TabIndex = 1;
            this.btnAccess_Reporte.Text = "Reporte General";
            this.btnAccess_Reporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccess_Reporte.UseVisualStyleBackColor = true;
            // 
            // pnlImage
            // 
            this.pnlImage.Controls.Add(this.pbUserImage);
            this.pnlImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImage.Location = new System.Drawing.Point(0, 0);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(250, 189);
            this.pnlImage.TabIndex = 0;
            // 
            // pbUserImage
            // 
            this.pbUserImage.BackColor = System.Drawing.Color.Transparent;
            this.pbUserImage.Image = global::ShopModule.Properties.Resources.BoniVentasLogo;
            this.pbUserImage.Location = new System.Drawing.Point(45, 15);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(160, 160);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserImage.TabIndex = 0;
            this.pbUserImage.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(250, 35);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlMain.Size = new System.Drawing.Size(710, 590);
            this.pnlMain.TabIndex = 2;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 625);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.slideMenu);
            this.Name = "MenuForm";
            this.Controls.SetChildIndex(this.slideMenu, 0);
            this.Controls.SetChildIndex(this.pnlMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.slideMenu.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel slideMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.PictureBox pbUserImage;
        private CustomControls.LButton btnAccess_Compras;
        private CustomControls.LButton btnAccess_Reporte;
        private CustomControls.LButton btnAccess_Productos;
        private CustomControls.LButton btnAccess_Ventas;
        private CustomControls.LButton btnAccess_Usuarios;
        private System.Windows.Forms.Panel pnlMain;
        private CustomControls.LButton btnAccess_Profile;
    }
}