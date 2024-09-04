namespace Ejercicio_02
{
    partial class frmRegistroEmpleados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudISSS = new System.Windows.Forms.NumericUpDown();
            this.lblISSS = new System.Windows.Forms.Label();
            this.nudRenta = new System.Windows.Forms.NumericUpDown();
            this.lblRenta = new System.Windows.Forms.Label();
            this.txtSueldoIni = new System.Windows.Forms.TextBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.dtpFechaContrato = new System.Windows.Forms.DateTimePicker();
            this.lblContrato = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAbrirPlanilla = new System.Windows.Forms.Button();
            this.btnGenerarPlanilla = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaNac);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.lblFechaNac);
            this.groupBox1.Controls.Add(this.lblApellidos);
            this.groupBox1.Controls.Add(this.lblNombres);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales de empleados";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(169, 116);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(227, 20);
            this.dtpFechaNac.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(169, 74);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(118, 20);
            this.txtApellidos.TabIndex = 4;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(169, 30);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(118, 20);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(23, 122);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(94, 13);
            this.lblFechaNac.TabIndex = 2;
            this.lblFechaNac.Text = "Fecha nacimiento:";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(23, 77);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(23, 33);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 0;
            this.lblNombres.Text = "Nombres:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudISSS);
            this.groupBox2.Controls.Add(this.lblISSS);
            this.groupBox2.Controls.Add(this.nudRenta);
            this.groupBox2.Controls.Add(this.lblRenta);
            this.groupBox2.Controls.Add(this.txtSueldoIni);
            this.groupBox2.Controls.Add(this.lblSueldo);
            this.groupBox2.Controls.Add(this.dtpFechaContrato);
            this.groupBox2.Controls.Add(this.lblContrato);
            this.groupBox2.Location = new System.Drawing.Point(442, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos laborales:";
            // 
            // nudISSS
            // 
            this.nudISSS.DecimalPlaces = 1;
            this.nudISSS.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudISSS.Location = new System.Drawing.Point(287, 119);
            this.nudISSS.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudISSS.Name = "nudISSS";
            this.nudISSS.Size = new System.Drawing.Size(69, 20);
            this.nudISSS.TabIndex = 7;
            this.nudISSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudISSS_KeyPress);
            // 
            // lblISSS
            // 
            this.lblISSS.AutoSize = true;
            this.lblISSS.Location = new System.Drawing.Point(203, 123);
            this.lblISSS.Name = "lblISSS";
            this.lblISSS.Size = new System.Drawing.Size(61, 13);
            this.lblISSS.TabIndex = 6;
            this.lblISSS.Text = "Tasa ISSS:";
            // 
            // nudRenta
            // 
            this.nudRenta.DecimalPlaces = 1;
            this.nudRenta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRenta.Location = new System.Drawing.Point(112, 119);
            this.nudRenta.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudRenta.Name = "nudRenta";
            this.nudRenta.Size = new System.Drawing.Size(69, 20);
            this.nudRenta.TabIndex = 5;
            this.nudRenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudRenta_KeyPress);
            // 
            // lblRenta
            // 
            this.lblRenta.AutoSize = true;
            this.lblRenta.Location = new System.Drawing.Point(25, 123);
            this.lblRenta.Name = "lblRenta";
            this.lblRenta.Size = new System.Drawing.Size(66, 13);
            this.lblRenta.TabIndex = 4;
            this.lblRenta.Text = "Tasa Renta:";
            // 
            // txtSueldoIni
            // 
            this.txtSueldoIni.Location = new System.Drawing.Point(112, 74);
            this.txtSueldoIni.Name = "txtSueldoIni";
            this.txtSueldoIni.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoIni.TabIndex = 3;
            this.txtSueldoIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoIni_KeyPress);
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(25, 77);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(69, 13);
            this.lblSueldo.TabIndex = 2;
            this.lblSueldo.Text = "Sueldo base:";
            // 
            // dtpFechaContrato
            // 
            this.dtpFechaContrato.Location = new System.Drawing.Point(136, 27);
            this.dtpFechaContrato.Name = "dtpFechaContrato";
            this.dtpFechaContrato.Size = new System.Drawing.Size(229, 20);
            this.dtpFechaContrato.TabIndex = 1;
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Location = new System.Drawing.Point(25, 33);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(82, 13);
            this.lblContrato.TabIndex = 0;
            this.lblContrato.Text = "Fecha contrato:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(21, 194);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(161, 35);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo empleado";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(232, 194);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(171, 35);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Proximo empleado";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnAbrirPlanilla
            // 
            this.btnAbrirPlanilla.Location = new System.Drawing.Point(451, 194);
            this.btnAbrirPlanilla.Name = "btnAbrirPlanilla";
            this.btnAbrirPlanilla.Size = new System.Drawing.Size(152, 35);
            this.btnAbrirPlanilla.TabIndex = 4;
            this.btnAbrirPlanilla.Text = "Abrir planilla";
            this.btnAbrirPlanilla.UseVisualStyleBackColor = true;
            this.btnAbrirPlanilla.Click += new System.EventHandler(this.btnAbrirPlanilla_Click);
            // 
            // btnGenerarPlanilla
            // 
            this.btnGenerarPlanilla.Location = new System.Drawing.Point(648, 194);
            this.btnGenerarPlanilla.Name = "btnGenerarPlanilla";
            this.btnGenerarPlanilla.Size = new System.Drawing.Size(176, 35);
            this.btnGenerarPlanilla.TabIndex = 5;
            this.btnGenerarPlanilla.Text = "Generar planilla";
            this.btnGenerarPlanilla.UseVisualStyleBackColor = true;
            this.btnGenerarPlanilla.Click += new System.EventHandler(this.btnGenerarPlanilla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 211);
            this.dataGridView1.TabIndex = 6;
            // 
            // frmRegistroEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenerarPlanilla);
            this.Controls.Add(this.btnAbrirPlanilla);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRegistroEmpleados";
            this.Text = "Registro inicial de empleados";
            this.Load += new System.EventHandler(this.frmRegistroEmpleados_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudISSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudISSS;
        private System.Windows.Forms.Label lblISSS;
        private System.Windows.Forms.NumericUpDown nudRenta;
        private System.Windows.Forms.Label lblRenta;
        private System.Windows.Forms.TextBox txtSueldoIni;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.DateTimePicker dtpFechaContrato;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAbrirPlanilla;
        private System.Windows.Forms.Button btnGenerarPlanilla;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

