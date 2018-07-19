using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Gimnasio : Form
    {
        public Gimnasio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Asistencia frm = new Asistencia();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Informes frm = new Informes();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción de administradores", "Message",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción de ver lista destudiantes", "Message",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void Gimnasio_Load(object sender, EventArgs e)
        {
            Clases.Poblar pob = new Clases.Poblar();
            pob.IniciarTodo();

            Clases.Estudiante[] array = pob.TodosEstudiantes();

            label3.Text = array[1].Name;
            label8.Text = array[1].Code.ToString();
            label10.Text = array[1].Career;
            label9.Text = array[1].Semester.ToString();
            label11.Text = array[1].Obervaciones;

            label16.Text = array[2].Name;
            label15.Text = array[2].Code.ToString();
            label14.Text = array[2].Career;
            label13.Text = array[2].Semester.ToString();
            label12.Text = array[2].Obervaciones;

            label21.Text = array[3].Name;
            label20.Text = array[3].Code.ToString();
            label19.Text = array[3].Career;
            label18.Text = array[3].Semester.ToString();
            label17.Text = array[3].Obervaciones;


        }
    }
}
