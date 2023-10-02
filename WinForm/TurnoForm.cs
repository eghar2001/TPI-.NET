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
        private readonly Datos.Instalacion datos_instalacion = new Datos.Instalacion();
        public TurnoForm()
        {
            InitializeComponent();
            this.listadoInstalaciones.Instalaciones = datos_instalacion.find_all();
        }
    }
}
