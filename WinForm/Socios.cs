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
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = negocio_socio.find_all();
            dgvSocios.Refresh();
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
            AgregarSocioForm socioForm = new AgregarSocioForm();
            socioForm.ShowDialog();
            if (socioForm.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            EditarSocioForm socioForm = new EditarSocioForm();
            socioForm.ShowDialog();
            if (socioForm.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            BorrarSocioForm socioForm = new BorrarSocioForm();
            socioForm.ShowDialog();
            if (socioForm.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }
    }
}