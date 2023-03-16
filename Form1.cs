using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            if ((Application.OpenForms["AddForm"] as AddForm) != null)
            {
                //Form is already open
                addForm.Activate();
            }
            else
            {
                // Form is not open
                addForm.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm();
            listForm.Show();
        }
    }
}