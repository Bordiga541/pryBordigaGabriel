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
        public PictureBox imgEnemigo1;
        public PictureBox imgEnemigo2;
        public PictureBox imgEnemigo3;
        public PictureBox imgEnemigo4;


        public void crearJugador() 
        {
            vida = 100;
            nombre = "jugador1";
            puntosDaño = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.Zoom;
            imgNave.ImageLocation = "PicturesJuego/nave.png";
            
        }
        public void crearEnemigo1()
        {
            vida = 25;
            nombre = "malito1";
            puntosDaño = 2;
            imgEnemigo1 = new PictureBox();
            imgEnemigo1.SizeMode = PictureBoxSizeMode.Zoom;
            imgEnemigo1.ImageLocation = "PicturesJuego/enemigo1.png";
        }
        public void crearEnemigo2()
        {
            vida = 25;
            nombre = "malito2";
            puntosDaño = 2;
            imgEnemigo2 = new PictureBox();
            imgEnemigo2.SizeMode = PictureBoxSizeMode.Zoom;
            imgEnemigo2.ImageLocation = "PicturesJuego/enemigo2.png";
        }
        public void crearEnemigo3()
        {
            vida = 25;
            nombre = "malito3";
            puntosDaño = 2;
            imgEnemigo3 = new PictureBox();
            imgEnemigo3.SizeMode = PictureBoxSizeMode.Zoom;
            imgEnemigo3.ImageLocation = "PicturesJuego/enemigo3.png";
        }
        public void crearEnemigo4()
        {
            vida = 25;
            nombre = "malito4";
            puntosDaño = 2;
            imgEnemigo4 = new PictureBox();
            imgEnemigo4.SizeMode = PictureBoxSizeMode.Zoom;
            imgEnemigo4.ImageLocation = "PicturesJuego/enemigo4.png";
        }
    }
}
