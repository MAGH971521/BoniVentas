using LiteDB;
using ShopModule.Classes.Controllers;
using ShopModule.Classes.Models;
using ShopModule.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopModule.Forms.ProductsActions.BrandActions
{
    public partial class BrandModifyForm : TemplateForm
    {
        private Brand brand;
        public BrandModifyForm(Brand brand)
        {
            this.WindowName.Text = "Marca - Modificar";
            this.brand = brand;
            InitializeComponent();
            txtField.Text = this.brand.Description;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtField.Text = "";
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!(txtField.Text == ""))
            {
                BrandController controller = new BrandController();

                Brand brand = new Brand()
                {
                    Id = this.brand.Id,
                    Description = txtField.Text
                };

                controller.Update(brand);
                txtField.Text = "";
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                txtField.Controls[0].BackColor = Color.FromArgb(192, 57, 43);
                txtField.Focus();
            }
        }
    }
}
