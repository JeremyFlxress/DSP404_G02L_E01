namespace Ejemplo2
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
            this.grbMatriz = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grbMantenimiento = new System.Windows.Forms.GroupBox();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblDInformacion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.grbInformacion = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.cbInformacion = new System.Windows.Forms.ComboBox();
            this.grbMatriz.SuspendLayout();
            this.grbMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.grbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMatriz
            // 
            this.grbMatriz.Controls.Add(this.btnSalir);
            this.grbMatriz.Controls.Add(this.btnPromedio);
            this.grbMatriz.Controls.Add(this.btnLimpiar);
            this.grbMatriz.Controls.Add(this.lblMostrar);
            this.grbMatriz.Controls.Add(this.btnAgregar);
            this.grbMatriz.Location = new System.Drawing.Point(311, 12);
            this.grbMatriz.Name = "grbMatriz";
            this.grbMatriz.Size = new System.Drawing.Size(270, 124);
            this.grbMatriz.TabIndex = 1;
            this.grbMatriz.TabStop = false;
            this.grbMatriz.Text = "Matriz";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(32, 92);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(149, 56);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 3;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(32, 56);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar Matriz";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.Location = new System.Drawing.Point(149, 23);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(75, 23);
            this.lblMostrar.TabIndex = 1;
            this.lblMostrar.Text = "Mostrar Matriz";
            this.lblMostrar.UseVisualStyleBackColor = true;
            this.lblMostrar.Click += new System.EventHandler(this.lblMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(32, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grbMantenimiento
            // 
            this.grbMantenimiento.Controls.Add(this.dgDatos);
            this.grbMantenimiento.Location = new System.Drawing.Point(12, 151);
            this.grbMantenimiento.Name = "grbMantenimiento";
            this.grbMantenimiento.Size = new System.Drawing.Size(569, 217);
            this.grbMantenimiento.TabIndex = 2;
            this.grbMantenimiento.TabStop = false;
            this.grbMantenimiento.Text = "Mantenimientos";
            // 
            // dgDatos
            // 
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(11, 30);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.Size = new System.Drawing.Size(544, 181);
            this.dgDatos.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(21, 28);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(103, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Tipo de información:";
            // 
            // lblDInformacion
            // 
            this.lblDInformacion.AutoSize = true;
            this.lblDInformacion.Location = new System.Drawing.Point(22, 61);
            this.lblDInformacion.Name = "lblDInformacion";
            this.lblDInformacion.Size = new System.Drawing.Size(105, 13);
            this.lblDInformacion.TabIndex = 1;
            this.lblDInformacion.Text = "Digite la información:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(22, 97);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";
            // 
            // grbInformacion
            // 
            this.grbInformacion.Controls.Add(this.txtEdad);
            this.grbInformacion.Controls.Add(this.txtInformacion);
            this.grbInformacion.Controls.Add(this.cbInformacion);
            this.grbInformacion.Controls.Add(this.lblEdad);
            this.grbInformacion.Controls.Add(this.lblDInformacion);
            this.grbInformacion.Controls.Add(this.lblInfo);
            this.grbInformacion.Location = new System.Drawing.Point(12, 12);
            this.grbInformacion.Name = "grbInformacion";
            this.grbInformacion.Size = new System.Drawing.Size(270, 124);
            this.grbInformacion.TabIndex = 0;
            this.grbInformacion.TabStop = false;
            this.grbInformacion.Text = "Informacion";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(130, 94);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(58, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(130, 58);
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(121, 20);
            this.txtInformacion.TabIndex = 4;
            // 
            // cbInformacion
            // 
            this.cbInformacion.FormattingEnabled = true;
            this.cbInformacion.Items.AddRange(new object[] {
            "Nombres ",
            "Apellidos"});
            this.cbInformacion.Location = new System.Drawing.Point(130, 25);
            this.cbInformacion.Name = "cbInformacion";
            this.cbInformacion.Size = new System.Drawing.Size(121, 21);
            this.cbInformacion.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(593, 380);
            this.Controls.Add(this.grbMantenimiento);
            this.Controls.Add(this.grbMatriz);
            this.Controls.Add(this.grbInformacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbMatriz.ResumeLayout(false);
            this.grbMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.grbInformacion.ResumeLayout(false);
            this.grbInformacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMatriz;
        private System.Windows.Forms.GroupBox grbMantenimiento;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDInformacion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.GroupBox grbInformacion;
        private System.Windows.Forms.ComboBox cbInformacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.Button lblMostrar;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtInformacion;
    }
}

