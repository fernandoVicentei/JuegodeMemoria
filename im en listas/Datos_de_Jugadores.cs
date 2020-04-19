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
    public partial class Datos_de_Jugadores : Form
    {
        
        public Datos_de_Jugadores()
        {
            InitializeComponent();
           
        }
        public int con = 0, coni = 7, aux, auxi = 0, b = 0, b1 = 0, conis = 0;
        public string pla1 = ""; public string pla2 = "";        
       
        private void button1_Click(object sender, EventArgs e)
        {
            pla1 = txtplay1.Text;
            pla2 = txtpla2.Text;
            this.Close();
            MemoramaPro memoramaPro = new MemoramaPro(pla1,pla2,auxi,b);
            memoramaPro.Show();
        }
        public void NombreDatos()
        {
           
        }
        private void Datos_de_Jugadores_Load(object sender, EventArgs e)
        {
          
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void CONTRO()
        {
           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {          
            if (con == 0)
            {
                pictureBox2.Image = imageList1.Images[0];
                con++;conis = 0;
            }else if (con == 1)
            {
                pictureBox2.Image = imageList1.Images[1];
                con++; conis = 1;
            }else if (con == 2)
            {
                pictureBox2.Image = imageList1.Images[2];
                con++; conis = 2;
            }else if (con == 3)
            {
                pictureBox2.Image = imageList1.Images[3];
                con++;  conis = 3;
            }else if (con == 4)
            {
                pictureBox2.Image = imageList1.Images[4];
                con++;  conis = 4;
            }else if (con == 5)
            {
                pictureBox2.Image = imageList1.Images[5];
                con++; conis = 5;
            }
            else if (con == 6)
            {
                pictureBox2.Image = imageList1.Images[6];
                con++;  conis = 6;
            }else if (con == 7)
            {
                pictureBox2.Image = imageList1.Images[7];
                con=0;  conis = 7;
            }
          
        }
        //private void pictureBox5_Click(object sender, EventArgs e)
        //{
        //    if (con == 0)
        //    {
        //        pictureBox2.Image = imageList1.Images[7];
        //        con++;
        //    }
        //    else if (con == 1)
        //    {
        //        pictureBox2.Image = imageList1.Images[6];
        //        con++;
        //    }
        //    else if (con == 2)
        //    {
        //        pictureBox2.Image = imageList1.Images[5];
        //        con++;
        //    }
        //    else if (con == 3)
        //    {
        //        pictureBox2.Image = imageList1.Images[4];
        //        con++;
        //    }
        //    else if (con == 4)
        //    {
        //        pictureBox2.Image = imageList1.Images[3];
        //        con++;
        //    }
        //    else if (con == 5)
        //    {
        //        pictureBox2.Image = imageList1.Images[2];
        //        con++;
        //    }
        //    else if (con == 6)
        //    {
        //        pictureBox2.Image = imageList1.Images[1];
        //        con++;
        //    }
        //    else if (con == 7)
        //    {
        //        pictureBox2.Image = imageList1.Images[0];
        //        coni=0;
        //    }
        //}
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (aux == 0)
            {
                auxi = conis;
                aux++;
            }
            else if (aux == 1)
            {
                b = conis;
                aux++;
            }
            if (b1 == 0)
            {
                pictureBox1.Image = pictureBox2.Image;
                b1++;
            }else if (b1 == 1)
            {
                pictureBox3.Image = pictureBox2.Image;
                b1++;
            }           

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
         
        }
    }
}
