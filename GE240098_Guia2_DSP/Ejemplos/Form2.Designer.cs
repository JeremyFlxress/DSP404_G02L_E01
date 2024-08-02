namespace Guia_2.Ejemplos
{
    partial class frmCesar
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.lblLlave = new System.Windows.Forms.Label();
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.grOpcion = new System.Windows.Forms.GroupBox();
            this.rdbEncriptar = new System.Windows.Forms.RadioButton();
            this.rdbDesencriptar = new System.Windows.Forms.RadioButton();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.grOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(359, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(176, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Encriptamiento por Código de César";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(71, 75);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(198, 13);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Ingrese el texto a Encriptar/Desencriptar";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(74, 107);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(652, 90);
            this.txtTexto.TabIndex = 2;
            // 
            // lblLlave
            // 
            this.lblLlave.AutoSize = true;
            this.lblLlave.Location = new System.Drawing.Point(426, 75);
            this.lblLlave.Name = "lblLlave";
            this.lblLlave.Size = new System.Drawing.Size(152, 13);
            this.lblLlave.TabIndex = 3;
            this.lblLlave.Text = "Llave(Digite un número entero)";
            // 
            // txtLlave
            // 
            this.txtLlave.Location = new System.Drawing.Point(584, 72);
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(142, 20);
            this.txtLlave.TabIndex = 4;
            this.txtLlave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLlave_KeyPress);
            // 
            // grOpcion
            // 
            this.grOpcion.Controls.Add(this.rdbDesencriptar);
            this.grOpcion.Controls.Add(this.rdbEncriptar);
            this.grOpcion.Location = new System.Drawing.Point(74, 214);
            this.grOpcion.Name = "grOpcion";
            this.grOpcion.Size = new System.Drawing.Size(282, 75);
            this.grOpcion.TabIndex = 5;
            this.grOpcion.TabStop = false;
            this.grOpcion.Text = "Seleccione una opción:";
            // 
            // rdbEncriptar
            // 
            this.rdbEncriptar.AutoSize = true;
            this.rdbEncriptar.Location = new System.Drawing.Point(26, 36);
            this.rdbEncriptar.Name = "rdbEncriptar";
            this.rdbEncriptar.Size = new System.Drawing.Size(67, 17);
            this.rdbEncriptar.TabIndex = 0;
            this.rdbEncriptar.TabStop = true;
            this.rdbEncriptar.Text = "Encriptar";
            this.rdbEncriptar.UseVisualStyleBackColor = true;
            this.rdbEncriptar.CheckedChanged += new System.EventHandler(this.rdbEncriptar_CheckedChanged);
            // 
            // rdbDesencriptar
            // 
            this.rdbDesencriptar.AutoSize = true;
            this.rdbDesencriptar.Location = new System.Drawing.Point(166, 36);
            this.rdbDesencriptar.Name = "rdbDesencriptar";
            this.rdbDesencriptar.Size = new System.Drawing.Size(85, 17);
            this.rdbDesencriptar.TabIndex = 1;
            this.rdbDesencriptar.TabStop = true;
            this.rdbDesencriptar.Text = "Desencriptar";
            this.rdbDesencriptar.UseVisualStyleBackColor = true;
            this.rdbDesencriptar.CheckedChanged += new System.EventHandler(this.rdbDesencriptar_CheckedChanged);
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(509, 214);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(75, 23);
            this.btnEncriptar.TabIndex = 6;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(509, 247);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(509, 279);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(71, 307);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 9;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(74, 334);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(652, 83);
            this.txtResultado.TabIndex = 10;
            // 
            // frmCesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.grOpcion);
            this.Controls.Add(this.txtLlave);
            this.Controls.Add(this.lblLlave);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCesar";
            this.Text = "Encriptador/Desencriptador de Código de César";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grOpcion.ResumeLayout(false);
            this.grOpcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label lblLlave;
        private System.Windows.Forms.TextBox txtLlave;
        private System.Windows.Forms.GroupBox grOpcion;
        private System.Windows.Forms.RadioButton rdbDesencriptar;
        private System.Windows.Forms.RadioButton rdbEncriptar;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
    }
}