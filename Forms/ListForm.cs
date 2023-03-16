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

            Alumno alumno = new Alumno();
            List<Alumno> listaDeAlumnos = alumno.ListarAlumnos();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = listaDeAlumnos;
            dataGridView1.DataSource = bindingSource;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
