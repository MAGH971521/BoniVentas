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

namespace ShopModule.Forms.ProductsActions.Provider
{
    public partial class ProviderAddFrom : TemplateForm
    {
        public ProviderAddFrom()
        {
            this.WindowName.Text = "Proveedor - Agregrar";
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtField.Text = "";
            this.Hide();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!(txtField.Text == ""))
            {
                ProviderController controller = new ProviderController();
                var item = controller.Count(Query.All()) + 1;

                Provider1 cat = new Provider1()
                {
                    Id = item,
                    Description = txtField.Text
                };

                controller.Add(cat);
            }
            else
            {
                txtField.Controls[0].BackColor = Color.FromArgb(192, 57, 43);
                txtField.Focus();
            }
        }
    }
}
