using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryBordigaGabriel
{
    internal class Explosion
    {
        public PictureBox imgExplosion = new PictureBox();
        private int frameIndex = 0;
        private List<string> frames = new List<string>()
    {
        "explosion1.png",
        "explosion2.png",
        "explosion3.png",
        // Agrega aquí el resto de tus imágenes de explosión
    };

        public Explosion(Point position)
        {
            imgExplosion.SizeMode = PictureBoxSizeMode.Zoom;
            imgExplosion.Location = position;
            imgExplosion.Width = 50; // Ajusta el tamaño de la explosión según sea necesario
            imgExplosion.Height = 50;
            imgExplosion.ImageLocation = "../../../../Images/PicturesJuego/" + frames[frameIndex];
        }

        public bool NextFrame()
        {
            frameIndex++;
            if (frameIndex >= frames.Count)
            {
                return false; // La animación de la explosión ha terminado
            }
            else
            {
                imgExplosion.ImageLocation = "../../../../Images/PicturesJuego/" + frames[frameIndex];
                return true; // La animación de la explosión continúa
            }
        }
    }
}
