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
            MessageBox.Show("Opción de ver asistencia", "Message",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción de informes", "Message",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
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
            TextBox myText = new TextBox();

        }
    }
}
