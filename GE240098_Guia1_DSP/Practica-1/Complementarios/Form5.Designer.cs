namespace Practica_1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboDia = new ComboBox();
            cboMes = new ComboBox();
            cboAnio = new ComboBox();
            btnValidar = new Button();
            btnFin = new Button();
            SuspendLayout();
            // 
            // cboDia
            // 
            cboDia.FormattingEnabled = true;
            cboDia.Location = new Point(312, 108);
            cboDia.Name = "cboDia";
            cboDia.Size = new Size(121, 23);
            cboDia.TabIndex = 0;
            // 
            // cboMes
            // 
            cboMes.FormattingEnabled = true;
            cboMes.Location = new Point(136, 108);
            cboMes.Name = "cboMes";
            cboMes.Size = new Size(121, 23);
            cboMes.TabIndex = 1;
            cboMes.SelectedIndexChanged += cboMes_SelectedIndexChanged;
            // 
            // cboAnio
            // 
            cboAnio.FormattingEnabled = true;
            cboAnio.Location = new Point(484, 108);
            cboAnio.Name = "cboAnio";
            cboAnio.Size = new Size(121, 23);
            cboAnio.TabIndex = 2;
            cboAnio.SelectedIndexChanged += cboAnio_SelectedIndexChanged;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(228, 213);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnFin
            // 
            btnFin.Location = new Point(396, 213);
            btnFin.Name = "btnFin";
            btnFin.Size = new Size(139, 23);
            btnFin.TabIndex = 4;
            btnFin.Text = "Salir del programa";
            btnFin.UseVisualStyleBackColor = true;
            btnFin.Click += btnFin_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFin);
            Controls.Add(btnValidar);
            Controls.Add(cboAnio);
            Controls.Add(cboMes);
            Controls.Add(cboDia);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboDia;
        private ComboBox cboMes;
        private ComboBox cboAnio;
        private Button btnValidar;
        private Button btnFin;
    }
}