namespace Ejemplo2
{
    partial class form1
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
            lblEmpresa = new Label();
            lblMonto = new Label();
            lblTiempo = new Label();
            lblTasaInter = new Label();
            btnAnalisis = new Button();
            btnFin = new Button();
            txtMonto = new TextBox();
            txtEmpresa = new TextBox();
            txtTiempo = new TextBox();
            txtTasaInterEX = new TextBox();
            rdbInteres1 = new RadioButton();
            rdbInteres2 = new RadioButton();
            rdbInteres3 = new RadioButton();
            lstResul = new ListBox();
            SuspendLayout();
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(12, 26);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(118, 15);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "Nombre de Empresa:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(12, 94);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(113, 15);
            lblMonto.TabIndex = 1;
            lblMonto.Text = "Monto Prestamo ($)";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(333, 91);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(83, 15);
            lblTiempo.TabIndex = 3;
            lblTiempo.Text = "Tiempo (años)";
            // 
            // lblTasaInter
            // 
            lblTasaInter.AutoSize = true;
            lblTasaInter.Location = new Point(12, 165);
            lblTasaInter.Name = "lblTasaInter";
            lblTasaInter.Size = new Size(70, 15);
            lblTasaInter.TabIndex = 2;
            lblTasaInter.Text = "Tasa Interes:";
            // 
            // btnAnalisis
            // 
            btnAnalisis.Location = new Point(50, 381);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(131, 36);
            btnAnalisis.TabIndex = 4;
            btnAnalisis.Text = "Análisis Financiero ";
            btnAnalisis.UseVisualStyleBackColor = true;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // btnFin
            // 
            btnFin.Location = new Point(216, 381);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(135, 36);
            btnFin.TabIndex = 5;
            btnFin.Text = "Salir del programa";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(151, 91);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(176, 23);
            txtMonto.TabIndex = 6;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(151, 23);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(176, 23);
            txtEmpresa.TabIndex = 7;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(421, 88);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(176, 23);
            txtTiempo.TabIndex = 9;
            txtTiempo.Text = "2";
            // 
            // txtTasaInterEX
            // 
            txtTasaInterEX.Enabled = false;
            txtTasaInterEX.Location = new Point(406, 228);
            txtTasaInterEX.Name = "txtTasaInterEX";
            txtTasaInterEX.Size = new Size(176, 23);
            txtTasaInterEX.TabIndex = 8;
            txtTasaInterEX.Text = "0";
            // 
            // rdbInteres1
            // 
            rdbInteres1.AutoSize = true;
            rdbInteres1.Checked = true;
            rdbInteres1.Location = new Point(24, 228);
            rdbInteres1.Name = "rdbInteres1";
            rdbInteres1.Size = new Size(47, 19);
            rdbInteres1.TabIndex = 10;
            rdbInteres1.TabStop = true;
            rdbInteres1.Text = "12%";
            rdbInteres1.UseVisualStyleBackColor = true;
            rdbInteres1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rdbInteres2
            // 
            rdbInteres2.AutoSize = true;
            rdbInteres2.Location = new Point(159, 228);
            rdbInteres2.Name = "rdbInteres2";
            rdbInteres2.Size = new Size(56, 19);
            rdbInteres2.TabIndex = 11;
            rdbInteres2.Text = "23.5%";
            rdbInteres2.UseVisualStyleBackColor = true;
            rdbInteres2.CheckedChanged += rdbInteres2_CheckedChanged;
            // 
            // rdbInteres3
            // 
            rdbInteres3.AutoSize = true;
            rdbInteres3.Location = new Point(295, 228);
            rdbInteres3.Name = "rdbInteres3";
            rdbInteres3.Size = new Size(95, 19);
            rdbInteres3.TabIndex = 12;
            rdbInteres3.Text = "Otro, indique";
            rdbInteres3.UseVisualStyleBackColor = true;
            rdbInteres3.CheckedChanged += rdbInteres3_CheckedChanged;
            // 
            // lstResul
            // 
            lstResul.Enabled = false;
            lstResul.FormattingEnabled = true;
            lstResul.ItemHeight = 15;
            lstResul.Location = new Point(66, 266);
            lstResul.Name = "lstResul";
            lstResul.Size = new Size(261, 94);
            lstResul.TabIndex = 13;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 439);
            Controls.Add(lstResul);
            Controls.Add(rdbInteres3);
            Controls.Add(rdbInteres2);
            Controls.Add(rdbInteres1);
            Controls.Add(txtTiempo);
            Controls.Add(txtTasaInterEX);
            Controls.Add(txtEmpresa);
            Controls.Add(txtMonto);
            Controls.Add(btnFin);
            Controls.Add(btnAnalisis);
            Controls.Add(lblTiempo);
            Controls.Add(lblTasaInter);
            Controls.Add(lblMonto);
            Controls.Add(lblEmpresa);
            Name = "form1";
            Text = "Calculo del Monto a pagar por un Prestamo ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpresa;
        private Label lblMonto;
        private Label lblTiempo;
        private Label lblTasaInter;
        private Button btnAnalisis;
        private Button btnFin;
        private TextBox txtMonto;
        private TextBox txtEmpresa;
        private TextBox txtTiempo;
        private TextBox txtTasaInterEX;
        private RadioButton rdbInteres1;
        private RadioButton rdbInteres2;
        private RadioButton rdbInteres3;
        private ListBox lstResul;
    }
}
