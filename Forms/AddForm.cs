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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.AgregarAlumno("Juan", "Pérez", 25); // Agrega un nuevo alumno
//            alumno.Actualizar(1, "Juan", "Pérez", 26); // Actualiza el alumno con Id=1
  //          alumno.Eliminar(2); // Elimina el alumno con Id=2
    //        DataTable dt = alumno.Buscar(); // Devuelve todos los alumnos en un DataTable

        }
    }
}
