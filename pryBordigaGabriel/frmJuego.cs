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

        public frmJuego()
        {
            InitializeComponent();
            InitializeComponent();

            // Crear la barra de vida
            barraVida = new ProgressBar();
            barraVida.Location = new Point(10, 10); // Posicionar la barra de vida en la parte superior izquierda
            barraVida.Width = 100; // Establecer el ancho de la barra de vida
            barraVida.Height = 20; // Establecer la altura de la barra de vida
            barraVida.Maximum = 100; // La vida máxima es 100
            barraVida.Value = 100; // La vida inicial es 100
            this.Controls.Add(barraVida); // Añadir la barra de vida al formulario
            System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer(); // Aquí está la corrección
            timer1.Interval = 100; // Establecer el intervalo en 100 milisegundos
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
             // Aquí está la corrección
            timer2.Interval = 2000; // Establecer el intervalo en 100 milisegundos
            timer2.Enabled = true;
            timer2.Tick += new EventHandler(timerDisparoEnemigos_Tick);
            // Crear jugador y enemigos
            nave.crearJugador();
            nave.imgNave.Location = new Point(this.Width / 2, this.Height - nave.imgNave.Height); // Posicionar la nave en el centro abajo
            for (int i = 0; i < 4; i++)
            {
                nave.crearEnemigo("malito" + (i + 1), this);
            }

            // Añadir la nave y los enemigos al formulario
            this.Controls.Add(nave.imgNave);
            foreach (Enemigo enemigo in nave.enemigos)
            {
                enemigo.imgEnemigo.Location = enemigo.posicion; // Asignar la posición del enemigo
                this.Controls.Add(enemigo.imgEnemigo);
            }
        }

        void frmJuego_KeyDown_1(object sender, KeyEventArgs e)
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
        }

        void frmJuego_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool b = false;

            if (nave.vida > 0)
            {
                nave.moverBalas(this);
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
            
            
        }
        private void timerDisparoEnemigos_Tick(object sender, EventArgs e)
        {
            foreach (Enemigo enemigo in nave.enemigos)
            {
                PictureBox balaEnemigo = enemigo.disparar();
                this.Controls.Add(balaEnemigo);
                nave.balasEnemigos.Add(balaEnemigo);
            }

            // Aquí puedes llamar al método para mover las balas de los enemigos

        }
        
    }
}
