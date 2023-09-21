﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class MenuEmpleado : Form
    {
        public MenuEmpleado()
        {
            InitializeComponent();
        }

        private void MenuEmpleado_Load(object sender, EventArgs e)
        {
            this.lblNombre.Text = DatosLogin.UsuarioLogueado.Nombre + " " + DatosLogin.UsuarioLogueado.Apellido;
            this.lblDni.Text = "" + DatosLogin.UsuarioLogueado.Dni;
        }




        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.subPanelProductos.Visible = !this.subPanelProductos.Visible;
        }

        private void btnInstalaciones_Click(object sender, EventArgs e)
        {
            this.subPanelnstalaciones.Visible = !this.subPanelnstalaciones.Visible;
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            this.subPanelActividades.Visible = !this.subPanelActividades.Visible;
        }

        private void btnManejoSocios_Click(object sender, EventArgs e)
        {
            Socios administrarSocios = new Socios();
            administrarSocios.ShowDialog();
        }

        private void btnAdministrarActividades_Click(object sender, EventArgs e)
        {
            AdministrarActividadesForm administrarActividades = new AdministrarActividadesForm();
            administrarActividades.Show();
        }
    }
}