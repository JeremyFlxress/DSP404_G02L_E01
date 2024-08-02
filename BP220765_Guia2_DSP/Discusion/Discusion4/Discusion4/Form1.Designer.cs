namespace Discusion4
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
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtValor = new TextBox();
            cmbInicial = new ComboBox();
            cmbFinal = new ComboBox();
            lblResultado1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 49);
            label1.Name = "label1";
            label1.Size = new Size(63, 30);
            label1.TabIndex = 0;
            label1.Text = "Valor";
            
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 206);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(130, 39);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(148, 206);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 39);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpair";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(284, 206);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 39);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(116, 56);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(143, 23);
            txtValor.TabIndex = 4;
            // 
            // cmbInicial
            // 
            cmbInicial.FormattingEnabled = true;
            cmbInicial.Location = new Point(25, 109);
            cmbInicial.Name = "cmbInicial";
            cmbInicial.Size = new Size(115, 23);
            cmbInicial.TabIndex = 5;
            // 
            // cmbFinal
            // 
            cmbFinal.FormattingEnabled = true;
            cmbFinal.Location = new Point(160, 109);
            cmbFinal.Name = "cmbFinal";
            cmbFinal.Size = new Size(115, 23);
            cmbFinal.TabIndex = 6;
            // 
            // lblResultado1
            // 
            lblResultado1.AutoSize = true;
            lblResultado1.Location = new Point(46, 331);
            lblResultado1.Name = "lblResultado1";
            lblResultado1.Size = new Size(0, 15);
            lblResultado1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado1);
            Controls.Add(cmbFinal);
            Controls.Add(cmbInicial);
            Controls.Add(txtValor);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtValor;
        private ComboBox cmbInicial;
        private ComboBox cmbFinal;
        private Label lblResultado1;
    }
}
