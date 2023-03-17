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
            this.Load += ListForm_Load; // suscribirse al evento Load

        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            CargarDatosAlumnos();
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


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
