﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.ReservasForms;

namespace WinForm
{
    public partial class MenuSocio : Form
    {
        public MenuSocio()
        {
            InitializeComponent();
        }

        private void MenuSocio_Load(object sender, EventArgs e)
        {
            this.picboxSocio.ImageLocation = DatosLogin.UsuarioLogueado.FotoAbsolutePath;
            this.lblNombre.Text = DatosLogin.UsuarioLogueado.Nombre + " " + DatosLogin.UsuarioLogueado.Apellido;
            this.lblDni.Text = "DNI: " + DatosLogin.UsuarioLogueado.Dni;
        }






        private void btnInstalaciones_Click(object sender, EventArgs e)
        {
            this.subPanelnstalaciones.Visible = !this.subPanelnstalaciones.Visible;
        }

        private void btnMisActividades_Click(object sender, EventArgs e)
        {
            this.subPanelActividades.Visible = !this.subPanelActividades.Visible;
        }

        private void btnManejoSocios_Click(object sender, EventArgs e)
        {
            Socios administrarSocios = new Socios();
            administrarSocios.ShowDialog();
        }

        private void btnMisCompras_Click(object sender, EventArgs e)
        {
            VerComprasSocio verComprasSocio = new VerComprasSocio();

            verComprasSocio.ShowDialog();
        }

        private void btnReservarInstalacion_Click(object sender, EventArgs e)
        {
            ReservarInstalacionForm reservarInstalacion = new ReservarInstalacionForm();
            reservarInstalacion.ShowDialog();
        }

        private void btnVerReservas_Click(object sender, EventArgs e)
        {
            ReservasUsuarioForm reservasUsuario = new ReservasUsuarioForm();
            reservasUsuario.ShowDialog();
        }

        private void btnReservarActividad_Click(object sender, EventArgs e)
        {
            InscripcionActividadSeleccionActividad reservarActividad = new InscripcionActividadSeleccionActividad();
            reservarActividad.ShowDialog();
        }

        private void btnVerReservasActividad_Click(object sender, EventArgs e)
        {
            VerInscripciones inscripcionesUsuario = new VerInscripciones();
            inscripcionesUsuario.ShowDialog();
        }

        private void btnGenerarCarnet_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea generar carnet digital para '" + DatosLogin.UsuarioLogueado.NombreApellido + "'", "Generar Carnet Digital", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                Reportes.GenerarCarnet(DatosLogin.UsuarioLogueado);
                MessageBox.Show("El carnet se ha generado con exito", "Carnet Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void tsbCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            DatosLogin.UsuarioLogueado = null;
            login.Show();
            this.Hide();
        }
    }
    
}
