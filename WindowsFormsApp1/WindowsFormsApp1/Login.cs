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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }      

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Opción de recuperación", "Message",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("administrador@gimnasio.com") & textBox2.Text.Equals("123")) {
                this.Hide();
                Gimnasio frm = new Gimnasio();
                frm.Show();
            }

            else if (textBox1.Text.Equals("administrador@deportes.com") & textBox2.Text.Equals("123")) {
                this.Hide();
                Deportes frm = new Deportes();
                frm.Show();
            }

            else {
                MessageBox.Show("Datos incorrectos", "Inicio de Sesión",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gimnasio frm = new Gimnasio();
            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
