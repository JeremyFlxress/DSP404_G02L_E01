namespace complementario3
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
            btnAgregar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            txtNota = new TextBox();
            listBoxResultados = new ListBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 266);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(126, 30);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(158, 266);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(126, 30);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(299, 266);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(126, 30);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 51);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingrese Nota";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(122, 43);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(162, 23);
            txtNota.TabIndex = 4;
            // 
            // listBoxResultados
            // 
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.ItemHeight = 15;
            listBoxResultados.Location = new Point(12, 96);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(224, 154);
            listBoxResultados.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResultados);
            Controls.Add(txtNota);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Estadísticas de Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnAgregar;
        private Button btnSalir;
        private Label label1;
        private TextBox txtNota;
        private ListBox listBoxResultados;
    }
}
