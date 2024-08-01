namespace Ejercicio2
{
    partial class Form1
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
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTasaInter = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lstResul = new System.Windows.Forms.ListBox();
            this.rdbInteres1 = new System.Windows.Forms.RadioButton();
            this.rdbInteres2 = new System.Windows.Forms.RadioButton();
            this.rdbInteres3 = new System.Windows.Forms.RadioButton();
            this.txtTasaInterEX = new System.Windows.Forms.TextBox();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(34, 76);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(105, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "Nombre de empresa:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(40, 135);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(99, 13);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto Prestamo ($)";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(406, 135);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(74, 13);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo (años)";
            // 
            // lblTasaInter
            // 
            this.lblTasaInter.AutoSize = true;
            this.lblTasaInter.Location = new System.Drawing.Point(68, 196);
            this.lblTasaInter.Name = "lblTasaInter";
            this.lblTasaInter.Size = new System.Drawing.Size(68, 13);
            this.lblTasaInter.TabIndex = 3;
            this.lblTasaInter.Text = "Tasa interes:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(145, 69);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(612, 20);
            this.txtEmpresa.TabIndex = 4;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(145, 128);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(212, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(486, 128);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(197, 20);
            this.txtTiempo.TabIndex = 6;
            // 
            // lstResul
            // 
            this.lstResul.FormattingEnabled = true;
            this.lstResul.Items.AddRange(new object[] {
            "Resultados"});
            this.lstResul.Location = new System.Drawing.Point(71, 264);
            this.lstResul.Name = "lstResul";
            this.lstResul.Size = new System.Drawing.Size(674, 121);
            this.lstResul.TabIndex = 7;
            // 
            // rdbInteres1
            // 
            this.rdbInteres1.AutoSize = true;
            this.rdbInteres1.Location = new System.Drawing.Point(93, 232);
            this.rdbInteres1.Name = "rdbInteres1";
            this.rdbInteres1.Size = new System.Drawing.Size(45, 17);
            this.rdbInteres1.TabIndex = 8;
            this.rdbInteres1.TabStop = true;
            this.rdbInteres1.Text = "12%";
            this.rdbInteres1.UseVisualStyleBackColor = true;
            this.rdbInteres1.CheckedChanged += new System.EventHandler(this.rdbInteres1_CheckedChanged);
            // 
            // rdbInteres2
            // 
            this.rdbInteres2.AutoSize = true;
            this.rdbInteres2.Location = new System.Drawing.Point(272, 232);
            this.rdbInteres2.Name = "rdbInteres2";
            this.rdbInteres2.Size = new System.Drawing.Size(54, 17);
            this.rdbInteres2.TabIndex = 9;
            this.rdbInteres2.TabStop = true;
            this.rdbInteres2.Text = "23.5%";
            this.rdbInteres2.UseVisualStyleBackColor = true;
            this.rdbInteres2.CheckedChanged += new System.EventHandler(this.rdbInteres2_CheckedChanged);
            // 
            // rdbInteres3
            // 
            this.rdbInteres3.AutoSize = true;
            this.rdbInteres3.Location = new System.Drawing.Point(438, 232);
            this.rdbInteres3.Name = "rdbInteres3";
            this.rdbInteres3.Size = new System.Drawing.Size(88, 17);
            this.rdbInteres3.TabIndex = 10;
            this.rdbInteres3.TabStop = true;
            this.rdbInteres3.Text = "Otro, indique:";
            this.rdbInteres3.UseVisualStyleBackColor = true;
            this.rdbInteres3.CheckedChanged += new System.EventHandler(this.rdbInteres3_CheckedChanged);
            // 
            // txtTasaInterEX
            // 
            this.txtTasaInterEX.Enabled = false;
            this.txtTasaInterEX.Location = new System.Drawing.Point(560, 229);
            this.txtTasaInterEX.Name = "txtTasaInterEX";
            this.txtTasaInterEX.Size = new System.Drawing.Size(160, 20);
            this.txtTasaInterEX.TabIndex = 11;
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(246, 416);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(127, 22);
            this.btnAnalisis.TabIndex = 12;
            this.btnAnalisis.Text = "Análisis Financiero";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(438, 416);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(127, 22);
            this.btnFin.TabIndex = 13;
            this.btnFin.Text = "Salir del programa";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.txtTasaInterEX);
            this.Controls.Add(this.rdbInteres3);
            this.Controls.Add(this.rdbInteres2);
            this.Controls.Add(this.rdbInteres1);
            this.Controls.Add(this.lstResul);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblTasaInter);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblEmpresa);
            this.Name = "Form1";
            this.Text = "Calculo del Monto a pagar por un Prestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTasaInter;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.ListBox lstResul;
        private System.Windows.Forms.RadioButton rdbInteres1;
        private System.Windows.Forms.RadioButton rdbInteres2;
        private System.Windows.Forms.RadioButton rdbInteres3;
        private System.Windows.Forms.TextBox txtTasaInterEX;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Button btnFin;
    }
}

