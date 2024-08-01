namespace Analisis_de_Resultado
{
    partial class Form3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtPositivo = new System.Windows.Forms.TextBox();
            this.lblPositivos = new System.Windows.Forms.Label();
            this.txtNegativo = new System.Windows.Forms.TextBox();
            this.lblNegativos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCantNumeros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPorcentaje);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPromedio);
            this.groupBox2.Controls.Add(this.lblPromedio);
            this.groupBox2.Controls.Add(this.txtPositivo);
            this.groupBox2.Controls.Add(this.lblPositivos);
            this.groupBox2.Controls.Add(this.txtNegativo);
            this.groupBox2.Controls.Add(this.lblNegativos);
            this.groupBox2.Location = new System.Drawing.Point(237, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 159);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Enabled = false;
            this.txtPorcentaje.Location = new System.Drawing.Point(21, 123);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(290, 20);
            this.txtPorcentaje.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Porcentaje de positivos, negativos y ceros:";
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(246, 73);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(65, 20);
            this.txtPromedio.TabIndex = 5;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(18, 76);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(105, 13);
            this.lblPromedio.TabIndex = 4;
            this.lblPromedio.Text = "Promedio Negativos:";
            // 
            // txtPositivo
            // 
            this.txtPositivo.Enabled = false;
            this.txtPositivo.Location = new System.Drawing.Point(246, 44);
            this.txtPositivo.Name = "txtPositivo";
            this.txtPositivo.Size = new System.Drawing.Size(65, 20);
            this.txtPositivo.TabIndex = 3;
            // 
            // lblPositivos
            // 
            this.lblPositivos.AutoSize = true;
            this.lblPositivos.Location = new System.Drawing.Point(18, 47);
            this.lblPositivos.Name = "lblPositivos";
            this.lblPositivos.Size = new System.Drawing.Size(97, 13);
            this.lblPositivos.TabIndex = 2;
            this.lblPositivos.Text = "Numeros Positivos:";
            // 
            // txtNegativo
            // 
            this.txtNegativo.Enabled = false;
            this.txtNegativo.Location = new System.Drawing.Point(246, 16);
            this.txtNegativo.Name = "txtNegativo";
            this.txtNegativo.Size = new System.Drawing.Size(65, 20);
            this.txtNegativo.TabIndex = 1;
            // 
            // lblNegativos
            // 
            this.lblNegativos.AutoSize = true;
            this.lblNegativos.Location = new System.Drawing.Point(18, 19);
            this.lblNegativos.Name = "lblNegativos";
            this.lblNegativos.Size = new System.Drawing.Size(84, 13);
            this.lblNegativos.TabIndex = 0;
            this.lblNegativos.Text = "Negativo mayor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.txtCantNumeros);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introducir datos";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(64, 130);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(64, 85);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(64, 56);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCantNumeros
            // 
            this.txtCantNumeros.Location = new System.Drawing.Point(124, 25);
            this.txtCantNumeros.Name = "txtCantNumeros";
            this.txtCantNumeros.Size = new System.Drawing.Size(72, 20);
            this.txtCantNumeros.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Numeros:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(606, 211);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.TextBox txtPositivo;
        private System.Windows.Forms.Label lblPositivos;
        private System.Windows.Forms.TextBox txtNegativo;
        private System.Windows.Forms.Label lblNegativos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCantNumeros;
        private System.Windows.Forms.Label label1;
    }
}