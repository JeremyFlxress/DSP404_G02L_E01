
namespace Ejemplo2
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
            btnVentas = new Button();
            label1 = new Label();
            label2 = new Label();
            btnCalcular = new Button();
            maskedTextBox1 = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            listBox1 = new ListBox();
            label3 = new Label();
            btnSalir = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(130, 156);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(133, 31);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Ver Resumen Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(20, 44);
            label1.Name = "label1";
            label1.Size = new Size(134, 21);
            label1.TabIndex = 1;
            label1.Text = "Monto Venta ($)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(20, 119);
            label2.Name = "label2";
            label2.Size = new Size(102, 21);
            label2.TabIndex = 2;
            label2.Text = "Fecha Venta";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.SpringGreen;
            btnCalcular.Location = new Point(356, 75);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(77, 31);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Registrar";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(160, 46);
            maskedTextBox1.Mask = "00000.00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(132, 23);
            maskedTextBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(127, 118);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 190);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de Venta";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 15);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(299, 135);
            dataGridView1.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(15, 212);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(438, 230);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(btnVentas);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(430, 202);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listBox1);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(430, 202);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(128, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(181, 94);
            listBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 52);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 0;
            label3.Text = "label3";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(158, 465);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 33);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(607, 534);
            Controls.Add(btnSalir);
            Controls.Add(tabControl1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Ejemplo2";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Llama al método para inicializar los controles al cargar el formulario
            InicializarControles();
        }
        #endregion

        private Button btnVentas;
        private Label label1;
        private Label label2;
        private Button btnCalcular;
        private MaskedTextBox maskedTextBox1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnSalir;
        private ListBox listBox1;
        private Label label3;
    }
}
