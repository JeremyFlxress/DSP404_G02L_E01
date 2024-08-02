namespace Discusion1
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
            btnGenerar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            txtNumero = new TextBox();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(27, 196);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(122, 28);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Calcular";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(168, 196);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(122, 28);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(296, 196);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(122, 28);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingresar Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(124, 60);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(128, 23);
            txtNumero.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(34, 284);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 79);
            listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGenerar);
            Name = "Form1";
            Text = "Serie fibonaci";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label label1;
        private TextBox txtNumero;
        private ListBox listBox1;
    }
}
