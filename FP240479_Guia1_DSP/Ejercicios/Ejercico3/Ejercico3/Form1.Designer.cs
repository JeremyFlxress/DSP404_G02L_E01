namespace Ejercico3
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
            this.lblApe1 = new System.Windows.Forms.Label();
            this.txtApe1 = new System.Windows.Forms.TextBox();
            this.btnAnalisis = new System.Windows.Forms.Button();
            this.lblApe2 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCUM = new System.Windows.Forms.Label();
            this.txtApe2 = new System.Windows.Forms.TextBox();
            this.txtCUM = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.btnFin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApe1
            // 
            this.lblApe1.AutoSize = true;
            this.lblApe1.Location = new System.Drawing.Point(52, 54);
            this.lblApe1.Name = "lblApe1";
            this.lblApe1.Size = new System.Drawing.Size(62, 13);
            this.lblApe1.TabIndex = 0;
            this.lblApe1.Text = "1er Apellido";
            // 
            // txtApe1
            // 
            this.txtApe1.Location = new System.Drawing.Point(132, 51);
            this.txtApe1.Name = "txtApe1";
            this.txtApe1.Size = new System.Drawing.Size(264, 20);
            this.txtApe1.TabIndex = 1;
            // 
            // btnAnalisis
            // 
            this.btnAnalisis.Location = new System.Drawing.Point(138, 305);
            this.btnAnalisis.Name = "btnAnalisis";
            this.btnAnalisis.Size = new System.Drawing.Size(94, 32);
            this.btnAnalisis.TabIndex = 2;
            this.btnAnalisis.Text = "Calcular UV";
            this.btnAnalisis.UseVisualStyleBackColor = true;
            this.btnAnalisis.Click += new System.EventHandler(this.btnAnalisis_Click);
            // 
            // lblApe2
            // 
            this.lblApe2.AutoSize = true;
            this.lblApe2.Location = new System.Drawing.Point(52, 100);
            this.lblApe2.Name = "lblApe2";
            this.lblApe2.Size = new System.Drawing.Size(50, 13);
            this.lblApe2.TabIndex = 3;
            this.lblApe2.Text = "2Apellido";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(52, 148);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(49, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nombres";
            // 
            // lblCUM
            // 
            this.lblCUM.AutoSize = true;
            this.lblCUM.Location = new System.Drawing.Point(52, 201);
            this.lblCUM.Name = "lblCUM";
            this.lblCUM.Size = new System.Drawing.Size(73, 13);
            this.lblCUM.TabIndex = 5;
            this.lblCUM.Text = "Valor de CUM";
            // 
            // txtApe2
            // 
            this.txtApe2.Location = new System.Drawing.Point(132, 100);
            this.txtApe2.Name = "txtApe2";
            this.txtApe2.Size = new System.Drawing.Size(264, 20);
            this.txtApe2.TabIndex = 6;
            // 
            // txtCUM
            // 
            this.txtCUM.Location = new System.Drawing.Point(132, 194);
            this.txtCUM.Name = "txtCUM";
            this.txtCUM.Size = new System.Drawing.Size(264, 20);
            this.txtCUM.TabIndex = 7;
            this.txtCUM.Text = "0.0";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(132, 145);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(264, 20);
            this.txtNom.TabIndex = 8;
            // 
            // txtResul
            // 
            this.txtResul.Location = new System.Drawing.Point(55, 253);
            this.txtResul.Name = "txtResul";
            this.txtResul.Size = new System.Drawing.Size(420, 20);
            this.txtResul.TabIndex = 9;
            this.txtResul.Text = "Resultado de evaluación ";
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(339, 305);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(111, 32);
            this.btnFin.TabIndex = 10;
            this.btnFin.Text = "Salir del Programa";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 372);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtCUM);
            this.Controls.Add(this.txtApe2);
            this.Controls.Add(this.lblCUM);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblApe2);
            this.Controls.Add(this.btnAnalisis);
            this.Controls.Add(this.txtApe1);
            this.Controls.Add(this.lblApe1);
            this.Name = "Form1";
            this.Text = "Calculo de UV a cursar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApe1;
        private System.Windows.Forms.TextBox txtApe1;
        private System.Windows.Forms.Button btnAnalisis;
        private System.Windows.Forms.Label lblApe2;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCUM;
        private System.Windows.Forms.TextBox txtApe2;
        private System.Windows.Forms.TextBox txtCUM;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.Button btnFin;
    }
}

