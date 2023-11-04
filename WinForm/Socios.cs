using System.Data;

namespace WinForm
{
    public partial class Socios : Form
    {

        private Negocio.Usuario negocio_usuario = new Negocio.Usuario();
        public Socios()
        {
            InitializeComponent();
        }


        public void Listar()
        {
            dgvSocios.DataSource = null;
            dgvSocios.DataSource = negocio_usuario.find_socios();
            dgvSocios.Refresh();
        }
        private void Socios_Load(object sender, EventArgs e)
        {
            Listar();
            dgvSocios.Columns.Remove("Contrasenia");
            dgvSocios.Columns.Remove("TipoUsuarioId");
            dgvSocios.Columns.Remove("TipoUsuario");

            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.HeaderText = "Editar";
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true; 
            this.dgvSocios.Columns.Add(colEditar);

            DataGridViewButtonColumn colBorrar = new DataGridViewButtonColumn();
            colBorrar.HeaderText = "Borrar";
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;
            this.dgvSocios.Columns.Add(colBorrar);



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
            SocioForm socioForm = new SocioForm();
            socioForm.ShowDialog();
            if (socioForm.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void dgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0 || e.ColumnIndex < 0)
            {
                return;
            }
            string columna = dgvSocios.Columns[e.ColumnIndex].HeaderText;
            if (columna == "Editar")
            {
                MessageBox.Show("Hola");
            }
            else if (columna == "Borrar")
            {

                DialogResult resultado = MessageBox.Show("Esta seguro que desea borrar al socio");
            }
        }
    }
}