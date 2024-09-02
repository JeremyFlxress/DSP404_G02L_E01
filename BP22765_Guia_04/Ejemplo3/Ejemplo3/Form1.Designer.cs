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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResul = new Label();
            cmbOperaciones = new ComboBox();
            nudN1 = new NumericUpDown();
            nudN2 = new NumericUpDown();
            btnCalcular = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)nudN1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudN2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 103);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero uno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 188);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero dos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 142);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 2;
            label3.Text = "Operaciones Disponibles";
            // 
            // lblResul
            // 
            lblResul.AutoSize = true;
            lblResul.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResul.Location = new Point(121, 279);
            lblResul.Name = "lblResul";
            lblResul.Size = new Size(0, 20);
            lblResul.TabIndex = 3;
            // 
            // cmbOperaciones
            // 
            cmbOperaciones.FormattingEnabled = true;
            cmbOperaciones.Location = new Point(309, 169);
            cmbOperaciones.Name = "cmbOperaciones";
            cmbOperaciones.Size = new Size(132, 23);
            cmbOperaciones.TabIndex = 4;
            // 
            // nudN1
            // 
            nudN1.Location = new Point(104, 95);
            nudN1.Name = "nudN1";
            nudN1.Size = new Size(134, 23);
            nudN1.TabIndex = 5;
            // 
            // nudN2
            // 
            nudN2.Location = new Point(102, 180);
            nudN2.Name = "nudN2";
            nudN2.Size = new Size(141, 23);
            nudN2.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(362, 256);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(119, 24);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(512, 256);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(101, 26);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(nudN2);
            Controls.Add(nudN1);
            Controls.Add(cmbOperaciones);
            Controls.Add(lblResul);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ejemplo3";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudN1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudN2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResul;
        private ComboBox cmbOperaciones;
        private NumericUpDown nudN1;
        private NumericUpDown nudN2;
        private Button btnCalcular;
        private Button btnSalir;
    }
}
