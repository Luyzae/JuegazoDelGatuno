namespace JuegoDelGato
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre1 = new System.Windows.Forms.TextBox();
            this.Nombre2 = new System.Windows.Forms.TextBox();
            this.BotonJugar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(199, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "JUEGO DEL GATO";
            // 
            // Nombre1
            // 
            this.Nombre1.Location = new System.Drawing.Point(199, 197);
            this.Nombre1.MaxLength = 32;
            this.Nombre1.Name = "Nombre1";
            this.Nombre1.PlaceholderText = "Nombre del jugador 1";
            this.Nombre1.Size = new System.Drawing.Size(262, 27);
            this.Nombre1.TabIndex = 1;
            // 
            // Nombre2
            // 
            this.Nombre2.Location = new System.Drawing.Point(199, 259);
            this.Nombre2.MaxLength = 32;
            this.Nombre2.Name = "Nombre2";
            this.Nombre2.PlaceholderText = "Nombre del jugador 2";
            this.Nombre2.Size = new System.Drawing.Size(262, 27);
            this.Nombre2.TabIndex = 2;
            // 
            // BotonJugar
            // 
            this.BotonJugar.Location = new System.Drawing.Point(259, 344);
            this.BotonJugar.Name = "BotonJugar";
            this.BotonJugar.Size = new System.Drawing.Size(152, 29);
            this.BotonJugar.TabIndex = 3;
            this.BotonJugar.Text = "Jugar";
            this.BotonJugar.UseVisualStyleBackColor = true;
            this.BotonJugar.Click += new System.EventHandler(this.BotonJugar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JuegoDelGato.Properties.Resources.SantoTomas;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BotonJugar);
            this.Controls.Add(this.Nombre2);
            this.Controls.Add(this.Nombre1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormMenu";
            this.Text = "Juego del gato";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Nombre1;
        private TextBox Nombre2;
        private Button BotonJugar;
        private PictureBox pictureBox1;
    }
}