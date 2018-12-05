using LiteDB;
using ShopModule.Classes.Controllers;
using ShopModule.Classes.Models;
using ShopModule.Forms.ProductsActions.BrandActions;
using ShopModule.Forms.ProductsActions.CategoryActions;
using System;
using System.Windows.Forms;

namespace ShopModule.Forms.ProductsActions
{
    public partial class ProductFormAdd : TemplateForm
    {
        public ProductFormAdd()
        {
            InitializeComponent();
            this.WindowName.Text = "Productos - Agregar";


        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtMin.Text = "";
            txtMax.Text = "";
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryAddForm CAF = new CategoryAddForm();
            CAF.Show();
        }

        private void btnModifyCategory_Click(object sender, EventArgs e)
        {
            CategoryController controller = new CategoryController();
            Category item = controller.Select(Query.EQ("Description", cbCategory.SelectedText))[0];
            CategoryModifyForm CMF = new CategoryModifyForm(item);

            CMF.Show();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if(cbCategory.SelectedText != "All")
            {
                CategoryController controller = new CategoryController();
                if (MessageBox.Show("¿Esta seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    controller.Delete(controller.Select(Query.EQ("Description", cbCategory.SelectedText))[0]);
                }
                else
                {
                    controller = null;
                }
                cbCategory.Refresh();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Hide();
        }
    }
}
