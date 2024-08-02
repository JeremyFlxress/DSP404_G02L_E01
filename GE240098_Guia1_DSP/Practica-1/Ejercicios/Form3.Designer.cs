namespace Practica_1
{
    partial class Form3
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
            lblApe1 = new Label();
            txtApe1 = new TextBox();
            lblApe2 = new Label();
            txtApe2 = new TextBox();
            txtNom = new TextBox();
            lblNom = new Label();
            lblCUM = new Label();
            txtCUM = new TextBox();
            txtResul = new TextBox();
            btnAnalisis = new Button();
            btnFin = new Button();
            SuspendLayout();
            // 
            // lblApe1
            // 
            lblApe1.AutoSize = true;
            lblApe1.Location = new Point(101, 80);
            lblApe1.Name = "lblApe1";
            lblApe1.Size = new Size(92, 15);
            lblApe1.TabIndex = 0;
            lblApe1.Text = "Primer Apellido:";
            // 
            // txtApe1
            // 
            txtApe1.Location = new Point(217, 77);
            txtApe1.Name = "txtApe1";
            txtApe1.Size = new Size(228, 23);
            txtApe1.TabIndex = 1;
            txtApe1.TextChanged += txtApe1_TextChanged;
            // 
            // lblApe2
            // 
            lblApe2.AutoSize = true;
            lblApe2.Location = new Point(101, 140);
            lblApe2.Name = "lblApe2";
            lblApe2.Size = new Size(104, 15);
            lblApe2.TabIndex = 2;
            lblApe2.Text = "Segundo Apellido:";
            // 
            // txtApe2
            // 
            txtApe2.Location = new Point(217, 137);
            txtApe2.Name = "txtApe2";
            txtApe2.Size = new Size(228, 23);
            txtApe2.TabIndex = 3;
            txtApe2.TextChanged += txtApe2_TextChanged;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(217, 198);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(228, 23);
            txtNom.TabIndex = 4;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(101, 201);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(56, 15);
            lblNom.TabIndex = 5;
            lblNom.Text = "Nombres";
            // 
            // lblCUM
            // 
            lblCUM.AutoSize = true;
            lblCUM.Location = new Point(101, 262);
            lblCUM.Name = "lblCUM";
            lblCUM.Size = new Size(79, 15);
            lblCUM.TabIndex = 6;
            lblCUM.Text = "Valor de CUM";
            // 
            // txtCUM
            // 
            txtCUM.Location = new Point(217, 259);
            txtCUM.Name = "txtCUM";
            txtCUM.Size = new Size(100, 23);
            txtCUM.TabIndex = 7;
            txtCUM.Text = "0.0";
            txtCUM.TextChanged += txtCUM_TextChanged;
            // 
            // txtResul
            // 
            txtResul.Enabled = false;
            txtResul.Location = new Point(101, 323);
            txtResul.Name = "txtResul";
            txtResul.Size = new Size(486, 23);
            txtResul.TabIndex = 8;
            txtResul.Text = "Resultado de evaluación";
            // 
            // btnAnalisis
            // 
            btnAnalisis.Location = new Point(166, 388);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(112, 23);
            btnAnalisis.TabIndex = 9;
            btnAnalisis.Text = "Calcular UV";
            btnAnalisis.UseVisualStyleBackColor = true;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // btnFin
            // 
            btnFin.Location = new Point(428, 388);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(159, 23);
            btnFin.TabIndex = 10;
            btnFin.Text = "Salir del Programa";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFin);
            Controls.Add(btnAnalisis);
            Controls.Add(txtResul);
            Controls.Add(txtCUM);
            Controls.Add(lblCUM);
            Controls.Add(lblNom);
            Controls.Add(txtNom);
            Controls.Add(txtApe2);
            Controls.Add(lblApe2);
            Controls.Add(txtApe1);
            Controls.Add(lblApe1);
            Name = "Form3";
            Text = "Calculo de UV a Cursar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApe1;
        private TextBox txtApe1;
        private Label lblApe2;
        private TextBox txtApe2;
        private TextBox txtNom;
        private Label lblNom;
        private Label lblCUM;
        private TextBox txtCUM;
        private TextBox txtResul;
        private Button btnAnalisis;
        private Button btnFin;
    }
}