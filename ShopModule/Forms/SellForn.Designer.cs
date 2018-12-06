namespace ShopModule.Forms
{
    partial class SellForn
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
            this.pnlSearchForm = new ShopModule.CustomControls.BorderPanel();
            this.lblusuarioparamostrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new ShopModule.CustomControls.FlatButton();
            this.txtcantidad = new ShopModule.CustomControls.FieldBox();
            this.txtprecio = new ShopModule.CustomControls.FieldBox();
            this.txtproduct = new ShopModule.CustomControls.FieldBox();
            this.lblParam3 = new System.Windows.Forms.Label();
            this.lblParam1 = new System.Windows.Forms.Label();
            this.btnSearch = new ShopModule.CustomControls.FlatButton();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.bbLabel1 = new ShopModule.CustomControls.BBLabel();
            this.btnMod = new ShopModule.CustomControls.FlatButton();
            this.btnResetSearch = new ShopModule.CustomControls.FlatButton();
            this.btnEliminar = new ShopModule.CustomControls.FlatButton();
            this.pnlSearchForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchForm
            // 
            this.pnlSearchForm.Controls.Add(this.lblusuarioparamostrar);
            this.pnlSearchForm.Controls.Add(this.label1);
            this.pnlSearchForm.Controls.Add(this.btnAdd);
            this.pnlSearchForm.Controls.Add(this.txtcantidad);
            this.pnlSearchForm.Controls.Add(this.txtprecio);
            this.pnlSearchForm.Controls.Add(this.txtproduct);
            this.pnlSearchForm.Controls.Add(this.lblParam3);
            this.pnlSearchForm.Controls.Add(this.lblParam1);
            this.pnlSearchForm.Controls.Add(this.btnSearch);
            this.pnlSearchForm.Controls.Add(this.lblSearch);
            this.pnlSearchForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchForm.Location = new System.Drawing.Point(0, 70);
            this.pnlSearchForm.Name = "pnlSearchForm";
            this.pnlSearchForm.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.pnlSearchForm.Size = new System.Drawing.Size(700, 176);
            this.pnlSearchForm.TabIndex = 9;
            // 
            // lblusuarioparamostrar
            // 
            this.lblusuarioparamostrar.AutoSize = true;
            this.lblusuarioparamostrar.Location = new System.Drawing.Point(455, 136);
            this.lblusuarioparamostrar.Name = "lblusuarioparamostrar";
            this.lblusuarioparamostrar.Size = new System.Drawing.Size(131, 21);
            this.lblusuarioparamostrar.TabIndex = 17;
            this.lblusuarioparamostrar.Text = "Muestra de name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Usuario:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(552, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcantidad.Location = new System.Drawing.Point(116, 103);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(125, 20);
            this.txtcantidad.TabIndex = 15;
            // 
            // txtprecio
            // 
            this.txtprecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprecio.Location = new System.Drawing.Point(116, 66);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(125, 20);
            this.txtprecio.TabIndex = 14;
            // 
            // txtproduct
            // 
            this.txtproduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtproduct.Location = new System.Drawing.Point(116, 25);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(125, 20);
            this.txtproduct.TabIndex = 10;
            // 
            // lblParam3
            // 
            this.lblParam3.AutoSize = true;
            this.lblParam3.Location = new System.Drawing.Point(34, 102);
            this.lblParam3.Name = "lblParam3";
            this.lblParam3.Size = new System.Drawing.Size(75, 21);
            this.lblParam3.TabIndex = 9;
            this.lblParam3.Text = "Cantidad:";
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.Location = new System.Drawing.Point(34, 65);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(56, 21);
            this.lblParam1.TabIndex = 7;
            this.lblParam1.Text = "Precio:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(310, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Refrescar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(34, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(76, 21);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Producto:";
            // 
            // dgUsers
            // 
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Location = new System.Drawing.Point(26, 277);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsers.Size = new System.Drawing.Size(500, 300);
            this.dgUsers.TabIndex = 8;
            // 
            // bbLabel1
            // 
            this.bbLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bbLabel1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bbLabel1.Location = new System.Drawing.Point(0, 0);
            this.bbLabel1.Name = "bbLabel1";
            this.bbLabel1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.bbLabel1.Size = new System.Drawing.Size(700, 70);
            this.bbLabel1.TabIndex = 7;
            this.bbLabel1.Text = "Ventas";
            this.bbLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.ForeColor = System.Drawing.Color.White;
            this.btnMod.Location = new System.Drawing.Point(574, 438);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(100, 30);
            this.btnMod.TabIndex = 16;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = false;
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnResetSearch.FlatAppearance.BorderSize = 0;
            this.btnResetSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnResetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSearch.ForeColor = System.Drawing.Color.White;
            this.btnResetSearch.Location = new System.Drawing.Point(574, 366);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(100, 30);
            this.btnResetSearch.TabIndex = 17;
            this.btnResetSearch.Text = "Imprimir Ticket";
            this.btnResetSearch.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(574, 402);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // SellForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnResetSearch);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pnlSearchForm);
            this.Controls.Add(this.dgUsers);
            this.Controls.Add(this.bbLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SellForn";
            this.Size = new System.Drawing.Size(700, 590);
            this.pnlSearchForm.ResumeLayout(false);
            this.pnlSearchForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.BorderPanel pnlSearchForm;
        private System.Windows.Forms.Label lblusuarioparamostrar;
        private System.Windows.Forms.Label label1;
        private CustomControls.FlatButton btnAdd;
        private CustomControls.FieldBox txtcantidad;
        private CustomControls.FieldBox txtprecio;
        private CustomControls.FieldBox txtproduct;
        private System.Windows.Forms.Label lblParam3;
        private System.Windows.Forms.Label lblParam1;
        private CustomControls.FlatButton btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgUsers;
        private CustomControls.BBLabel bbLabel1;
        private CustomControls.FlatButton btnMod;
        private CustomControls.FlatButton btnResetSearch;
        private CustomControls.FlatButton btnEliminar;
    }
}
