using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBordigaGabriel
{

    internal class clsNave
    {
        //Características
        public int vida;
        public string nombre;
        int puntosDaño;
        public PictureBox imgNave;
        public List<Enemigo> enemigos = new List<Enemigo>();
        public List<PictureBox> balas = new List<PictureBox>();
        public List<PictureBox> balasEnemigos = new List<PictureBox>();

        public void crearJugador()
        {
            vida = 100;
            nombre = "jugador1";
            puntosDaño = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.Zoom;
            imgNave.ImageLocation = "../../../../Images/PicturesJuego/nave.png";
        }

        public void crearEnemigo(string nombreEnemigo, Form form)
        {
            Random rand = new Random();
            int posicionX = rand.Next(0, form.Width - 100); // Generar una posición X aleatoria dentro del ancho del formulario
            int posicionY = rand.Next(50, 500); // Generar una posición Y aleatoria entre 50 y 500
            Point posicion = new Point(posicionX, posicionY); // La posición Y será aleatoria (entre 50 y 500)

            string imagenEnemigo = imagenesEnemigos[rand.Next(imagenesEnemigos.Count)]; // Seleccionar una imagen de enemigo aleatoria

            Enemigo enemigo = new Enemigo();
            enemigo.vida = 25;
            enemigo.posicion = posicion; // Asignar la posición
            enemigo.imgEnemigo = new PictureBox();
            enemigo.imgEnemigo.SizeMode = PictureBoxSizeMode.Zoom;
            enemigo.imgEnemigo.ImageLocation = "../../../../Images/PicturesJuego/" + imagenEnemigo;
            enemigos.Add(enemigo);
        }

        public void disparar()
        {
            PictureBox bala = new PictureBox();
            bala.SizeMode = PictureBoxSizeMode.Zoom;
            bala.ImageLocation = "../../../../Images/PicturesJuego/bala.png";
            bala.Left = imgNave.Left + imgNave.Width / 2 - bala.Width / 9; // Ajustar la posición inicial de la bala
            bala.Top = imgNave.Top;
            bala.Width = 20;  // Ancho de la bala
            bala.Height = 20; // Altura de la bala
            balas.Add(bala);
        }

        public void moverBalas(Form form)
        {
            for (int i = balas.Count - 1; i >= 0; i--)
            {
                PictureBox bala = balas[i];
                bala.Top -= 20;
                for (int j = enemigos.Count - 1; j >= 0; j--)
                {
                    Enemigo enemigo = enemigos[j];
                    if (bala.Bounds.IntersectsWith(enemigo.imgEnemigo.Bounds))
                    {
                        enemigo.vida -= 15;
                        if (enemigo.vida <= 0)
                        {
                            form.Controls.Remove(enemigo.imgEnemigo);
                            enemigos.RemoveAt(j);
                        }
                        form.Controls.Remove(bala);
                        balas.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        public void moverNave(bool izquierda, int velocidad)
        {
            if (izquierda)
            {
                imgNave.Left -= velocidad;
            }
            else
            {
                imgNave.Left += velocidad;
            }
        }
        public List<string> imagenesEnemigos = new List<string>()
        {
            "enemigo1.png",
            "enemigo2.png",
            "enemigo3.png",
            "enemigo4.png"
        };
        public void moverBalasEnemigos(Form form, ProgressBar barraVida)
        {
            for (int i = balasEnemigos.Count - 1; i >= 0; i--)
            {
                PictureBox balaEnemigo = balasEnemigos[i];
                balaEnemigo.Top += 20; // Mover la bala hacia abajo
                if (vida <= 0)
                {
                    
                }
                else if (balaGolpeaNave(balaEnemigo))
                {
                    vida -= 20; // Reducir la vida de la nave
                    barraVida.Value = vida; // Actualizar la barra de vida

                    // Comprobar si la vida ha llegado a 0


                    form.Controls.Remove(balaEnemigo); // Eliminar la bala del formulario
                    balasEnemigos.RemoveAt(i); // Eliminar la bala de la lista de balas de los enemigos
                }
                
            }
        }
        public bool balaGolpeaNave(PictureBox bala)
        {
            return bala.Bounds.IntersectsWith(imgNave.Bounds);
        }

    }
}
