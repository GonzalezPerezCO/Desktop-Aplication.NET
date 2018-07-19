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
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gimnasio frm = new Gimnasio();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Informes frm = new Informes();
            frm.Show();
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            Clases.Poblar pob = new Clases.Poblar();
            pob.IniciarTodo();

            Clases.Estudiante[] array = pob.TodosEstudiantes();

            label6.Text = array[1].Name;
            label7.Text = array[1].Code.ToString();
            label8.Text = array[1].Fallas.ToString();
            label9.Text = array[1].Horario[0];
            label10.Text = array[1].Horario[1];
            label11.Text = array[1].Horario[2];

            label17.Text = array[2].Name;
            label16.Text = array[2].Code.ToString();
            label15.Text = array[2].Fallas.ToString();
            label14.Text = array[2].Horario[0];
            label13.Text = array[2].Horario[1];
            label12.Text = array[2].Horario[2];

            label23.Text = array[3].Name;
            label22.Text = array[3].Code.ToString();
            label21.Text = array[3].Fallas.ToString();
            label20.Text = array[3].Horario[0];
            label19.Text = array[3].Horario[1];
            label18.Text = array[3].Horario[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarAsistencia frm = new RegistrarAsistencia();
            frm.Show();
        }
    }
}
