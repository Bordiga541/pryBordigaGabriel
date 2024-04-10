namespace pryBordigaGabriel
{
    partial class frmFirma
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
            pictureBox1 = new PictureBox();
            cmdGuardar = new Button();
            cmdBorrar = new Button();
            groupBox1 = new GroupBox();
            chkAmarillo = new RadioButton();
            chkNegro = new RadioButton();
            chkAzul = new RadioButton();
            chkRojo = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Location = new Point(29, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 313);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // cmdGuardar
            // 
            cmdGuardar.Location = new Point(572, 21);
            cmdGuardar.Name = "cmdGuardar";
            cmdGuardar.Size = new Size(82, 35);
            cmdGuardar.TabIndex = 1;
            cmdGuardar.Text = "GURADAR";
            cmdGuardar.UseVisualStyleBackColor = true;
            cmdGuardar.Click += cmdGuardar_Click;
            // 
            // cmdBorrar
            // 
            cmdBorrar.Location = new Point(572, 62);
            cmdBorrar.Name = "cmdBorrar";
            cmdBorrar.Size = new Size(82, 35);
            cmdBorrar.TabIndex = 2;
            cmdBorrar.Text = "BORRAR";
            cmdBorrar.UseVisualStyleBackColor = true;
            cmdBorrar.Click += cmdBorrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAmarillo);
            groupBox1.Controls.Add(chkNegro);
            groupBox1.Controls.Add(chkAzul);
            groupBox1.Controls.Add(chkRojo);
            groupBox1.Location = new Point(570, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(91, 127);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "COLOR";
            // 
            // chkAmarillo
            // 
            chkAmarillo.AutoSize = true;
            chkAmarillo.Location = new Point(6, 97);
            chkAmarillo.Name = "chkAmarillo";
            chkAmarillo.Size = new Size(83, 19);
            chkAmarillo.TabIndex = 1;
            chkAmarillo.Text = "AMARILLO";
            chkAmarillo.UseVisualStyleBackColor = true;
            // 
            // chkNegro
            // 
            chkNegro.AutoSize = true;
            chkNegro.Checked = true;
            chkNegro.Location = new Point(6, 72);
            chkNegro.Name = "chkNegro";
            chkNegro.Size = new Size(64, 19);
            chkNegro.TabIndex = 1;
            chkNegro.TabStop = true;
            chkNegro.Text = "NEGRO";
            chkNegro.UseVisualStyleBackColor = true;
            // 
            // chkAzul
            // 
            chkAzul.AutoSize = true;
            chkAzul.Location = new Point(6, 47);
            chkAzul.Name = "chkAzul";
            chkAzul.Size = new Size(54, 19);
            chkAzul.TabIndex = 1;
            chkAzul.Text = "AZUL";
            chkAzul.UseVisualStyleBackColor = true;
            // 
            // chkRojo
            // 
            chkRojo.AutoSize = true;
            chkRojo.Location = new Point(6, 22);
            chkRojo.Name = "chkRojo";
            chkRojo.Size = new Size(54, 19);
            chkRojo.TabIndex = 1;
            chkRojo.Text = "ROJO";
            chkRojo.UseVisualStyleBackColor = true;
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 349);
            Controls.Add(groupBox1);
            Controls.Add(cmdBorrar);
            Controls.Add(cmdGuardar);
            Controls.Add(pictureBox1);
            Name = "frmFirma";
            Text = "frmFirma";
            Load += frmFirma_Load;
            KeyDown += frmFirma_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button cmdGuardar;
        private Button cmdBorrar;
        private GroupBox groupBox1;
        private RadioButton chkAmarillo;
        private RadioButton chkNegro;
        private RadioButton chkAzul;
        private RadioButton chkRojo;
    }
}