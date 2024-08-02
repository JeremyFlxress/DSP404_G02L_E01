namespace Ejemplo3
{
    partial class frmCesar
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
            btnEncriptar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lbltitulo = new Label();
            lbltexto = new Label();
            lblllave = new Label();
            lblresultado = new Label();
            txtLlave = new TextBox();
            txtTexto = new TextBox();
            txtResultado = new TextBox();
            rdbEncriptar = new RadioButton();
            rdbDesencriptar = new RadioButton();
            grOpcion = new GroupBox();
            grOpcion.SuspendLayout();
            SuspendLayout();
            // 
            // btnEncriptar
            // 
            btnEncriptar.Location = new Point(515, 222);
            btnEncriptar.Name = "btnEncriptar";
            btnEncriptar.Size = new Size(107, 25);
            btnEncriptar.TabIndex = 0;
            btnEncriptar.Text = "Encriptar";
            btnEncriptar.UseVisualStyleBackColor = true;
            btnEncriptar.Click += btnEncriptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(515, 252);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(107, 25);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(515, 281);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 25);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Location = new Point(370, 28);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(181, 15);
            lbltitulo.TabIndex = 3;
            lbltitulo.Text = "Encriptamiento por código César";
            // 
            // lbltexto
            // 
            lbltexto.AutoSize = true;
            lbltexto.Location = new Point(77, 61);
            lbltexto.Name = "lbltexto";
            lbltexto.Size = new Size(217, 15);
            lbltexto.TabIndex = 4;
            lbltexto.Text = "Ingrese el texto a Encriptar/Desencriptar";
            // 
            // lblllave
            // 
            lblllave.AutoSize = true;
            lblllave.Location = new Point(361, 67);
            lblllave.Name = "lblllave";
            lblllave.Size = new Size(175, 15);
            lblllave.TabIndex = 5;
            lblllave.Text = "Llave (Digite un número entero)";
            lblllave.Click += lblllave_Click;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(61, 28);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(0, 15);
            lblresultado.TabIndex = 6;
            // 
            // txtLlave
            // 
            txtLlave.Location = new Point(542, 64);
            txtLlave.Name = "txtLlave";
            txtLlave.Size = new Size(190, 23);
            txtLlave.TabIndex = 7;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(77, 90);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(655, 126);
            txtTexto.TabIndex = 8;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(74, 312);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(658, 126);
            txtResultado.TabIndex = 9;
            // 
            // rdbEncriptar
            // 
            rdbEncriptar.AutoSize = true;
            rdbEncriptar.Checked = true;
            rdbEncriptar.Location = new Point(22, 40);
            rdbEncriptar.Name = "rdbEncriptar";
            rdbEncriptar.Size = new Size(72, 19);
            rdbEncriptar.TabIndex = 10;
            rdbEncriptar.TabStop = true;
            rdbEncriptar.Text = "Encriptar";
            rdbEncriptar.UseVisualStyleBackColor = true;
            // 
            // rdbDesencriptar
            // 
            rdbDesencriptar.AutoSize = true;
            rdbDesencriptar.Location = new Point(234, 40);
            rdbDesencriptar.Name = "rdbDesencriptar";
            rdbDesencriptar.Size = new Size(91, 19);
            rdbDesencriptar.TabIndex = 11;
            rdbDesencriptar.Text = "Desencriptar";
            rdbDesencriptar.UseVisualStyleBackColor = true;
            // 
            // grOpcion
            // 
            grOpcion.Controls.Add(rdbDesencriptar);
            grOpcion.Controls.Add(rdbEncriptar);
            grOpcion.Location = new Point(74, 227);
            grOpcion.Name = "grOpcion";
            grOpcion.Size = new Size(334, 79);
            grOpcion.TabIndex = 12;
            grOpcion.TabStop = false;
            grOpcion.Text = "Seleccione una opción";
            // 
            // frmCesar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grOpcion);
            Controls.Add(txtResultado);
            Controls.Add(txtTexto);
            Controls.Add(txtLlave);
            Controls.Add(lblresultado);
            Controls.Add(lblllave);
            Controls.Add(lbltexto);
            Controls.Add(lbltitulo);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEncriptar);
            Name = "frmCesar";
            Text = "Encriptador/Desencriptador de Código de César";
            Load += frmCesar_Load;
            grOpcion.ResumeLayout(false);
            grOpcion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncriptar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lbltitulo;
        private Label lbltexto;
        private Label lblllave;
        private Label lblresultado;
        private TextBox txtLlave;
        private TextBox txtTexto;
        private TextBox txtResultado;
        private RadioButton rdbEncriptar;
        private RadioButton rdbDesencriptar;
        private GroupBox grOpcion;
    }
}
