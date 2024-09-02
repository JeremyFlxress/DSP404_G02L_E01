
namespace Complementario1
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
            btnCrear = new Button();
            btnMostrar = new Button();
            btnInsertar = new Button();
            btnRemover = new Button();
            txtValor = new TextBox();
            listBoxElementos = new ListBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 23);
            label1.Name = "label1";
            label1.Size = new Size(128, 17);
            label1.TabIndex = 0;
            label1.Text = "Simulación de Lista";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(39, 83);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(95, 26);
            btnCrear.TabIndex = 1;
            btnCrear.Text = "Crear Lista";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(39, 128);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(95, 26);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar Lista";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(39, 171);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(95, 26);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click_1;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(39, 212);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(95, 26);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(180, 86);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(163, 23);
            txtValor.TabIndex = 5;
            // 
            // listBoxElementos
            // 
            listBoxElementos.FormattingEnabled = true;
            listBoxElementos.ItemHeight = 15;
            listBoxElementos.Location = new Point(180, 128);
            listBoxElementos.Name = "listBoxElementos";
            listBoxElementos.Size = new Size(164, 199);
            listBoxElementos.TabIndex = 6;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(37, 261);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(101, 34);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(listBoxElementos);
            Controls.Add(txtValor);
            Controls.Add(btnRemover);
            Controls.Add(btnInsertar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(label1);
            Name = "Form1";
            Text = "SimulacionLista";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("Formulario cargado correctamente.");
        }

        #endregion

        private Label label1;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnInsertar;
        private Button btnRemover;
        private TextBox txtValor;
        private ListBox listBoxElementos;
        private Button btnSalir;
    }
}
