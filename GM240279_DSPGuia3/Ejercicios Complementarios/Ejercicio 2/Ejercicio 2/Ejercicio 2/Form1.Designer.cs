namespace Ejercicio_2
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
            this.lblMatriz = new System.Windows.Forms.Label();
            this.txtMatriz = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgMatriz = new System.Windows.Forms.DataGridView();
            this.dgTranspuesta = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTranspuesta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatriz
            // 
            this.lblMatriz.AutoSize = true;
            this.lblMatriz.Location = new System.Drawing.Point(46, 19);
            this.lblMatriz.Name = "lblMatriz";
            this.lblMatriz.Size = new System.Drawing.Size(106, 26);
            this.lblMatriz.TabIndex = 0;
            this.lblMatriz.Text = "Ingrese la dimension \r\nde la matriz";
            // 
            // txtMatriz
            // 
            this.txtMatriz.Location = new System.Drawing.Point(158, 25);
            this.txtMatriz.Name = "txtMatriz";
            this.txtMatriz.Size = new System.Drawing.Size(100, 20);
            this.txtMatriz.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(289, 23);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(133, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Matriz";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dgMatriz
            // 
            this.dgMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatriz.Location = new System.Drawing.Point(10, 66);
            this.dgMatriz.Name = "dgMatriz";
            this.dgMatriz.Size = new System.Drawing.Size(354, 285);
            this.dgMatriz.TabIndex = 3;
            this.dgMatriz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgTranspuesta
            // 
            this.dgTranspuesta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTranspuesta.Location = new System.Drawing.Point(386, 66);
            this.dgTranspuesta.Name = "dgTranspuesta";
            this.dgTranspuesta.Size = new System.Drawing.Size(372, 285);
            this.dgTranspuesta.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(459, 23);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 363);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgTranspuesta);
            this.Controls.Add(this.dgMatriz);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtMatriz);
            this.Controls.Add(this.lblMatriz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTranspuesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatriz;
        private System.Windows.Forms.TextBox txtMatriz;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgMatriz;
        private System.Windows.Forms.DataGridView dgTranspuesta;
        private System.Windows.Forms.Button btnSalir;
    }
}

