namespace ejemplo1
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
            btnContar = new Button();
            btnReinicio = new Button();
            btnFin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnContar
            // 
            btnContar.Location = new Point(145, 246);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(111, 47);
            btnContar.TabIndex = 0;
            btnContar.Text = "Contar";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // btnReinicio
            // 
            btnReinicio.Location = new Point(294, 246);
            btnReinicio.Name = "btnReinicio";
            btnReinicio.Size = new Size(105, 47);
            btnReinicio.TabIndex = 1;
            btnReinicio.Text = "Reinicio";
            btnReinicio.UseVisualStyleBackColor = true;
            btnReinicio.Click += btnReinicio_Click;
            // 
            // btnFin
            // 
            btnFin.Location = new Point(425, 246);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(105, 49);
            btnFin.TabIndex = 2;
            btnFin.Text = "Salir programa";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Location = new Point(228, 123);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 3;
            label1.Text = "Pruebas de ámbito de variables";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnFin);
            Controls.Add(btnReinicio);
            Controls.Add(btnContar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnContar;
        private Button btnReinicio;
        private Button btnFin;
        private Label label1;
    }
}
