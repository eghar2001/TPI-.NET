using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinForm
{
    public partial class ActividadForm : Form
    {
        private readonly Negocio.Actividad negocio_actividad = new Negocio.Actividad();
        private Entidades.Actividad? actividad_a_modificar = null;
        public ActividadForm()
        {
            InitializeComponent();
            this.Text = "Agregar Actividad";
            this.lblTitulo.Text = "Agregar Actividad";
            this.lblErrorNombre.Text = null;
            this.lblErrorDescripcion.Text = null;
            this.lblErrorPrecio.Text = null;
        }
        public ActividadForm(Entidades.Actividad actividad_original)
        {
            InitializeComponent();
            this.Text = "Editar Actividad";
            this.lblTitulo.Text = "Editar Actividad";

            this.lblErrorNombre.Text = null;
            this.lblErrorDescripcion.Text = null;
            this.lblErrorPrecio.Text = null;

            this.txtNombre.Text = actividad_original.Nombre;
            this.txtDescripcion.Text = actividad_original.Descripcion;
            this.txtPrecio.Text = Convert.ToString(actividad_original.UltimoPrecio);

            this.actividad_a_modificar = actividad_original;
        }


        private bool PrecioValido()
        {
            if (txtPrecio.Text.Length == 0)
            {
                this.lblErrorPrecio.Text = "Debe ingresar un precio";
                return false;
            }
            if (!Validaciones.EsPrecio(txtPrecio.Text))
            {
                this.lblErrorPrecio.Text = "Ingrese un precio valido";
                return false;
            }
            else
            {
                this.lblErrorPrecio.Text = "";
                return true;
            }
        }
        private bool NombreValido()
        {

            if (txtNombre.Text.Length == 0)
            {
                this.lblErrorNombre.Text = "Debe ingresar un nombre";
                return false;
            }
            else if (!Validaciones.TieneLargoMaximo(txtNombre.Text, 150))
            {
                this.lblErrorNombre.Text = "Maximo 150 caracteres";
                return false;
            }

            else
            {
                this.lblErrorNombre.Text = "";
                return true;
            }
        }
        private bool DescripcionValida()
        {
            if (txtDescripcion.Text.Length > 0 &&
                !Validaciones.TieneLargoMaximo(txtDescripcion.Text, 400))
            {
                this.lblErrorDescripcion.Text = "Maximo 400 caracteres";
                return false;
            }
            else
            {
                this.lblErrorDescripcion.Text = "";
                return true;
            }
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            NombreValido();
        }
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            DescripcionValida();
        }


        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (PrecioValido() && NombreValido() && DescripcionValida())
            {
                bool agregar = this.actividad_a_modificar == null;
                if (agregar)
                {
                    Entidades.Actividad actividad = new Entidades.Actividad()
                    {
                        Nombre = txtNombre.Text,
                        Descripcion = txtDescripcion.Text,
                        UltimoPrecio = Decimal.Parse(txtPrecio.Text)
                    };
                    try
                    {
                        negocio_actividad.agregar_actividad(actividad);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (NombreActividadExistenteException)
                    {
                        MessageBox.Show("El nombre de la actividad ya existe", "Nombre repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error inesperado, por favor intente mas tarde", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Entidades.Actividad actividad = new Entidades.Actividad()
                    {
                        Id = actividad_a_modificar.Id,
                        Nombre = txtNombre.Text,
                        Descripcion = txtDescripcion.Text,
                        UltimoPrecio = Decimal.Parse(txtPrecio.Text)
                    };
                    try
                    {
                        negocio_actividad.modificar_actividad(actividad);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (NombreActividadExistenteException)
                    {
                        MessageBox.Show("El nombre de la actividad ya existe", "Nombre repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error inesperado, por favor intente mas tarde", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bntMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
