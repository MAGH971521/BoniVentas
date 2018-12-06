using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using ShopModule.Classes.Controllers;
using ShopModule.Classes.Models;

namespace ShopModule.Forms
{
    public partial class SellForn : UserControl
    {
        BuyController controller = new BuyController();
        public SellForn()
        {
            InitializeComponent();
            dgUsers.DataSource = controller.Select(Query.All());
            dgUsers.ReadOnly = true;
            dgUsers.Visible = true;
        }




        private void btnResetSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int cantidad = Convert.ToInt32(txtcantidad.Text);
            int precio = Convert.ToInt32(txtprecio.Text);
            BuyController controller = new BuyController();
            //Buy venta = new Buy()
            //{
            //     = txtproduct.Text,
            //    cantidad = cantidad,
            //    precio = precio
            //};

            //controller.Add(venta);


        }

        private void dgUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dgUsers.DataSource = controller.Select(Query.All());
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgUsers.SelectedRows.Count > 0)
            {

            }
        }
    }
}
