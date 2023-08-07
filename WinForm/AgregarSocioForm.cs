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
    public partial class AgregarSocioForm : Form
    {
        Negocio.Usuario negocio_usuario = new Negocio.Usuario();
        public AgregarSocioForm()
        {

            InitializeComponent();
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            int dni = Int32.Parse(txtDni.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nombre_usuario = txtNombreUsuario.Text;
            string contrasenia = txtContrasenia.Text;

            Entidades.Usuario socio = new Entidades.Usuario(dni, nombre, apellido, nombre_usuario, contrasenia);

            negocio_usuario.agregar_usuario(socio);
            this.DialogResult = DialogResult.OK;

        }


    }
}
