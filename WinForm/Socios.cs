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
                NombreApellido = u.NombreApellido,
                DNI = u.Dni,
                Username = u.NombreUsuario
            }).ToList();
            dgvSocios.DataSource = usuarios_display;
        }
        private void Socios_Load(object sender, EventArgs e)
        {
            Listar();

            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.Name = "Editar";
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            this.dgvSocios.Columns.Add(colEditar);

            DataGridViewButtonColumn colBorrar = new DataGridViewButtonColumn();
            colBorrar.Name = "Borrar";
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;
            this.dgvSocios.Columns.Add(colBorrar);





        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UsuarioForm agregarSocioForm = new UsuarioForm();
            agregarSocioForm.ShowDialog();
            if (agregarSocioForm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("El socio se ha agregado con exito", "Socio agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listar();
            }
        }

        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {
            var usuarios_display = usuarios.Where(u => (u.Nombre + u.Apellido).ToUpper().Contains(txtNombreApellido.Text.ToUpper())).Select(u => new
            {
                Id = u.Id,
                NombreApellido = u.NombreApellido,
                DNI = u.Dni,
                Username = u.NombreUsuario
            }).ToList();
            dgvSocios.DataSource = usuarios_display;
        }

        private void dgvSocios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0 || e.ColumnIndex < 0)
            {
                return;
            }
            string columna = dgvSocios.Columns[e.ColumnIndex].Name;
            int id =int.Parse( dgvSocios.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            if (columna == "Editar")
            {
                UsuarioForm editarSocioForm = new UsuarioForm(id);
                editarSocioForm.ShowDialog();
                if (editarSocioForm.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("El socio se ha modificado con exito", "Socio modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Listar();
                }
            }
            if (columna == "Borrar")
            {
                string nombreapellido = dgvSocios.Rows[e.RowIndex].Cells["NombreApellido"].Value.ToString();
                DialogResult resultado = MessageBox.Show("Esta seguro que desea borrar al socio '" + nombreapellido + "'", "Borrar socio", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.OK)
                {
                    negocio_usuario.borrar_usuario(id);
                }
            }
        }
    }
}