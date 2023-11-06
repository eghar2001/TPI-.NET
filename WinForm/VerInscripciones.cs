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
    public partial class VerInscripciones : Form
    {
        private Negocio.InscripcionTurno negocio_InscripcionesTurno = new Negocio.InscripcionTurno();
        public VerInscripciones()
        {
            InitializeComponent();
        }

        private void VerInscripciones_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void Listar()
        {
            dgvInscripciones.DataSource = negocio_InscripcionesTurno.find_all(DatosLogin.UsuarioLogueado.Id);
        }
    }
}
