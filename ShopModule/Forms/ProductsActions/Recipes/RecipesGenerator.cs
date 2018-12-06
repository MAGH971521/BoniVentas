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

namespace ShopModule.Forms.ProductsActions.Recipes
{
    public partial class RecipesGenerator : TemplateForm
    {
        private Product product;
        private Recipe recipe = new Recipe();
        public RecipesGenerator(Product product, bool IsMod = false)
        {
            this.product = product;
            InitializeComponent();
            dgProductsRecipe.ReadOnly = true;
            cbProductos.Items.Add("Productos");
            ProductController productController = new ProductController();
            RecipeController recipeController = new RecipeController();
            dgProductsRecipe.DataSource = recipeController.Select(Query.EQ("Name", product.Name));


            foreach (Product item in productController.Select(Query.All()))
            {
                cbProductos.Items.Add(item.Name);
            }

            if(IsMod)
            {
                foreach (Recipe item in recipeController.Select(Query.EQ("Product", this.product.Name)))
                {
                    dgProductsRecipe.Rows.Add(item.Ingredient, txtUnits.Text);
                }
            }
        }

        private void ClearFields()
        {
            cbProductos.SelectedIndex = 0;
            txtUnits.Clear();
            dgProductsRecipe.DataSource = null;
            dgProductsRecipe.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbProductos.SelectedIndex = 0;
            txtUnits.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();
            productController.Add(product);
            ClearFields();
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbProductos.SelectedIndex == 0) return;
            RecipeController controller = new RecipeController();
            ProductController productController = new ProductController();
            recipe = new Recipe()
            {
                Product = product.Name,
                Ingredient = productController.Select(Query.EQ("Name", cbProductos.SelectedText))[0].Name,
                Units = Convert.ToInt32(txtUnits.Text)
            };
            controller.Add(recipe);

            dgProductsRecipe.DataSource = controller.Select(Query.EQ("Name", product.Name));
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();
            RecipeController recipeController = new RecipeController();

            string[] productlist = new string[] { };


            productController.Add(product);
            ClearFields();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            recipe = new Recipe()
            {
                Product = product.Name,
                Ingredient = dgProductsRecipe.SelectedRows[0].Cells["Ingredient"].Value.ToString(),
                Units = Convert.ToInt32(dgProductsRecipe.SelectedRows[0].Cells["Units"].Value.ToString())
            };

            if (MessageBox.Show("¿Esta seguro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RecipeController controller = new RecipeController();
                controller.Delete(recipe);
            }
        }
    }
}
