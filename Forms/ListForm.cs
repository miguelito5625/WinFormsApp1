using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Controllers.DataBase;

namespace WinFormsApp1.Forms
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
            CargarDatosGrados();
            this.Load += ListForm_Load; // suscribirse al evento Load

        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            CargarDatosAlumnos();

            // Agregar columna con botones de control
            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
            btnCol.HeaderText = "Acciones";
            btnCol.Text = "Editar";
            btnCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnCol);

            DataGridViewButtonColumn btnCol2 = new DataGridViewButtonColumn();
            btnCol2.HeaderText = "";
            btnCol2.Text = "Borrar";
            btnCol2.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnCol2);
        }

        private void CargarDatosGrados()
        {
            Grado grado = new Grado();
            List<string> listaGrados = grado.ListarGrados();
            foreach (string gradotxt in listaGrados)
            {
                comboBoxGrados.Items.Add(gradotxt);
            }
        }

        private void CargarDatosAlumnos()
        {
            try
            {
                var listaAlumnos = new Alumno().ListarAlumnos();
                if (listaAlumnos != null && listaAlumnos.Count > 0)
                {
                    dataGridView1.DataSource = listaAlumnos;
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la lista de alumnos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void comboBoxGrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gradoSeleccionado = comboBoxGrados.SelectedItem as string;
            if (!string.IsNullOrEmpty(gradoSeleccionado))
            {
                var listaAlumnos = new Alumno().ListarAlumnos(gradoSeleccionado);
                dataGridView1.DataSource = listaAlumnos;
            }
            else
            {
                CargarDatosAlumnos();
            }
        }



    }
}
