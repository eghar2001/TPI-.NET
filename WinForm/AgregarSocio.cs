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
    public partial class AgregarSocio : Form
    {
        Negocio.Socio negocio_socio = new Negocio.Socio();
        public AgregarSocio()
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

            Entidades.Socio socio = new Entidades.Socio(dni, nombre, apellido, nombre_usuario, contrasenia);

            negocio_socio.agregar_socio(socio);
            this.DialogResult = DialogResult.OK;

        }


    }
}
