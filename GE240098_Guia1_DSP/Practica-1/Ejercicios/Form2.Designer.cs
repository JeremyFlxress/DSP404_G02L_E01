namespace Practica_1
{
    partial class Form2
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
            lblEmpresa = new Label();
            txtEmpresa = new TextBox();
            lblMonto = new Label();
            txtMonto = new TextBox();
            lblTiempo = new Label();
            txtTiempo = new TextBox();
            lblTasaInter = new Label();
            rbdInteres1 = new RadioButton();
            rdbInteres2 = new RadioButton();
            rdbInteres3 = new RadioButton();
            txtTasaInterEX = new TextBox();
            lstResul = new ListBox();
            btnAnalisis = new Button();
            btnFin = new Button();
            SuspendLayout();
            // 
            // lblEmpresa
            // 
            lblEmpresa.AutoSize = true;
            lblEmpresa.Location = new Point(75, 32);
            lblEmpresa.Name = "lblEmpresa";
            lblEmpresa.Size = new Size(118, 15);
            lblEmpresa.TabIndex = 0;
            lblEmpresa.Text = "Nombre de Empresa:";
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(216, 29);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(515, 23);
            txtEmpresa.TabIndex = 1;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(75, 92);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(113, 15);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto Prestamo ($)";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(194, 89);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(152, 23);
            txtMonto.TabIndex = 3;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(462, 92);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(83, 15);
            lblTiempo.TabIndex = 4;
            lblTiempo.Text = "Tiempo (años)";
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(551, 89);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(180, 23);
            txtTiempo.TabIndex = 5;
            txtTiempo.Text = "2";
            // 
            // lblTasaInter
            // 
            lblTasaInter.AutoSize = true;
            lblTasaInter.Location = new Point(75, 154);
            lblTasaInter.Name = "lblTasaInter";
            lblTasaInter.Size = new Size(73, 15);
            lblTasaInter.TabIndex = 6;
            lblTasaInter.Text = "Tasa Interes: ";
            // 
            // rbdInteres1
            // 
            rbdInteres1.AutoSize = true;
            rbdInteres1.Checked = true;
            rbdInteres1.Location = new Point(141, 211);
            rbdInteres1.Name = "rbdInteres1";
            rbdInteres1.Size = new Size(47, 19);
            rbdInteres1.TabIndex = 7;
            rbdInteres1.TabStop = true;
            rbdInteres1.Text = "12%";
            rbdInteres1.UseVisualStyleBackColor = true;
            rbdInteres1.CheckedChanged += rbdInteres1_CheckedChanged;
            // 
            // rdbInteres2
            // 
            rdbInteres2.AutoSize = true;
            rdbInteres2.Location = new Point(306, 211);
            rdbInteres2.Name = "rdbInteres2";
            rdbInteres2.Size = new Size(56, 19);
            rdbInteres2.TabIndex = 8;
            rdbInteres2.Text = "23.5%";
            rdbInteres2.UseVisualStyleBackColor = true;
            rdbInteres2.CheckedChanged += rdbInteres2_CheckedChanged;
            // 
            // rdbInteres3
            // 
            rdbInteres3.AutoSize = true;
            rdbInteres3.Location = new Point(489, 211);
            rdbInteres3.Name = "rdbInteres3";
            rdbInteres3.Size = new Size(101, 19);
            rdbInteres3.TabIndex = 9;
            rdbInteres3.Text = "Otro, indique: ";
            rdbInteres3.UseVisualStyleBackColor = true;
            rdbInteres3.CheckedChanged += rdbInteres3_CheckedChanged;
            // 
            // txtTasaInterEX
            // 
            txtTasaInterEX.Enabled = false;
            txtTasaInterEX.Location = new Point(618, 210);
            txtTasaInterEX.Name = "txtTasaInterEX";
            txtTasaInterEX.Size = new Size(113, 23);
            txtTasaInterEX.TabIndex = 10;
            txtTasaInterEX.Text = "0";
            // 
            // lstResul
            // 
            lstResul.Enabled = false;
            lstResul.FormattingEnabled = true;
            lstResul.ItemHeight = 15;
            lstResul.Items.AddRange(new object[] { "Resultados" });
            lstResul.Location = new Point(75, 260);
            lstResul.Name = "lstResul";
            lstResul.Size = new Size(656, 124);
            lstResul.TabIndex = 11;
            // 
            // btnAnalisis
            // 
            btnAnalisis.Location = new Point(151, 408);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(181, 23);
            btnAnalisis.TabIndex = 12;
            btnAnalisis.Text = "Análisis Financiero";
            btnAnalisis.UseVisualStyleBackColor = true;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // btnFin
            // 
            btnFin.Location = new Point(445, 408);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(181, 23);
            btnFin.TabIndex = 13;
            btnFin.Text = "Salir del Programa";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFin);
            Controls.Add(btnAnalisis);
            Controls.Add(lstResul);
            Controls.Add(txtTasaInterEX);
            Controls.Add(rdbInteres3);
            Controls.Add(rdbInteres2);
            Controls.Add(rbdInteres1);
            Controls.Add(lblTasaInter);
            Controls.Add(txtTiempo);
            Controls.Add(lblTiempo);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(txtEmpresa);
            Controls.Add(lblEmpresa);
            Name = "Form2";
            Text = "Calculo del Monto a pagar por un Prestamo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmpresa;
        private TextBox txtEmpresa;
        private Label lblMonto;
        private TextBox txtMonto;
        private Label lblTiempo;
        private TextBox txtTiempo;
        private Label lblTasaInter;
        private RadioButton rbdInteres1;
        private RadioButton rdbInteres2;
        private RadioButton rdbInteres3;
        private TextBox txtTasaInterEX;
        private ListBox lstResul;
        private Button btnAnalisis;
        private Button btnFin;
    }
}