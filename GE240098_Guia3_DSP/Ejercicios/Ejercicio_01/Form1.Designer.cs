namespace Ejercicio_01
{
    partial class Form1
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lstDesorden = new System.Windows.Forms.ListBox();
            this.lstOrdenada = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(104, 79);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(88, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Ingresar Numero:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(216, 76);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 1;
            // 
            // lstDesorden
            // 
            this.lstDesorden.FormattingEnabled = true;
            this.lstDesorden.Location = new System.Drawing.Point(107, 220);
            this.lstDesorden.Name = "lstDesorden";
            this.lstDesorden.Size = new System.Drawing.Size(177, 160);
            this.lstDesorden.TabIndex = 2;
            // 
            // lstOrdenada
            // 
            this.lstOrdenada.FormattingEnabled = true;
            this.lstOrdenada.Location = new System.Drawing.Point(322, 220);
            this.lstOrdenada.Name = "lstOrdenada";
            this.lstOrdenada.Size = new System.Drawing.Size(154, 160);
            this.lstOrdenada.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(416, 76);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Yellow;
            this.btnOrdenar.Location = new System.Drawing.Point(416, 123);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 5;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(589, 458);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstOrdenada);
            this.Controls.Add(this.lstDesorden);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNumero);
            this.Name = "Form1";
            this.Text = "Ordenar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListBox lstDesorden;
        private System.Windows.Forms.ListBox lstOrdenada;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnOrdenar;
    }
}