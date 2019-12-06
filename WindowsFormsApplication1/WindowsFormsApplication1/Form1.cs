using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<PictureBox> listaObstaculosAmarillo = new List<PictureBox>();
        Random RnTipoObstaculo = new Random();
        int Velocidad = 3;
        int AnimacionCarro1;
        public Form1()
        {
            //Inicializando los componentes del juego y por lo tanto el juego en si
            InitializeComponent();
            /*SoundPlayer simpleSound = new SoundPlayer("./Resources/back_in_black_8_bits.wav");
            simpleSound.Play();*/

            //Reproduciendo musica de fondo

            System.Media.SoundPlayer logout = new System.Media.SoundPlayer(Properties.Resources.back_in_black_8_bits);
            logout.Play();
            
            CrearObstaculo(listaObstaculosAmarillo, this, 10, 80);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            carro1.Image = (AnimacionCarro1 == 0) ? Properties.Resources.carritouno : Properties.Resources.carritouno_;
            AnimacionCarro1 = (AnimacionCarro1 == 0) ? 1 : 0;
        }

        public void CrearObstaculo(List<PictureBox> ListaElementos, Form panelJuegoUno, int distanciaUno, int distanciaDos)
        {
            int NumeroCarro = 1;
            int TipoObstaculo = RnTipoObstaculo.Next(1, 3);



            int UbicacionObstaculo = RnTipoObstaculo.Next(1, 3);

            int DIstanciaUbicaciónObstaculo = (UbicacionObstaculo == 1) ? distanciaUno : distanciaDos;

            PictureBox pb = new PictureBox();
            pb.Location = new Point(DIstanciaUbicaciónObstaculo, 0);


            pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("obstaculo" + TipoObstaculo);

            pb.BackColor = Color.Transparent;
            pb.Tag = NumeroCarro + "_" + TipoObstaculo;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            ListaElementos.Add(pb);
            panelJuegoUno.Controls.Add(pb);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox ImagenCarro in listaObstaculosAmarillo)
            {
                int MovimientoY;
                MovimientoY = ImagenCarro.Location.Y;
                MovimientoY = MovimientoY + Velocidad;
                ImagenCarro.Location = new Point(ImagenCarro.Location.X, MovimientoY);
            }

            if (listaObstaculosAmarillo.Count > 0)
            {
                if (listaObstaculosAmarillo[(listaObstaculosAmarillo.Count) - 1].Location.Y > 250)
                {
                    CrearObstaculo(listaObstaculosAmarillo, this, 10, 80);
                }
            }
            if (listaObstaculosAmarillo.Count > 0)

            {
                for (int i = 0; i < listaObstaculosAmarillo.Count; i++)
                {
                    if (listaObstaculosAmarillo[i].Location.Y > 400)
                    {
                        if (listaObstaculosAmarillo[i].Tag.ToString() == "1_1")
                        {
                            ReiniciarJuego();
                        }
                        this.Controls.Remove(listaObstaculosAmarillo[i]);
                        listaObstaculosAmarillo.Remove(listaObstaculosAmarillo[i]);
                    }
                    if (listaObstaculosAmarillo[i].Bounds.IntersectsWith(carro1.Bounds))
                    {
                        if (listaObstaculosAmarillo[i].Tag.ToString() == "1_1")
                        {
                            this.Controls.Remove(listaObstaculosAmarillo[i]);
                            int TotalPuntos = Convert.ToInt32(lblPuntos.Text) + 1;
                            if (TotalPuntos % 2 == 0)
                            {
                                Velocidad++;
                            }
                            lblPuntos.Text = TotalPuntos.ToString();

                            listaObstaculosAmarillo.Remove(listaObstaculosAmarillo[i]);
                        }
                        else
                        {
                            this.Controls.Remove(listaObstaculosAmarillo[i]);
                            listaObstaculosAmarillo.Remove(listaObstaculosAmarillo[i]);
                            ReiniciarJuego();

                        }
                    }
                }

            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int CambioCoches = (carro1.Location.X == 80) ? 10 : 80;
            carro1.Location = new Point(CambioCoches, carro1.Location.Y);
        }
        public void ReiniciarJuego()
        {
            lblPuntos.Text = "0";
            Velocidad = 3;
        }
    }
}
