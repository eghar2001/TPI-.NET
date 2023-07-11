using System.Data;

namespace WinForm
{
    public partial class Socios : Form
    {
        public Socios()
        {
            InitializeComponent();
        }

        
        public void Listar()
        {
            
            dgvSocios.DataSource = negocio_socio.find_all();
        }
        private void Socios_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        public void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            AgregarSocio socioForm = new AgregarSocio();
            socioForm.ShowDialog();
            if (socioForm.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        
    }
}