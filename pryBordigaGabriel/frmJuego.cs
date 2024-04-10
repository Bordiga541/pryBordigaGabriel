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
        clsNave objNaveJugador;
        public frmJuego()
        {
            InitializeComponent();
        }

        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNaveJugador = new clsNave();

            objNaveJugador.crearJugador();
            objNaveJugador.imgNave.Location = new Point(300, 600);
            Controls.Add(objNaveJugador.imgNave);

            objNaveJugador.crearEnemigo1();
            objNaveJugador.imgEnemigo1.Location = new Point(350, 200);
            Controls.Add(objNaveJugador.imgEnemigo1);

            objNaveJugador.crearEnemigo2();
            objNaveJugador.imgEnemigo2.Location = new Point(250, 200);
            Controls.Add(objNaveJugador.imgEnemigo2);

            objNaveJugador.crearEnemigo3();
            objNaveJugador.imgEnemigo3.Location = new Point(450, 200);
            Controls.Add(objNaveJugador.imgEnemigo3);

            objNaveJugador.crearEnemigo4();
            objNaveJugador.imgEnemigo4.Location = new Point(150, 200);
            Controls.Add(objNaveJugador.imgEnemigo4);
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (objNaveJugador.imgNave.Location.X < 620) 
                {
                    objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X + 5,
                                                            objNaveJugador.imgNave.Location.Y);
                }
                    
            }
            if (e.KeyCode == Keys.Left)
            {
                if (objNaveJugador.imgNave.Location.X > -18) 
                {
                    objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X - 5,
                                                            objNaveJugador.imgNave.Location.Y);
                }
                    
            }
            if (e.KeyCode == Keys.Up)
            {
                if (objNaveJugador.imgNave.Location.Y > 250)
                {
                    objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X,
                                                            objNaveJugador.imgNave.Location.Y - 5);
                }

            }
            if (e.KeyCode == Keys.Down)
            {
                if (objNaveJugador.imgNave.Location.Y < 650) 
                {
                    objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X,
                                                            objNaveJugador.imgNave.Location.Y + 5);
                }
                    
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
