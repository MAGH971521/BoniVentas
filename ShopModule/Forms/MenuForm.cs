﻿using ShopModule.Classes.Models;
using ShopModule.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopModule.Forms
{
    public partial class MenuForm : TemplateForm
    {
        public MenuForm(string WindowName, Image Logo, User user)
        {
            this.WindowName.Text = WindowName;
            pbLogo.Image = Logo;
            InitializeComponent();

            if (user.Image != null) pbUserImage.Image = user.Image;
            else pbUserImage.Image = null;

            btnAccess_Compras.Controls[0].BackColor = Color.FromArgb(243, 156, 18);
            btnAccess_Ventas.Controls[0].BackColor = Color.FromArgb(22, 160, 133);
            btnAccess_Productos.Controls[0].BackColor = Color.FromArgb(142, 68, 173);
            btnAccess_Usuarios.Controls[0].BackColor = Color.FromArgb(192, 57, 43);
            LButtonHoverEffect(btnAccess_Compras);
            LButtonHoverEffect(btnAccess_Productos);
            LButtonHoverEffect(btnAccess_Reporte);
            LButtonHoverEffect(btnAccess_Ventas);
            LButtonHoverEffect(btnAccess_Usuarios);

            if (!(user.Type == UserType.Admon))
            {
                btnAccess_Usuarios.Visible = false;
            }
        }


        private void LButtonHoverEffect(object sender)
        {
            LButton button = sender as LButton;
            button.MouseEnter += (object obj, EventArgs e) =>
            {
                LButton btn = obj as LButton;
                btn.BackColor = btn.Controls[0].BackColor;
            };
            button.MouseLeave += (object obj, EventArgs e) =>
            {
                LButton btn = obj as LButton;
                btn.BackColor = Color.Transparent;
            };
        }


        public override void btnClose_Click(object sender, EventArgs e)
        {
            base.btnClose_Click(sender, e);
        }

        private void btnAccess_Usuarios_Click(object sender, EventArgs e)
        {
            LButton btn = sender as LButton;
            btn.BackColor = btn.FlatAppearance.MouseOverBackColor;
            if (this.pnlMain.Controls.Count > 0) this.pnlMain.Controls.Clear(); 
            this.pnlMain.Controls.Add(new UserForm()
            {
                Dock = DockStyle.Fill
            });
        }
    }
}
