using LiteDB;
using ShopModule.Classes.Controllers;
using ShopModule.Classes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopModule.Forms.ProductsActions.CategoryActions
{
    public partial class CategoryModifyForm : TemplateForm
    {
        private Category cat;
        public CategoryModifyForm(Category cat)
        {
            this.WindowName.Text = "Categoria - Modificar";
            InitializeComponent();
            txtField.Text = this.cat.Description;
            this.cat = cat;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtField.Text = "";
            this.Hide();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!(txtField.Text == ""))
            {
                CategoryController controller = new CategoryController();

                Category vat = new Category()
                {
                    Id = cat.Id,
                    Description = txtField.Text
                };

                controller.Update(cat);
            }
            else
            {
                txtField.Controls[0].BackColor = Color.FromArgb(192, 57, 43);
                txtField.Focus();
            }
        }
    }
}
