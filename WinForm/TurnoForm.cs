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
    public partial class TurnoForm : Form
    {
        public bool DescripcionValida()
        {
            if (Validaciones.EsNulo(txtDescripcion.Text))
            {
                lblErrorDescripcion.Text = "Debe ingresar una descripcion";
                return false;
            }
            lblErrorDescripcion.Text = "";
            return true;
        }
        public bool ProfesorValido()
        {
            if (listadoProfesores.ProfesorSeleccionado == null)
            {
                MessageBox.Show("Debe seleccioanr un profesor", "Profesor no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool InstalacionValida()
        {
            if (listadoInstalaciones.InstalacionSeleccionada == null)
            {
                MessageBox.Show("Debe seleccioanr una instalacion", "Instalacion no ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //CAMBIAR, CONECTAR A NEGOCIO CUANDO SE TENGA
        private readonly Negocio.Turno negocio_turno = new Negocio.Turno();
        private readonly Datos.Instalacion datos_instalacion = new Datos.Instalacion();
        private readonly Datos.Profesor datos_profesor = new Datos.Profesor();
        private readonly Entidades.Actividad actividad;
        public TurnoForm(Entidades.Actividad actividad)
        {
            InitializeComponent();
            this.actividad = actividad;
            this.lblTitulo.Text = "Agregar Turno a '" + actividad.Nombre + "'";
            this.listadoInstalaciones.Instalaciones = datos_instalacion.find_all();
            this.listadoProfesores.Profesores = datos_profesor.find_all();
            this.lblErrorDescripcion.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!(DescripcionValida() && ProfesorValido() && InstalacionValida()))
            {
                return;
            }
            Entidades.Turno turno_nuevo = new Entidades.Turno()
            {
                Descripcion = txtDescripcion.Text,
                ActividadId = actividad.Id,
                ProfesorId = listadoProfesores.ProfesorSeleccionado.Id,
                InstalacionId = listadoInstalaciones.InstalacionSeleccionada.Id
            };
            try
            {
                negocio_turno.agregarTurno(turno_nuevo);
                this.DialogResult = DialogResult.OK;
            }
            //Agregar excepciones necesarias
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
