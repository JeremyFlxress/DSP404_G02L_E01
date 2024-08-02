namespace Discusion3
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
            label7 = new Label();
            txtNumero = new TextBox();
            txtMayorNegativo = new TextBox();
            txtPositivos = new TextBox();
            txtPromedioNegativos = new TextBox();
            txtPorcentajePositivos = new TextBox();
            txtPorcentajeNegativos = new TextBox();
            txtPorcentajeCeros = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 50);
            label1.Name = "label1";
            label1.Size = new Size(120, 17);
            label1.TabIndex = 0;
            label1.Text = "Ingresar Numero :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 247);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 1;
            label2.Text = "Mayor Negativo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 333);
            label3.Name = "label3";
            label3.Size = new Size(134, 17);
            label3.TabIndex = 3;
            label3.Text = "Promedio Negativos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 290);
            label4.Name = "label4";
            label4.Size = new Size(112, 17);
            label4.TabIndex = 2;
            label4.Text = "Numero Positivo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 418);
            label5.Name = "label5";
            label5.Size = new Size(158, 17);
            label5.TabIndex = 5;
            label5.Text = "Porcentaje de Negativos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 374);
            label6.Name = "label6";
            label6.Size = new Size(152, 17);
            label6.TabIndex = 4;
            label6.Text = "Porcentaje de Positivos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 453);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 6;
            label7.Text = "Ceros";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(183, 46);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(139, 25);
            txtNumero.TabIndex = 7;
            // 
            // txtMayorNegativo
            // 
            txtMayorNegativo.Location = new Point(203, 238);
            txtMayorNegativo.Name = "txtMayorNegativo";
            txtMayorNegativo.Size = new Size(139, 25);
            txtMayorNegativo.TabIndex = 8;
            // 
            // txtPositivos
            // 
            txtPositivos.Location = new Point(203, 281);
            txtPositivos.Name = "txtPositivos";
            txtPositivos.Size = new Size(139, 25);
            txtPositivos.TabIndex = 9;
            // 
            // txtPromedioNegativos
            // 
            txtPromedioNegativos.Location = new Point(203, 324);
            txtPromedioNegativos.Name = "txtPromedioNegativos";
            txtPromedioNegativos.Size = new Size(139, 25);
            txtPromedioNegativos.TabIndex = 10;
            // 
            // txtPorcentajePositivos
            // 
            txtPorcentajePositivos.Location = new Point(203, 365);
            txtPorcentajePositivos.Name = "txtPorcentajePositivos";
            txtPorcentajePositivos.Size = new Size(139, 25);
            txtPorcentajePositivos.TabIndex = 11;
            // 
            // txtPorcentajeNegativos
            // 
            txtPorcentajeNegativos.Location = new Point(203, 409);
            txtPorcentajeNegativos.Name = "txtPorcentajeNegativos";
            txtPorcentajeNegativos.Size = new Size(139, 25);
            txtPorcentajeNegativos.TabIndex = 12;
            // 
            // txtPorcentajeCeros
            // 
            txtPorcentajeCeros.Location = new Point(203, 450);
            txtPorcentajeCeros.Name = "txtPorcentajeCeros";
            txtPorcentajeCeros.Size = new Size(139, 25);
            txtPorcentajeCeros.TabIndex = 13;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(37, 159);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(131, 37);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(191, 159);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(131, 37);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(352, 159);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(131, 37);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Location = new Point(389, 248);
            label8.Name = "label8";
            label8.Size = new Size(200, 34);
            label8.TabIndex = 17;
            label8.Text = "Se le recomienda Limpiar cada \r\nque quiera hacer nuevo calculo\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(914, 510);
            Controls.Add(label8);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtPorcentajeCeros);
            Controls.Add(txtPorcentajeNegativos);
            Controls.Add(txtPorcentajePositivos);
            Controls.Add(txtPromedioNegativos);
            Controls.Add(txtPositivos);
            Controls.Add(txtMayorNegativo);
            Controls.Add(txtNumero);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
        private Label label7;
        private TextBox txtNumero;
        private TextBox txtMayorNegativo;
        private TextBox txtPositivos;
        private TextBox txtPromedioNegativos;
        private TextBox txtPorcentajePositivos;
        private TextBox txtPorcentajeNegativos;
        private TextBox txtPorcentajeCeros;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label8;
    }
}
