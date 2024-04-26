using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryBordigaGabriel
{
    public partial class frmJuego : Form
    {
        clsNave nave = new clsNave();
        bool moverIzquierda, moverDerecha;
        ProgressBar barraVida;
        System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        private Dictionary<Keys, bool> keys = new Dictionary<Keys, bool>();

        public frmJuego()
        {
            InitializeComponent();
            keys.Add(Keys.Space, false);
            keys.Add(Keys.Left, false);
            keys.Add(Keys.Right, false);

            


            // Crear la barra de vida
            barraVida = new ProgressBar();
            barraVida.Location = new Point(10, 10); // Posicionar la barra de vida en la parte superior izquierda
            barraVida.Width = 100;
            barraVida.Height = 20;
            barraVida.Maximum = 100;
            barraVida.Value = 100;
            this.Controls.Add(barraVida);
            System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
            timer1.Interval = 100;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
            Random rand = new Random();
            //timer2.Interval = rand.Next(2200, 3001); // Genera un número aleatorio entre 2200 y 3000

            //timer2.Enabled = true;
            //timer2.Tick += new EventHandler(timerDisparoEnemigos_Tick);
            nave.crearJugador();
            nave.imgNave.Location = new Point(this.Width / 2, this.Height - nave.imgNave.Height - 15); // Posicionar la nave en el centro abajo
            for (int i = 0; i < 4; i++)
            {
                nave.crearEnemigo("malito" + (i + 1), this);
            }

            this.Controls.Add(nave.imgNave);
            foreach (Enemigo enemigo in nave.enemigos)
            {
                enemigo.imgEnemigo.Location = enemigo.posicion;
                this.Controls.Add(enemigo.imgEnemigo);
            }
        }


        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                nave.disparar();
                this.Controls.Add(nave.balas.Last());
            }
            else if (e.KeyCode == Keys.Left)
            {
                nave.moverNave(true, 5);
            }
            else if (e.KeyCode == Keys.Right)
            {
                nave.moverNave(false, 5);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (keys.ContainsKey(e.KeyCode))
            {
                keys[e.KeyCode] = true;
            }
        }

        private void frmJuego_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblScore.Text = "SCORE: " + nave.score;
            bool b = false;

            if (nave.vida > 0)
            {
                nave.moverBalas(this, nave);
                nave.moverBalasEnemigos(this, barraVida);
            }
            else
            {
                b = true;
                timer1.Stop();
            }

            if (b)
            {
                MessageBox.Show("¡Has perdido!");
                this.Close();
                frmJuego juego = new frmJuego();
                juego.ShowDialog();

            }
            foreach (Enemigo enemigo in nave.enemigos)
            {
                Enemigo enemigoGolpeado = VerificarColisiones();
                if (enemigoGolpeado != null)
                {
                    Explosion explosion = new Explosion(enemigoGolpeado.posicion);
                    this.Controls.Add(explosion.imgExplosion);
                }
            }


        }
        private Enemigo VerificarColisiones()
        {
            foreach (PictureBox bala in nave.balas)
            {
                foreach (Enemigo enemigo in nave.enemigos)
                {
                    if (bala.Bounds.IntersectsWith(enemigo.imgEnemigo.Bounds))
                    {
                        return enemigo;
                    }
                }
            }
            return null;
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {

        }



        private void timerDisparoEnemigos_Tick(object sender, EventArgs e)
        {
            foreach (Enemigo enemigo in nave.enemigos)
            {
                PictureBox balaEnemigo = enemigo.disparar();
                this.Controls.Add(balaEnemigo);
                nave.balasEnemigos.Add(balaEnemigo);
            }



        }

        private void frmJuego_KeyUp_1(object sender, KeyEventArgs e)
        {
            
        }
    }
}
