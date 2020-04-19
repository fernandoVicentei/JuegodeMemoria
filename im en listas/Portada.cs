using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace im_en_listas
{
    public partial class Portada : Form
    {
        //bool ANDAR= true;
        //int X = 0;
        //int Y = 227;/*1716; 216*/
        public Portada()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //    MemoramaPro memoramaPro = new MemoramaPro();
        //    memoramaPro.Show();
        //}
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lbllpla1 lbllpla1 = new lbllpla1();
            lbllpla1.Show();
        }
        private void Portada_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {            
            //if (ANDAR)
            //{
            //    label1.Location = new Point(X++, Y);
            //    if (X == 335)
            //    {
            //        ANDAR = false;
            //    }               
            //}else if (ANDAR == false){
            //    label1.Location = new Point(X--, Y);
            //    if (X == 1)
            //    {
            //        ANDAR = true;
            //    }
            //}
            
               
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbllpla1 memorama_novato = new lbllpla1();
            memorama_novato.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Datos_de_Jugadores datos_De_Jugadores = new Datos_de_Jugadores();
            datos_De_Jugadores.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
