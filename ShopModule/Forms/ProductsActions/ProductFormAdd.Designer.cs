namespace ShopModule.Forms.ProductsActions
{
    partial class ProductFormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductFormAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.borderPanel1 = new ShopModule.CustomControls.BorderPanel();
            this.txtMax = new ShopModule.CustomControls.FieldBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMin = new ShopModule.CustomControls.FieldBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDeleteCategory = new ShopModule.CustomControls.RoundButton();
            this.btnModifyCategory = new ShopModule.CustomControls.RoundButton();
            this.btnAddCategory = new ShopModule.CustomControls.RoundButton();
            this.cbCategory = new ShopModule.CustomControls.CustomComboBox();
            this.lblParam3 = new System.Windows.Forms.Label();
            this.txtName = new ShopModule.CustomControls.CustomTextBox();
            this.btnCancel = new ShopModule.CustomControls.FlatButton();
            this.btnAccept = new ShopModule.CustomControls.FlatButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.borderPanel1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // borderPanel1
            // 
            this.borderPanel1.Controls.Add(this.label2);
            this.borderPanel1.Controls.Add(this.txtMax);
            this.borderPanel1.Controls.Add(this.label7);
            this.borderPanel1.Controls.Add(this.txtMin);
            this.borderPanel1.Controls.Add(this.label6);
            this.borderPanel1.Controls.Add(this.btnDeleteCategory);
            this.borderPanel1.Controls.Add(this.btnModifyCategory);
            this.borderPanel1.Controls.Add(this.btnAddCategory);
            this.borderPanel1.Controls.Add(this.cbCategory);
            this.borderPanel1.Controls.Add(this.lblParam3);
            this.borderPanel1.Controls.Add(this.txtName);
            this.borderPanel1.Controls.Add(this.label1);
            this.borderPanel1.Location = new System.Drawing.Point(48, 58);
            this.borderPanel1.Name = "borderPanel1";
            this.borderPanel1.Size = new System.Drawing.Size(597, 161);
            this.borderPanel1.TabIndex = 9;
            // 
            // txtMax
            // 
            this.txtMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMax.Location = new System.Drawing.Point(424, 115);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(158, 20);
            this.txtMax.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Maximo en Inventario:";
            // 
            // txtMin
            // 
            this.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMin.Location = new System.Drawing.Point(424, 51);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(158, 20);
            this.txtMin.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Minimo en Inventario:";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(375, 58);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(25, 25);
            this.btnDeleteCategory.TabIndex = 31;
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnModifyCategory
            // 
            this.btnModifyCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnModifyCategory.FlatAppearance.BorderSize = 0;
            this.btnModifyCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnModifyCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyCategory.ForeColor = System.Drawing.Color.White;
            this.btnModifyCategory.Location = new System.Drawing.Point(344, 57);
            this.btnModifyCategory.Name = "btnModifyCategory";
            this.btnModifyCategory.Size = new System.Drawing.Size(25, 25);
            this.btnModifyCategory.TabIndex = 30;
            this.btnModifyCategory.UseVisualStyleBackColor = false;
            this.btnModifyCategory.Click += new System.EventHandler(this.btnModifyCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAddCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.BackgroundImage")));
            this.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(313, 58);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(25, 25);
            this.btnAddCategory.TabIndex = 29;
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(109, 54);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(198, 29);
            this.cbCategory.TabIndex = 25;
            // 
            // lblParam3
            // 
            this.lblParam3.AutoSize = true;
            this.lblParam3.Location = new System.Drawing.Point(23, 62);
            this.lblParam3.Name = "lblParam3";
            this.lblParam3.Size = new System.Drawing.Size(80, 21);
            this.lblParam3.TabIndex = 20;
            this.lblParam3.Text = "Categoria:";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(109, 23);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 20);
            this.txtName.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(539, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 25;
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
            this.btnAccept.Location = new System.Drawing.Point(417, 244);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 30);
            this.btnAccept.TabIndex = 24;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Es compuesto:";
            // 
            // ProductFormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 297);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.borderPanel1);
            this.Name = "ProductFormAdd";
            this.Text = "ProductFormAdd";
            this.Controls.SetChildIndex(this.borderPanel1, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.borderPanel1.ResumeLayout(false);
            this.borderPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.BorderPanel borderPanel1;
        private CustomControls.CustomTextBox txtName;
        private CustomControls.CustomComboBox cbCategory;
        private System.Windows.Forms.Label lblParam3;
        private CustomControls.RoundButton btnDeleteCategory;
        private CustomControls.RoundButton btnModifyCategory;
        private CustomControls.RoundButton btnAddCategory;
        private CustomControls.FieldBox txtMax;
        private CustomControls.FieldBox txtMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private CustomControls.FlatButton btnCancel;
        private CustomControls.FlatButton btnAccept;
        private System.Windows.Forms.Label label2;
    }
}