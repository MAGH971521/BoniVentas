namespace ShopModule.Forms
{
    partial class Products
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtName = new ShopModule.CustomControls.FieldBox();
            this.txtCode = new ShopModule.CustomControls.FieldBox();
            this.lblTitle = new ShopModule.CustomControls.BBLabel();
            this.cbMarca = new ShopModule.CustomControls.CustomComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new ShopModule.CustomControls.CustomComboBox();
            this.customComboBox1 = new ShopModule.CustomControls.CustomComboBox();
            this.lblProvider = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.GridColor = System.Drawing.Color.White;
            this.dgvProductos.Location = new System.Drawing.Point(300, 250);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(350, 350);
            this.dgvProductos.TabIndex = 2;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(15, 96);
            this.lblCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(63, 20);
            this.lblCod.TabIndex = 3;
            this.lblCod.Text = "Codigo:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(150, 96);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Nombre:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(15, 132);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(57, 20);
            this.lblBrand.TabIndex = 7;
            this.lblBrand.Text = "Marca:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(227, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCode.Location = new System.Drawing.Point(85, 96);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(58, 20);
            this.txtCode.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(650, 77);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Productos";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbMarca
            // 
            this.cbMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMarca.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(79, 125);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 29);
            this.cbMarca.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(528, 87);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(115, 29);
            this.cbCategoria.TabIndex = 10;
            // 
            // customComboBox1
            // 
            this.customComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.customComboBox1.FormattingEnabled = true;
            this.customComboBox1.Location = new System.Drawing.Point(299, 125);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Size = new System.Drawing.Size(344, 29);
            this.customComboBox1.TabIndex = 12;
            // 
            // lblProvider
            // 
            this.lblProvider.AutoSize = true;
            this.lblProvider.Location = new System.Drawing.Point(207, 132);
            this.lblProvider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(85, 20);
            this.lblProvider.TabIndex = 11;
            this.lblProvider.Text = "Proveedor:";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.customComboBox1);
            this.Controls.Add(this.lblProvider);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Products";
            this.Size = new System.Drawing.Size(650, 600);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.BBLabel lblTitle;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblCod;
        private CustomControls.FieldBox txtCode;
        private System.Windows.Forms.Label lblName;
        private CustomControls.FieldBox txtName;
        private System.Windows.Forms.Label lblBrand;
        private CustomControls.CustomComboBox cbMarca;
        private System.Windows.Forms.Label label1;
        private CustomControls.CustomComboBox cbCategoria;
        private CustomControls.CustomComboBox customComboBox1;
        private System.Windows.Forms.Label lblProvider;
    }
}
