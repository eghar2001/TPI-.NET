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
    public partial class EditarInstalacionForm : Form
    {
        public Entidades.Instalacion instalacion_a_editar { get; set; }
        Negocio.Instalacion negocio_instalacion = new Negocio.Instalacion();
        public EditarInstalacionForm()
        {
            InitializeComponent();
        }

        private void EditarInstalacionForm_Load(object sender, EventArgs e)
        {
            txtCupo.Text = instalacion_a_editar.Cupo.ToString();
            txtDesc.Text = instalacion_a_editar.Descripcion;
            txtTitulo.Text = instalacion_a_editar.Titulo;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string desc = txtDesc.Text;
            int  cupo;
            try
            {
                cupo = int.Parse(txtCupo.Text);
            }
            catch (FormatException) { MessageBox.Show("El Cupo debe ser un entero", "Problema de Cupo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           

            negocio_instalacion.modificar_Instalacion(instalacion_a_editar); 
           
            MessageBox.Show("La acción se realizó con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
