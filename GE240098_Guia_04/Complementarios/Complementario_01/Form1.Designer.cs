namespace Complemetario_01
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCrearLista = new System.Windows.Forms.Button();
            this.btnMostrarElementos = new System.Windows.Forms.Button();
            this.btnInsertarElemento = new System.Windows.Forms.Button();
            this.btnRemoverElemento = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite el valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(396, 82);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.Location = new System.Drawing.Point(163, 153);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(75, 23);
            this.btnCrearLista.TabIndex = 2;
            this.btnCrearLista.Text = "Crear lista";
            this.btnCrearLista.UseVisualStyleBackColor = true;
            this.btnCrearLista.Click += new System.EventHandler(this.btnCrearLista_Click);
            // 
            // btnMostrarElementos
            // 
            this.btnMostrarElementos.Location = new System.Drawing.Point(277, 153);
            this.btnMostrarElementos.Name = "btnMostrarElementos";
            this.btnMostrarElementos.Size = new System.Drawing.Size(110, 23);
            this.btnMostrarElementos.TabIndex = 3;
            this.btnMostrarElementos.Text = "Mostrar elementos";
            this.btnMostrarElementos.UseVisualStyleBackColor = true;
            this.btnMostrarElementos.Click += new System.EventHandler(this.btnMostrarElementos_Click);
            // 
            // btnInsertarElemento
            // 
            this.btnInsertarElemento.Location = new System.Drawing.Point(421, 153);
            this.btnInsertarElemento.Name = "btnInsertarElemento";
            this.btnInsertarElemento.Size = new System.Drawing.Size(111, 23);
            this.btnInsertarElemento.TabIndex = 4;
            this.btnInsertarElemento.Text = "Insertar elemento";
            this.btnInsertarElemento.UseVisualStyleBackColor = true;
            this.btnInsertarElemento.Click += new System.EventHandler(this.btnInsertarElemento_Click);
            // 
            // btnRemoverElemento
            // 
            this.btnRemoverElemento.Location = new System.Drawing.Point(562, 153);
            this.btnRemoverElemento.Name = "btnRemoverElemento";
            this.btnRemoverElemento.Size = new System.Drawing.Size(109, 23);
            this.btnRemoverElemento.TabIndex = 5;
            this.btnRemoverElemento.Text = "Remover elemento";
            this.btnRemoverElemento.UseVisualStyleBackColor = true;
            this.btnRemoverElemento.Click += new System.EventHandler(this.btnRemoverElemento_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(289, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(255, 173);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRemoverElemento);
            this.Controls.Add(this.btnInsertarElemento);
            this.Controls.Add(this.btnMostrarElementos);
            this.Controls.Add(this.btnCrearLista);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCrearLista;
        private System.Windows.Forms.Button btnMostrarElementos;
        private System.Windows.Forms.Button btnInsertarElemento;
        private System.Windows.Forms.Button btnRemoverElemento;
        private System.Windows.Forms.ListBox listBox1;
    }
}

