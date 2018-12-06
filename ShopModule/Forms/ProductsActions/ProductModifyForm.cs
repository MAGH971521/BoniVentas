using LiteDB;
using ShopModule.Classes.Controllers;
using ShopModule.Classes.Models;
using ShopModule.Forms.ProductsActions.BrandActions;
using ShopModule.Forms.ProductsActions.CategoryActions;
using ShopModule.Forms.ProductsActions.Recipes;
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
    public partial class ProductModifyForm : TemplateForm
    {
        private Product Product;
        public ProductModifyForm(Product product)
        {
            CategoryController categoryController = new CategoryController();
            BrandController brandController = new BrandController();
            InitializeComponent(); this.WindowName.Text = "Productos - Agregar";
            this.Product = product;
            cbUnit.DataSource = Enum.GetNames(typeof(Unit));
            ReloadCategoryBox();
            ReloadBrandBox();

            txtName.Text = Product.Name;
            txtMin.Text = Product.Min.ToString();
            txtMax.Text = Product.Max.ToString();
            cbCategory.SelectedItem = categoryController.Select(Query.EQ("Description", Product.Category))[0].Description;
            cbBrand.SelectedItem = brandController.Select(Query.EQ("Description", Product.Brand))[0].Description;
            if (Product.IsCompost) radYes.Checked = true;
            else radNo.Checked = true;
            cbUnit.SelectedText = Enum.GetName(typeof(Unit), Product.Unit);
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
            cbCategory.Items.Clear();
            CategoryController catController = new CategoryController();
            foreach (var item in catController.Select(Query.All()))
            {
                cbCategory.Items.Add(item.Description);
            }
        }

        private void ReloadBrandBox()
        {
            cbBrand.Items.Clear();
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

            if (CMF.ShowDialog() == DialogResult.OK)
            {
                ReloadCategoryBox();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if (cbCategory.SelectedItem.ToString() != "All")
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
            this.DialogResult = DialogResult.Cancel;
            ClearFields();
            this.Hide();
        }

        private void radYes_CheckedChange(object sender, EventArgs e)
        {
            RadioButton rad = sender as RadioButton;
            if (rad.Checked == true) btnAccept.Text = "Receta";
            else if (rad.Checked == false) btnAccept.Text = "Aceptar";
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            CategoryController categoryController = new CategoryController();
            BrandController brandController = new BrandController();
            ProductController productController = new ProductController();

            if (txtName.Text == "") return;
            Product.Name = txtName.Text;
            Product.Category = categoryController.Select(Query.EQ("Description", cbCategory.SelectedItem.ToString()))[0].Description;
            Product.Brand = brandController.Select(Query.EQ("Description", cbBrand.SelectedItem.ToString()))[0].Description;
            Product.Min = (txtMin.Text == "" ? 0 : Convert.ToInt32(txtMin.Text));
            Product.Max = (txtMax.Text == "" ? 1000 : Convert.ToInt32(txtMax.Text));
            Product.Stock = 0;
            Product.Cost = 0;
            Product.Price = 0;
            Product.IsCompost = radYes.Checked ? true : false;
            if (cbUnit.SelectedValue.ToString() == "") Product.Unit = Unit.Pieza;
            else
            {
                Unit unit;
                Enum.TryParse(cbUnit.SelectedValue.ToString(), out unit);
                Product.Unit = unit;
            }

            if (radYes.Checked)
            {
                RecipesGenerator recipe = new RecipesGenerator(Product, Product.IsCompost);
                if (recipe.ShowDialog(this) == DialogResult.OK)
                {
                    ClearFields();
                    this.Hide();
                }
                return;
            }
            if (radNo.Checked)
            {
                RecipeController recipeController = new RecipeController();
                foreach (var item in recipeController.Select(Query.EQ("Product",Product.Name)))
                {
                    recipeController.Delete(item);
                }
            }
            this.DialogResult = DialogResult.OK;
            productController.Update(Product);
            ClearFields();
            this.Hide();
        }
    }
}
