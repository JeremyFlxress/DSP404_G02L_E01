namespace Ejercicio01
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
            this.lbltema = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.nupBase = new System.Windows.Forms.NumericUpDown();
            this.gbrResult = new System.Windows.Forms.GroupBox();
            this.lstTabla2 = new System.Windows.Forms.ListBox();
            this.lstTabla1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).BeginInit();
            this.gbrResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltema
            // 
            this.lbltema.AutoSize = true;
            this.lbltema.Location = new System.Drawing.Point(48, 89);
            this.lbltema.Name = "lbltema";
            this.lbltema.Size = new System.Drawing.Size(80, 13);
            this.lbltema.TabIndex = 0;
            this.lbltema.Text = "Ingrese numero";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(51, 167);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(111, 39);
            this.btnCalculo.TabIndex = 1;
            this.btnCalculo.Text = "Ver tablas";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(51, 244);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 39);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Finalizar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // nupBase
            // 
            this.nupBase.DecimalPlaces = 1;
            this.nupBase.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nupBase.Location = new System.Drawing.Point(51, 120);
            this.nupBase.Maximum = new decimal(new int[] {
            69,
            0,
            0,
            65536});
            this.nupBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupBase.Name = "nupBase";
            this.nupBase.Size = new System.Drawing.Size(77, 20);
            this.nupBase.TabIndex = 3;
            this.nupBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // gbrResult
            // 
            this.gbrResult.Controls.Add(this.lstTabla2);
            this.gbrResult.Controls.Add(this.lstTabla1);
            this.gbrResult.Location = new System.Drawing.Point(225, 38);
            this.gbrResult.Name = "gbrResult";
            this.gbrResult.Size = new System.Drawing.Size(303, 308);
            this.gbrResult.TabIndex = 4;
            this.gbrResult.TabStop = false;
            this.gbrResult.Text = "Resultados";
            // 
            // lstTabla2
            // 
            this.lstTabla2.FormattingEnabled = true;
            this.lstTabla2.Location = new System.Drawing.Point(160, 35);
            this.lstTabla2.Name = "lstTabla2";
            this.lstTabla2.Size = new System.Drawing.Size(120, 251);
            this.lstTabla2.TabIndex = 1;
            this.lstTabla2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // lstTabla1
            // 
            this.lstTabla1.FormattingEnabled = true;
            this.lstTabla1.Location = new System.Drawing.Point(19, 35);
            this.lstTabla1.Name = "lstTabla1";
            this.lstTabla1.Size = new System.Drawing.Size(120, 251);
            this.lstTabla1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(571, 386);
            this.Controls.Add(this.gbrResult);
            this.Controls.Add(this.nupBase);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lbltema);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupBase)).EndInit();
            this.gbrResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltema;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.NumericUpDown nupBase;
        private System.Windows.Forms.GroupBox gbrResult;
        private System.Windows.Forms.ListBox lstTabla2;
        private System.Windows.Forms.ListBox lstTabla1;
    }
}

