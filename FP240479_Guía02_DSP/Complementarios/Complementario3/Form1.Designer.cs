
namespace Complementario3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblMayorNegativo = new System.Windows.Forms.TextBox();
            this.lblCantidadPositivos = new System.Windows.Forms.TextBox();
            this.lblPromedioNegativos = new System.Windows.Forms.TextBox();
            this.lblPorcentajePositivos = new System.Windows.Forms.TextBox();
            this.lblPorcentajeNegativos = new System.Windows.Forms.TextBox();
            this.lblPorcentajeCeros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los numeros que quiere evaluar: (Puede ingresar tantos numeros como quier" +
    "a) ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(81, 418);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(71, 30);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(208, 418);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(71, 30);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(339, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(71, 30);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(233, 59);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(46, 20);
            this.txtNum.TabIndex = 10;
            // 
            // lblMayorNegativo
            // 
            this.lblMayorNegativo.Location = new System.Drawing.Point(62, 115);
            this.lblMayorNegativo.Name = "lblMayorNegativo";
            this.lblMayorNegativo.Size = new System.Drawing.Size(198, 20);
            this.lblMayorNegativo.TabIndex = 11;
            // 
            // lblCantidadPositivos
            // 
            this.lblCantidadPositivos.Location = new System.Drawing.Point(62, 150);
            this.lblCantidadPositivos.Name = "lblCantidadPositivos";
            this.lblCantidadPositivos.Size = new System.Drawing.Size(198, 20);
            this.lblCantidadPositivos.TabIndex = 12;
            // 
            // lblPromedioNegativos
            // 
            this.lblPromedioNegativos.Location = new System.Drawing.Point(62, 188);
            this.lblPromedioNegativos.Name = "lblPromedioNegativos";
            this.lblPromedioNegativos.Size = new System.Drawing.Size(198, 20);
            this.lblPromedioNegativos.TabIndex = 13;
            // 
            // lblPorcentajePositivos
            // 
            this.lblPorcentajePositivos.Location = new System.Drawing.Point(62, 233);
            this.lblPorcentajePositivos.Name = "lblPorcentajePositivos";
            this.lblPorcentajePositivos.Size = new System.Drawing.Size(198, 20);
            this.lblPorcentajePositivos.TabIndex = 14;
            // 
            // lblPorcentajeNegativos
            // 
            this.lblPorcentajeNegativos.Location = new System.Drawing.Point(62, 275);
            this.lblPorcentajeNegativos.Name = "lblPorcentajeNegativos";
            this.lblPorcentajeNegativos.Size = new System.Drawing.Size(198, 20);
            this.lblPorcentajeNegativos.TabIndex = 15;
            // 
            // lblPorcentajeCeros
            // 
            this.lblPorcentajeCeros.Location = new System.Drawing.Point(62, 316);
            this.lblPorcentajeCeros.Name = "lblPorcentajeCeros";
            this.lblPorcentajeCeros.Size = new System.Drawing.Size(198, 20);
            this.lblPorcentajeCeros.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 478);
            this.Controls.Add(this.lblPorcentajeCeros);
            this.Controls.Add(this.lblPorcentajeNegativos);
            this.Controls.Add(this.lblPorcentajePositivos);
            this.Controls.Add(this.lblPromedioNegativos);
            this.Controls.Add(this.lblCantidadPositivos);
            this.Controls.Add(this.lblMayorNegativo);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox lblMayorNegativo;
        private System.Windows.Forms.TextBox lblCantidadPositivos;
        private System.Windows.Forms.TextBox lblPromedioNegativos;
        private System.Windows.Forms.TextBox lblPorcentajePositivos;
        private System.Windows.Forms.TextBox lblPorcentajeNegativos;
        private System.Windows.Forms.TextBox lblPorcentajeCeros;
    }
}

