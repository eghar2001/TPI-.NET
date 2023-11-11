using System.Data;

namespace WinForm
{
    public partial class Socios : Form
    {

        private Negocio.Usuario negocio_usuario = new Negocio.Usuario();
        List<Entidades.Usuario> usuarios;
        public Socios()
        {
            InitializeComponent();
        }


        public void Listar()
        {
            dgvSocios.DataSource = null;
            usuarios = negocio_usuario.find_socios();
            var usuarios_display = usuarios.Select(u => new
            {
                Id = u.Id,
                NombreApellido = u.Nombre + u.Apellido,
                DNI = u.Dni,
                Username = u.NombreUsuario
            }).ToList();
            dgvSocios.DataSource = usuarios_display;
        }
        private void Socios_Load(object sender, EventArgs e)
        {
            Listar();


            DataGridViewButtonColumn colBorrar = new DataGridViewButtonColumn();
            colBorrar.Text = "Borrar";
            this.dgvSocios.Columns.Add(colBorrar);



        }
        public void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();

        }
        public void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarSocioForm socioForm = new AgregarSocioForm();
            socioForm.ShowDialog();
            if (socioForm.DialogResult == DialogResult.OK)
            {
                Listar();
            }
        }

        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {
            var usuarios_display = usuarios.Where(u=> (u.Nombre + u.Apellido).ToUpper().Contains(txtNombreApellido.Text.ToUpper())).Select(u => new
            {
                Id = u.Id,
                NombreApellido = u.Nombre + u.Apellido,
                DNI = u.Dni,
                Username = u.NombreUsuario
            }).ToList();
            dgvSocios.DataSource = usuarios_display;
        }
    }
}