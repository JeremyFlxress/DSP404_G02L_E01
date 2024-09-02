namespace Ejemplo1
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
            btnCalculo = new Button();
            btnSalir = new Button();
            label1 = new Label();
            lstTabla1 = new ListBox();
            lstTabla2 = new ListBox();
            nupBase = new NumericUpDown();
            grbResult = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nupBase).BeginInit();
            grbResult.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalculo
            // 
            btnCalculo.Location = new Point(52, 271);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(124, 35);
            btnCalculo.TabIndex = 0;
            btnCalculo.Text = "Ver tablas";
            btnCalculo.UseVisualStyleBackColor = true;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(206, 271);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(124, 35);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Finalizar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 73);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 2;
            label1.Text = "Ingrese número";
            // 
            // lstTabla1
            // 
            lstTabla1.FormattingEnabled = true;
            lstTabla1.ItemHeight = 15;
            lstTabla1.Location = new Point(20, 40);
            lstTabla1.Name = "lstTabla1";
            lstTabla1.Size = new Size(104, 139);
            lstTabla1.TabIndex = 3;
            // 
            // lstTabla2
            // 
            lstTabla2.FormattingEnabled = true;
            lstTabla2.ItemHeight = 15;
            lstTabla2.Location = new Point(145, 40);
            lstTabla2.Name = "lstTabla2";
            lstTabla2.Size = new Size(104, 139);
            lstTabla2.TabIndex = 4;
            // 
            // nupBase
            // 
            nupBase.DecimalPlaces = 1;
            nupBase.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nupBase.Location = new Point(52, 107);
            nupBase.Maximum = new decimal(new int[] { 69, 0, 0, 65536 });
            nupBase.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nupBase.Name = "nupBase";
            nupBase.Size = new Size(124, 23);
            nupBase.TabIndex = 5;
            nupBase.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // grbResult
            // 
            grbResult.Controls.Add(lstTabla1);
            grbResult.Controls.Add(lstTabla2);
            grbResult.Location = new Point(197, 56);
            grbResult.Name = "grbResult";
            grbResult.Size = new Size(274, 209);
            grbResult.TabIndex = 6;
            grbResult.TabStop = false;
            grbResult.Text = "Resultados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbResult);
            Controls.Add(nupBase);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnCalculo);
            Name = "Form1";
            Text = "Ejemplo1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nupBase).EndInit();
            grbResult.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculo;
        private Button btnSalir;
        private Label label1;
        private ListBox lstTabla1;
        private ListBox lstTabla2;
        private NumericUpDown nupBase;
        private GroupBox grbResult;
    }
}
