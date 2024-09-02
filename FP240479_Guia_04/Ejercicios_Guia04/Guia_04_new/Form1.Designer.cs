namespace Guia_04_new
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
            this.lbltema = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.nupBase = new System.Windows.Forms.NumericUpDown();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.lstTabla1 = new System.Windows.Forms.ListBox();
            this.lstTabla2 = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).BeginInit();
            this.grbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.Location = new System.Drawing.Point(48, 76);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(85, 13);
            this.lbltema.TabIndex = 0;
            this.lbltema.Text = "Ingrese Numero:";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(51, 210);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(134, 46);
            this.btnCalculo.TabIndex = 1;
            this.btnCalculo.Text = "Ver Tablas";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // nupBase
            // 
            this.nupBase.DecimalPlaces = 1;
            this.nupBase.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupBase.Location = new System.Drawing.Point(51, 126);
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
            this.nupBase.TabIndex = 3;
            this.nupBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.lstTabla1);
            this.grbResult.Controls.Add(this.lstTabla2);
            this.grbResult.Location = new System.Drawing.Point(245, 46);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(408, 313);
            this.grbResult.TabIndex = 4;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Resultados";
            // 
            // lstTabla1
            // 
            this.lstTabla1.FormattingEnabled = true;
            this.lstTabla1.Location = new System.Drawing.Point(16, 61);
            this.lstTabla1.Name = "lstTabla1";
            this.lstTabla1.Size = new System.Drawing.Size(157, 199);
            this.lstTabla1.TabIndex = 5;
            // 
            // lstTabla2
            // 
            this.lstTabla2.FormattingEnabled = true;
            this.lstTabla2.Location = new System.Drawing.Point(244, 61);
            this.lstTabla2.Name = "lstTabla2";
            this.lstTabla2.Size = new System.Drawing.Size(158, 199);
            this.lstTabla2.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(51, 289);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 41);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Finalizar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(665, 396);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.nupBase);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lbltema);
            this.Name = "Form1";
            this.Text = "Form1_Ejercicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).EndInit();
            this.grbResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltema;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.NumericUpDown nupBase;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.ListBox lstTabla1;
        private System.Windows.Forms.ListBox lstTabla2;
        private System.Windows.Forms.Button btnSalir;
    }
}

