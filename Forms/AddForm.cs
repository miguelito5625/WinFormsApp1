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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string name = textBoxName.Text;
            string lname = textBoxLastName.Text;
            int age = Convert.ToInt32(textBoxAge.Text);

            string mensaje = alumno.GuardarAlumno(name, lname, age); // Agrega un nuevo alumno
            MessageBox.Show(mensaje);

        }
    }
}
