
namespace complementario2
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
            btnMostrar = new Button();
            btnSalir = new Button();
            txtLimiteInferior = new TextBox();
            txtLimiteSuperior = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvMatriz = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).BeginInit();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(45, 97);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(115, 30);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(182, 97);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(115, 30);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(316, 97);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(115, 30);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtLimiteInferior
            // 
            txtLimiteInferior.Location = new Point(45, 164);
            txtLimiteInferior.Name = "txtLimiteInferior";
            txtLimiteInferior.Size = new Size(209, 23);
            txtLimiteInferior.TabIndex = 5;
            // 
            // txtLimiteSuperior
            // 
            txtLimiteSuperior.Location = new Point(45, 212);
            txtLimiteSuperior.Name = "txtLimiteSuperior";
            txtLimiteSuperior.Size = new Size(209, 23);
            txtLimiteSuperior.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 172);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 7;
            label1.Text = "Límite Inferior";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 220);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 8;
            label2.Text = "Límite Superior";
            label2.Click += label2_Click;
            // 
            // dgvMatriz
            // 
            dgvMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatriz.Location = new Point(31, 283);
            dgvMatriz.Name = "dgvMatriz";
            dgvMatriz.Size = new Size(313, 141);
            dgvMatriz.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMatriz);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLimiteSuperior);
            Controls.Add(txtLimiteInferior);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Name = "Form1";
            Text = "Matriz Aleatoria 5x5";
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnGenerar;
        private Button btnMostrar;
        private Button btnSalir;
        private TextBox txtLimiteInferior;
        private TextBox txtLimiteSuperior;
        private Label label1;
        private Label label2;
        private DataGridView dgvMatriz;
    }
}
