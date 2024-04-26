using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryBordigaGabriel
{
    public class Enemigo
    {
        public PictureBox imgEnemigo = new PictureBox();
        public int vida = 25;
        public Point posicion; // Nueva propiedad para la posición
        public System.Windows.Forms.Timer timerDisparo = new System.Windows.Forms.Timer();
        public List<PictureBox> balasEnemigo = new List<PictureBox>();
        public PictureBox disparar()
        {

            PictureBox bala = new PictureBox();
            bala.SizeMode = PictureBoxSizeMode.AutoSize;
            bala.ImageLocation = "../../../../Images/PicturesJuego/balaEnemigo2.png"; // Asegúrate de tener una imagen para la bala del enemigo
            bala.Left = imgEnemigo.Left + imgEnemigo.Width / 2 - bala.Width / 22; // La bala sale del centro del enemigo
            bala.Top = imgEnemigo.Bottom; // La bala sale de la parte inferior del enemigo
            bala.Width = 10;  // Ancho de la bala
            bala.Height = 10; // Altura de la bala
            return bala;

        }
            
    }
    

}
