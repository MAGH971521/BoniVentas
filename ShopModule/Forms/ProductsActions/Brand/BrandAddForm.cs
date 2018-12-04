﻿using LiteDB;
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

namespace ShopModule.Forms.ProductsActions
{
    public partial class BrandAddForm : TemplateForm
    {
        public BrandAddForm()
        {
            this.WindowName.Text = "Marca - Agregar";
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!(txtField.Text == ""))
            {
                BrandController controller = new BrandController();
                var item = controller.Count(Query.All()) + 1;

                Brand brand = new Brand()
                {
                    Id = item,
                    Description = txtField.Text
                };

                controller.Add(brand);
            }
            else
            {
                txtField.Controls[0].BackColor = Color.FromArgb(192, 57, 43);
                txtField.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtField.Text = "";
            this.Hide();
        }
    }
}