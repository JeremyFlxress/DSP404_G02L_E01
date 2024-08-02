namespace Ejemplo4
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
            btnLimpiar = new Button();
            lblNumero = new Label();
            lblReves = new Label();
            txtNumero = new TextBox();
            txtReves = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(127, 212);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 36);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(329, 212);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 36);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(127, 82);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Numero:";
            // 
            // lblReves
            // 
            lblReves.AutoSize = true;
            lblReves.Location = new Point(329, 82);
            lblReves.Name = "lblReves";
            lblReves.Size = new Size(40, 15);
            lblReves.TabIndex = 3;
            lblReves.Text = "Reves:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(127, 135);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(144, 23);
            txtNumero.TabIndex = 4;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // txtReves
            // 
            txtReves.Location = new Point(329, 135);
            txtReves.Name = "txtReves";
            txtReves.Size = new Size(144, 23);
            txtReves.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 319);
            Controls.Add(txtReves);
            Controls.Add(txtNumero);
            Controls.Add(lblReves);
            Controls.Add(lblNumero);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Mostrar un numero al reves";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnLimpiar;
        private Label lblNumero;
        private Label lblReves;
        private TextBox txtNumero;
        private TextBox txtReves;
    }
}
