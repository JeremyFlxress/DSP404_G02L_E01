
namespace Discusion02
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
            btnTranspuesta = new Button();
            btnSalir = new Button();
            label1 = new Label();
            txtDimension = new TextBox();
            dgvMatriz = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).BeginInit();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(70, 233);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(111, 27);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar Matriz";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnTranspuesta
            // 
            btnTranspuesta.Location = new Point(163, 266);
            btnTranspuesta.Name = "btnTranspuesta";
            btnTranspuesta.Size = new Size(138, 27);
            btnTranspuesta.TabIndex = 1;
            btnTranspuesta.Text = "Calcular Transpuesta";
            btnTranspuesta.UseVisualStyleBackColor = true;
            btnTranspuesta.Click += btnTranspuesta_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(89, 299);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 27);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 98);
            label1.Name = "label1";
            label1.Size = new Size(137, 17);
            label1.TabIndex = 3;
            label1.Text = "Dimension de Matriz";
            // 
            // txtDimension
            // 
            txtDimension.Location = new Point(185, 95);
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(169, 23);
            txtDimension.TabIndex = 4;
            // 
            // dgvMatriz
            // 
            dgvMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatriz.Location = new Point(31, 124);
            dgvMatriz.Name = "dgvMatriz";
            dgvMatriz.Size = new Size(341, 100);
            dgvMatriz.TabIndex = 5;
            dgvMatriz.CellContentClick += dgvMatriz_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMatriz);
            Controls.Add(txtDimension);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnTranspuesta);
            Controls.Add(btnGenerar);
            Name = "Form1";
            Text = "Matriz";
            ((System.ComponentModel.ISupportInitialize)dgvMatriz).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dgvMatriz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnGenerar;
        private Button btnTranspuesta;
        private Button btnSalir;
        private Label label1;
        private TextBox txtDimension;
        private DataGridView dgvMatriz;
    }
}
