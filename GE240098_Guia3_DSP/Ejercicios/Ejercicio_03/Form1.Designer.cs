namespace Ejercicio_03
{
    partial class Form1
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
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.lblPalabra = new System.Windows.Forms.Label();
            this.txtSignificado = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.Location = new System.Drawing.Point(78, 46);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(176, 264);
            this.lstPalabras.TabIndex = 0;
            this.lstPalabras.SelectedIndexChanged += new System.EventHandler(this.lstPalabras_SelectedIndexChanged);
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPalabra.Location = new System.Drawing.Point(322, 46);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(43, 13);
            this.lblPalabra.TabIndex = 1;
            this.lblPalabra.Text = "Palabra";
            // 
            // txtSignificado
            // 
            this.txtSignificado.Location = new System.Drawing.Point(301, 130);
            this.txtSignificado.Multiline = true;
            this.txtSignificado.Name = "txtSignificado";
            this.txtSignificado.Size = new System.Drawing.Size(184, 180);
            this.txtSignificado.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(162, 378);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(195, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(527, 486);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtSignificado);
            this.Controls.Add(this.lblPalabra);
            this.Controls.Add(this.lstPalabras);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.TextBox txtSignificado;
        private System.Windows.Forms.Button btnSalir;
    }
}

