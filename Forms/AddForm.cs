using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class AddForm : MaterialForm
    {
        public AddForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
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
