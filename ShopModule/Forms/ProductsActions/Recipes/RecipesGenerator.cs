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
        private RecipeDescription[] desc;
        public RecipesGenerator(Product product)
        {
            this.product = product;
            this.recipe.Product = product;
            InitializeComponent();
            cbProductos.Items.Add("Productos");
            ProductController productController = new ProductController();
            foreach(Product item in productController.Select(Query.All()))
            {
                cbProductos.Items.Add(item.Name);
            }
            dgProductsRecipe.DataSource = desc;
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
            ProductController productController = new ProductController();
            RecipeDescription aux = new RecipeDescription();
            if (cbProductos.SelectedIndex == 0) return;
            aux.Product = productController.Select(Query.EQ("Name", cbProductos.SelectedItem.ToString()))[0];
            if (txtUnits.Text == "") aux.Units = 0;
            else aux.Units = Convert.ToInt32(txtUnits.Text);
            if (desc == null) desc = new RecipeDescription[] { aux };
            else desc = desc.Concat(new RecipeDescription[] { aux }).ToArray();

            dgProductsRecipe.DataSource = desc;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            ProductController productController = new ProductController();
            RecipeController recipeController = new RecipeController();
            recipe.Description = desc;
            productController.Add(product);
            recipeController.Add(recipe);
            ClearFields();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
