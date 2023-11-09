using Microsoft.IdentityModel.Tokens;
using Negocio;
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
        private List<int> ids_turno;
        private List<int> ids_inscripcion;
        public VerInscripciones()
        {
            InitializeComponent();
        }

        private void VerInscripciones_Load(object sender, EventArgs e)
        {
            lblSocio.Text = "Socio: " + DatosLogin.UsuarioLogueado.Nombre + " " + DatosLogin.UsuarioLogueado.Apellido + "(" + DatosLogin.UsuarioLogueado.Dni + ")";
            this.Listar();

            


        }

        private void Listar()
        {
            List<Entidades.InscripcionTurno> inscripciones = negocio_InscripcionesTurno.find_all(DatosLogin.UsuarioLogueado.Id);

            if (inscripciones.IsNullOrEmpty())
            {
                dgvInscripciones.Columns.Clear() ;
                MessageBox.Show("No tiene inscripciones hechas", "Sin inscripciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var inscripciones_display = inscripciones.Select(i => new
            {
                Id = i.Id,
                
                Actividad = i.Turno,
                FechaInscripcion = i.FechaHoraInscripcion,

            }).ToList();


            dgvInscripciones.DataSource = inscripciones_display;
            
            DataGridViewButtonColumn colHorarios = new DataGridViewButtonColumn();
            colHorarios.Name = "Horarios";
            colHorarios.HeaderText = "Horarios";
            colHorarios.Text = "Ver Horarios";
            colHorarios.UseColumnTextForButtonValue = true;
            dgvInscripciones.Columns.Add(colHorarios);

            DataGridViewButtonColumn colBaja = new DataGridViewButtonColumn();
            colBaja.Name = "Baja";
            colBaja.HeaderText = "Baja";
            colBaja.Text = "Darse de baja";
            colBaja.UseColumnTextForButtonValue = true;
            dgvInscripciones.Columns.Add(colBaja);


            ids_turno = inscripciones.Select(i => i.TurnoId).ToList();
            ids_inscripcion = inscripciones.Select(i => i.Id).ToList();
            

        }

        private void dgvInscripciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) 
            { 
                return; 
            }
            string actividad = dgvInscripciones.Rows[e.RowIndex].Cells["Actividad"].Value.ToString();
            string columna = dgvInscripciones.Columns[e.ColumnIndex].Name;
            int id_turno = ids_turno[e.RowIndex];
            int id_inscripcion = ids_inscripcion[e.RowIndex];
            if (columna == "Baja")
            {
                DialogResult resultado = MessageBox.Show("Esta seguro que desea darse de baja de la actividad '" + actividad + "'", "Darse de baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.OK)
                {
                    try
                    {
                        negocio_InscripcionesTurno.darDeBajaInscripcionTurno(id_inscripcion);
                        this.Listar();
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("No se encontró la inscripcion", "Inscripcion no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (InscripcionDadaDeBajaException)
                    {
                        MessageBox.Show("La inscripcion ya se encuentra dada de baja", "Inscripcion dada de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrió un error inesperado", "Error Ineseperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
