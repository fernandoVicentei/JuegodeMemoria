using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
namespace im_en_listas
{
    public partial class lbllpla1 : Form
    {
        public lbllpla1()
        {
            InitializeComponent();
        }
        public List<Image> images = new List<Image>();
        public int[] vect = new int[8];
        public int[] vect2 = new int[13];
        SoundPlayer Sound = new SoundPlayer();
        Random random = new Random();
        public int[] vVerifi = new int[13];
        public int[] Verguar = new int[13];
        public int Veri = 0;
        public int Aux = 0;
        public int Aux2 = 0;
        public int ayu = 1;
        public int ayu2 = 1;
        public int Valor_Pictur = 0;
        public int Valor_Pictur2 = 0;
        public int conta;
        public int inTENTOS = 2;
        public int VIDA = 0, Ganador = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }
        public void IniciarJuego()
        {
            Ubicacion_de_Imagenes_en_Picture();
            timer1.Start();
        }
        public void Iniciañizar_Variables()
        {
            VIDA = 0;
            inTENTOS = 2;
            vect = new int[8];
            vect2 = new int[13];
            Verguar = new int[13];
            vVerifi = new int[13];
            images = null;
            images = new List<Image>();
            Agregarimagen();
            ayu = 1;
            ayu2 = 1;
            Valor_Pictur = 0;
            conta = 0;
            timer.Text = "50".ToString();
            Valor_Pictur2 = 0;            
            PICTUVIDA.Visible = true; PICTUVID2.Visible = true;
            txtsentences.Clear();
            button3.Visible = false;
            //JUMPED.Visible = false; RUN.Visible = false; STUDIED.Visible = false; KISSED.Visible = false; DANCED.Visible = false; WALKED.Visible = false;
        }
        public void Agregarimagen()
        {
            images.Add(Properties.Resources.visita); //1
            images.Add(Properties.Resources.tra);//2
            images.Add(Properties.Resources.baile);//3
            images.Add(Properties.Resources.baille);//4
            images.Add(Properties.Resources.comer1);//5
            images.Add(Properties.Resources.trba);//6
            lblvid.Text = inTENTOS.ToString();

        }
        public int Selector_de_Imagen(int aux1)
        {
            int a = 0, b = 0;
            for (int i = aux1; i >= 0; i--)
            {
                if (i == aux1 && b == 0 && i != 0)//aux1 recibe el valor alatorio de la imagen, aux2 del picture, y aca preguntamos si i es  igual al numero de imagen y si el picturebox en pocision aux2 es  menor a 1, ya que si no  es  menor a 1 ese picture ya no esta disponible
                {
                    if (vect[aux1] < 2) { a = aux1; i = 1; vect[aux1] += 1; } else { i = 7; b = 1; }
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
                    if (vect2[aux2] < 1) { i = 1; c = aux2; vect2[aux2] = 1; } else { i = 13; c = 1; }
                }
                else if (vect2[i] < 1 && i != 0) { c = i; vect2[i] = 1; i = 1; }
            }
            return c;
        }
        public void Ubicacion_de_Imagenes_en_Picture()
        {
            int Vimag, vpictur, con = images.Count, aux = 1;
            for (int i = 0; i < 2; i++)
            {
                foreach (var item in images)
                {
                    Vimag = random.Next(1, 6);
                    vpictur = random.Next(1, 12);
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
                            break;

                    }
                    aux = 1;
                }
            }
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
            vVerifi[2] = Verguar[2]; int x = 1;
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
            vVerifi[3] = Verguar[3]; int x = 1;
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
            vVerifi[4] = Verguar[4]; int x = 1;
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
            vVerifi[5] = Verguar[5]; int x = 1;
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
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            vVerifi[7] = Verguar[7]; int x = 1;
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
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            vVerifi[6] = Verguar[6]; int x = 1;
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
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            vVerifi[8] = Verguar[8]; int x = 1;
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
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Iniciañizar_Variables();
          //  Sound.SoundLocation = @"E:\nuevo\MEMORAMA PROYECTO FINALJMFMHCMH\im en listas\Sonidos\gwkc0-4v1p8.wav";
          //  Sound.PlayLooping();
            button1.Visible = false;
            timer1.Start();
        }
        public void Verifi()//funciion para verificar si se tocaron dos picturebox, y lo que hace es verificar si las imagenes que lleva dentro son iguales o no
        {
            if (Veri == 2)
            {
                if (Aux2 == Aux && Valor_Pictur != Valor_Pictur2)
                {
                    ayu2 = 2; ayu = 1;
                    button3.Visible = true;
                    Revision_de_Orciones();
                    inTENTOS = 2; lblvid.Text = inTENTOS.ToString();
                }
                else
                {
                    for (int i = 1; i < 3; i++)
                    {
                        switch (Valor_Pictur)
                        {
                            case 1:
                                pictureBox1.Image = Properties.Resources.PortadaNueva1;
                                break;
                            case 2:
                                pictureBox2.Image = Properties.Resources.PortadaNueva1;
                                break;
                            case 3:
                                pictureBox3.Image = Properties.Resources.PortadaNueva1;
                                break;
                            case 4:
                                pictureBox4.Image = Properties.Resources.PortadaNueva1;
                                break;
                            case 5:
                                pictureBox5.Image = Properties.Resources.PortadaNueva1;
                                break;
                            case 6:
                                pictureBox6.Image = Properties.Resources.PortadaNueva1;
                                break;
                            case 7:
                                pictureBox7.Image = Properties.Resources.PortadaNueva1;
                                break;
                            case 8:
                                pictureBox8.Image = Properties.Resources.PortadaNueva1;
                                break;
                            case 9:
                                pictureBox9.Image = Properties.Resources.PortadaNueva1;
                                break;
                            case 10:
                                pictureBox10.Image = Properties.Resources.PortadaNueva1;
                                break;
                            case 11:
                                pictureBox11.Image = Properties.Resources.PortadaNueva1;
                                break;
                            case 12:
                                pictureBox12.Image = Properties.Resources.PortadaNueva1;
                                    break;
                        }
                        Valor_Pictur = Valor_Pictur2;
                    }
                }
                Veri = 0;
            }
            else if (Veri == 1) { Aux2 = Aux; Valor_Pictur2 = Valor_Pictur; }
            conta = 50; timer.Text = conta.ToString();
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            vVerifi[11] = Verguar[11]; int x = 1;
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
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            vVerifi[9] = Verguar[9]; int x = 1;
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
            vVerifi[10] = Verguar[10]; int x = 1;
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
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            vVerifi[12] = Verguar[12]; int x = 1;
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
        public void Revision_de_Orciones()
        {
            int con = 1;
            foreach (var imge in images)
            {
                if (con == Aux2)
                {
                    pictureVIsor.Image = imge;
                    timer2.Start();
                    conta = 50;
                }
                con++;
            }
            button3.Visible = true;
            if (Aux2 == 1)
            {
                labeloraion.Text = "THEY VISITED MY HOUSE  LAST WEEK".ToString();
            }
            else if (Aux2 == 2)
            {
                labeloraion.Text = "I WORKED HARD LAST MONTH".ToString();

            }
            else if (Aux2 == 3)
            {
                labeloraion.Text = "MARIO WENT TO A PARTY THE LAST NIGHT".ToString();
            }
            else if (Aux2 == 4)
            {
                labeloraion.Text = "THEY  WENT TO THE PARTY VERY LATE".ToString();
            }
            else if (Aux2 == 5)
            {
                labeloraion.Text = "PATRICIO ATE HAMBURGERS IN THE MORNING".ToString();
            }
            else if (Aux2 == 6)
            {
                labeloraion.Text = "ZAYN  WORKED IN THE OFFICE LAST FRIDAY".ToString();
            }
        }
        private void pictureVIsor_Click(object sender, EventArgs e)
        {

        }
        public bool Control_Sentences(int a)
        {
            int VERISH = 0; string letrayud = "";
            if (Aux2 == 1)
            {
                letrayud = ControlPalabra();
                if (letrayud.Equals("ELLOS VISITARON MI CASA LA SEMANA PASADA ") || letrayud.Equals("ELLOS VISITARON MI CASA LA SEMANA PASADA ")|| letrayud.Equals("ELLOS VISITARON MI CASA LA ANTERIOR SEMANA ")|| letrayud.Equals("ELLOS VISITARON MI CASA LA ANTERIOR SEMANA") == true) { VERISH = 1; } else { VERISH = 2; }
            }
            else if (Aux2 == 2)
            {
                letrayud = ControlPalabra();
                if (letrayud.Equals("YO TRABAJE DURO EL ULTIMO MES") || letrayud.Equals("YO TRABAJE DURO EL ULTIMO MES ")|| letrayud.Equals("YO TRABAJE DURO EL MES PASADO ")|| letrayud.Equals("YO TRABAJE DURO EL MES PASADO")|| letrayud.Equals("YO TRABAJE DURO EL ANTERIOR MES ")|| letrayud.Equals("YO TRABAJE DURO EL ANTERIOR MES") == true) { VERISH = 1; } else { VERISH = 2; }
            }
            else if (Aux2 == 3)
            {
                letrayud = ControlPalabra();
                if (letrayud.Equals("MARIO FUE A UNA FIESTA LA NOCHE PASADA") || letrayud.Equals("MARIO FUE A UNA FIESTA LA NOCHE PASADA ")|| letrayud.Equals("MARIO FUE A UNA FIESTA LA ANTERIOR NOCHE")|| letrayud.Equals("MARIO FUE A UNA FIESTA LA ANTERIOR NOCHE ") == true) { VERISH = 1; } else { VERISH = 2; }
            }
            else if (Aux2 == 4)
            {
                letrayud = ControlPalabra();
                if (letrayud.Equals("ELLOS FUERON A LA FIESTA MUY TARDE") || letrayud.Equals("ELLOS FUERON A LA FIESTA MUY TARDE ") == true) { VERISH = 1; } else { VERISH = 2; }
            }
            else if (Aux2 == 5)
            {
                letrayud = ControlPalabra();
                if (letrayud.Equals("PATRICIO COMIO HAMBURGUESAS EN LA MAÑANA") || letrayud.Equals("PATRICIO COMIO HAMBURGUESAS EN LA MAÑANA ") == true) { VERISH = 1; } else { VERISH = 2; }
            }
            else if (Aux2 == 6)
            {
                letrayud = ControlPalabra();
                if (letrayud.Equals("ZAYN TRABAJÓ EN LA OFICINA EL ÚLTIMO VIERNES") || letrayud.Equals("ZAYN TRABAJÓ EN LA OFICINA EL ÚLTIMO VIERNES ") == true) { VERISH = 1; } else { VERISH = 2; }
            }
            if (VERISH == 1) { return true; } else { return false; }

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            conta--;           
            timer.Text = conta.ToString();
            if (conta <= 0)
            { pictureVIsor.Image = null;
                txtsentences.Clear();
                labeloraion.Text = null;
                button3.Visible = false;
                Veri = 2; Aux2 = 0; Aux = 1; Verifi();//INVENTAMOS ESTOS VALORES PARA QUE LAS CARTAS   SE VOLTEEN, SI POR EJEMMPLO EL NO PRESIONARIA EL BOTON PARA ENVIAR ENTONCES EL PROGRAMA VOLTEARA AUTOMATICAMENTE LAS CARTAS 
                timer2.Stop();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            IniciarJuego();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (Control_Sentences(Aux2) == true)//EVALUAMOS SI LA FUNCION NOS RETORNO TRUE SI LA ORACION ES CORRECTA , SINO  SERA FALSE
            {
                timer2.Stop();
                MessageBox.Show(" CORRECTO ");
                conta = 50; timer.Text = conta.ToString();
                txtsentences.Clear();               
                Ganador++;
                button3.Visible = false;
                WINNER_GAME();
            }
            else
            {
                inTENTOS--;
                lblvid.Text = inTENTOS.ToString();
                
                if (inTENTOS == 0)
                {
                    VIDA++;
                    if (VIDA == 1)
                    {
                        PICTUVIDA.Visible = false;
                        Aux2 = 0;
                        Veri = 2;
                        Verifi(); txtsentences.Clear();
                        pictureVIsor.Image = null;
                        timer2.Stop();
                        button3.Visible = false;
                    }
                    else if (VIDA == 2)
                    {
                        PICTUVID2.Visible = false;
                        timer1.Stop();
                        timer2.Stop();
                        button1.Visible = true;
                        Perdiste();
                    }
                }
            }
        }
        private void lblganaste_Click(object sender, EventArgs e)
        {

        }
        private void txtsentences_TextChanged(object sender, EventArgs e)
        {

        }
        public void WINNER_GAME()
        {
            if (Ganador == 6)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureVIsor.Visible = false;
                PICTUVIDA.Visible = false; PICTUVID2.Visible = false;
                lblvid.Visible = false; PICTUVID2.Visible = false;
                PICTUVIDA.Visible = false;
                labeloraion.Visible = false;
                pictureBox14.Visible = false;
                pictureBox13.Visible = false;
                timer.Visible = false;
                label5.Visible = false;
                lblvid.Visible = false;
                //label11.Visible = false;
                txtsentences.Visible = false;
                pictureBox17.Visible = false;
                BackColor = Color.Black;
                pictureBox16.Visible = false;
                label1.Visible = false;
                button3.Visible = false;
                BackgroundImage = null;
                BackColor = Color.Black;
                //pictureBox15.Image = Properties.Resources.GIFFELIZ;
                lblganaste.Visible = true;
                btnreincii.Visible = true;
                button2.Visible = true;
               
            }
        }
        public string ControlPalabra()
        {
            string subp = "", uniora = "";
            int loongi = 0, controlador = 0;
            string ora = Convert.ToString(txtsentences.Text);
            loongi = ora.Length;
            for (int i = 0; i < loongi; i++)
            {
                subp = ora.Substring(i, 1);
                if (subp != " ")
                {
                    uniora = uniora + subp; controlador = 0; 
                }
                else if (subp != ")" && subp != "("&&controlador<=1)
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
        public void Perdiste()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureVIsor.Visible = false;          
            lblvid.Visible = false; PICTUVID2.Visible = false;
            PICTUVIDA.Visible = false;
            labeloraion.Visible = false;
            pictureBox14.Visible = false;
            pictureBox13.Visible = false;
            timer.Visible = false;
            label5.Visible = false;
            lblvid.Visible = false;
            //label11.Visible = false
            pictureBox17.Visible = false;
            pictureBox14.Visible=false;
            txtsentences.Visible = false;
            pictureBox16.Visible = false;
            BackColor = Color.Black;
            pictureBox15.Visible = true;
            button3.Visible = false;
            label1.Visible = false;
            BackgroundImage = null;
            BackColor = Color.Black;
            pictureBox15.Image = Properties.Resources.perdiste_el_juego_gif_1;
            button2.Visible = true;
            lblganaste.Visible = true;
            button1.Visible = false;
            lblganaste.Text = "               You Lost ".ToString();
            btnreincii.Visible = true;          
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }
        private void btnreincii_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Pictures_Vacios();
            Reinicio_Variables();           
            Iniciañizar_Variables();
           // Sound.SoundLocation = @"G:\TRABAJOS WINDOWSFORMS\MEMORAMA PROYECTO FINALJMFMHCMH\im en listas\Sonidos\gwkc0-4v1p8.wav";
           // Sound.PlayLooping();
            button2.Visible = false;
            btnreincii.Visible = false;
            button2.Visible = false;
            timer1.Start();
        }
        public void Pictures_Vacios()
        {
            pictureBox1.Image = Properties.Resources.PortadaNueva1;
            pictureBox2.Image = Properties.Resources.PortadaNueva1;
            pictureBox3.Image = Properties.Resources.PortadaNueva1;
            pictureBox4.Image = Properties.Resources.PortadaNueva1;
            pictureBox5.Image = Properties.Resources.PortadaNueva1;
            pictureBox6.Image = Properties.Resources.PortadaNueva1;
            pictureBox7.Image = Properties.Resources.PortadaNueva1;
            pictureBox8.Image = Properties.Resources.PortadaNueva1;
            pictureBox9.Image = Properties.Resources.PortadaNueva1;
            pictureBox10.Image = Properties.Resources.PortadaNueva1;
            pictureBox11.Image = Properties.Resources.PortadaNueva1;
            pictureBox12.Image = Properties.Resources.PortadaNueva1;
        }

        private void JUMPED_Click(object sender, EventArgs e)
        {

        }

        private void WALKED_Click(object sender, EventArgs e)
        {

        }

        private void STUDIED_Click(object sender, EventArgs e)
        {

        }

        private void KISSED_Click(object sender, EventArgs e)
        {

        }

        private void RUN_Click(object sender, EventArgs e)
        {

        }

        private void DANCED_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void Reinicio_Variables()
        {
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
            pictureVIsor.Image = null;
            pictureBox16.Visible = true;
            pictureVIsor.Visible = true;
            PICTUVIDA.Visible = true; PICTUVID2.Visible = true;
            lblvid.Visible = true;
            button2.Visible = true;
            labeloraion.Visible = true;
            pictureBox14.Visible = true;
            pictureBox13.Visible = true;
            pictureBox15.Visible = false;
            timer.Visible = true;
            label5.Visible = true;
            lblvid.Visible = true;
            label1.Visible = true;
            pictureBox14.Visible = true;
            pictureBox17.Visible = true;
            timer2.Stop();
            txtsentences.Visible = true;
            BackgroundImage = Properties.Resources.IMG_20190130_WA0015;
            button2.Visible = true;
            //pictureBox15.Visible = true;
            button3.Visible = false;           ;
            //pictureBox15.Visible = false;
            lblganaste.Visible = false;
            
        }
    }
}
