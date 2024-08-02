namespace Ejemplo5
{
    partial class frmULAM
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
            btnSalir = new Button();
            lblNumero = new Label();
            label2 = new Label();
            txtnumero = new TextBox();
            lstLista = new ListBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(54, 101);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(111, 33);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(54, 158);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(111, 33);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(54, 218);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 33);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(206, 101);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(109, 15);
            lblNumero.TabIndex = 3;
            lblNumero.Text = "Sucesión de ULAM:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 48);
            label2.Name = "label2";
            label2.Size = new Size(155, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingrese un número positivo:";
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(227, 48);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(156, 23);
            txtnumero.TabIndex = 7;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.ItemHeight = 15;
            lstLista.Location = new Point(206, 131);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(163, 109);
            lstLista.TabIndex = 8;
            // 
            // frmULAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 331);
            Controls.Add(lstLista);
            Controls.Add(txtnumero);
            Controls.Add(label2);
            Controls.Add(lblNumero);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Name = "frmULAM";
            Text = "Sucesión de ULAM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblNumero;
        private Label label2;
        private TextBox txtnumero;
        private ListBox lstLista;
    }
}
