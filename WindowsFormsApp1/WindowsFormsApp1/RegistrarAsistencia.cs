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
    public partial class RegistrarAsistencia : Form
    {
        public RegistrarAsistencia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarAsistencia_Load(object sender, EventArgs e)
        {
            Clases.Poblar pob = new Clases.Poblar();
            pob.TodosEstudiantes();

            int busca = 0;

            if (int.TryParse(textBox1.Text, out busca))
            {
                Clases.Estudiante est = pob.BuscarEstdudiante(busca);

                if (est != null)
                {
                    label7.Text = est.Name;
                    label8.Text = est.Code.ToString();
                    label9.Text = est.Career;
                    label10.Text = est.Horario[0];
                    label11.Text = est.Horario[1];
                    label12.Text = est.Horario[2];
                }
                else {
                    label6.Text = "Estudiante no encontrado";
                }


               

            }
            else
            {
                MessageBox.Show("No es un código valido!", "Buscar estudiante",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }         

            
        }
    }
}
