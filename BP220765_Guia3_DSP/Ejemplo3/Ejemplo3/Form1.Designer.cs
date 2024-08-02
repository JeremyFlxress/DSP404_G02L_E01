namespace Ejemplo3
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
            btnsalir = new Button();
            lblpalabra = new Label();
            lstPalabras = new ListBox();
            txtsignificado = new TextBox();
            SuspendLayout();
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(126, 303);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(284, 26);
            btnsalir.TabIndex = 0;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // lblpalabra
            // 
            lblpalabra.AutoSize = true;
            lblpalabra.Location = new Point(264, 91);
            lblpalabra.Name = "lblpalabra";
            lblpalabra.Size = new Size(46, 15);
            lblpalabra.TabIndex = 1;
            lblpalabra.Text = "Palabra";
            // 
            // lstPalabras
            // 
            lstPalabras.FormattingEnabled = true;
            lstPalabras.ItemHeight = 15;
            lstPalabras.Location = new Point(76, 91);
            lstPalabras.Name = "lstPalabras";
            lstPalabras.Size = new Size(121, 184);
            lstPalabras.TabIndex = 2;
            lstPalabras.SelectedIndexChanged += lstPalabras_SelectedIndexChanged;
            // 
            // txtsignificado
            // 
            txtsignificado.Enabled = false;
            txtsignificado.Location = new Point(264, 139);
            txtsignificado.Multiline = true;
            txtsignificado.Name = "txtsignificado";
            txtsignificado.Size = new Size(193, 112);
            txtsignificado.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtsignificado);
            Controls.Add(lstPalabras);
            Controls.Add(lblpalabra);
            Controls.Add(btnsalir);
            Name = "Form1";
            Text = "Formulario";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsalir;
        private Label lblpalabra;
        private ListBox lstPalabras;
        private TextBox txtsignificado;
    }
}
