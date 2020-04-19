using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace im_en_listas
{
    public partial class MemoramaPro : Form
    {
        public MemoramaPro()
        {
            InitializeComponent();
        }        
        public MemoramaPro(string nom1,string nom2,int im1,int im2)
        {            
            InitializeComponent();
            lblnombre1.Text = nom1.ToUpper();
            lblnombre2.Text = nom2.ToUpper();
            imag1 = im1;
            imag2 = im2;
        }
        public List<Image> images = new List<Image>();
        SoundPlayer sound = new SoundPlayer();
        public int[] vect = new int[9];
        public int[] vect2 = new int[17];
        Random random = new Random();
        public int[] vVerifi = new int[17];
        public int[] Verguar = new int[17];
        public int Veri = 0;
        public int Aux = 0;
        public int Aux2 = 0;
        public int ayu = 1;
        public int ayu2 = 1;
        public int Valor_Pictur = 0;
        public int Valor_Pictur2 = 0;
        public int conta;
        public int inTENTOS = 2;
        public int Ganador = 0;
        public int Play1, Play2 = 0;
        public int ayud = 0, ay = 0;
        public int yudita = 1, playpunt1, playpunt2 = 0;
        public int Falla1, Falla2 = 0;
        public string num, num2 = "";
        public int imag1 = 0, imag2 = 0;
        public int GAN = 0;
        
        private void MemoramaPro_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }
        public void Star_Game()
        {
            Ubicacion_de_Imagenes_en_Picture();            
            timer1.Start();
        }        
        public void Inicializar_Variables()
        {            
            inTENTOS = 2;
            vect = new int[9];
            vect2 = new int[17];
            Verguar = new int[17];
            vVerifi = new int[17];
            images = null;
            images = new List<Image>();
            Agregarimagen();            
            txtplay1.Visible = false;
            btnenviar.Visible = false;
            yudita = 1;
            playpunt1 = 0; playpunt2 = 0;
            lblpuntos1.Text = playpunt1.ToString(); lblpuntos2.Text = playpunt2.ToString();
            Encontrados1.Text = null;
            Encontrados2.Text = null;
            Play1 = 0;Play2 = 0; playpunt1 = 0; playpunt2 = 0;
            ayu = 1; Falla1 = 0; Falla2 = 0;
            ayu2 = 1;
            Valor_Pictur = 0;
            conta = 0;
            lbltimer.Text = conta.ToString();
            Valor_Pictur2 = 0;          
        }              
        public void Agregarimagen()
        {
            images.Add(Properties.Resources.arquera); //1
            images.Add(Properties.Resources.bebedragon);//2
            images.Add(Properties.Resources.esqueletogigante);//3
            images.Add(Properties.Resources.esqueleto);//4
            images.Add(Properties.Resources.grandulonduende);//5
            images.Add(Properties.Resources.montapuercos);//6
            images.Add(Properties.Resources.BRUJ5);
            images.Add(Properties.Resources.esdragoninfernl);
            Perfil_Jugador();            
        }
        public void Perfil_Jugador()
        {
            for (int i = 0; i < 8; i++)
            {
                if (imag1 == i)
                {
                    player1.Image = imageList1.Images[i];
                }
                if (imag2 == i)
                {
                    player2.Image = imageList1.Images[i];
                }
            }
        }
        public int Selector_de_Imagen(int aux1)
        {
            int a = 0, b = 0;
            for (int i = aux1; i >= 0; i--)
            {
                if (i == aux1 && b == 0 && i != 0)//aux1 recibe el valor alatorio de la imagen, aux2 del picture, y aca preguntamos si i es  igual al numero de imagen y si el picturebox en pocision aux2 es  menor a 1, ya que si no  es  menor a 1 ese picture ya no esta disponible
                {
                    if (vect[aux1] < 2) { a = aux1; i = 1; vect[aux1] += 1; } else { i = 9; b = 1; }
                }
                else if (vect[i] < 2 && i != 0)
                {
                    a = i;
                    vect[i] += 1; i = 1;
                }
            }
            return a;
        }
        public int Selector_de_Picture(int aux2)
        {
            int c = 0;
            for (int i = aux2; i >= 0; i--)
            {
                if (i == aux2 && c == 0 && i != 0)
                {
                    if (vect2[aux2] < 1) { i = 1; c = aux2; vect2[aux2] = 1; } else { i = 17; c = 1; }
                }
                else if (vect2[i] < 1 && i != 0) { c = i; vect2[i] = 1; i = 1; }
            }
            return c;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {            
            Star_Game();
        }
        private void btnincip_Click(object sender, EventArgs e)
        {
            timer1.Stop();            
            Inicializar_Variables();
          //  sound.SoundLocation = @"G:\TRABAJOS WINDOWSFORMS\MEMORAMA PROYECTO FINALJMFMHCMH\im en listas\Sonidos\wr7q1-hexbk.wav";
          //  sound.PlayLooping();
            play1pic.Visible = true;           
            play2pict.Visible = false;
            btnincip.Visible = false;
            timer2.Stop();
            timer1.Start();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[1] = Verguar[1];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[1])
                    {
                        pictureBox1.BackgroundImage = null;
                        pictureBox1.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[1]; Valor_Pictur = 1;
            Verifi();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[2] = Verguar[2];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[2])
                    {
                        pictureBox2.BackgroundImage = null;
                        pictureBox2.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[2]; Valor_Pictur = 2;
            Verifi();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[3] = Verguar[3];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[3])
                    {
                        pictureBox3.BackgroundImage = null;
                        pictureBox3.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[3]; Valor_Pictur = 3;
            Verifi();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[4] = Verguar[4];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[4])
                    {
                        pictureBox4.BackgroundImage = null;
                        pictureBox4.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[4]; Valor_Pictur = 4;
            Verifi();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[5] = Verguar[5];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[5])
                    {
                        pictureBox5.BackgroundImage = null;
                        pictureBox5.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[5]; Valor_Pictur = 5;
            Verifi();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[6] = Verguar[6];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[6])
                    {
                        pictureBox6.BackgroundImage = null;
                        pictureBox6.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[6]; Valor_Pictur = 6;
            Verifi();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[7] = Verguar[7];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[7])
                    {
                        pictureBox7.BackgroundImage = null;
                        pictureBox7.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[7]; Valor_Pictur = 7;
            Verifi();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[8] = Verguar[8];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[8])
                    {
                        pictureBox8.BackgroundImage = null;
                        pictureBox8.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[8]; Valor_Pictur = 8;
            Verifi();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[9] = Verguar[9];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[9])
                    {
                        pictureBox9.BackgroundImage = null;
                        pictureBox9.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[9]; Valor_Pictur = 9;
            Verifi();
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[10] = Verguar[10];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[10])
                    {
                        pictureBox10.BackgroundImage = null;
                        pictureBox10.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[10]; Valor_Pictur = 10;
            Verifi();
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[11] = Verguar[11];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[11])
                    {
                        pictureBox11.BackgroundImage = null;
                        pictureBox11.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[11]; Valor_Pictur = 11;
            Verifi();
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[12] = Verguar[12];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[12])
                    {
                        pictureBox12.BackgroundImage = null;
                        pictureBox12.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[12]; Valor_Pictur = 12;
            Verifi();
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[13] = Verguar[13];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[13])
                    {
                        pictureBox13.BackgroundImage = null;
                        pictureBox13.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[13]; Valor_Pictur = 13;
            Verifi();
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[14] = Verguar[14];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[14])
                    {
                        pictureBox14.BackgroundImage = null;
                        pictureBox14.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[14]; Valor_Pictur = 14;
            Verifi();
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[15] = Verguar[15];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[15])
                    {
                        pictureBox15.BackgroundImage = null;
                        pictureBox15.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[15]; Valor_Pictur = 15;
            Verifi();
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            int x = 1; vVerifi[16] = Verguar[16];
            if (ayu == 1)
            {
                foreach (var img in images)
                {
                    if (x == vVerifi[16])
                    {
                        pictureBox16.BackgroundImage = null;
                        pictureBox16.Image = img;
                    }
                    x++;
                }
            }
            Veri++; Aux = vVerifi[16]; Valor_Pictur = 16;
            Verifi();
        }
        public void Ubicacion_de_Imagenes_en_Picture()
        {
            int Vimag, vpictur, con = images.Count;
            for (int i = 0; i < 3; i++)
            {
                foreach (var item in images)
                {
                    Vimag = random.Next(1, 8);
                    vpictur = random.Next(1, 16);
                    Vimag = Selector_de_Imagen(Vimag);
                    vpictur = Selector_de_Picture(vpictur);
                    switch (vpictur)
                    {
                        case 1:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 2:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 3:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 4:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 5:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 6:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 7:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 8:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 9:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 10:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 11:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 12:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        default:
                        case 13:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 14:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 15:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                        case 16:
                            if (Verguar[vpictur] < 1)
                            {
                                Verguar[vpictur] = Vimag;
                            }
                            break;
                    }                    
                }
            }
        }
        public void Verifi()//funciion para verificar si se tocaron dos picturebox, y lo que hace es verificar si las imagenes que lleva dentro son iguales o no
        {            
            if (Veri == 2)
            {
                if (Aux2 == Aux && Valor_Pictur != Valor_Pictur2)
                {
                    if (yudita == 1)
                    {                                     
                        ayud = 1; Player_One();
                        lblnombre.Location = new Point(80, 333);
                        Determination_Cuestions(Aux2); lbllpregun1.Location = new Point(15, 73);//aca lo que se hace es cambiar la ubicacion para no tener que utilizar doble pictures o label  para cada jugador, sino  con uno  vasta, de acuerdo asu turno  se cambiara la pocision de estos objetos a su lado
                        pictupiza.Location = new Point(8, 110);
                        picturecuestions.Location = new Point(17, 120);
                        txtplay1.Location = new Point(8, 367);
                        btnenviar.Location = new Point(17, 405);
                    }
                    else { ay = 0;                        
                        Player_Two();
                        Determination_Cuestions(Aux2); lbllpregun1.Location=new Point(859, 65);
                        lblnombre.Location = new Point(1052, 327);
                        pictupiza.Location = new Point(978, 89);
                        picturecuestions.Location = new Point(987, 99);
                        txtplay1.Location = new Point(956, 353);
                        btnenviar.Location=new Point(1045, 392);
                    }
                    NombreImag(Aux2);                  
                    ayu2 = 2; ayu = 1;
                    conta = 50; lbltimer.Text = conta.ToString();
                    txtplay1.Visible = true; btnenviar.Visible = true;
                    timer2.Start();
                }
                else
                {
                    for (int i = 1; i < 3; i++)
                    {
                        switch (Valor_Pictur)
                        {
                            case 1:
                                pictureBox1.Image = Properties.Resources.car__2_;
                                break;
                            case 2:
                                pictureBox2.Image = Properties.Resources.car__2_;
                                break;
                            case 3:
                                pictureBox3.Image = Properties.Resources.car__2_;
                                break;
                            case 4:
                                pictureBox4.Image = Properties.Resources.car__2_;
                                break;
                            case 5:
                                pictureBox5.Image = Properties.Resources.car__2_;
                                break;
                            case 6:
                                pictureBox6.Image = Properties.Resources.car__2_;
                                break;
                            case 7:
                                pictureBox7.Image = Properties.Resources.car__2_;
                                break;
                            case 8:
                                pictureBox8.Image = Properties.Resources.car__2_;
                                break;
                            case 9:
                                pictureBox9.Image = Properties.Resources.car__2_;
                                break;
                            case 10:
                                pictureBox10.Image = Properties.Resources.car__2_;
                                break;
                            case 11:
                                pictureBox11.Image = Properties.Resources.car__2_;
                                break;
                            case 12:
                                pictureBox12.Image = Properties.Resources.car__2_;
                                break;
                            case 13:
                                pictureBox13.Image = Properties.Resources.car__2_;
                                break;
                            case 14:
                                pictureBox14.Image = Properties.Resources.car__2_;
                                break;
                            case 15:
                                pictureBox15.Image = Properties.Resources.car__2_;
                                break;
                            case 16:
                                pictureBox16.Image = Properties.Resources.car__2_;
                                break;
                        }
                        Valor_Pictur = Valor_Pictur2;
                    }
                    if (yudita == 0)
                    {
                        ay = 1; Player_One();
                    }
                    else { ayud = 0;                    
                        Player_Two(); }
                }
                Veri = 0;
            }
            else if (Veri == 1) { Aux2 = Aux; Valor_Pictur2 = Valor_Pictur; }
            conta = 50;
            ayu2 = 2; ayu = 1;           
        }
        public void Player_One()
        {           
            play1pic.Visible = true;
            play2pict.Visible = false;
            yudita = 1;
        }
        public void Player_Two()
        {           
           play1pic.Visible = false;
           play2pict.Visible = true;
            yudita = 0;
        }
        public void NombreImag(int nume)
        {
            switch (nume)
            {
                case 1:lblnombre.Text = "an Arrow".ToString();
                    break;
                case 2:lblnombre.Text = "very  happy".ToString();
                    break;
                case 3:lblnombre.Text = "a bomb".ToString();
                    break;
                case 4:
                    lblnombre.Text = "a bomb".ToString();
                    break;
                case 5:lblnombre.Text = "two goblins".ToString();
                    break;
                case 6: lblnombre.Text = "a pig".ToString();
                    break;
                case 7: lblnombre.Text = "rats soup".ToString();
                    break;
                case 8: lblnombre.Text = "a helmet".ToString();
                    break;
            }
        }
        public void Empates()
        {
            MessageBox.Show(" empates");
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            conta--;
            lbltimer.Text = conta.ToString();
            if (conta == 0)
            {
                Visible_false();
                Veri = 2; Aux2 = 0; Verifi();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string conres = "";
            string conten = ControlPalabra();
            if (Control_Sentences(Aux2, conten)==true)
            {
                GAN++;
                if (yudita == 1)
                {
                    playpunt1 += 10; Play1++;
                    lblpuntos1.Text = playpunt1.ToString();  //los emojis que se mostrarn podrian estar en una lista    
                    //pictuemoji1.Image = imageList1.Images[6];                    
                }else if (yudita == 0)
                {
                    playpunt2 += 10;  Play2++;
                    lblpuntos2.Text = playpunt2.ToString();
                    //pictuemoji2.Image = imageList1.Images[6];
                }
                if (yudita == 1)
                {
                    conres = Pal(Aux2);
                    Encontrados1.Items.Add(conres);
                }
                else
                {
                    conres = Pal(Aux2);
                    Encontrados2.Items.Add(conres);
                }
                if (GAN == 8)
                {
                    if (playpunt1 == playpunt2 && playpunt2 == 6)
                    {
                        Empates();
                        btnreincia.Visible = true;
                    }
                    else if (playpunt1 > playpunt2)
                    {
                        label6.Visible = true; label6.Location = new Point(152, 120);
                        label5.Visible = true; label5.Location = new Point(800, 120);
                        pictureBox18.Visible = true;
                        pictureBox18.Image = Properties.Resources.picper__3_;
                        Perdiste();
                    }else
                    {
                        label6.Visible = true; label6.Location = new Point(800,120);
                        label5.Visible = true; label5.Location = new Point(152, 120);
                        pictureBox18.Visible = true;
                        pictureBox18.Image = Properties.Resources.picper__3_;
                        Perdiste();
                    }
                }
                Visible_false();
            }
            else
            {
                Visible_false();
                if (yudita == 1)
                {
                    playpunt1 -= 10;  Falla1++;
                    lblpuntos1.Text = playpunt1.ToString();
                }
                else if (yudita == 0)
                {
                    playpunt2 -= 10;  Falla2++;
                    lblpuntos2.Text = playpunt2.ToString();
                }
                if (Falla1 == 5)
                {
                    pictureBox18.Visible = true;
                    pictureBox18.Image = Properties.Resources.picgana__3_;
                    label5.Visible = true; label5.Location=new Point(152, 120);
                    label6.Visible = true; label6.Location = new Point(800, 120);
                    Perdiste();
                }
                else if (Falla2 == 5)
                {
                    pictureBox18.Visible = true;
                    pictureBox18.Image = Properties.Resources.picper__4_;
                    label5.Visible = true; label5.Location = new Point(800, 120);
                    label6.Visible = true; label6.Location = new Point(152, 120);
                    Perdiste();
                }
                Veri = 2; Aux2 = 0; Verifi(); 
            }           
            if (Play1 == Play2 && playpunt1 == playpunt2 && Play1 == 4)
            {
                Empates();
                timer2.Stop();
                timer1.Stop();
            }
        }
        public void Determination_Cuestions(int nume)
        {
            string senten = ""; int ayu = 1;
            switch (nume)
            {
                case 1:senten = "¿What did the archer launch with the bow?";
                    lbllpregun1.Text = senten.ToString();
                    break;
                case 2:senten = "¿How did the baby dragon fly?";
                    lbllpregun1.Text = senten.ToString();
                    break;
                case 3:senten = "¿What did the skeleton grab in the hand?";
                    lbllpregun1.Text = senten.ToString();
                    break;
                case 4:senten = "¿What did the skeleton embrace?";
                    lbllpregun1.Text = senten.ToString();
                    break;
                case 5:senten = "¿What did the troll carry on his back?";
                    lbllpregun1.Text = senten.ToString();
                    break;
                case 6:senten = "¿What did the montapuercos ride?";
                    lbllpregun1.Text = senten.ToString();
                    break;
                case 7:senten = "¿What did the witch cook?";
                    lbllpregun1.Text = senten.ToString();
                    break;
                case 8:senten = "¿What did the baby dragon carry on his head?";
                    lbllpregun1.Text = senten.ToString();
                    break;
            }
            foreach (var ime in images)
            {
                if (ayu == nume)
                {
                    picturecuestions.Image = ime;
                }
                ayu++;
            }
        }
        public bool Control_Sentences(int nume, string respuest)
        {
            int aux = 0;
            switch (nume)
            {
                case 1: if(respuest.Equals("THE ARCHER LAUNCHED WITH THE BOW AN ARROW")|| respuest.Equals("THE ARCHER LAUNCHED WITH THE BOW AN ARROW ") == true) { aux = 1; } else { aux = 2; }
                    break;
                case 2: if(respuest.Equals("THE BABY DRAGON FLEW VERY HAPPY")||txtplay1.Text.Equals("THE BABY DRAGON FLEW VERY HAPPY ") == true) { aux = 1; }else { aux = 2; }
                    break;
                case 3: if(respuest.Equals("THE SKELETON GRABBED IN THE HAND A BOMB")|| respuest.Equals("THE SKELETON GRABBED IN THE HAND A BOMB ") == true) { aux = 1; } else { aux = 2; }
                    break;
                case 4:  if(respuest.Equals("THE SKELETON EMBRACED A BOMB")|| respuest.Equals("THE SKELETON EMBRACED A BOMB ") == true) { aux = 1; } else { aux = 2; }
                    break;
                case 5: if(respuest.Equals("THE TROLL CARRIED ON HIS BACK TWO GOBLINS")|| respuest.Equals("THE TROLL CARRIED ON HIS BACK TWO GOBLINS ") == true) { aux = 1; }else { aux = 2; }
                    break;
                case 6: if(respuest.Equals("THE MONTAPUERCOS RODE A PIG")|| respuest.Equals("THE MONTAPUERCOS RODE A PIG ") == true) { aux = 1; } else { aux = 2; }
                    break;
                case 7: if(respuest.Equals("THE WITCH COOKED RATS SOUP") || respuest.Equals("THE WITCH COOKED RATS SOUP ") == true) { aux = 1; } else { aux = 2; }
                    break;
                case 8: if(respuest.Equals("THE BABY DRAGON CARRIED ON HIS HEAD A HELMET")|| respuest.Equals("THE BABY DRAGON CARRIED ON HIS HEAD A HELMET ") == true) { aux = 1; } else { aux = 2; }
                    break;                                   
            }
            if (aux == 1)
            {
                return true;
            }else{ return false; }
        }
        public string ControlPalabra()
        {
            string subp = "", uniora = "";
            int loongi = 0, controlador = 0;
            string ora = Convert.ToString(txtplay1.Text);
            loongi = ora.Length;
            for (int i = 0; i < loongi; i++)
            {
                subp = ora.Substring(i, 1);
                if (subp != " ")
                {
                    uniora = uniora + subp; controlador = 0;
                }
                else if (subp != ")" && subp != "(" && controlador <= 1)
                {
                    controlador = 1;//esta variable la cree en si para que me controle el numero de espacios, y solo aceptar un espaio
                    uniora = uniora + " ";
                }
                controlador++;
            }
            subp = "";
            subp = uniora.ToUpper();
            return subp;
        }

        private void lblnombre1_Click(object sender, EventArgs e)
        {

        }

        private void picturecuestions_Click(object sender, EventArgs e)
        {

        }
        private void btnreinicio_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Pictures_Vacios();
        //    sound.SoundLocation = @"G:\TRABAJOS WINDOWSFORMS\MEMORAMA PROYECTO FINALJMFMHCMH\im en listas\Sonidos\wr7q1-hexbk.wav";
        //    sound.PlayLooping();
            Reinicio_Objetos();
            Inicializar_Variables();
            btnreincia.Visible = false;
           
            timer1.Start();
        }
        public string Pal(int nume)
        {
            string pala = "";
            switch (nume)
            {
                case 1: pala = " LAUNCHED ";
                    break;
                case 2: pala = " FLEW ";
                    break;
                case 3: pala = " GRABBED ";
                    break;
                case 4: pala = "EMBRACED ";
                    break;
                case 5: pala = "CARRIED ";
                    break;
                case 6: pala = " RODE ";
                    break;
                case 7: pala = "COOKED";
                    break;
                case 8: pala = "CARRIED";
                    break;
            }
            return pala; 
        }
        public void Perdiste()
        {
            timer1.Stop();
            timer2.Stop();
            this.BackColor = Color.Black;
            pictureBox1.Visible=false;
            pictureBox2.Visible=false;
            pictureBox3.Visible=false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            label3.Visible = false; label4.Visible = false;            
            txtplay1.Visible = false;
            btnincip.Visible = true;
            Encontrados1.Visible = false; Encontrados2.Visible = false;
            btnincip.Visible = false;
            btnreincia.Visible = true;
            play1pic.Visible = false;
            play2pict.Visible = false;
            player1.Location = new Point(108,353);
            player2.Location = new Point(1109,353);
            pictupiza.Visible = false;
            play1pic.Visible = false;
            play2pict.Visible = false;
        }
        public void Visible_false()
        {
            timer2.Stop();
            conta = 50; lbltimer.Text = conta.ToString();
            txtplay1.Clear(); txtplay1.Visible = false;
            picturecuestions.Image = null;
            lbllpregun1.Text = ""; lblnombre.Text = "";
            btnenviar.Visible = false;
        }
        public void Reinicio_Objetos()
        {
            this.BackColor = Color.DarkRed;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            label3.Visible = true;  label4.Visible = true;
            Encontrados1.Visible = true; Encontrados2.Visible = true;
            pictureBox18.Visible = false;
            player1.Location = new Point(17, 565);
            player2.Location = new Point(1134, 565);
            label5.Visible = false;
            label6.Visible = false;
            pictupiza.Visible = true;
        }
        public void Pictures_Vacios()
        {
            pictureBox1.Image = Properties.Resources.car__2_;
            pictureBox2.Image = Properties.Resources.car__2_;
            pictureBox3.Image = Properties.Resources.car__2_;
            pictureBox4.Image = Properties.Resources.car__2_;
            pictureBox5.Image = Properties.Resources.car__2_;
            pictureBox6.Image = Properties.Resources.car__2_;
            pictureBox7.Image = Properties.Resources.car__2_;
            pictureBox8.Image = Properties.Resources.car__2_;
            pictureBox9.Image = Properties.Resources.car__2_;
            pictureBox10.Image = Properties.Resources.car__2_;
            pictureBox11.Image = Properties.Resources.car__2_;
            pictureBox12.Image = Properties.Resources.car__2_;
            pictureBox13.Image = Properties.Resources.car__2_;
            pictureBox14.Image = Properties.Resources.car__2_;
            pictureBox15.Image = Properties.Resources.car__2_;
            pictureBox16.Image = Properties.Resources.car__2_;
        }
    }
}
