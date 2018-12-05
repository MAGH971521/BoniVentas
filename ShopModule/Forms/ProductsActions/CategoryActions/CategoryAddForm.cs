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

namespace ShopModule.Forms.ProductsActions
{
    public partial class CategoryAddForm : TemplateForm
    {
        public CategoryAddForm()
        {
            this.WindowName.Text = "Categoria - Agregrar";
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtField.Text = "";
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(!(txtField.Text == ""))
            {
                CategoryController controller = new CategoryController();

                Category cat = new Category()
                {
                    Description = txtField.Text
                };

                controller.Add(cat);
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
