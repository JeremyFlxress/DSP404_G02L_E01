namespace FIFI
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnNuevo = new Button();
            btnAceptar = new Button();
            btnAbrirPlanilla = new Button();
            btnGenerarPlanilla = new Button();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtSueldoini = new TextBox();
            dtpFechaNac = new DateTimePicker();
            dtpFechaContrato = new DateTimePicker();
            nudRenta = new NumericUpDown();
            nudISSS = new NumericUpDown();
            dataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudRenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudISSS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 72);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 122);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 18);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha contrato:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 68);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 4;
            label5.Text = "Sueldo base:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 118);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 5;
            label6.Text = "Tasa Renta:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(180, 118);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 6;
            label7.Text = "Tasa ISSS:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 223);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(159, 31);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo empleado";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(198, 223);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(159, 31);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Proximo empleado";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnAbrirPlanilla
            // 
            btnAbrirPlanilla.Location = new Point(400, 223);
            btnAbrirPlanilla.Name = "btnAbrirPlanilla";
            btnAbrirPlanilla.Size = new Size(159, 31);
            btnAbrirPlanilla.TabIndex = 9;
            btnAbrirPlanilla.Text = "Abrir Planilla";
            btnAbrirPlanilla.UseVisualStyleBackColor = true;
            // 
            // btnGenerarPlanilla
            // 
            btnGenerarPlanilla.Location = new Point(598, 223);
            btnGenerarPlanilla.Name = "btnGenerarPlanilla";
            btnGenerarPlanilla.Size = new Size(159, 31);
            btnGenerarPlanilla.TabIndex = 10;
            btnGenerarPlanilla.Text = "Generar Planilla";
            btnGenerarPlanilla.UseVisualStyleBackColor = true;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(102, 19);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(178, 23);
            txtNombres.TabIndex = 11;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(102, 69);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(178, 23);
            txtApellidos.TabIndex = 12;
            // 
            // txtSueldoini
            // 
            txtSueldoini.Location = new Point(90, 65);
            txtSueldoini.Name = "txtSueldoini";
            txtSueldoini.Size = new Size(103, 23);
            txtSueldoini.TabIndex = 13;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(122, 116);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(222, 23);
            dtpFechaNac.TabIndex = 14;
            // 
            // dtpFechaContrato
            // 
            dtpFechaContrato.Location = new Point(106, 15);
            dtpFechaContrato.Name = "dtpFechaContrato";
            dtpFechaContrato.Size = new Size(222, 23);
            dtpFechaContrato.TabIndex = 15;
            // 
            // nudRenta
            // 
            nudRenta.Location = new Point(82, 112);
            nudRenta.Name = "nudRenta";
            nudRenta.Size = new Size(101, 23);
            nudRenta.TabIndex = 16;
            // 
            // nudISSS
            // 
            nudISSS.Location = new Point(242, 112);
            nudISSS.Name = "nudISSS";
            nudISSS.Size = new Size(119, 23);
            nudISSS.TabIndex = 17;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(29, 279);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(697, 164);
            dataGridView.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpFechaNac);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 169);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos personales de empleados";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nudISSS);
            groupBox2.Controls.Add(nudRenta);
            groupBox2.Controls.Add(dtpFechaContrato);
            groupBox2.Controls.Add(txtSueldoini);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(365, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(383, 188);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos laborales:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView);
            Controls.Add(btnGenerarPlanilla);
            Controls.Add(btnAbrirPlanilla);
            Controls.Add(btnAceptar);
            Controls.Add(btnNuevo);
            Name = "Form1";
            Text = "Registro inicial de empleados";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudRenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudISSS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnNuevo;
        private Button btnAceptar;
        private Button btnAbrirPlanilla;
        private Button btnGenerarPlanilla;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtSueldoini;
        private DateTimePicker dtpFechaNac;
        private DateTimePicker dtpFechaContrato;
        private NumericUpDown nudRenta;
        private NumericUpDown nudISSS;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
