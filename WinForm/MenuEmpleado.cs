using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using Microsoft.IdentityModel.Tokens;
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
    public partial class MenuEmpleado : Form
    {
        public MenuEmpleado()
        {
            InitializeComponent();
        }

        private void MenuEmpleado_Load(object sender, EventArgs e)
        {
            if (!DatosLogin.UsuarioLogueado.FotoNombre.IsNullOrEmpty())
            {
                try
                {
                    this.picboxEmpleado.Image = System.Drawing.Image.FromFile(DatosLogin.UsuarioLogueado.FotoAbsolutePath);
                }
                catch (IOException)
                {
                    MessageBox.Show("No se encontro la imagen del usuario", "Imagen no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.picboxEmpleado.Image = System.Drawing.Image.FromFile(Entidades.Rutas.RutaImagenesPerfil + "\\default.png");
                }
            }
            this.lblNombre.Text = DatosLogin.UsuarioLogueado.Nombre + " " + DatosLogin.UsuarioLogueado.Apellido;
            this.lblDni.Text = "DNI: " + DatosLogin.UsuarioLogueado.Dni;
        }




        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.subPanelProductos.Visible = !this.subPanelProductos.Visible;
        }

        private void btnInstalaciones_Click(object sender, EventArgs e)
        {
            this.subPanelnstalaciones.Visible = !this.subPanelnstalaciones.Visible;
        }

        private void btnActividades_Click(object sender, EventArgs e)
        {
            this.subPanelActividades.Visible = !this.subPanelActividades.Visible;
        }

        private void btnManejoSocios_Click(object sender, EventArgs e)
        {
            Socios administrarSocios = new Socios();
            administrarSocios.ShowDialog();
        }

        private void btnAdministrarProductos_Click(object sender, EventArgs e)
        {
            AdministrarProductosForm administrarProductosForm = new AdministrarProductosForm();
            administrarProductosForm.ShowDialog();
        }

        private void btnCompraProducto_Click(object sender, EventArgs e)
        {
            EleccionClienteCompraProducto eleccionClienteCompraProducto = new EleccionClienteCompraProducto();

            eleccionClienteCompraProducto.ShowDialog();
        }

        private void btnAdministrarActividades_Click(object sender, EventArgs e)
        {
            AdministrarActividadesForm administrarActividades = new AdministrarActividadesForm();
            administrarActividades.ShowDialog();
        }

        private void btnManejarInstalaciones_Click(object sender, EventArgs e)
        {
            ManejarInstalacionesForm manejarInstalaciones = new ManejarInstalacionesForm();
            manejarInstalaciones.Show();
        }

        private void btnAdministrarProfes_Click(object sender, EventArgs e)
        {
            AdministrarProfesores administrarProfesores = new AdministrarProfesores();
            administrarProfesores.Show();
        }

        private void btnReporteActividades_Click(object sender, EventArgs e)
        {
            ReporteHistoricoPreciosActividad reporteForm = new ReporteHistoricoPreciosActividad();
            reporteForm.Show();

        }

        private void btnMiCuenta_Click(object sender, EventArgs e)
        {
            UsuarioForm editarCuentaForm = new UsuarioForm(DatosLogin.UsuarioLogueado.Id);
            editarCuentaForm.ShowDialog();
            if (editarCuentaForm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Usuario creado con exito!!");
            }
        }

        private void tsbCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            DatosLogin.UsuarioLogueado = null;
            login.Show();
            this.Hide();
        }
    }
}
