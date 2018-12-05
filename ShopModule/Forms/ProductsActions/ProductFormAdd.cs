using LiteDB;
using ShopModule.Classes.Controllers;
using ShopModule.Classes.Models;
using ShopModule.Forms.ProductsActions.BrandActions;
using ShopModule.Forms.ProductsActions.CategoryActions;
using ShopModule.Forms.ProductsActions.Recipes;
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

            ReloadCategoryBox();
            ReloadBrandBox();
        }

        private void ClearFields()
        {
            txtName.Text = "";
            txtMin.Text = "";
            txtMax.Text = "";
            radNo.Checked = false;
            radYes.Checked = false;
        }

        private void ReloadCategoryBox()
        {
            CategoryController catController = new CategoryController();
            foreach (var item in catController.Select(Query.All()))
            {
                cbCategory.Items.Add(item.Description);
            }
        }

        private void ReloadBrandBox()
        {
            BrandController catController = new BrandController();
            foreach (var item in catController.Select(Query.All()))
            {
                cbBrand.Items.Add(item.Description);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryAddForm CAF = new CategoryAddForm();
            if (CAF.ShowDialog() == DialogResult.OK)
            {
                ReloadCategoryBox();
            }
        }

        private void btnModifyCategory_Click(object sender, EventArgs e)
        {
            CategoryController controller = new CategoryController();
            Category item = controller.Select(Query.EQ("Description", cbCategory.SelectedItem.ToString()))[0];
            CategoryModifyForm CMF = new CategoryModifyForm(item);

            if(CMF.ShowDialog() == DialogResult.OK)
            {
                ReloadCategoryBox();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if(cbCategory.SelectedValue.ToString() != "All")
            {
                CategoryController controller = new CategoryController();
                if (MessageBox.Show("¿Esta seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    controller.Delete(controller.Select(Query.EQ("Description", cbCategory.SelectedValue.ToString()))[0]);
                }
                else
                {
                    controller = null;
                }
                ReloadCategoryBox();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
            this.Hide();
        }

        private void radYes_CheckedChange(object sender, EventArgs e)
        {
            RadioButton rad = sender as RadioButton;
            if (rad.Checked == true) btnAccept.Text = "Receta";
            else if (rad.Checked == false) btnAccept.Text = "Aceptar";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            CategoryController categoryController = new CategoryController();
            BrandController brandController = new BrandController();
            ProductController productController = new ProductController();
            if (txtName.Text == "") return;
            prod.Name = txtName.Text;
            
            prod.Category = categoryController.Select(Query.EQ("Description", cbCategory.SelectedItem.ToString()))[0];
            prod.Brand = brandController.Select(Query.EQ("Description", cbBrand.SelectedItem.ToString()))[0];
            prod.Min = (txtMin.Text == "" ? 0 : Convert.ToInt32(txtMin.Text));
            prod.Max = (txtMax.Text == "" ? 1000 : Convert.ToInt32(txtMax.Text));
            prod.Stock = 0;
            prod.Cost = 0;
            prod.Price = 0;
            if (radYes.Checked)
            {
                RecipesGenerator recipe = new RecipesGenerator(prod);
                if (recipe.ShowDialog(this) == DialogResult.OK)
                {
                    ClearFields();
                    this.Hide();
                }
                return;
            }
            productController.Add(prod);
            ClearFields();
            this.Hide();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            BrandAddForm CAF = new BrandAddForm();
            if (CAF.ShowDialog() == DialogResult.OK)
            {
                ReloadBrandBox();
            }
        }

        private void btnModifyBrand_Click(object sender, EventArgs e)
        {
            BrandController controller = new BrandController();
            Brand item = controller.Select(Query.EQ("Description", cbCategory.SelectedItem.ToString()))[0];
            BrandModifyForm CMF = new BrandModifyForm(item);

            if (CMF.ShowDialog() == DialogResult.OK)
            {
                ReloadBrandBox();
            }
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            if (cbCategory.SelectedValue.ToString() != "All")
            {
                BrandController controller = new BrandController();
                if (MessageBox.Show("¿Esta seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    controller.Delete(controller.Select(Query.EQ("Description", cbCategory.SelectedValue.ToString()))[0]);
                }
                else
                {
                    controller = null;
                }
                ReloadBrandBox();
            }
        }
    }
}
