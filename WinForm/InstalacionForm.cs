using Microsoft.IdentityModel.Tokens;
using Negocio;
using System;
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
    public partial class InstalacionForm : Form
    {
        Negocio.Instalacion negocio_instalacion = new Negocio.Instalacion();
        private Entidades.Instalacion? instalacion_a_editar = null;

        public InstalacionForm()
        {

            InitializeComponent();
            this.lblTitulo.Text = "Agregar Instalacion";
        }

        public InstalacionForm(Entidades.Instalacion instalacion_a_editar)
        {

            InitializeComponent();
            this.instalacion_a_editar = instalacion_a_editar;
            this.Text = "Editar Actividad";
            this.txtCupo.Text = instalacion_a_editar.Cupo.ToString();
            this.txtDesc.Text = instalacion_a_editar.Descripcion;
            this.txtTitulo.Text = instalacion_a_editar.Titulo;
            this.lblTitulo.Text = "Modificar Instalacion";
            this.txtPrecio.Text = (instalacion_a_editar.UltimoPrecio).ToString();
            
            this.instalacion_a_editar.Id = instalacion_a_editar.Id;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string desc = txtDesc.Text;
            int cupo = 0 ;
            decimal precio = 0;
            string mensajeError = "";

            if (titulo.IsNullOrEmpty())
            {
                mensajeError += "El tituno no puede estar vacío \n";
            }


            try
            {
                cupo = int.Parse(txtCupo.Text);
            }
            catch (FormatException) { mensajeError += "El cupo debe ser un entero  \n "; };
            try
            {
                precio = Convert.ToDecimal(txtPrecio.Text);
            }
            catch (FormatException) { mensajeError += "El precio tiene formato incorrecto \n"; };

            if( precio <= 0 ) {
                mensajeError += "El precio debe ser mayor a 0 \n";
            }
            if (cupo <= 0)
            {
                mensajeError += "El cupo debe ser mayor a 0 \n";
            }

            if (!mensajeError.IsNullOrEmpty())
            {
                MessageBox.Show(mensajeError, "Error en el formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.instalacion_a_editar == null)
            {
                Entidades.Instalacion instalacion = new Entidades.Instalacion()
                {
                    Titulo = titulo,
                    Cupo = cupo,
                    Descripcion = desc,
                    UltimoPrecio = precio
                };

                try
                {
                    negocio_instalacion.agregar_instalacion(instalacion);
                    this.DialogResult = DialogResult.OK;
                }
                catch (TituloInstalacionRepetidoException)
                {
                    MessageBox.Show("El Titulo se encuentra repetido", "Problema de titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("El Cupo o el Precio debe ser mayor a 0", "Problema de Cupo/Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {

               
                instalacion_a_editar.Titulo = titulo;
                instalacion_a_editar.Cupo = cupo;
                instalacion_a_editar.Descripcion = desc;
                instalacion_a_editar.UltimoPrecio = precio;

                try
                {
                    negocio_instalacion.modificar_Instalacion(instalacion_a_editar);
                }
                catch (ArgumentOutOfRangeException)
                {

                    MessageBox.Show("El Cupo o el Precio debe ser mayor a 0", "Problema de Cupo/Precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (TituloInstalacionRepetidoException)
                {
                    MessageBox.Show("El Titulo se encuentra repetido", "Problema de titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            this.DialogResult = DialogResult.OK;
        }

        private void bntMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))) { e.Handled = true; }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == ','))) { e.Handled = true; }

        }

        
    }
}
