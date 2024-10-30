using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_de_laa_bolita
{
    public partial class frmRedBall : Form
    {
        public frmRedBall()
        {
            InitializeComponent();
        }
        public static class Globalcontar
        {
            public static int contar;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {



        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button4_Click(object sender, EventArgs e)
        {
            var randomNumber = new Random().Next(1, 4);
            lblResultado.Text = Convert.ToString(randomNumber.ToString());
            int jugada = Convert.ToInt32(lblJugada.Text)+1;
            lblJugada.Text = Convert.ToString(jugada);
            pb4.Visible = false;
            pb5.Visible = false;
            pb6.Visible = false;
            pb1.Visible = true;
            pb2.Visible = true;
            pb3.Visible = true;
            pb7.Visible = false;
            pb8.Visible = false;
            pb9.Visible = false;
            Globalcontar.contar = Globalcontar.contar + 1;
            Console.WriteLine(Globalcontar.contar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vikingo1 = 1 ;
            if (vikingo1 == Convert.ToInt32(lblResultado.Text))
            {
                pb4.Visible=true;
                jugador.Rows.Add(lblJugada.Text, comboBox1.Text, 10);
            } 
            else
            {
                jugador.Rows.Add(lblJugada.Text, comboBox1.Text, 0);
                pb4.Visible=false;
                pb7.Visible=true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var vikingo2 = 1;
            if (vikingo2 == Convert.ToInt32(lblResultado.Text))
            {
                pb5.Visible = true;
                jugador.Rows.Add(lblJugada.Text, comboBox1.Text, 10);
            }
            else
            {
                jugador.Rows.Add(lblJugada.Text, comboBox1.Text,0);
                pb5.Visible = false;
                pb8.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var vikingo3 = 1;
            if (vikingo3 == Convert.ToInt32(lblResultado.Text))
            {
                pb6.Visible = true;
                jugador.Rows.Add(lblJugada.Text, comboBox1.Text, 10);
            }
            else
            {
                jugador.Rows.Add(lblJugada.Text, comboBox1.Text, 0);
                pb6.Visible = false;
                pb9.Visible = true;
            }
        }
    }
}



