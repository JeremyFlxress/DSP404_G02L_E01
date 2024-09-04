namespace Ejercicio_01
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
            this.lblTema = new System.Windows.Forms.Label();
            this.nupBase = new System.Windows.Forms.NumericUpDown();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.lstTabla1 = new System.Windows.Forms.ListBox();
            this.lstTabla2 = new System.Windows.Forms.ListBox();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).BeginInit();
            this.grbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(68, 100);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(98, 13);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Ingrese un número:";
            // 
            // nupBase
            // 
            this.nupBase.DecimalPlaces = 1;
            this.nupBase.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupBase.Location = new System.Drawing.Point(71, 142);
            this.nupBase.Maximum = new decimal(new int[] {
            69,
            0,
            0,
            65536});
            this.nupBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupBase.Name = "nupBase";
            this.nupBase.Size = new System.Drawing.Size(120, 20);
            this.nupBase.TabIndex = 1;
            this.nupBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.lstTabla2);
            this.grbResult.Controls.Add(this.lstTabla1);
            this.grbResult.Location = new System.Drawing.Point(280, 29);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(365, 382);
            this.grbResult.TabIndex = 2;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Resultados";
            // 
            // lstTabla1
            // 
            this.lstTabla1.FormattingEnabled = true;
            this.lstTabla1.Location = new System.Drawing.Point(30, 40);
            this.lstTabla1.Name = "lstTabla1";
            this.lstTabla1.Size = new System.Drawing.Size(158, 316);
            this.lstTabla1.TabIndex = 0;
            // 
            // lstTabla2
            // 
            this.lstTabla2.FormattingEnabled = true;
            this.lstTabla2.Location = new System.Drawing.Point(194, 40);
            this.lstTabla2.Name = "lstTabla2";
            this.lstTabla2.Size = new System.Drawing.Size(165, 316);
            this.lstTabla2.TabIndex = 1;
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(71, 238);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(153, 51);
            this.btnCalculo.TabIndex = 3;
            this.btnCalculo.Text = "Ver tablas";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(71, 295);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(153, 50);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.nupBase);
            this.Controls.Add(this.lblTema);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).EndInit();
            this.grbResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.NumericUpDown nupBase;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.ListBox lstTabla2;
        private System.Windows.Forms.ListBox lstTabla1;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnFinalizar;
    }
}

