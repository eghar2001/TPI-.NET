using Microsoft.IdentityModel.Tokens;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Drawing;
using Entidades;

namespace WinForm
{
    public partial class UsuarioForm : Form
    {
        Negocio.Usuario negocio_usuario = new Negocio.Usuario();
        Entidades.Usuario? socio_a_editar = null;
        private string nombre_imagen = "default.png";


        public UsuarioForm()
        {

            InitializeComponent();
            this.picboxImagen.ImageLocation = Rutas.RutaImagenesPerfil + "\\default.png";
            this.Text = "Crear Usuario";
            this.lblTitulo.Text = "Crear Usuario";

            checkContrasenia.Visible = false;
            ActivarContrasenia();


        }
        public UsuarioForm(int id_socio)
        {
            socio_a_editar = negocio_usuario.get(id_socio);
            InitializeComponent();
            this.picboxImagen.ImageLocation = socio_a_editar.FotoAbsolutePath;
            this.Text = "Editar Usuario";
            this.lblTitulo.Text = "Editar Usuario '" + socio_a_editar.NombreApellido + "'";

            this.txtNombre.Text = socio_a_editar.Nombre;
            this.txtApellido.Text = socio_a_editar.Apellido;
            this.txtDni.Text = socio_a_editar.Dni.ToString();
            this.txtNombreUsuario.Text = socio_a_editar.NombreUsuario;


        }
        private bool NombreValido()
        {
            string nombre = txtNombre.Text;
            if (nombre.IsNullOrEmpty())
            {
                lblErrorNombre.Text = "El campo nombre es obligatorio";
                return false;
            }
            if (nombre.Length > 150)
            {
                lblErrorNombre.Text = "El campo tiene un maximo de 150 caracteres";
                return false;
            }
            lblErrorNombre.Text = "";
            return true;
        }
        private bool ApellidoValido()
        {
            string apellido = txtApellido.Text;
            if (apellido.IsNullOrEmpty())
            {
                lblErrorApellido.Text = "El campo apellido es obligatorio";
                return false;
            }
            if (apellido.Length > 150)
            {
                lblErrorApellido.Text = "El campo tiene un maximo de 150 caracteres";
                return false;
            }
            lblErrorApellido.Text = "";
            return true;
        }
        private bool NombreUsuarioValido()
        {
            string nombreUsuario = txtNombreUsuario.Text;
            if (nombreUsuario.IsNullOrEmpty())
            {
                lblErrorNombreUsuario.Text = "El campo nombreUsuario es obligatorio";
                return false;
            }
            if (nombreUsuario.Length > 150)
            {
                lblErrorNombreUsuario.Text = "El campo tiene un maximo de 150 caracteres";
                return false;
            }
            lblErrorNombreUsuario.Text = "";
            return true;
        }
        private bool DNIValido()
        {
            string dni = txtDni.Text;
            if (dni.IsNullOrEmpty())
            {
                LblErrorDni.Text = "El campo DNI es obligatorio";
                return false;
            }
            if (dni.Length > 8)
            {
                LblErrorDni.Text = "El campo tiene un maximo de 8 caracteres";
                return false;
            }
            if (!Validaciones.EsEntero(dni))
            {
                LblErrorDni.Text = "No tiene el formato valido";
                return false;
            }
            LblErrorDni.Text = "";
            return true;
        }

        private bool ContraseniaValida()
        {
            if (!checkContrasenia.Checked && checkContrasenia.Visible)
            {
                return true;
            }
            string contrasenia = txtContrasenia.Text;
            if (contrasenia.IsNullOrEmpty())
            {
                lblErrorContrasenia.Text = "El campo contraseña es obligatorio";
                return false;
            }
            if (contrasenia.Length > 50)
            {
                lblErrorContrasenia.Text = "El campo tiene un maximo de 50 caracteres";
                return false;
            }
            if (contrasenia != txtConfirmarContraseña.Text)
            {
                lblErrorContrasenia.Text = "Contraseña y Confirmar Contraseña deben coincidir";
                return false;
            }
            if (!Validaciones.EsContrasenia(contrasenia))
            {
                lblErrorContrasenia.Text = "La contrasenia debe tener 4 letras, 2 numeros y un caracter especial";
                return false;
            }
            lblErrorContrasenia.Text = "";
            return true;
        }



