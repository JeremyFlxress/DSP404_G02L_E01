namespace Complementario_02
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtOriginalMatriz = new System.Windows.Forms.TextBox();
            this.txtTranspuesta = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la dimensión de la matriz: ";
            // 
            // txtDimension
            // 
            this.txtDimension.Location = new System.Drawing.Point(287, 90);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(100, 20);
            this.txtDimension.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnGenerate.Location = new System.Drawing.Point(474, 69);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generar Matriz";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtOriginalMatriz
            // 
            this.txtOriginalMatriz.Location = new System.Drawing.Point(142, 204);
            this.txtOriginalMatriz.Multiline = true;
            this.txtOriginalMatriz.Name = "txtOriginalMatriz";
            this.txtOriginalMatriz.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOriginalMatriz.Size = new System.Drawing.Size(177, 132);
            this.txtOriginalMatriz.TabIndex = 3;
            // 
            // txtTranspuesta
            // 
            this.txtTranspuesta.Location = new System.Drawing.Point(373, 204);
            this.txtTranspuesta.Multiline = true;
            this.txtTranspuesta.Name = "txtTranspuesta";
            this.txtTranspuesta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTranspuesta.Size = new System.Drawing.Size(176, 132);
            this.txtTranspuesta.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(474, 148);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Lime;
            this.btnNuevo.Location = new System.Drawing.Point(474, 108);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 458);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtTranspuesta);
            this.Controls.Add(this.txtOriginalMatriz);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtDimension);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDimension;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtOriginalMatriz;
        private System.Windows.Forms.TextBox txtTranspuesta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
    }
}

