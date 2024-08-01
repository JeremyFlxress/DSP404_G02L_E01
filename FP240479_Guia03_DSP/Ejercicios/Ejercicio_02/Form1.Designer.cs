
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
            this.Informacion = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.cbtipoinfo = new System.Windows.Forms.ComboBox();
            this.lbedad = new System.Windows.Forms.Label();
            this.lbdig_info = new System.Windows.Forms.Label();
            this.lbtipo_info = new System.Windows.Forms.Label();
            this.gbMatriz = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.dgdatos = new System.Windows.Forms.DataGridView();
            this.Informacion.SuspendLayout();
            this.gbMatriz.SuspendLayout();
            this.gbMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // Informacion
            // 
            this.Informacion.Controls.Add(this.txtEdad);
            this.Informacion.Controls.Add(this.txtInfo);
            this.Informacion.Controls.Add(this.cbtipoinfo);
            this.Informacion.Controls.Add(this.lbedad);
            this.Informacion.Controls.Add(this.lbdig_info);
            this.Informacion.Controls.Add(this.lbtipo_info);
            this.Informacion.Location = new System.Drawing.Point(72, 49);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(288, 175);
            this.Informacion.TabIndex = 0;
            this.Informacion.TabStop = false;
            this.Informacion.Text = "groupBox1";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(112, 114);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(107, 20);
            this.txtEdad.TabIndex = 5;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(112, 75);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(162, 20);
            this.txtInfo.TabIndex = 4;
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // cbtipoinfo
            // 
            this.cbtipoinfo.FormattingEnabled = true;
            this.cbtipoinfo.Items.AddRange(new object[] {
            "Nombre",
            "Apellido"});
            this.cbtipoinfo.Location = new System.Drawing.Point(112, 39);
            this.cbtipoinfo.Name = "cbtipoinfo";
            this.cbtipoinfo.Size = new System.Drawing.Size(170, 21);
            this.cbtipoinfo.TabIndex = 3;
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(28, 117);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(32, 13);
            this.lbedad.TabIndex = 2;
            this.lbedad.Text = "Edad";
            // 
            // lbdig_info
            // 
            this.lbdig_info.AutoSize = true;
            this.lbdig_info.Location = new System.Drawing.Point(6, 82);
            this.lbdig_info.Name = "lbdig_info";
            this.lbdig_info.Size = new System.Drawing.Size(102, 13);
            this.lbdig_info.TabIndex = 1;
            this.lbdig_info.Text = "Digite la informacion";
            // 
            // lbtipo_info
            // 
            this.lbtipo_info.AutoSize = true;
            this.lbtipo_info.Location = new System.Drawing.Point(6, 42);
            this.lbtipo_info.Name = "lbtipo_info";
            this.lbtipo_info.Size = new System.Drawing.Size(100, 13);
            this.lbtipo_info.TabIndex = 0;
            this.lbtipo_info.Text = "Tipo de informacion";
            // 
            // gbMatriz
            // 
            this.gbMatriz.Controls.Add(this.button5);
            this.gbMatriz.Controls.Add(this.btnPromedio);
            this.gbMatriz.Controls.Add(this.btnLimpiar);
            this.gbMatriz.Controls.Add(this.btnMostrar);
            this.gbMatriz.Controls.Add(this.btnAgregar);
            this.gbMatriz.Location = new System.Drawing.Point(417, 49);
            this.gbMatriz.Name = "gbMatriz";
            this.gbMatriz.Size = new System.Drawing.Size(288, 175);
            this.gbMatriz.TabIndex = 1;
            this.gbMatriz.TabStop = false;
            this.gbMatriz.Text = "Mantenimiento";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(165, 82);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 3;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(21, 82);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(165, 32);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Matriz";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.dgdatos);
            this.gbMantenimiento.Location = new System.Drawing.Point(72, 250);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(643, 226);
            this.gbMantenimiento.TabIndex = 1;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Matriz";
            // 
            // dgdatos
            // 
            this.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdatos.Location = new System.Drawing.Point(31, 19);
            this.dgdatos.Name = "dgdatos";
            this.dgdatos.Size = new System.Drawing.Size(596, 196);
            this.dgdatos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(753, 502);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.gbMatriz);
            this.Controls.Add(this.Informacion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Informacion.ResumeLayout(false);
            this.Informacion.PerformLayout();
            this.gbMatriz.ResumeLayout(false);
            this.gbMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Informacion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.ComboBox cbtipoinfo;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.Label lbdig_info;
        private System.Windows.Forms.Label lbtipo_info;
        private System.Windows.Forms.GroupBox gbMatriz;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbMantenimiento;
        private System.Windows.Forms.DataGridView dgdatos;
    }
}

