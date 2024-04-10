namespace pryBordigaGabriel
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pictureBox1 = new PictureBox();
            pcFirma = new PictureBox();
            pcJuego = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcFirma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcJuego).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pcFirma
            // 
            pcFirma.Image = (Image)resources.GetObject("pcFirma.Image");
            pcFirma.Location = new Point(26, 33);
            pcFirma.Name = "pcFirma";
            pcFirma.Size = new Size(75, 23);
            pcFirma.SizeMode = PictureBoxSizeMode.StretchImage;
            pcFirma.TabIndex = 5;
            pcFirma.TabStop = false;
            pcFirma.Click += pcFirma_Click;
            // 
            // pcJuego
            // 
            pcJuego.Image = (Image)resources.GetObject("pcJuego.Image");
            pcJuego.Location = new Point(173, 33);
            pcJuego.Name = "pcJuego";
            pcJuego.Size = new Size(75, 23);
            pcJuego.SizeMode = PictureBoxSizeMode.StretchImage;
            pcJuego.TabIndex = 5;
            pcJuego.TabStop = false;
            pcJuego.Click += pcJuego_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 89);
            Controls.Add(pcJuego);
            Controls.Add(pcFirma);
            Controls.Add(pictureBox1);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcFirma).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcJuego).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pcFirma;
        private PictureBox pcJuego;
    }
}