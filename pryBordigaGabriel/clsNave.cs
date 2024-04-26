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
            imgNave.SizeMode = PictureBoxSizeMode.AutoSize;
            imgNave.ImageLocation = "../../../../Images/PicturesJuego/nave3.png";
        }

        public void crearEnemigo(string nombreEnemigo, Form form)
        {
            Random rand = new Random();
            int posicionX = rand.Next(0, form.Width - 100);
            int posicionY = rand.Next(50, 300);
            Point posicion = new Point(posicionX, posicionY); 

            string imagenEnemigo = imagenesEnemigos[rand.Next(imagenesEnemigos.Count)];

            Enemigo enemigo = new Enemigo();
            enemigo.vida = 25;
            enemigo.posicion = posicion;
            enemigo.imgEnemigo = new PictureBox();
            enemigo.imgEnemigo.SizeMode = PictureBoxSizeMode.AutoSize;
            enemigo.imgEnemigo.ImageLocation = "../../../../Images/PicturesJuego/" + imagenEnemigo;
            enemigos.Add(enemigo);

            enemigo.timerDisparo.Interval = rand.Next(2200, 3001); // Intervalo aleatorio entre 2200 y 3000 milisegundos
            enemigo.timerDisparo.Tick += (sender, e) =>
            {
                PictureBox balaEnemigo = enemigo.disparar();
                if (balaEnemigo != null)
                {
                    form.Controls.Add(balaEnemigo);
                    balasEnemigos.Add(balaEnemigo);
                    enemigo.balasEnemigo.Add(balaEnemigo); // Agrega la bala a la lista de balas del enemigo
                }
            };
            enemigo.timerDisparo.Start();

            enemigos.Add(enemigo);
        }

        public void disparar()
        {
            PictureBox bala = new PictureBox();
            bala.SizeMode = PictureBoxSizeMode.Zoom;
            bala.ImageLocation = "../../../../Images/PicturesJuego/bala2.png";
            bala.Left = imgNave.Left + imgNave.Width / 2 - bala.Width / 11; // Ajustar la posición inicial de la bala
            bala.Top = imgNave.Top;
            bala.Width = 20;
            bala.Height = 20;
            balas.Add(bala);
        }
        public int score = 0;
        public void moverBalas(Form form, clsNave nave)
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
                            enemigo.timerDisparo.Stop();
                            enemigo.timerDisparo.Dispose();
                            foreach (PictureBox balaEnemiga in enemigo.balasEnemigo)
                            {
                                form.Controls.Remove(bala);
                                balasEnemigos.Remove(bala);
                            }
                            score++;
                            // Crear una nueva explosión en la posición del enemigo
                            Point posicionExplosion = new Point(enemigo.posicion.X, enemigo.posicion.Y);
                            Explosion explosion = new Explosion(posicionExplosion);
                            form.Controls.Add(explosion.imgExplosion);

                            // Crear un temporizador para la animación de la explosión
                            System.Windows.Forms.Timer timerExplosion = new System.Windows.Forms.Timer();
                            timerExplosion.Interval = 100;
                            timerExplosion.Tick += (sender, e) =>
                            {
                                if (!explosion.NextFrame())
                                {
                                    // Si la animación de la explosión ha terminado, detén el temporizador y elimina la explosión
                                    timerExplosion.Stop();
                                    form.Controls.Remove(explosion.imgExplosion);
                                }
                            };
                            timerExplosion.Start(); // Iniciar el temporizador

                            form.Controls.Remove(enemigo.imgEnemigo);
                            enemigos.RemoveAt(j);

                            // Crear un nuevo enemigo después de eliminar al enemigo derrotado
                            string nombreEnemigo = "malito" + (enemigos.Count + 1);
                            nave.crearEnemigo(nombreEnemigo, form);
                            Enemigo nuevoEnemigo = nave.enemigos.Last();
                            nuevoEnemigo.imgEnemigo.Location = nuevoEnemigo.posicion;
                            form.Controls.Add(nuevoEnemigo.imgEnemigo);
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
                balaEnemigo.Top += 20;
                if (vida <= 0)
                {
                    
                }
                else if (balaGolpeaNave(balaEnemigo))
                {
                    vida -= 20;
                    barraVida.Value = vida;



                    form.Controls.Remove(balaEnemigo); 
                    balasEnemigos.RemoveAt(i);
                }
                
            }
        }
        public bool balaGolpeaNave(PictureBox bala)
        {
            return bala.Bounds.IntersectsWith(imgNave.Bounds);
        }

    }
}
