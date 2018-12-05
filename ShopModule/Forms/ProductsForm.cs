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

namespace ShopModule.Forms
{
    public partial class ProductsForm : UserControl
    {
        public ProductsForm()
        {
            ProductController controller = new ProductController();
            InitializeComponent();
            dgProducts.DataSource = controller.Select(Query.All());
            dgProducts.ReadOnly = false;

            CategoryController catController = new CategoryController();
            BrandController brandController = new BrandController();

            cbBrand.Items.Add("All");
            cbCategory.Items.Add("All");

            foreach (var item in brandController.Select(Query.All()))
            {
                cbBrand.Items.Add(item.Description);
            }
            foreach(var item in catController.Select(Query.All()))
            {
                cbCategory.Items.Add(item.Description);
            }
        }

        private void HideColumns()
        {
            dgProducts.Columns[0].Visible = false;
            dgProducts.Columns[5].Visible = false;
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
            ProductFormAdd add = new ProductFormAdd();
            add.Show();

            cbBrand.Items.Clear();
            cbCategory.Items.Clear();
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
        }
    }
}
