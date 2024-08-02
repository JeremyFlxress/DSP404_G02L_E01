namespace Discusion2
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            txtNumero3 = new TextBox();
            txtNumero4 = new TextBox();
            txtPromedio = new TextBox();
            txtDesviacionTipica = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Numero 1 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 74);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese Numero 2 :\r\n";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 120);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingrese Numero 3 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 163);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 3;
            label4.Text = "Ingrese Numero 4 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 315);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 4;
            label5.Text = "Resultado Promedio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 367);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 5;
            label6.Text = "Resultado Desviacion";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 224);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 36);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(132, 224);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(103, 36);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(251, 224);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 36);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(156, 27);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(125, 23);
            txtNumero1.TabIndex = 9;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(156, 66);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(125, 23);
            txtNumero2.TabIndex = 10;
            // 
            // txtNumero3
            // 
            txtNumero3.Location = new Point(156, 120);
            txtNumero3.Name = "txtNumero3";
            txtNumero3.Size = new Size(125, 23);
            txtNumero3.TabIndex = 11;
            // 
            // txtNumero4
            // 
            txtNumero4.Location = new Point(156, 163);
            txtNumero4.Name = "txtNumero4";
            txtNumero4.Size = new Size(125, 23);
            txtNumero4.TabIndex = 12;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(178, 307);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(125, 23);
            txtPromedio.TabIndex = 13;
            // 
            // txtDesviacionTipica
            // 
            txtDesviacionTipica.Location = new Point(178, 364);
            txtDesviacionTipica.Name = "txtDesviacionTipica";
            txtDesviacionTipica.Size = new Size(125, 23);
            txtDesviacionTipica.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDesviacionTipica);
            Controls.Add(txtPromedio);
            Controls.Add(txtNumero4);
            Controls.Add(txtNumero3);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private TextBox txtNumero3;
        private TextBox txtNumero4;
        private TextBox txtPromedio;
        private TextBox txtDesviacionTipica;
    }
}
