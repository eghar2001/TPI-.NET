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
    public partial class SocioForm : Form
    {
        Negocio.Usuario negocio_usuario = new Negocio.Usuario();
        Entidades.Usuario socio_a_editar;
        public SocioForm()
        {

            InitializeComponent();
            this.Text = "Agregar Socio";
            this.lblTitulo.Text = "Agregar Socio";
        }
        public SocioForm(Entidades.Usuario socio)
        {

            InitializeComponent();
            this.socio_a_editar = socio;
            this.Text = "Editar Socio";
            this.lblTitulo.Text = "Editar Socio";

            this.txtNombre.Text = socio.Nombre;
            this.txtApellido.Text = socio.Apellido;
            this.txtDni.Text = socio.Dni.ToString();
            this.txtNombreUsuario.Text = socio.NombreUsuario;
            
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            int dni = Int32.Parse(txtDni.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nombre_usuario = txtNombreUsuario.Text;
            string contrasenia = txtContrasenia.Text;

            Entidades.Usuario socio = new Entidades.Usuario(dni, nombre, apellido, nombre_usuario, contrasenia);

            try
            {
                negocio_usuario.agregar_usuario(socio);
                this.DialogResult = DialogResult.OK;
            }
            catch (DniRepetidoException)
            {
                MessageBox.Show("El DNI se encuentra repetido", "Problema de socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NombreUsuarioRepetidoException)
            {
                MessageBox.Show("El nombre de usuario se encuentra repetido", "Problema de socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error inesperado. Por favor, intente mas tarde", "Hubo un problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
