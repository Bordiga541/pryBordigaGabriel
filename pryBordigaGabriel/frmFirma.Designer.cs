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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAmarillo = new System.Windows.Forms.RadioButton();
            this.chkNegro = new System.Windows.Forms.RadioButton();
            this.chkAzul = new System.Windows.Forms.RadioButton();
            this.chkRojo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(29, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 313);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(572, 21);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(82, 35);
            this.cmdGuardar.TabIndex = 1;
            this.cmdGuardar.Text = "GUARDAR";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(572, 62);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(82, 35);
            this.cmdBorrar.TabIndex = 2;
            this.cmdBorrar.Text = "BORRAR";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAmarillo);
            this.groupBox1.Controls.Add(this.chkNegro);
            this.groupBox1.Controls.Add(this.chkAzul);
            this.groupBox1.Controls.Add(this.chkRojo);
            this.groupBox1.Location = new System.Drawing.Point(570, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(91, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COLOR";
            // 
            // chkAmarillo
            // 
            this.chkAmarillo.AutoSize = true;
            this.chkAmarillo.Location = new System.Drawing.Point(6, 97);
            this.chkAmarillo.Name = "chkAmarillo";
            this.chkAmarillo.Size = new System.Drawing.Size(83, 19);
            this.chkAmarillo.TabIndex = 1;
            this.chkAmarillo.Text = "AMARILLO";
            this.chkAmarillo.UseVisualStyleBackColor = true;
            // 
            // chkNegro
            // 
            this.chkNegro.AutoSize = true;
            this.chkNegro.Checked = true;
            this.chkNegro.Location = new System.Drawing.Point(6, 72);
            this.chkNegro.Name = "chkNegro";
            this.chkNegro.Size = new System.Drawing.Size(64, 19);
            this.chkNegro.TabIndex = 1;
            this.chkNegro.TabStop = true;
            this.chkNegro.Text = "NEGRO";
            this.chkNegro.UseVisualStyleBackColor = true;
            // 
            // chkAzul
            // 
            this.chkAzul.AutoSize = true;
            this.chkAzul.Location = new System.Drawing.Point(6, 47);
            this.chkAzul.Name = "chkAzul";
            this.chkAzul.Size = new System.Drawing.Size(54, 19);
            this.chkAzul.TabIndex = 1;
            this.chkAzul.Text = "AZUL";
            this.chkAzul.UseVisualStyleBackColor = true;
            // 
            // chkRojo
            // 
            this.chkRojo.AutoSize = true;
            this.chkRojo.Location = new System.Drawing.Point(6, 22);
            this.chkRojo.Name = "chkRojo";
            this.chkRojo.Size = new System.Drawing.Size(54, 19);
            this.chkRojo.TabIndex = 1;
            this.chkRojo.Text = "ROJO";
            this.chkRojo.UseVisualStyleBackColor = true;
            // 
            // frmFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 349);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmFirma";
            this.Text = "frmFirma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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