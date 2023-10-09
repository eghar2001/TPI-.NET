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
        //CAMBIAR, CONECTAR A NEGOCIO CUANDO SE TENGA
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
        }


    }
}
