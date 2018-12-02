namespace ShopModule.Forms
{
    partial class UserForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlSearchForm = new ShopModule.CustomControls.BorderPanel();
            this.btnResetSearch = new ShopModule.CustomControls.FlatButton();
            this.chckUserType2 = new System.Windows.Forms.CheckBox();
            this.chckUserType = new System.Windows.Forms.CheckBox();
            this.txtLastPattern = new ShopModule.CustomControls.FieldBox();
            this.txtFirstPattern = new ShopModule.CustomControls.FieldBox();
            this.lblParam3 = new System.Windows.Forms.Label();
            this.lblParam2 = new System.Windows.Forms.Label();
            this.lblParam1 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new ShopModule.CustomControls.FlatButton();
            this.btnMod = new ShopModule.CustomControls.FlatButton();
            this.btnEliminar = new ShopModule.CustomControls.FlatButton();
            this.btnAdd = new ShopModule.CustomControls.FlatButton();
            this.bbLabel1 = new ShopModule.CustomControls.BBLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlSearchForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(500, 300);
            this.dataGridView1.TabIndex = 1;
            // 
            // pnlSearchForm
            // 
            this.pnlSearchForm.Controls.Add(this.btnResetSearch);
            this.pnlSearchForm.Controls.Add(this.chckUserType2);
            this.pnlSearchForm.Controls.Add(this.chckUserType);
            this.pnlSearchForm.Controls.Add(this.txtLastPattern);
            this.pnlSearchForm.Controls.Add(this.txtFirstPattern);
            this.pnlSearchForm.Controls.Add(this.lblParam3);
            this.pnlSearchForm.Controls.Add(this.lblParam2);
            this.pnlSearchForm.Controls.Add(this.lblParam1);
            this.pnlSearchForm.Controls.Add(this.lblSearch);
            this.pnlSearchForm.Controls.Add(this.btnSearch);
            this.pnlSearchForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchForm.Location = new System.Drawing.Point(0, 70);
            this.pnlSearchForm.Name = "pnlSearchForm";
            this.pnlSearchForm.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.pnlSearchForm.Size = new System.Drawing.Size(700, 150);
            this.pnlSearchForm.TabIndex = 6;
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnResetSearch.FlatAppearance.BorderSize = 0;
            this.btnResetSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnResetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSearch.ForeColor = System.Drawing.Color.White;
            this.btnResetSearch.Location = new System.Drawing.Point(452, 97);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(100, 30);
            this.btnResetSearch.TabIndex = 14;
            this.btnResetSearch.Text = "Limpiar";
            this.btnResetSearch.UseVisualStyleBackColor = false;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // chckUserType2
            // 
            this.chckUserType2.AutoSize = true;
            this.chckUserType2.Location = new System.Drawing.Point(529, 61);
            this.chckUserType2.Name = "chckUserType2";
            this.chckUserType2.Size = new System.Drawing.Size(129, 25);
            this.chckUserType2.TabIndex = 13;
            this.chckUserType2.Text = "Administrador";
            this.chckUserType2.UseVisualStyleBackColor = true;
            // 
            // chckUserType
            // 
            this.chckUserType.AutoSize = true;
            this.chckUserType.Location = new System.Drawing.Point(425, 61);
            this.chckUserType.Name = "chckUserType";
            this.chckUserType.Size = new System.Drawing.Size(98, 25);
            this.chckUserType.TabIndex = 12;
            this.chckUserType.Text = "Empleado";
            this.chckUserType.UseVisualStyleBackColor = true;
            // 
            // txtLastPattern
            // 
            this.txtLastPattern.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastPattern.Location = new System.Drawing.Point(139, 98);
            this.txtLastPattern.Name = "txtLastPattern";
            this.txtLastPattern.Size = new System.Drawing.Size(125, 20);
            this.txtLastPattern.TabIndex = 11;
            // 
            // txtFirstPattern
            // 
            this.txtFirstPattern.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstPattern.Location = new System.Drawing.Point(140, 66);
            this.txtFirstPattern.Name = "txtFirstPattern";
            this.txtFirstPattern.Size = new System.Drawing.Size(125, 20);
            this.txtFirstPattern.TabIndex = 10;
            // 
            // lblParam3
            // 
            this.lblParam3.AutoSize = true;
            this.lblParam3.Location = new System.Drawing.Point(290, 61);
            this.lblParam3.Name = "lblParam3";
            this.lblParam3.Size = new System.Drawing.Size(129, 21);
            this.lblParam3.TabIndex = 9;
            this.lblParam3.Text = "Tipos de Usuario:";
            // 
            // lblParam2
            // 
            this.lblParam2.AutoSize = true;
            this.lblParam2.Location = new System.Drawing.Point(33, 97);
            this.lblParam2.Name = "lblParam2";
            this.lblParam2.Size = new System.Drawing.Size(97, 21);
            this.lblParam2.TabIndex = 8;
            this.lblParam2.Text = "Termina con:";
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.Location = new System.Drawing.Point(34, 65);
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
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(558, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.ForeColor = System.Drawing.Color.White;
            this.btnMod.Location = new System.Drawing.Point(573, 412);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(100, 30);
            this.btnMod.TabIndex = 4;
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
            this.btnEliminar.Location = new System.Drawing.Point(573, 359);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 3;
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
            this.btnAdd.Location = new System.Drawing.Point(573, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // bbLabel1
            // 
            this.bbLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bbLabel1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bbLabel1.Location = new System.Drawing.Point(0, 0);
            this.bbLabel1.Name = "bbLabel1";
            this.bbLabel1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.bbLabel1.Size = new System.Drawing.Size(700, 70);
            this.bbLabel1.TabIndex = 0;
            this.bbLabel1.Text = "Usuarios";
            this.bbLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlSearchForm);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bbLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserForm";
            this.Size = new System.Drawing.Size(700, 590);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlSearchForm.ResumeLayout(false);
            this.pnlSearchForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.BBLabel bbLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.FlatButton btnAdd;
        private CustomControls.FlatButton btnEliminar;
        private CustomControls.FlatButton btnMod;
        private CustomControls.FlatButton btnSearch;
        private CustomControls.BorderPanel pnlSearchForm;
        private System.Windows.Forms.Label lblSearch;
        private CustomControls.FlatButton btnResetSearch;
        private System.Windows.Forms.CheckBox chckUserType2;
        private System.Windows.Forms.CheckBox chckUserType;
        private CustomControls.FieldBox txtLastPattern;
        private CustomControls.FieldBox txtFirstPattern;
        private System.Windows.Forms.Label lblParam3;
        private System.Windows.Forms.Label lblParam2;
        private System.Windows.Forms.Label lblParam1;
    }
}
