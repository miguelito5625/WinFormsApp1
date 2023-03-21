using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Form formularioHijoActual;

        public Form1()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cierra el formulario hijo actualmente abierto, si existe
            if (formularioHijoActual != null)
            {
                formularioHijoActual.Close();
            }

            // Crea una instancia del formulario que deseas abrir
            Form formularioHijo = new AddForm();

            // Establece las propiedades necesarias para que el formulario secundario se convierta en un control dentro del panel y se muestren los bordes
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // Cambia aquí la propiedad FormBorderStyle
            formularioHijo.Dock = DockStyle.None;
            formularioHijo.MaximizeBox = false; // Establece en "false" para evitar la opción de maximizar
            formularioHijo.MinimizeBox = false; // Establece en "false" para evitar la opción de minimizar

            // Agrega el formulario secundario al panel de contenedor
            panel1.Controls.Add(formularioHijo);
            formularioHijo.BringToFront();

            // Muestra el formulario secundario
            formularioHijo.Show();

            // Actualiza la variable global del formulario hijo actualmente abierto
            formularioHijoActual = formularioHijo;
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cierra el formulario hijo actualmente abierto, si existe
            if (formularioHijoActual != null)
            {
                formularioHijoActual.Close();
            }

            // Crea una instancia del formulario que deseas abrir
            Form formularioHijo = new ListForm();

            // Establece las propiedades necesarias para que el formulario secundario se convierta en un control dentro del panel y se muestren los bordes
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.FixedSingle;
            formularioHijo.Dock = DockStyle.None;
            formularioHijo.MaximizeBox = false; // Establece en "false" para evitar la opción de maximizar
            formularioHijo.MinimizeBox = false; // Establece en "false" para evitar la opción de minimizar

            // Agrega el formulario secundario al panel de contenedor
            panel1.Controls.Add(formularioHijo);
            formularioHijo.BringToFront();

            // Muestra el formulario secundario
            formularioHijo.Show();

            // Actualiza la variable global del formulario hijo actualmente abierto
            formularioHijoActual = formularioHijo;
        }
    }
}
