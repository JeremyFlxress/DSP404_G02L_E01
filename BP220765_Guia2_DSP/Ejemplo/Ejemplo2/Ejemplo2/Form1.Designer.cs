namespace Ejemplo2
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
            btnCalcular = new Button();
            btnSalir = new Button();
            txtNumero = new TextBox();
            txtFactorial = new TextBox();
            lblNumero = new Label();
            lblFactorial = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(73, 234);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(102, 25);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(237, 234);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(102, 25);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(71, 164);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(104, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtFactorial
            // 
            txtFactorial.Enabled = false;
            txtFactorial.Location = new Point(237, 164);
            txtFactorial.Name = "txtFactorial";
            txtFactorial.Size = new Size(102, 23);
            txtFactorial.TabIndex = 3;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(73, 105);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Numero";
            lblNumero.Click += lblNumero_Click;
            // 
            // lblFactorial
            // 
            lblFactorial.AutoSize = true;
            lblFactorial.Location = new Point(237, 105);
            lblFactorial.Name = "lblFactorial";
            lblFactorial.Size = new Size(52, 15);
            lblFactorial.TabIndex = 5;
            lblFactorial.Text = "Factorial";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 321);
            Controls.Add(lblFactorial);
            Controls.Add(lblNumero);
            Controls.Add(txtFactorial);
            Controls.Add(txtNumero);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Calculando el factorial de un número";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnSalir;
        private TextBox txtNumero;
        private TextBox txtFactorial;
        private Label lblNumero;
        private Label lblFactorial;
    }
}
