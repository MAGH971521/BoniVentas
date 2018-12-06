using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopModule.Classes.Controllers;
using LiteDB;
using ShopModule.Forms.ProductsActions;
using ShopModule.Classes.Models;

namespace ShopModule.Forms
{
    public partial class ProductsForm : UserControl
    {
        public ProductsForm()
        {
            ProductController controller = new ProductController();
            InitializeComponent();
            dgProducts.DataSource = controller.Select(Query.All());
            dgProducts.ReadOnly = true;

            CategoryController catController = new CategoryController();
            BrandController brandController = new BrandController();

            cbBrand.Items.Add("All");
            cbCategory.Items.Add("All");

            foreach (var item in brandController.Select(Query.All()))
            {
                cbBrand.Items.Add(item.Description);
            }
            foreach (var item in catController.Select(Query.All()))
            {
                cbCategory.Items.Add(item.Description);
            }

            RefreshData();
        }

        private void RefreshData()
        {
            CategoryController catController = new CategoryController();
            BrandController brandController = new BrandController();
            ProductController productController = new ProductController();

            cbBrand.Items.Clear();
            cbCategory.Items.Clear();
            foreach (var item in brandController.Select(Query.All()))
            {
                cbBrand.Items.Add(item.Description);
            }
            foreach (var item in catController.Select(Query.All()))
            {
                cbCategory.Items.Add(item.Description);
            }
            dgProducts.DataSource = productController.Select(Query.All());
        }

        private void HideColumns()
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ProductController controller = new ProductController();
            CategoryController catController = new CategoryController();
            BrandController brandController = new BrandController();
            
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtFirstPattern.Text = "";
            cbCategory.SelectedItem = 0;
            cbBrand.SelectedItem = 0;
            ProductController controller = new ProductController();
            dgProducts.DataSource = controller.Select(Query.All());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductFormAdd1 add = new ProductFormAdd1();
            ProductController controller = new ProductController();
            if (add.ShowDialog() == DialogResult.Yes)
            {
                dgProducts.DataSource = controller.Select(Query.All());
                RefreshData();
                return;
            }

            cbBrand.Items.Clear();
            cbCategory.Items.Clear();
            CategoryController catController = new CategoryController();
            BrandController brandController = new BrandController();
            cbBrand.Items.Add("All");
            cbCategory.Items.Add("All");
            RefreshData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgProducts.SelectedRows.Count > 0)
            {
                ProductController controller = new ProductController();


                var helper = dgProducts.SelectedRows[0].Cells;

                Product prod = new Product();
                prod.Id = Convert.ToInt32(helper["Id"].Value.ToString());
                prod.Name = helper["Name"].Value.ToString();

                if (MessageBox.Show("¿Esta seguro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    RecipeController delete = new RecipeController();
                    foreach (var item in delete.Select(Query.EQ("Name", prod.Name)))
                    {
                        delete.Delete(item);
                    }
                    controller.Delete(controller.Select(Query.EQ("Id", prod.Id))[0]);
                    dgProducts.DataSource = controller.Select(Query.All());
                }
                else
                {
                    prod = null;
                }
                dgProducts.DataSource = controller.Select(Query.All());
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if(dgProducts.SelectedRows.Count == 1)
            {
                var helper = dgProducts.SelectedRows[0].Cells;
                Unit unit;
                Enum.TryParse(helper["Unit"].ToString(), out unit);

                Product prod = new Product();
                prod.Id = Convert.ToInt32(helper["Id"].Value.ToString());
                prod.Name = helper["Name"].Value.ToString();
                prod.Category = helper["Category"].Value.ToString();
                prod.Unit = unit;
                prod.Brand = helper["Brand"].Value.ToString();
                prod.IsCompost = Convert.ToBoolean(helper["IsCompost"].Value);
                prod.Min = Convert.ToInt32(helper["Min"].Value);
                prod.Max = Convert.ToInt32(helper["Max"].Value);

                ProductModifyForm add = new ProductModifyForm(prod);
                ProductController controller = new ProductController();
                if (add.ShowDialog() == DialogResult.Yes)
                {
                    dgProducts.DataSource = controller.Select(Query.All());
                    RefreshData();
                    return;
                }

                cbBrand.Items.Clear();
                cbCategory.Items.Clear();
                CategoryController catController = new CategoryController();
                BrandController brandController = new BrandController();
                cbBrand.Items.Add("All");
                cbCategory.Items.Add("All");
                RefreshData();
            }
        }
    }
}
