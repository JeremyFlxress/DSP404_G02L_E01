namespace Ejemplo1
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
            this.btnContar = new System.Windows.Forms.Button();
            this.btnReinicio = new System.Windows.Forms.Button();
            this.BtnFin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(66, 92);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(133, 34);
            this.btnContar.TabIndex = 0;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnReinicio
            // 
            this.btnReinicio.Location = new System.Drawing.Point(66, 177);
            this.btnReinicio.Name = "btnReinicio";
            this.btnReinicio.Size = new System.Drawing.Size(133, 34);
            this.btnReinicio.TabIndex = 1;
            this.btnReinicio.Text = "Reinicio";
            this.btnReinicio.UseVisualStyleBackColor = true;
            this.btnReinicio.Click += new System.EventHandler(this.btnReinicio_Click);
            // 
            // BtnFin
            // 
            this.BtnFin.Location = new System.Drawing.Point(317, 177);
            this.BtnFin.Name = "BtnFin";
            this.BtnFin.Size = new System.Drawing.Size(133, 34);
            this.BtnFin.TabIndex = 2;
            this.BtnFin.Text = "Salir del Programa";
            this.BtnFin.UseVisualStyleBackColor = true;
            this.BtnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(352, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resultado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFin);
            this.Controls.Add(this.btnReinicio);
            this.Controls.Add(this.btnContar);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Pruebas de ámbito de variables";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnReinicio;
        private System.Windows.Forms.Button BtnFin;
        private System.Windows.Forms.Label label1;
    }
}

