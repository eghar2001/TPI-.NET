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
    public partial class ProfesorForm : Form
    {
        Negocio.Profesor negocio_profesor = new Negocio.Profesor();
        private Entidades.Profesor? profesor_a_editar = null;

        public ProfesorForm()
        {
            InitializeComponent();
            this.lblTitulo.Text = "Agregar Profesor";
        }

        public ProfesorForm(Entidades.Profesor profesor_a_editar)
        {
            InitializeComponent();
            this.profesor_a_editar = profesor_a_editar;
            this.Text = "Editar Profesor";
            this.txtSalario.Text = profesor_a_editar.Salario.ToString();
            this.txtNombre.Text = profesor_a_editar.Nombre;
            this.txtApellido.Text = profesor_a_editar.Apellido;
            this.lblTitulo.Text = "Modificar Profesor";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            decimal salario;
            try
            {
                salario = decimal.Parse(txtSalario.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("El salario no tiene el formato pedido", "Problema de salario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.profesor_a_editar == null)
            {
                Entidades.Profesor profesor = new Entidades.Profesor()
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Salario = salario
                };

                try
                {
                    negocio_profesor.agregar_profesor(profesor);
                    this.DialogResult = DialogResult.OK;
                }

                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("El Salario debe ser mayor a 0", "Problema de salario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                Entidades.Profesor profesor = new Entidades.Profesor()
                {
                    Id = profesor_a_editar.Id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Salario = salario
                };
                try
                {
                    negocio_profesor.modificar_profesor(profesor);
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("El Salario debe ser mayor a 0", "Problema de salario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.OK;
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void bntMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

