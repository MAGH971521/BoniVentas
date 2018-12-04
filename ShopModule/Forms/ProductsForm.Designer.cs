namespace ShopModule.Forms
{
    partial class ProductsForm
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
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.pnlSearchForm = new ShopModule.CustomControls.BorderPanel();
            this.cbCategory = new ShopModule.CustomControls.CustomComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProvider = new ShopModule.CustomControls.CustomComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBrand = new ShopModule.CustomControls.CustomComboBox();
            this.btnResetSearch = new ShopModule.CustomControls.FlatButton();
            this.txtFirstPattern = new ShopModule.CustomControls.FieldBox();
            this.lblParam3 = new System.Windows.Forms.Label();
            this.lblParam1 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new ShopModule.CustomControls.FlatButton();
            this.btnMod = new ShopModule.CustomControls.FlatButton();
            this.btnEliminar = new ShopModule.CustomControls.FlatButton();
            this.btnAdd = new ShopModule.CustomControls.FlatButton();
            this.lblTitle = new ShopModule.CustomControls.BBLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            this.pnlSearchForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProducts
            // 
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(26, 304);
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProducts.Size = new System.Drawing.Size(500, 273);
            this.dgProducts.TabIndex = 8;
            // 
            // pnlSearchForm
            // 
            this.pnlSearchForm.Controls.Add(this.cbCategory);
            this.pnlSearchForm.Controls.Add(this.label2);
            this.pnlSearchForm.Controls.Add(this.cbProvider);
            this.pnlSearchForm.Controls.Add(this.label1);
            this.pnlSearchForm.Controls.Add(this.cbBrand);
            this.pnlSearchForm.Controls.Add(this.btnResetSearch);
            this.pnlSearchForm.Controls.Add(this.txtFirstPattern);
            this.pnlSearchForm.Controls.Add(this.lblParam3);
            this.pnlSearchForm.Controls.Add(this.lblParam1);
            this.pnlSearchForm.Controls.Add(this.lblSearch);
            this.pnlSearchForm.Controls.Add(this.btnSearch);
            this.pnlSearchForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchForm.Location = new System.Drawing.Point(0, 70);
            this.pnlSearchForm.Name = "pnlSearchForm";
            this.pnlSearchForm.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.pnlSearchForm.Size = new System.Drawing.Size(700, 202);
            this.pnlSearchForm.TabIndex = 12;
            // 
            // cbCategory
            // 
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(323, 53);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(265, 29);
            this.cbCategory.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Marca:";
            // 
            // cbProvider
            // 
            this.cbProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProvider.FormattingEnabled = true;
            this.cbProvider.Location = new System.Drawing.Point(140, 133);
            this.cbProvider.Name = "cbProvider";
            this.cbProvider.Size = new System.Drawing.Size(284, 29);
            this.cbProvider.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Proveedor:";
            // 
            // cbBrand
            // 
            this.cbBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(140, 93);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(284, 29);
            this.cbBrand.TabIndex = 15;
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnResetSearch.FlatAppearance.BorderSize = 0;
            this.btnResetSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnResetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSearch.ForeColor = System.Drawing.Color.White;
            this.btnResetSearch.Location = new System.Drawing.Point(518, 93);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(100, 30);
            this.btnResetSearch.TabIndex = 14;
            this.btnResetSearch.Text = "Limpiar";
            this.btnResetSearch.UseVisualStyleBackColor = false;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // txtFirstPattern
            // 
            this.txtFirstPattern.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstPattern.Location = new System.Drawing.Point(140, 62);
            this.txtFirstPattern.Name = "txtFirstPattern";
            this.txtFirstPattern.Size = new System.Drawing.Size(71, 20);
            this.txtFirstPattern.TabIndex = 10;
            // 
            // lblParam3
            // 
            this.lblParam3.AutoSize = true;
            this.lblParam3.Location = new System.Drawing.Point(217, 61);
            this.lblParam3.Name = "lblParam3";
            this.lblParam3.Size = new System.Drawing.Size(80, 21);
            this.lblParam3.TabIndex = 9;
            this.lblParam3.Text = "Categoria:";
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.Location = new System.Drawing.Point(34, 61);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(100, 21);
            this.lblParam1.TabIndex = 7;
            this.lblParam1.Text = "Empieza con:";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(34, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(166, 21);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Patrones de busqueda:";
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
            this.btnSearch.Location = new System.Drawing.Point(518, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.ForeColor = System.Drawing.Color.White;
            this.btnMod.Location = new System.Drawing.Point(573, 366);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(100, 30);
            this.btnMod.TabIndex = 11;
            this.btnMod.Text = "Modificar";
            this.btnMod.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(573, 411);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(573, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(700, 70);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Productos";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlSearchForm);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgProducts);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductsForm";
            this.Size = new System.Drawing.Size(700, 590);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            this.pnlSearchForm.ResumeLayout(false);
            this.pnlSearchForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.BorderPanel pnlSearchForm;
        private CustomControls.CustomComboBox cbProvider;
        private System.Windows.Forms.Label label1;
        private CustomControls.CustomComboBox cbBrand;
        private CustomControls.FlatButton btnResetSearch;
        private CustomControls.FieldBox txtFirstPattern;
        private System.Windows.Forms.Label lblParam3;
        private System.Windows.Forms.Label lblParam1;
        private System.Windows.Forms.Label lblSearch;
        private CustomControls.FlatButton btnSearch;
        private CustomControls.FlatButton btnMod;
        private CustomControls.FlatButton btnEliminar;
        private CustomControls.FlatButton btnAdd;
        private System.Windows.Forms.DataGridView dgProducts;
        private CustomControls.BBLabel lblTitle;
        private CustomControls.CustomComboBox cbCategory;
        private System.Windows.Forms.Label label2;
    }
}
