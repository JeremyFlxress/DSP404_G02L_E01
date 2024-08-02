namespace Discusion03
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
            label1 = new Label();
            label2 = new Label();
            dgvNotas = new DataGridView();
            dgvMedia = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedia).BeginInit();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(53, 296);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(127, 48);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(362, 296);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(150, 48);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 57);
            label1.Name = "label1";
            label1.Size = new Size(116, 17);
            label1.TabIndex = 2;
            label1.Text = "Nota de Alumnos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(386, 57);
            label2.Name = "label2";
            label2.Size = new Size(105, 17);
            label2.TabIndex = 3;
            label2.Text = "Media de Notas\r\n";
            // 
            // dgvNotas
            // 
            dgvNotas.AllowUserToAddRows = false;
            dgvNotas.AllowUserToDeleteRows = false;
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Location = new Point(16, 114);
            dgvNotas.Name = "dgvNotas";
            dgvNotas.ReadOnly = true;
            dgvNotas.Size = new Size(322, 149);
            dgvNotas.TabIndex = 4;
            
            // 
            // dgvMedia
            // 
            dgvMedia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedia.Location = new Point(362, 114);
            dgvMedia.Name = "dgvMedia";
            dgvMedia.Size = new Size(285, 149);
            dgvMedia.TabIndex = 5;
            
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMedia);
            Controls.Add(dgvNotas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Notas Colegio";
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private DataGridView dgvNotas;
        private DataGridView dgvMedia;
    }
}
