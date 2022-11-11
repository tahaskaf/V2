using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {// VARIABLES
        int x = 307;
        int y = 167;

        int mov = 1;
        int cont = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Dado1, Dado2;
            Random tirada = new Random();
            Dado1 = tirada.Next(1,7);
            Dado2 = tirada.Next(1, 7);

            //DADO 1
            if (Dado1 == 1)
            {
                picDado1.Image = Image.FromFile("1.jpg");
            }
            if (Dado1 == 2)
            {
                picDado1.Image = Image.FromFile("2.jpg");
            }
            if (Dado1 == 3)
            {
                picDado1.Image = Image.FromFile("3.jpg");
            }
            if (Dado1 == 4)
            {
                picDado1.Image = Image.FromFile("4.jpg");
            }
            if (Dado1 == 5)
            {
                picDado1.Image = Image.FromFile("5.jpg");
            }
            if (Dado1 == 6)
            {
                picDado1.Image = Image.FromFile("6.jpg");
            }

            //DADO 2
            if (Dado2 == 1)
            {
                picDado2.Image = Image.FromFile("1.jpg");
            }
            if (Dado2 == 2)
            {
                picDado2.Image = Image.FromFile("2.jpg");
            }
            if (Dado2 == 3)
            {
                picDado2.Image = Image.FromFile("3.jpg");
            }
            if (Dado2 == 4)
            {
                picDado2.Image = Image.FromFile("4.jpg");
            }
            if (Dado2 == 5)
            {
                picDado2.Image = Image.FromFile("5.jpg");
            }
            if (Dado2 == 6)
            {
                picDado2.Image = Image.FromFile("6.jpg");
            }

            if (Dado1 == Dado2)
            {
                MessageBox.Show("DOBLES!!!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tablero_MouseMove(object sender, MouseEventArgs e)
        {
            miPosicion.Text = "X= " + e.X + " Y= " + e.Y;
        }

        public void Tablero_Paint(object sender, PaintEventArgs e)
        {
            Tablero.Invalidate();
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            SolidBrush myBrush = new SolidBrush(Color.Red);
            graphics.FillEllipse(myBrush, x, y, 26, 26);

        }

        private void Mover_Click(object sender, EventArgs e)
        {
            if (mov == 1)
            {
                y = y + 40;
            }
            if (mov == 2)
            {
                x = x - 40;
            }
            if (mov == 3)
            {
                y = y + 80;
            }
            if (mov == 4)
            {
                x = x + 40;
            }
            if (mov == 5)
            {
                y = y - 40;
            }

            if ((mov == 1) && (y > 310) && (cont == 0))
            {
                mov = 2;
                x = 290;
                y = 320;
                cont++;
            }
            if ((mov == 2) && (x < 40) && (cont == 1))
            {
                mov = 3;
                cont++;
            }
            if ((mov == 3) && (y > 440) && (cont == 2))
            {
                mov = 4;
                cont++;
            }
            if ((mov == 4) && (x > 310) && (cont == 3))
            {
                mov = 1;
                x = 320;
                y = 490;
                cont++;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

        private void miPosicion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
