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
    public partial class EditarSocioForm : Form
    {
        Negocio.Usuario negocio_usuario = new Negocio.Usuario();

        private Entidades.Usuario socio_a_editar = null;
        public EditarSocioForm()
        {

            InitializeComponent();
        }



        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                id = Int32.Parse(txtIdSocio.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("No ingreso un id numerico", "Error de Id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            socio_a_editar = negocio_usuario.get(id);
            if (socio_a_editar == null)
            {
                MessageBox.Show("No se encontró el socio", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNombre.Text = socio_a_editar.Nombre;
            txtApellido.Text = socio_a_editar.Apellido;
            txtDni.Text = socio_a_editar.Dni.ToString();
            txtNombreUsuario.Text = socio_a_editar.NombreUsuario;
            txtContrasenia.Text = socio_a_editar.Contrasenia;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (socio_a_editar == null)
            {
                MessageBox.Show("No se busco un socio todavia", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int dni  = 0;
            try
            {
                dni = Int32.Parse(txtDni.Text);
                
            }
            catch(Exception )
            {
                MessageBox.Show("No ingreso un Dni valido", "Error de DNI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            socio_a_editar.Nombre = txtNombre.Text;
            socio_a_editar.Apellido = txtApellido.Text;
            socio_a_editar.Dni = dni;
            socio_a_editar.NombreUsuario = txtNombreUsuario.Text;
            socio_a_editar.Contrasenia = txtContrasenia.Text;
            negocio_usuario.modificar_usuario(socio_a_editar);
            MessageBox.Show("Su socio se ha modificado con exito", "Socio Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}
