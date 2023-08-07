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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (negocio_usuario.login(txtNombreUsuario.Text, txtContrasenia.Text))
                {
                    MessageBox.Show("Se ha logueado correctamente", "Login correcto",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;

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
