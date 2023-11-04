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
            string titulo = "Agregar Instalacion";
            this.lblTitulo.Text = titulo;
            this.Text = titulo;
        }

        public InstalacionForm(Entidades.Instalacion instalacion_a_editar)
        {
            InitializeComponent();
            this.instalacion_a_editar = instalacion_a_editar;
            string titulo = "Editar Instalacion";
            this.Text = titulo;
            this.txtCupo.Text = instalacion_a_editar.Cupo.ToString();
            this.txtDesc.Text = instalacion_a_editar.Descripcion;
            this.txtTitulo.Text = instalacion_a_editar.Titulo;
            this.lblTitulo.Text = titulo;
            this.txtPrecio.Text = (instalacion_a_editar.UltimoPrecio).ToString();
        }

        private void InstalacionForm_Load(object sender, EventArgs e)
        {
            this.lblErrorTitulo.Text = "";
            this.lblErrorPrecio.Text = "";
            this.lblErrorCupo.Text = "";
            this.lblErrorDescripcion.Text = "";

        }
        private bool FormValido()
        {
            bool resultado = true;
            resultado = TituloValido() && resultado;
            resultado = PrecioValido() && resultado;
            resultado = CupoValido() && resultado;
            resultado = DescripcionValida() && resultado;
            return resultado;

        }
        private bool TituloValido()
        {
            string titulo = this.txtTitulo.Text;

            if (titulo.Length == 0)
            {
                this.lblErrorTitulo.Text = "Debe ingresar un titulo";
                return false;
            }
            if (titulo.Length > 150)
            {
                this.lblErrorTitulo.Text = "Supero el maximo de 150 caracteres";
                return false;
            }
            this.lblErrorTitulo.Text = "";
            return true;
        }
        private bool PrecioValido()
        {
            string precio = this.txtPrecio.Text;

            if (precio.Length == 0)
            {
                this.lblErrorPrecio.Text = "Debe ingresar un precio";
                return false;
            }
            if (!Validaciones.EsPrecio(precio))
            {
                this.lblErrorPrecio.Text = "No se ingreso un precio";
                return false;
            }
            this.lblErrorPrecio.Text = "";
            return true;

        }
        private bool CupoValido()
        {
            string cupo = this.txtCupo.Text;

            if (cupo.Length == 0)
            {
                this.lblErrorCupo.Text = "Debe ingresar un cupo";
                return false;
            }
            if (!Validaciones.EsEntero(cupo))
            {
                this.lblErrorCupo.Text = "No ingreso un cupo entero";
                return false;
            }
            this.lblErrorCupo.Text = "";
            return true;
        }
        private bool DescripcionValida()
        {
            string descripcion = this.txtDesc.Text;

            if (descripcion.Length > 500)
            {
                this.lblErrorDescripcion.Text = "Debe tener como mucho 500 caracteres";
                return false;
            }
            this.lblErrorDescripcion.Text = "";
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!FormValido())
            {
                return;
            }
            string titulo = txtTitulo.Text;
            string desc = txtDesc.Text;
            int cupo = 0;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            try
            {
                cupo = int.Parse(txtCupo.Text);
                precio = Convert.ToDecimal(txtPrecio.Text);
            }
            catch (FormatException) { MessageBox.Show("El Cupo o precio debe ser un entero", "Problema de Cupo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

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
                    MessageBox.Show("El Cupo debe ser mayor a 0", "Problema de Cupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                Entidades.Instalacion instalacion = new Entidades.Instalacion()
                {
                    Id = instalacion_a_editar.Id,
                    Titulo = titulo,
                    Cupo = cupo,
                    Descripcion = desc,
                    UltimoPrecio = precio
                };
                try
                {
                    negocio_instalacion.modificar_Instalacion(instalacion);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("El Cupo debe ser mayor a 0", "Problema de Cupo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (TituloInstalacionRepetidoException)
                {
                    MessageBox.Show("El Titulo se encuentra repetido", "Problema de titulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            this.DialogResult = DialogResult.OK;
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            TituloValido();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            PrecioValido();
        }

        private void txtCupo_TextChanged(object sender, EventArgs e)
        {
            CupoValido();
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            DescripcionValida();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',' ||  Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
