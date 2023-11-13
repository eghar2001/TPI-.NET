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
        private readonly Negocio.Usuario negocio_usuario = new Negocio.Usuario();
        private Entidades.Usuario? socio_a_editar = null;
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
        public UsuarioForm(int id_socio )
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
            
            try
            {
                if(socio_a_editar == null)
                {
                    negocio_usuario.agregar_socio(socio);
                }
                else
                {
                    socio.Id = socio_a_editar.Id;
                    negocio_usuario.modificar_socio(socio);
                }
                string ruta_archivo_guardado = Rutas.RutaImagenesPerfil + "\\" + foto_filename;
                
                picboxImagen.Image.Save(ruta_archivo_guardado);
                this.DialogResult = DialogResult.OK;
                
            }
            catch (DniRepetidoException)
            {
                MessageBox.Show("El DNI se encuentra repetido", "Problema de socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (NombreUsuarioRepetidoException)
            {
                MessageBox.Show("El nombre de usuario se encuentra repetido", "Problema de socio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            fileDialog.Filter = "Image Files(*.PNG; *.JPG;*.JPEG| *.PNG; *.JPG; *.JPEG| All files(*.*) | *.*";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                if (fileDialog.SafeFileName.EndsWith(".jpg") || fileDialog.SafeFileName.EndsWith(".png") || fileDialog.SafeFileName.EndsWith(".jpeg"))
                {
                    nombre_imagen = fileDialog.SafeFileName;
                    Image imagen = Image.FromStream(fileDialog.OpenFile());

                    Image imagen_arreglada = Utils.ResizeImage(imagen, new Size(150,150));
                    imagen_arreglada = Utils.FixImageOrientation(imagen_arreglada);
                    picboxImagen.Image = imagen_arreglada;
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
