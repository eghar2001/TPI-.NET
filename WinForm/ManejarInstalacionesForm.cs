﻿using Negocio;
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
    public partial class ManejarInstalacionesForm : Form
    {
        private Negocio.Instalacion negocio_instalacion = new Negocio.Instalacion();
        private Entidades.Instalacion instalacion_a_editar;
        public ManejarInstalacionesForm()
        {
            InitializeComponent();
        }



        private void ManejarInstalacionesForm_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            colEditar.Name = "Editar";
            colEditar.Text = "Editar";
            colEditar.UseColumnTextForButtonValue = true;
            DataGridViewButtonColumn colBorrar = new DataGridViewButtonColumn();
            colBorrar.Name= "Borrar";
            colBorrar.Text = "Borrar";
            colBorrar.UseColumnTextForButtonValue = true;
            this.dgvInstalaciones.Columns.Add(colEditar);
            this.dgvInstalaciones.Columns.Add(colBorrar);
            this.Listar();
        }

        public void Listar()
        {

            dgvInstalaciones.DataSource = negocio_instalacion.find_all();
            dgvInstalaciones.Refresh();

        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar();
            
        }




        private void dgvInstalaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvInstalaciones.AutoResizeColumns();
            dgvInstalaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvInstalaciones.Columns["Editar"].Index)
            {
                DataGridViewRow row = dgvInstalaciones.Rows[e.RowIndex];
                int colId = int.Parse(row.Cells["Id"].Value.ToString());
                instalacion_a_editar = negocio_instalacion.get_by_Id(colId);
                if (instalacion_a_editar == null)
                {
                    MessageBox.Show("No se encontró la instalacion", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    InstalacionForm editarInstalacionForm = new InstalacionForm(instalacion_a_editar);
                    editarInstalacionForm.ShowDialog();
                    
                }


            }


            if (e.RowIndex >= 0 && e.ColumnIndex == dgvInstalaciones.Columns["Borrar"].Index)
            {
                DataGridViewRow row = dgvInstalaciones.Rows[e.RowIndex];
                int colId = int.Parse(row.Cells["Id"].Value.ToString());
                DialogResult resultado = MessageBox.Show($"¿Estás seguro que desea borrar la inslatacion:{row.Cells["Titulo"].Value.ToString()}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        negocio_instalacion.remover_Instalacion(colId);
                    }
                    catch (InstalacionInexistenteException)
                    {
                        MessageBox.Show("La instalacion no existe", "Instalacion inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("La acción se realizó con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("La acción fue cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InstalacionForm InstalacionForm = new InstalacionForm();
            InstalacionForm.ShowDialog();

        }


    }
}
