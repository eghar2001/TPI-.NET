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
    public partial class AgregarProfesor : Form
    {
        Negocio.Profesor negocio_profesor = new Negocio.Profesor();
        private Entidades.Profesor? profesor_a_editar = null;

        public AgregarProfesor()
        {
            InitializeComponent();
        }

        public AgregarProfesor(Entidades.Profesor profesor_a_editar)
        {
            InitializeComponent();
            this.profesor_a_editar = profesor_a_editar;
            this.Text = "Editar Profesor";
            this.txtSalario.Text = profesor_a_editar.Salario.ToString();
            this.txtNombre.Text = profesor_a_editar.Nombre;
            this.txtApellido.Text = profesor_a_editar.Apellido;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int salario = 0;
            try
            {
                salario = int.Parse(txtSalario.Text);
            }
            catch (FormatException) { MessageBox.Show("El salario debe ser un entero", "Problema de salario", MessageBoxButtons.OK, MessageBoxIcon.Error); }

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
               negocio_profesor.modificar_profesor(profesor);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
    }

