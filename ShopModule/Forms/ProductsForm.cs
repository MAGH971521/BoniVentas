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
            dgProducts.ReadOnly = false;

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

            foreach (var item in brandController.Select(Query.All()))
            {
                cbBrand.Items.Add(item.Description);
            }
            foreach (var item in catController.Select(Query.All()))
            {
                cbCategory.Items.Add(item.Description);
            }
            for (int c = 0; c < dgProducts.Rows.Count; c += 1)
            {
                Product p = (Product)dgProducts.Rows[c].DataBoundItem;
                // dgProducts.Rows[c].Cells["Category"].Value = p.Category.Description.ToString();
            }
            dgProducts.DataSource = productController.Select(Query.All());
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

            foreach (var item in brandController.Select(Query.All()))
            {
                cbBrand.Items.Add(item.Description);
            }
            foreach (var item in catController.Select(Query.All()))
            {
                cbCategory.Items.Add(item.Description);
            }



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
