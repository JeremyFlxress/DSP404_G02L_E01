
namespace Ejemplo3
{
    partial class Form1
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
            lblApe1 = new Label();
            lblApe2 = new Label();
            lblCUM = new Label();
            lblNom = new Label();
            txtApe1 = new TextBox();
            txtApe2 = new TextBox();
            txtCUM = new TextBox();
            txtNom = new TextBox();
            txtResul = new TextBox();
            btnAnalisis = new Button();
            btnFin = new Button();
            SuspendLayout();
            // 
            // lblApe1
            // 
            lblApe1.AutoSize = true;
            lblApe1.Location = new Point(23, 31);
            lblApe1.Name = "lblApe1";
            lblApe1.Size = new Size(73, 15);
            lblApe1.TabIndex = 0;
            lblApe1.Text = "1er Apellido:";
            // 
            // lblApe2
            // 
            lblApe2.AutoSize = true;
            lblApe2.Location = new Point(23, 74);
            lblApe2.Name = "lblApe2";
            lblApe2.Size = new Size(77, 15);
            lblApe2.TabIndex = 1;
            lblApe2.Text = "2do Apellido:";
            // 
            // lblCUM
            // 
            lblCUM.AutoSize = true;
            lblCUM.Location = new Point(23, 166);
            lblCUM.Name = "lblCUM";
            lblCUM.Size = new Size(79, 15);
            lblCUM.TabIndex = 3;
            lblCUM.Text = "Valor de CUM";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(23, 129);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(56, 15);
            lblNom.TabIndex = 2;
            lblNom.Text = "Nombres";
            // 
            // txtApe1
            // 
            txtApe1.Location = new Point(132, 31);
            txtApe1.Name = "txtApe1";
            txtApe1.Size = new Size(171, 23);
            txtApe1.TabIndex = 4;
            // 
            // txtApe2
            // 
            txtApe2.Location = new Point(132, 71);
            txtApe2.Name = "txtApe2";
            txtApe2.Size = new Size(171, 23);
            txtApe2.TabIndex = 5;
            // 
            // txtCUM
            // 
            txtCUM.Location = new Point(132, 158);
            txtCUM.Name = "txtCUM";
            txtCUM.Size = new Size(171, 23);
            txtCUM.TabIndex = 7;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(132, 121);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(171, 23);
            txtNom.TabIndex = 6;
            // 
            // txtResul
            // 
            txtResul.Enabled = false;
            txtResul.Location = new Point(23, 217);
            txtResul.Name = "txtResul";
            txtResul.Size = new Size(280, 23);
            txtResul.TabIndex = 8;
            txtResul.Text = "Resultado de evaluacion";
            // 
            // btnAnalisis
            // 
            btnAnalisis.Location = new Point(23, 280);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(141, 33);
            btnAnalisis.TabIndex = 9;
            btnAnalisis.Text = "Calcular UV";
            btnAnalisis.UseVisualStyleBackColor = true;
            btnAnalisis.Click += btnAnalisis_Click_1;
            // 
            // btnFin
            // 
            btnFin.Location = new Point(170, 280);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(133, 33);
            btnFin.TabIndex = 10;
            btnFin.Text = "Salir del programa ";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 362);
            Controls.Add(btnFin);
            Controls.Add(btnAnalisis);
            Controls.Add(txtResul);
            Controls.Add(txtCUM);
            Controls.Add(txtNom);
            Controls.Add(txtApe2);
            Controls.Add(txtApe1);
            Controls.Add(lblCUM);
            Controls.Add(lblNom);
            Controls.Add(lblApe2);
            Controls.Add(lblApe1);
            Name = "Form1";
            Text = "Calculo de UV ";
            
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnFin_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnalisis_Click_1(object sender, EventArgs e)
        {
            btnAnalisis.Enabled = false;
        }

        #endregion

        private Label lblApe1;
        private Label lblApe2;
        private Label lblCUM;
        private Label lblNom;
        private TextBox txtApe1;
        private TextBox txtApe2;
        private TextBox txtCUM;
        private TextBox txtNom;
        private TextBox txtResul;
        private Button btnAnalisis;
        private Button btnFin;
    }
}
