using System.Windows.Forms;

namespace Ejercicio_02
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
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.cboTipoInfo = new System.Windows.Forms.ComboBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lbldig_info = new System.Windows.Forms.Label();
            this.lblTipo_info = new System.Windows.Forms.Label();
            this.gbMatriz = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.gbInformacion.SuspendLayout();
            this.gbMatriz.SuspendLayout();
            this.gbMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.cboTipoInfo);
            this.gbInformacion.Controls.Add(this.txtEdad);
            this.gbInformacion.Controls.Add(this.txtInfo);
            this.gbInformacion.Controls.Add(this.lblEdad);
            this.gbInformacion.Controls.Add(this.lbldig_info);
            this.gbInformacion.Controls.Add(this.lblTipo_info);
            this.gbInformacion.Location = new System.Drawing.Point(22, 12);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(377, 201);
            this.gbInformacion.TabIndex = 0;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Información";
            // 
            // cboTipoInfo
            // 
            this.cboTipoInfo.FormattingEnabled = true;
            this.cboTipoInfo.Items.AddRange(new object[] {
            "Nombre",
            "Apellido"});
            this.cboTipoInfo.Location = new System.Drawing.Point(180, 46);
            this.cboTipoInfo.Name = "cboTipoInfo";
            this.cboTipoInfo.Size = new System.Drawing.Size(127, 21);
            this.cboTipoInfo.TabIndex = 5;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(124, 128);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(99, 20);
            this.txtEdad.TabIndex = 4;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(180, 90);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(127, 20);
            this.txtInfo.TabIndex = 3;
            this.txtInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInfo_KeyPress);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(60, 131);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lbldig_info
            // 
            this.lbldig_info.AutoSize = true;
            this.lbldig_info.Location = new System.Drawing.Point(60, 93);
            this.lbldig_info.Name = "lbldig_info";
            this.lbldig_info.Size = new System.Drawing.Size(105, 13);
            this.lbldig_info.TabIndex = 1;
            this.lbldig_info.Text = "Digite la información:";
            // 
            // lblTipo_info
            // 
            this.lblTipo_info.AutoSize = true;
            this.lblTipo_info.Location = new System.Drawing.Point(60, 49);
            this.lblTipo_info.Name = "lblTipo_info";
            this.lblTipo_info.Size = new System.Drawing.Size(103, 13);
            this.lblTipo_info.TabIndex = 0;
            this.lblTipo_info.Text = "Tipo de información:";
            // 
            // gbMatriz
            // 
            this.gbMatriz.Controls.Add(this.btnSalir);
            this.gbMatriz.Controls.Add(this.btnPromedio);
            this.gbMatriz.Controls.Add(this.btnLimpiar);
            this.gbMatriz.Controls.Add(this.btnMostrar);
            this.gbMatriz.Controls.Add(this.btnAgregar);
            this.gbMatriz.Location = new System.Drawing.Point(425, 12);
            this.gbMatriz.Name = "gbMatriz";
            this.gbMatriz.Size = new System.Drawing.Size(347, 201);
            this.gbMatriz.TabIndex = 1;
            this.gbMatriz.TabStop = false;
            this.gbMatriz.Text = "Matiz";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Yellow;
            this.btnSalir.Location = new System.Drawing.Point(187, 88);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.BackColor = System.Drawing.Color.Lime;
            this.btnPromedio.Location = new System.Drawing.Point(187, 39);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 3;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = false;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLimpiar.Location = new System.Drawing.Point(30, 131);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar Matriz";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMostrar.Location = new System.Drawing.Point(30, 88);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(91, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Matriz";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Red;
            this.btnAgregar.Location = new System.Drawing.Point(30, 39);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.dgDatos);
            this.gbMantenimiento.Location = new System.Drawing.Point(22, 230);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(750, 208);
            this.gbMantenimiento.TabIndex = 2;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Mantenimientos";
            // 
            // dgDatos
            // 
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(26, 33);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.Size = new System.Drawing.Size(702, 150);
            this.dgDatos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.gbMatriz);
            this.Controls.Add(this.gbInformacion);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Formulario";
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.gbMatriz.ResumeLayout(false);
            this.gbMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbInformacion;
        private GroupBox gbMatriz;
        private GroupBox gbMantenimiento;
        private DataGridView dgDatos;
        private TextBox txtInfo;
        private Label lblEdad;
        private Label lbldig_info;
        private Label lblTipo_info;
        private TextBox txtEdad;
        private ComboBox cboTipoInfo;
        private Button btnSalir;
        private Button btnPromedio;
        private Button btnLimpiar;
        private Button btnMostrar;
        private Button btnAgregar;
    }
}