        private bool FormValido()
        {
            bool resultado = true;
            resultado = NombreValido() && resultado;
            resultado = ApellidoValido() && resultado;
            resultado = NombreUsuarioValido() && resultado;
            resultado = DNIValido() && resultado;
            resultado = ContraseniaValida() && resultado;
            return resultado;
        }
        public void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!FormValido())
            {
                return;
            }
            int dni = Int32.Parse(txtDni.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nombre_usuario = txtNombreUsuario.Text;
            string contrasenia;
            if (checkContrasenia.Checked)
            {
                contrasenia = txtContrasenia.Text;
            }
            else
            {
                contrasenia = socio_a_editar.Contrasenia;
            }

            Entidades.Usuario socio = new Entidades.Usuario(dni, nombre, apellido, nombre_usuario, contrasenia);

            string foto_filename = socio.NombreUsuario + DateTime.Now.ToString("ddMMyyyyhhmmss") + Path.GetExtension(nombre_imagen);
            socio.FotoNombre = foto_filename;
            if (socio_a_editar == null)
            {

                try
                {
                    negocio_usuario.agregar_socio(socio);
                    picboxImagen.Image.Save(Rutas.RutaImagenesPerfil + "\\" + foto_filename);
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
            else
            {
                socio.Id = socio_a_editar.Id;
                try
                {
                    negocio_usuario.modificar_socio(socio);
                    picboxImagen.Image.Save(Rutas.RutaImagenesPerfil + "\\" + foto_filename);
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
                catch (ArgumentException)
                {
                    MessageBox.Show("No se encontro el usuario a editar", "Problema de socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }

        private void SocioForm_Load(object sender, EventArgs e)
        {
            lblErrorNombre.Text = "";
            lblErrorApellido.Text = "";
            lblErrorNombreUsuario.Text = "";
            LblErrorDni.Text = "";
            lblErrorContrasenia.Text = "";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            NombreValido();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ApellidoValido();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            DNIValido();
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            NombreUsuarioValido();
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            ContraseniaValida();
        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            ContraseniaValida();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.PNG; *.JPG;| *.PNG; *.JPG| All files(*.*) | *.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.SafeFileName.EndsWith(".jpg") || fileDialog.SafeFileName.EndsWith(".png"))
                {
                    nombre_imagen = fileDialog.SafeFileName;
                    Image imagen = Image.FromStream(fileDialog.OpenFile());
                    imagen = Utils.FixImageOrientation(imagen);
                    picboxImagen.Image = imagen;
                }
                else
                {
                    MessageBox.Show("No se ingreso un formato de archivo correcto", "Formato de archivo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                nombre_imagen = "default.png";
            }
        }
        private void ActivarContrasenia()
        {
            lblContrasenia.Visible = true;
            lblConfirmarContrasenia.Visible = true;

            txtContrasenia.Visible = true;
            txtConfirmarContraseña.Visible = true;

            lblErrorContrasenia.Visible = true;
        }
        private void DesactivarContrasenia()
        {
            lblContrasenia.Visible = false;
            lblConfirmarContrasenia.Visible = false;

            txtContrasenia.Visible = false;
            txtConfirmarContraseña.Visible = false;

            lblErrorContrasenia.Visible = false;
        }
        private void checkContrasenia_CheckedChanged(object sender, EventArgs e)
        {
            if (checkContrasenia.Checked)
            {

                ActivarContrasenia();
            }
            else
            {
                DesactivarContrasenia();
            }
        }

        private void bntMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
