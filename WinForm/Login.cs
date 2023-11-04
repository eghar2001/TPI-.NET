using Entidades;
using Microsoft.Data.SqlClient;
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
    public partial class Login : Form
    {
        private Negocio.Usuario negocio_usuario = new Negocio.Usuario();
        public Login()
        {
            InitializeComponent();
            this.lblErrorNombreUsuario.Text = "";
            this.lblErrorContrasenia.Text = "";
        }

        private bool FormValido()
        {
            bool resultado = true;
            resultado = NombreUsuariovValido() && resultado;
            resultado = ContraseniaValida() && resultado;
            return resultado;
        }
        private bool NombreUsuariovValido()
        {
            string nombreUsuario = this.txtNombreUsuario.Text;

            if (nombreUsuario.Length == 0)
            {
                this.lblErrorNombreUsuario.Text = "Debe ingresar un nombre de usuario";
                return false;
            }
            if (nombreUsuario.Length > 150)
            {
                this.lblErrorNombreUsuario.Text = "Supero el maximo de 150 caracteres";
                return false;
            }
            this.lblErrorNombreUsuario.Text = "";
            return true;
        }
        private bool ContraseniaValida()
        {
            string contrasenia = this.txtContrasenia.Text;

            if (contrasenia.Length == 0)
            {
                this.lblErrorContrasenia.Text = "Debe ingresar una Contraseña";
                return false;
            }
            if (contrasenia.Length > 150)
            {
                this.lblErrorContrasenia.Text = "Supero el maximo de 150 caracteres";
                return false;
            }
            this.lblErrorContrasenia.Text = "";
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!FormValido())
            {
                return;
            }
            try
            {
                Entidades.Usuario usuario = negocio_usuario.login(txtNombreUsuario.Text, txtContrasenia.Text);
                if (usuario != null)
                {

                    Form menu;


                    if (usuario.EsTipoUsuario(Entidades.TiposUsuarioEnum.EMPLEADO))
                    {
                        menu = (MenuEmpleado)new MenuEmpleado();
                    }
                    else if (usuario.EsTipoUsuario(Entidades.TiposUsuarioEnum.SOCIO))
                    {
                        menu = (MenuSocio)new MenuSocio();
                    }
                    else
                    {
                        MessageBox.Show("El tipo de usuario no es valido", "Tipo usuario error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        menu = new Form();
                        this.Dispose();
                    }
                    menu.FormClosing += (s, args) =>
                    {
                        this.Dispose();
                    };


                    MessageBox.Show("Se ha logueado correctamente", "Login correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DatosLogin.UsuarioLogueado = usuario;
                    menu.Show();
                    this.Hide();
                }

            }
            catch (UsuarioInexistenteException)
            {
                MessageBox.Show("El nombre de usuario es inexistente", "Error de Login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ContraseniaIncorrectaException)
            {
                MessageBox.Show("La contraseña es incorrecta", "Error de Login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Hubo un error al conectarse a la base de datos. Por favor, intente mas tarde", "Error de servidor",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }


    }
}
