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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcFirma = new System.Windows.Forms.PictureBox();
            this.pcJuego = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pcFirma
            // 
            this.pcFirma.Image = ((System.Drawing.Image)(resources.GetObject("pcFirma.Image")));
            this.pcFirma.Location = new System.Drawing.Point(26, 33);
            this.pcFirma.Name = "pcFirma";
            this.pcFirma.Size = new System.Drawing.Size(75, 23);
            this.pcFirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcFirma.TabIndex = 5;
            this.pcFirma.TabStop = false;
            this.pcFirma.Click += new System.EventHandler(this.pcFirma_Click_1);
            // 
            // pcJuego
            // 
            this.pcJuego.Image = ((System.Drawing.Image)(resources.GetObject("pcJuego.Image")));
            this.pcJuego.Location = new System.Drawing.Point(173, 33);
            this.pcJuego.Name = "pcJuego";
            this.pcJuego.Size = new System.Drawing.Size(75, 23);
            this.pcJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcJuego.TabIndex = 5;
            this.pcJuego.TabStop = false;
            this.pcJuego.Click += new System.EventHandler(this.pcJuego_Click_1);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 89);
            this.Controls.Add(this.pcJuego);
            this.Controls.Add(this.pcFirma);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcJuego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pcFirma;
        private PictureBox pcJuego;
    }
}