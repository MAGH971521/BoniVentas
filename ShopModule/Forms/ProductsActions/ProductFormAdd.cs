using ShopModule.Forms.ProductsActions.Provider;
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
    public partial class ProductFormAdd : TemplateForm
    {
        public ProductFormAdd()
        {
            InitializeComponent();
            this.WindowName.Text = "Productos - Agregar";


        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CategoryAddForm CAF = new CategoryAddForm();
            CAF.Show();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            BrandAddForm BAF = new BrandAddForm();
            BAF.Show();
        }

        private void btnAddProvider_Click(object sender, EventArgs e)
        {
            ProviderAddFrom PAF = new ProviderAddFrom();
            PAF.Show();
        }
    }
}
