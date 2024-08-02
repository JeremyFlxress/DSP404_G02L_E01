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
            this.btAgregar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btPromedio = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Lbtipo_info = new System.Windows.Forms.Label();
            this.Lbdig_info = new System.Windows.Forms.Label();
            this.lbedad = new System.Windows.Forms.Label();
            this.cbtipoinfo = new System.Windows.Forms.ComboBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.dgdatos = new System.Windows.Forms.DataGridView();
            this.gbInformacon = new System.Windows.Forms.GroupBox();
            this.gbMatriz = new System.Windows.Forms.GroupBox();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).BeginInit();
            this.gbInformacon.SuspendLayout();
            this.gbMatriz.SuspendLayout();
            this.gbMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.Red;
            this.btAgregar.Location = new System.Drawing.Point(24, 57);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(87, 26);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.BackColor = System.Drawing.Color.Orange;
            this.btMostrar.Location = new System.Drawing.Point(24, 89);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(87, 26);
            this.btMostrar.TabIndex = 1;
            this.btMostrar.Text = "Mostrar Matriz";
            this.btMostrar.UseVisualStyleBackColor = false;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.BackColor = System.Drawing.Color.Violet;
            this.btLimpiar.Location = new System.Drawing.Point(117, 57);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(87, 26);
            this.btLimpiar.TabIndex = 2;
            this.btLimpiar.Text = "Limpair Matriz";
            this.btLimpiar.UseVisualStyleBackColor = false;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click_1);
            // 
            // btPromedio
            // 
            this.btPromedio.BackColor = System.Drawing.Color.LightGreen;
            this.btPromedio.Location = new System.Drawing.Point(117, 89);
            this.btPromedio.Name = "btPromedio";
            this.btPromedio.Size = new System.Drawing.Size(87, 26);
            this.btPromedio.TabIndex = 3;
            this.btPromedio.Text = "Promedio";
            this.btPromedio.UseVisualStyleBackColor = false;
            this.btPromedio.Click += new System.EventHandler(this.btPromedio_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Yellow;
            this.btnSalir.Location = new System.Drawing.Point(210, 57);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 26);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Lbtipo_info
            // 
            this.Lbtipo_info.AutoSize = true;
            this.Lbtipo_info.Location = new System.Drawing.Point(8, 51);
            this.Lbtipo_info.Name = "Lbtipo_info";
            this.Lbtipo_info.Size = new System.Drawing.Size(100, 13);
            this.Lbtipo_info.TabIndex = 5;
            this.Lbtipo_info.Text = "Tipo de informacion";
            // 
            // Lbdig_info
            // 
            this.Lbdig_info.AutoSize = true;
            this.Lbdig_info.Location = new System.Drawing.Point(6, 99);
            this.Lbdig_info.Name = "Lbdig_info";
            this.Lbdig_info.Size = new System.Drawing.Size(102, 13);
            this.Lbdig_info.TabIndex = 6;
            this.Lbdig_info.Text = "Digite la informacion";
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(8, 137);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(32, 13);
            this.lbedad.TabIndex = 7;
            this.lbedad.Text = "Edad";
            // 
            // cbtipoinfo
            // 
            this.cbtipoinfo.FormattingEnabled = true;
            this.cbtipoinfo.Location = new System.Drawing.Point(114, 48);
            this.cbtipoinfo.Name = "cbtipoinfo";
            this.cbtipoinfo.Size = new System.Drawing.Size(93, 21);
            this.cbtipoinfo.TabIndex = 8;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(114, 96);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(105, 20);
            this.txtInfo.TabIndex = 9;
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(86, 134);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(105, 20);
            this.txtEdad.TabIndex = 10;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // dgdatos
            // 
            this.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdatos.Location = new System.Drawing.Point(40, 26);
            this.dgdatos.Name = "dgdatos";
            this.dgdatos.Size = new System.Drawing.Size(479, 141);
            this.dgdatos.TabIndex = 11;
            // 
            // gbInformacon
            // 
            this.gbInformacon.Controls.Add(this.txtEdad);
            this.gbInformacon.Controls.Add(this.txtInfo);
            this.gbInformacon.Controls.Add(this.cbtipoinfo);
            this.gbInformacon.Controls.Add(this.lbedad);
            this.gbInformacon.Controls.Add(this.Lbdig_info);
            this.gbInformacon.Controls.Add(this.Lbtipo_info);
            this.gbInformacon.Location = new System.Drawing.Point(24, 35);
            this.gbInformacon.Name = "gbInformacon";
            this.gbInformacon.Size = new System.Drawing.Size(235, 193);
            this.gbInformacon.TabIndex = 12;
            this.gbInformacon.TabStop = false;
            this.gbInformacon.Text = "Informacion";
            // 
            // gbMatriz
            // 
            this.gbMatriz.Controls.Add(this.btnSalir);
            this.gbMatriz.Controls.Add(this.btPromedio);
            this.gbMatriz.Controls.Add(this.btLimpiar);
            this.gbMatriz.Controls.Add(this.btMostrar);
            this.gbMatriz.Controls.Add(this.btAgregar);
            this.gbMatriz.Location = new System.Drawing.Point(305, 45);
            this.gbMatriz.Name = "gbMatriz";
            this.gbMatriz.Size = new System.Drawing.Size(311, 182);
            this.gbMatriz.TabIndex = 13;
            this.gbMatriz.TabStop = false;
            this.gbMatriz.Text = "Matriz";
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.dgdatos);
            this.gbMantenimiento.Location = new System.Drawing.Point(51, 248);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(550, 191);
            this.gbMantenimiento.TabIndex = 14;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Mantenimientos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.gbMatriz);
            this.Controls.Add(this.gbInformacon);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).EndInit();
            this.gbInformacon.ResumeLayout(false);
            this.gbInformacon.PerformLayout();
            this.gbMatriz.ResumeLayout(false);
            this.gbMantenimiento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btPromedio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label Lbtipo_info;
        private System.Windows.Forms.Label Lbdig_info;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.ComboBox cbtipoinfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DataGridView dgdatos;
        private System.Windows.Forms.GroupBox gbInformacon;
        private System.Windows.Forms.GroupBox gbMatriz;
        private System.Windows.Forms.GroupBox gbMantenimiento;
    }
}

