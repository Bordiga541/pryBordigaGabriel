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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void frmFirma_Click(object sender, EventArgs e)
        {


        }

        private void frmJuego_Click(object sender, EventArgs e)
        {


        }

        private void frmFirma_Click_1(object sender, EventArgs e)
        {

        }

        private void frmJuego_Click_1(object sender, EventArgs e)
        {

        }

        private void pcFirma_Click(object sender, EventArgs e)
        {
            frmFirma Firma = new frmFirma();
            Firma.Show();
        }

        private void pcJuego_Click(object sender, EventArgs e)
        {
            frmJuego Juego = new frmJuego();
            Juego.Show();
        }
    }
}
