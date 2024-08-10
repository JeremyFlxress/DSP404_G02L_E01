namespace Ejercicio_01
{
    partial class Login
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
            this.txtIProtagonistas = new System.Windows.Forms.TextBox();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblProtagonistas = new System.Windows.Forms.Label();
            this.lblSinopsis = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.lblTituloEspañol = new System.Windows.Forms.Label();
            this.lblCreado = new System.Windows.Forms.Label();
            this.txtCreadoPor = new System.Windows.Forms.TextBox();
            this.txtPaisOrigen = new System.Windows.Forms.TextBox();
            this.txtEpisodios = new System.Windows.Forms.TextBox();
            this.txtTemporadas = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblTemporadas = new System.Windows.Forms.Label();
            this.lblEpisodios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIProtagonistas
            // 
            this.txtIProtagonistas.Enabled = false;
            this.txtIProtagonistas.Location = new System.Drawing.Point(273, 127);
            this.txtIProtagonistas.Multiline = true;
            this.txtIProtagonistas.Name = "txtIProtagonistas";
            this.txtIProtagonistas.Size = new System.Drawing.Size(136, 195);
            this.txtIProtagonistas.TabIndex = 3;
            this.txtIProtagonistas.TextChanged += new System.EventHandler(this.txtIProtagonistas_TextChanged);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Lucida Calligraphy", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(15, 24);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(256, 44);
            this.lblTitulo1.TabIndex = 2;
            this.lblTitulo1.Text = "Informacion";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(28, 395);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblProtagonistas
            // 
            this.lblProtagonistas.AutoSize = true;
            this.lblProtagonistas.Location = new System.Drawing.Point(270, 111);
            this.lblProtagonistas.Name = "lblProtagonistas";
            this.lblProtagonistas.Size = new System.Drawing.Size(80, 13);
            this.lblProtagonistas.TabIndex = 5;
            this.lblProtagonistas.Text = "Protagoniostas:";
            this.lblProtagonistas.Click += new System.EventHandler(this.lblProtagonistas_Click);
            // 
            // lblSinopsis
            // 
            this.lblSinopsis.AutoSize = true;
            this.lblSinopsis.Location = new System.Drawing.Point(25, 111);
            this.lblSinopsis.Name = "lblSinopsis";
            this.lblSinopsis.Size = new System.Drawing.Size(49, 13);
            this.lblSinopsis.TabIndex = 6;
            this.lblSinopsis.Text = "Sinopsis:";
            this.lblSinopsis.Click += new System.EventHandler(this.lblSinopsis_Click);
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Enabled = false;
            this.txtSinopsis.Location = new System.Drawing.Point(23, 127);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(227, 121);
            this.txtSinopsis.TabIndex = 7;
            // 
            // lblTituloEspañol
            // 
            this.lblTituloEspañol.AutoSize = true;
            this.lblTituloEspañol.Location = new System.Drawing.Point(20, 82);
            this.lblTituloEspañol.Name = "lblTituloEspañol";
            this.lblTituloEspañol.Size = new System.Drawing.Size(35, 13);
            this.lblTituloEspañol.TabIndex = 8;
            this.lblTituloEspañol.Text = "label2";
            // 
            // lblCreado
            // 
            this.lblCreado.AutoSize = true;
            this.lblCreado.Location = new System.Drawing.Point(25, 260);
            this.lblCreado.Name = "lblCreado";
            this.lblCreado.Size = new System.Drawing.Size(62, 13);
            this.lblCreado.TabIndex = 9;
            this.lblCreado.Text = "Creado por:";
            // 
            // txtCreadoPor
            // 
            this.txtCreadoPor.Enabled = false;
            this.txtCreadoPor.Location = new System.Drawing.Point(93, 257);
            this.txtCreadoPor.Multiline = true;
            this.txtCreadoPor.Name = "txtCreadoPor";
            this.txtCreadoPor.Size = new System.Drawing.Size(156, 39);
            this.txtCreadoPor.TabIndex = 10;
            // 
            // txtPaisOrigen
            // 
            this.txtPaisOrigen.Enabled = false;
            this.txtPaisOrigen.Location = new System.Drawing.Point(95, 302);
            this.txtPaisOrigen.Name = "txtPaisOrigen";
            this.txtPaisOrigen.Size = new System.Drawing.Size(154, 20);
            this.txtPaisOrigen.TabIndex = 11;
            // 
            // txtEpisodios
            // 
            this.txtEpisodios.Enabled = false;
            this.txtEpisodios.Location = new System.Drawing.Point(273, 332);
            this.txtEpisodios.Name = "txtEpisodios";
            this.txtEpisodios.Size = new System.Drawing.Size(32, 20);
            this.txtEpisodios.TabIndex = 12;
            // 
            // txtTemporadas
            // 
            this.txtTemporadas.Enabled = false;
            this.txtTemporadas.Location = new System.Drawing.Point(122, 332);
            this.txtTemporadas.Name = "txtTemporadas";
            this.txtTemporadas.Size = new System.Drawing.Size(43, 20);
            this.txtTemporadas.TabIndex = 13;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(25, 305);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(64, 13);
            this.lblPais.TabIndex = 14;
            this.lblPais.Text = "Pais Origen:";
            // 
            // lblTemporadas
            // 
            this.lblTemporadas.AutoSize = true;
            this.lblTemporadas.Location = new System.Drawing.Point(25, 335);
            this.lblTemporadas.Name = "lblTemporadas";
            this.lblTemporadas.Size = new System.Drawing.Size(69, 13);
            this.lblTemporadas.TabIndex = 15;
            this.lblTemporadas.Text = "Temporadas:";
            // 
            // lblEpisodios
            // 
            this.lblEpisodios.AutoSize = true;
            this.lblEpisodios.Location = new System.Drawing.Point(195, 335);
            this.lblEpisodios.Name = "lblEpisodios";
            this.lblEpisodios.Size = new System.Drawing.Size(55, 13);
            this.lblEpisodios.TabIndex = 16;
            this.lblEpisodios.Text = "Episodios:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEpisodios);
            this.Controls.Add(this.lblTemporadas);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.txtTemporadas);
            this.Controls.Add(this.txtEpisodios);
            this.Controls.Add(this.txtPaisOrigen);
            this.Controls.Add(this.txtCreadoPor);
            this.Controls.Add(this.lblCreado);
            this.Controls.Add(this.lblTituloEspañol);
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.lblSinopsis);
            this.Controls.Add(this.lblProtagonistas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtIProtagonistas);
            this.Controls.Add(this.lblTitulo1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIProtagonistas;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblProtagonistas;
        private System.Windows.Forms.Label lblSinopsis;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Label lblTituloEspañol;
        private System.Windows.Forms.Label lblCreado;
        private System.Windows.Forms.TextBox txtCreadoPor;
        private System.Windows.Forms.TextBox txtPaisOrigen;
        private System.Windows.Forms.TextBox txtEpisodios;
        private System.Windows.Forms.TextBox txtTemporadas;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblTemporadas;
        private System.Windows.Forms.Label lblEpisodios;
    }
}