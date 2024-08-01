namespace com_3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.lstNegativeNumbers = new System.Windows.Forms.ListBox();
            this.lstPositiveNumbers = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblMinNegative = new System.Windows.Forms.Label();
            this.lblAvgPositive = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.AcceptsReturn = true;
            this.txtNumber.Location = new System.Drawing.Point(243, 80);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(83, 20);
            this.txtNumber.TabIndex = 0;
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(154, 131);
            this.btnAddNumber.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(102, 24);
            this.btnAddNumber.TabIndex = 1;
            this.btnAddNumber.Text = "añadir numeros";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // lstNegativeNumbers
            // 
            this.lstNegativeNumbers.FormattingEnabled = true;
            this.lstNegativeNumbers.Location = new System.Drawing.Point(154, 190);
            this.lstNegativeNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.lstNegativeNumbers.Name = "lstNegativeNumbers";
            this.lstNegativeNumbers.Size = new System.Drawing.Size(81, 56);
            this.lstNegativeNumbers.TabIndex = 2;
            // 
            // lstPositiveNumbers
            // 
            this.lstPositiveNumbers.FormattingEnabled = true;
            this.lstPositiveNumbers.Location = new System.Drawing.Point(345, 190);
            this.lstPositiveNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.lstPositiveNumbers.Name = "lstPositiveNumbers";
            this.lstPositiveNumbers.Size = new System.Drawing.Size(81, 56);
            this.lstPositiveNumbers.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(345, 131);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(56, 24);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblMinNegative
            // 
            this.lblMinNegative.AutoSize = true;
            this.lblMinNegative.Location = new System.Drawing.Point(266, 255);
            this.lblMinNegative.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinNegative.Name = "lblMinNegative";
            this.lblMinNegative.Size = new System.Drawing.Size(35, 13);
            this.lblMinNegative.TabIndex = 5;
            this.lblMinNegative.Text = "label1";
            // 
            // lblAvgPositive
            // 
            this.lblAvgPositive.AutoSize = true;
            this.lblAvgPositive.Location = new System.Drawing.Point(266, 286);
            this.lblAvgPositive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvgPositive.Name = "lblAvgPositive";
            this.lblAvgPositive.Size = new System.Drawing.Size(35, 13);
            this.lblAvgPositive.TabIndex = 6;
            this.lblAvgPositive.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "COLOQUE UN NUMERO, LUEGO SELECCIONE AÑADIR NUMERO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(582, 365);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAvgPositive);
            this.Controls.Add(this.lblMinNegative);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstPositiveNumbers);
            this.Controls.Add(this.lstNegativeNumbers);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.txtNumber);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.ListBox lstNegativeNumbers;
        private System.Windows.Forms.ListBox lstPositiveNumbers;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblMinNegative;
        private System.Windows.Forms.Label lblAvgPositive;
        private System.Windows.Forms.TextBox textBox1;
    }
}

