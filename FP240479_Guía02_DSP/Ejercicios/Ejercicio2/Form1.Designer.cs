
namespace Ejercicio2
{
    partial class frmCesar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblLlave = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.grOpcion = new System.Windows.Forms.GroupBox();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.rdbEncriptar = new System.Windows.Forms.RadioButton();
            this.rdbDesencriptar = new System.Windows.Forms.RadioButton();
            this.grOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(200, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(163, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Encriptamiento por código César ";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(12, 68);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(204, 13);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Ingrese el texto a Encriptar / Desencriptar";
            // 
            // lblLlave
            // 
            this.lblLlave.AutoSize = true;
            this.lblLlave.Location = new System.Drawing.Point(321, 68);
            this.lblLlave.Name = "lblLlave";
            this.lblLlave.Size = new System.Drawing.Size(113, 13);
            this.lblLlave.TabIndex = 2;
            this.lblLlave.Text = "Llave (Numero Entero)";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(21, 286);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(35, 13);
            this.lblresultado.TabIndex = 3;
            this.lblresultado.Text = "label4";
            // 
            // txtLlave
            // 
            this.txtLlave.Location = new System.Drawing.Point(447, 65);
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(54, 20);
            this.txtLlave.TabIndex = 4;
            this.txtLlave.TextChanged += new System.EventHandler(this.txtLlave_TextChanged);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(15, 87);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(432, 88);
            this.txtTexto.TabIndex = 5;
            // 
            // grOpcion
            // 
            this.grOpcion.Controls.Add(this.rdbDesencriptar);
            this.grOpcion.Controls.Add(this.rdbEncriptar);
            this.grOpcion.Location = new System.Drawing.Point(60, 200);
            this.grOpcion.Name = "grOpcion";
            this.grOpcion.Size = new System.Drawing.Size(303, 67);
            this.grOpcion.TabIndex = 6;
            this.grOpcion.TabStop = false;
            this.grOpcion.Text = "Seleccione una opción";
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.Location = new System.Drawing.Point(423, 200);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(69, 20);
            this.btnEncriptar.TabIndex = 7;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = true;
            this.btnEncriptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(423, 231);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(69, 20);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(423, 267);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 20);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(15, 320);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(432, 106);
            this.txtResultado.TabIndex = 10;
            // 
            // rdbEncriptar
            // 
            this.rdbEncriptar.AutoSize = true;
            this.rdbEncriptar.Location = new System.Drawing.Point(30, 31);
            this.rdbEncriptar.Name = "rdbEncriptar";
            this.rdbEncriptar.Size = new System.Drawing.Size(70, 17);
            this.rdbEncriptar.TabIndex = 0;
            this.rdbEncriptar.TabStop = true;
            this.rdbEncriptar.Text = "Encriptar ";
            this.rdbEncriptar.UseVisualStyleBackColor = true;
            this.rdbEncriptar.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbDesencriptar
            // 
            this.rdbDesencriptar.AutoSize = true;
            this.rdbDesencriptar.Location = new System.Drawing.Point(178, 31);
            this.rdbDesencriptar.Name = "rdbDesencriptar";
            this.rdbDesencriptar.Size = new System.Drawing.Size(85, 17);
            this.rdbDesencriptar.TabIndex = 1;
            this.rdbDesencriptar.TabStop = true;
            this.rdbDesencriptar.Text = "Desencriptar";
            this.rdbDesencriptar.UseVisualStyleBackColor = true;
            this.rdbDesencriptar.CheckedChanged += new System.EventHandler(this.rdbDesencriptar_CheckedChanged);
            // 
            // frmCesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 460);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEncriptar);
            this.Controls.Add(this.grOpcion);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.txtLlave);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblLlave);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCesar";
            this.Text = "Encriptor / Desencriptador de Código de César";
            this.grOpcion.ResumeLayout(false);
            this.grOpcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblLlave;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtLlave;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.GroupBox grOpcion;
        private System.Windows.Forms.RadioButton rdbEncriptar;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.RadioButton rdbDesencriptar;
    }
}

