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
    public partial class frmFirma : Form
    {

        private Bitmap _bitmap;

        public frmFirma()
        {
            InitializeComponent();

            // Inicializa el bitmap con el tamaño del PictureBox
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (chkAzul.Checked == true) 
                {
                    using (Graphics objetoLoco = Graphics.FromImage(_bitmap))
                    {
                        objetoLoco.FillEllipse(Brushes.Blue, e.X, e.Y, 5, 5);
                    }
                    pictureBox1.Image = _bitmap;
                }
                else if (chkNegro.Checked == true)
                {
                    using (Graphics objetoLoco = Graphics.FromImage(_bitmap))
                    {
                        objetoLoco.FillEllipse(Brushes.Black, e.X, e.Y, 5, 5);
                    }
                    pictureBox1.Image = _bitmap;
                }
                else if (chkRojo.Checked == true)
                {
                    using (Graphics objetoLoco = Graphics.FromImage(_bitmap))
                    {
                        objetoLoco.FillEllipse(Brushes.Red, e.X, e.Y, 5, 5);
                    }
                    pictureBox1.Image = _bitmap;
                }
                else if(chkAmarillo.Checked == true)
                {
                    using (Graphics objetoLoco = Graphics.FromImage(_bitmap))
                    {
                        objetoLoco.FillEllipse(Brushes.Yellow, e.X, e.Y, 5, 5);
                    }
                    pictureBox1.Image = _bitmap;
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            _bitmap.Save("ruta_del_archivo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = _bitmap;
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = _bitmap;
        }
    }
}
