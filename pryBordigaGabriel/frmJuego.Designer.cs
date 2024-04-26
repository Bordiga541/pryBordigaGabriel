namespace pryBordigaGabriel
{
    partial class frmJuego
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
            progressBar1 = new ProgressBar();
            lbl = new Label();
            lblScore = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(10, 30);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(0, 0);
            progressBar1.TabIndex = 0;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("ROG Fonts", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.ForeColor = SystemColors.ButtonHighlight;
            lbl.Location = new Point(10, 33);
            lbl.Name = "lbl";
            lbl.Size = new Size(41, 14);
            lbl.TabIndex = 1;
            lbl.Text = "VIDA";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Black;
            lblScore.Font = new Font("ROG Fonts", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(605, 15);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(59, 14);
            lblScore.TabIndex = 2;
            lblScore.Text = "SCORE";
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(700, 700);
            Controls.Add(lblScore);
            Controls.Add(lbl);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Juego";
            Load += frmJuego_Load;
            KeyDown += frmJuego_KeyDown;
            KeyUp += frmJuego_KeyUp_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lbl;
        private Label lblScore;
    }
}