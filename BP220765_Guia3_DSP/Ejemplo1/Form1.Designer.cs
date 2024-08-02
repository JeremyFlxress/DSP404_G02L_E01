namespace Ejemplo1
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
            this.btAgregar = new System.Windows.Forms.Button();
            this.btOrdenar = new System.Windows.Forms.Button();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lstdesorden = new System.Windows.Forms.ListBox();
            this.lstOrdenada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.SeaGreen;
            this.btAgregar.Location = new System.Drawing.Point(297, 57);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(134, 31);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btOrdenar
            // 
            this.btOrdenar.BackColor = System.Drawing.Color.Yellow;
            this.btOrdenar.Location = new System.Drawing.Point(297, 109);
            this.btOrdenar.Name = "btOrdenar";
            this.btOrdenar.Size = new System.Drawing.Size(134, 31);
            this.btOrdenar.TabIndex = 1;
            this.btOrdenar.Text = "Ordenar";
            this.btOrdenar.UseVisualStyleBackColor = false;
            this.btOrdenar.Click += new System.EventHandler(this.btOrdenar_Click);
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(32, 97);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(88, 13);
            this.lblnumero.TabIndex = 2;
            this.lblnumero.Text = "Ingresar Numero:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(126, 94);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(124, 20);
            this.txtNum.TabIndex = 3;
            // 
            // lstdesorden
            // 
            this.lstdesorden.FormattingEnabled = true;
            this.lstdesorden.Location = new System.Drawing.Point(53, 159);
            this.lstdesorden.Name = "lstdesorden";
            this.lstdesorden.Size = new System.Drawing.Size(173, 160);
            this.lstdesorden.TabIndex = 4;
            // 
            // lstOrdenada
            // 
            this.lstOrdenada.FormattingEnabled = true;
            this.lstOrdenada.Location = new System.Drawing.Point(297, 159);
            this.lstOrdenada.Name = "lstOrdenada";
            this.lstOrdenada.Size = new System.Drawing.Size(173, 160);
            this.lstOrdenada.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOrdenada);
            this.Controls.Add(this.lstdesorden);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.btOrdenar);
            this.Controls.Add(this.btAgregar);
            this.Name = "Form1";
            this.Text = "Ordenar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btOrdenar;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListBox lstdesorden;
        private System.Windows.Forms.ListBox lstOrdenada;
    }
}

