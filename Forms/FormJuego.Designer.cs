using JuegoDelGato.Logica;

namespace JuegoDelGato.Forms
{
    partial class FormJuego
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
            this.LabelResultado = new System.Windows.Forms.Label();
            this.LabelTurno = new System.Windows.Forms.Label();
            this.Tablero = new System.Windows.Forms.TableLayoutPanel();
            this.Casillero9 = new System.Windows.Forms.Button();
            this.Casillero8 = new System.Windows.Forms.Button();
            this.Casillero7 = new System.Windows.Forms.Button();
            this.Casillero6 = new System.Windows.Forms.Button();
            this.Casillero5 = new System.Windows.Forms.Button();
            this.Casillero4 = new System.Windows.Forms.Button();
            this.Casillero3 = new System.Windows.Forms.Button();
            this.Casillero1 = new System.Windows.Forms.Button();
            this.Casillero2 = new System.Windows.Forms.Button();
            this.LabelJugador1 = new System.Windows.Forms.Label();
            this.LabelJugador2 = new System.Windows.Forms.Label();
            this.BotonNuevoJuego = new System.Windows.Forms.Button();
            this.BotonReiniciarContador = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tablero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelResultado
            // 
            this.LabelResultado.AutoSize = true;
            this.LabelResultado.Location = new System.Drawing.Point(326, 63);
            this.LabelResultado.Name = "LabelResultado";
            this.LabelResultado.Size = new System.Drawing.Size(78, 20);
            this.LabelResultado.TabIndex = 0;
            this.LabelResultado.Text = "Resultado:";
            // 
            // LabelTurno
            // 
            this.LabelTurno.AutoSize = true;
            this.LabelTurno.Location = new System.Drawing.Point(326, 95);
            this.LabelTurno.Name = "LabelTurno";
            this.LabelTurno.Size = new System.Drawing.Size(68, 20);
            this.LabelTurno.TabIndex = 1;
            this.LabelTurno.Text = "Turno de";
            // 
            // Tablero
            // 
            this.Tablero.ColumnCount = 3;
            this.Tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tablero.Controls.Add(this.Casillero9, 2, 2);
            this.Tablero.Controls.Add(this.Casillero8, 1, 2);
            this.Tablero.Controls.Add(this.Casillero7, 0, 2);
            this.Tablero.Controls.Add(this.Casillero6, 2, 1);
            this.Tablero.Controls.Add(this.Casillero5, 1, 1);
            this.Tablero.Controls.Add(this.Casillero4, 0, 1);
            this.Tablero.Controls.Add(this.Casillero3, 2, 0);
            this.Tablero.Controls.Add(this.Casillero1, 0, 0);
            this.Tablero.Controls.Add(this.Casillero2, 1, 0);
            this.Tablero.Location = new System.Drawing.Point(213, 151);
            this.Tablero.Name = "Tablero";
            this.Tablero.RowCount = 3;
            this.Tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.Tablero.Size = new System.Drawing.Size(299, 300);
            this.Tablero.TabIndex = 2;
            // 
            // Casillero9
            // 
            this.Casillero9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Casillero9.Location = new System.Drawing.Point(201, 201);
            this.Casillero9.Name = "Casillero9";
            this.Casillero9.Size = new System.Drawing.Size(94, 93);
            this.Casillero9.TabIndex = 8;
            this.Casillero9.Text = "-";
            this.Casillero9.UseVisualStyleBackColor = true;
            this.Casillero9.Click += new System.EventHandler(this.Casillero9_Click);
            // 
            // Casillero8
            // 
            this.Casillero8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Casillero8.Location = new System.Drawing.Point(102, 201);
            this.Casillero8.Name = "Casillero8";
            this.Casillero8.Size = new System.Drawing.Size(93, 93);
            this.Casillero8.TabIndex = 7;
            this.Casillero8.Text = "-";
            this.Casillero8.UseVisualStyleBackColor = true;
            this.Casillero8.Click += new System.EventHandler(this.Casillero8_Click);
            // 
            // Casillero7
            // 
            this.Casillero7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Casillero7.Location = new System.Drawing.Point(3, 201);
            this.Casillero7.Name = "Casillero7";
            this.Casillero7.Size = new System.Drawing.Size(93, 93);
            this.Casillero7.TabIndex = 6;
            this.Casillero7.Text = "-";
            this.Casillero7.UseVisualStyleBackColor = true;
            this.Casillero7.Click += new System.EventHandler(this.Casillero7_Click);
            // 
            // Casillero6
            // 
            this.Casillero6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Casillero6.Location = new System.Drawing.Point(201, 102);
            this.Casillero6.Name = "Casillero6";
            this.Casillero6.Size = new System.Drawing.Size(94, 93);
            this.Casillero6.TabIndex = 5;
            this.Casillero6.Text = "-";
            this.Casillero6.UseVisualStyleBackColor = true;
            this.Casillero6.Click += new System.EventHandler(this.Casillero6_Click);
            // 
            // Casillero5
            // 
            this.Casillero5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Casillero5.Location = new System.Drawing.Point(102, 102);
            this.Casillero5.Name = "Casillero5";
            this.Casillero5.Size = new System.Drawing.Size(93, 93);
            this.Casillero5.TabIndex = 4;
            this.Casillero5.Text = "-";
            this.Casillero5.UseVisualStyleBackColor = true;
            this.Casillero5.Click += new System.EventHandler(this.Casillero5_Click);
            // 
            // Casillero4
            // 
            this.Casillero4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Casillero4.Location = new System.Drawing.Point(3, 102);
            this.Casillero4.Name = "Casillero4";
            this.Casillero4.Size = new System.Drawing.Size(93, 93);
            this.Casillero4.TabIndex = 3;
            this.Casillero4.Text = "-";
            this.Casillero4.UseVisualStyleBackColor = true;
            this.Casillero4.Click += new System.EventHandler(this.Casillero4_Click);
            // 
            // Casillero3
            // 
            this.Casillero3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Casillero3.Location = new System.Drawing.Point(201, 3);
            this.Casillero3.Name = "Casillero3";
            this.Casillero3.Size = new System.Drawing.Size(94, 93);
            this.Casillero3.TabIndex = 2;
            this.Casillero3.Text = "-";
            this.Casillero3.UseVisualStyleBackColor = true;
            this.Casillero3.Click += new System.EventHandler(this.Casillero3_Click);
            // 
            // Casillero1
            // 
            this.Casillero1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Casillero1.Location = new System.Drawing.Point(3, 3);
            this.Casillero1.Name = "Casillero1";
            this.Casillero1.Size = new System.Drawing.Size(93, 93);
            this.Casillero1.TabIndex = 0;
            this.Casillero1.Text = "-";
            this.Casillero1.UseVisualStyleBackColor = true;
            this.Casillero1.Click += new System.EventHandler(this.Casillero1_Click);
            // 
            // Casillero2
            // 
            this.Casillero2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Casillero2.Location = new System.Drawing.Point(102, 3);
            this.Casillero2.Name = "Casillero2";
            this.Casillero2.Size = new System.Drawing.Size(93, 93);
            this.Casillero2.TabIndex = 1;
            this.Casillero2.Text = "-";
            this.Casillero2.UseVisualStyleBackColor = true;
            this.Casillero2.Click += new System.EventHandler(this.Casillero2_Click);
            // 
            // LabelJugador1
            // 
            this.LabelJugador1.AutoSize = true;
            this.LabelJugador1.Location = new System.Drawing.Point(285, 480);
            this.LabelJugador1.Name = "LabelJugador1";
            this.LabelJugador1.Size = new System.Drawing.Size(186, 20);
            this.LabelJugador1.TabIndex = 3;
            this.LabelJugador1.Text = "Jugador n°1 O (0 Ganadas)";
            // 
            // LabelJugador2
            // 
            this.LabelJugador2.AutoSize = true;
            this.LabelJugador2.Location = new System.Drawing.Point(285, 512);
            this.LabelJugador2.Name = "LabelJugador2";
            this.LabelJugador2.Size = new System.Drawing.Size(184, 20);
            this.LabelJugador2.TabIndex = 4;
            this.LabelJugador2.Text = "Jugador n°2 X (0 Ganadas)";
            // 
            // BotonNuevoJuego
            // 
            this.BotonNuevoJuego.Location = new System.Drawing.Point(294, 567);
            this.BotonNuevoJuego.Name = "BotonNuevoJuego";
            this.BotonNuevoJuego.Size = new System.Drawing.Size(130, 29);
            this.BotonNuevoJuego.TabIndex = 5;
            this.BotonNuevoJuego.Text = "Nuevo juego";
            this.BotonNuevoJuego.UseVisualStyleBackColor = true;
            this.BotonNuevoJuego.Click += new System.EventHandler(this.BotonNuevoJuego_Click);
            // 
            // BotonReiniciarContador
            // 
            this.BotonReiniciarContador.Location = new System.Drawing.Point(283, 601);
            this.BotonReiniciarContador.Name = "BotonReiniciarContador";
            this.BotonReiniciarContador.Size = new System.Drawing.Size(152, 29);
            this.BotonReiniciarContador.TabIndex = 6;
            this.BotonReiniciarContador.Text = "Reiniciar contador";
            this.BotonReiniciarContador.UseVisualStyleBackColor = true;
            this.BotonReiniciarContador.Click += new System.EventHandler(this.BotonReiniciarContador_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JuegoDelGato.Properties.Resources.SantoTomas;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BotonReiniciarContador);
            this.Controls.Add(this.BotonNuevoJuego);
            this.Controls.Add(this.LabelJugador2);
            this.Controls.Add(this.LabelJugador1);
            this.Controls.Add(this.Tablero);
            this.Controls.Add(this.LabelTurno);
            this.Controls.Add(this.LabelResultado);
            this.Name = "FormJuego";
            this.Text = "FormJuego";
            this.Load += new System.EventHandler(this.FormJuego_Load);
            this.Tablero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelResultado;
        private Label LabelTurno;
        private TableLayoutPanel Tablero;
        private Button Casillero9;
        private Button Casillero8;
        private Button Casillero7;
        private Button Casillero6;
        private Button Casillero5;
        private Button Casillero4;
        private Button Casillero3;
        private Button Casillero2;
        private Button Casillero1;
        private Label LabelJugador1;
        private Label LabelJugador2;
        private Button BotonNuevoJuego;
        private Button BotonReiniciarContador;
        private PictureBox pictureBox1;
    }
}