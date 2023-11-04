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
using Negocio;

namespace WinForm
{
    public partial class TurnoForm : Form
    {
        //CAMBIAR, CONECTAR A NEGOCIO CUANDO SE TENGA
        private readonly Negocio.Turno negocio_turno = new Negocio.Turno();
        private readonly Negocio.Instalacion negocio_instalacion = new Negocio.Instalacion();
        private readonly Negocio.Profesor negocio_profesor = new Negocio.Profesor();
        private readonly Entidades.Turno? turno_a_editar = null;
        private readonly Entidades.Actividad actividad;
        public TurnoForm(Entidades.Actividad actividad)
        {
            InitializeComponent();

            this.actividad = actividad;
            this.lblTitulo.Text = "Agregar Turno a '" + actividad.Nombre + "'";
            this.listadoInstalaciones.Instalaciones = negocio_instalacion.find_all();
            this.listadoProfesores.Profesores = negocio_profesor.find_all();
            this.lblErrorDescripcion.Text = "";
        }
        public TurnoForm(Entidades.Turno turno)
        {
            InitializeComponent();
            this.turno_a_editar = turno;
            this.actividad = turno.Actividad;
            this.lblTitulo.Text = "Editar Turno";
            this.listadoInstalaciones.Instalaciones = negocio_instalacion.find_all();
            this.listadoProfesores.Profesores = negocio_profesor.find_all();

            this.txtDescripcion.Text = turno.Descripcion;
            this.listadoProfesores.ProfesorSeleccionado = turno.Profesor;
            this.listadoInstalaciones.InstalacionSeleccionada = turno.Instalacion;
            this.lblErrorDescripcion.Text = "";
        }
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


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!(DescripcionValida() && ProfesorValido() && InstalacionValida()))
            {
                return;
            }
            Entidades.Turno turno = new Entidades.Turno()
            {
                Descripcion = txtDescripcion.Text,
                ActividadId = actividad.Id,
                ProfesorId = listadoProfesores.ProfesorSeleccionado.Id,
                InstalacionId = listadoInstalaciones.InstalacionSeleccionada.Id
            };
            //Si turno a editar es nulo, se quiere agregar un nuevo turno
            //caso contrario, se quiere modificar
            if (turno_a_editar == null)
            {


                try
                {
                    negocio_turno.agregarTurno(turno);
                    this.DialogResult = DialogResult.OK;
                }
                //Agregar excepciones necesarias
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    turno.Id = turno_a_editar.Id;
                    negocio_turno.modificarTurno(turno);
                    this.DialogResult = DialogResult.OK;
                }
                //Agregar excepciones necesarias
                catch (HorarioSuperpuestoException ex)
                {
                    MessageBox.Show(ex.Message, "Horarios Superpuestos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }




            }
        }
    }
}
