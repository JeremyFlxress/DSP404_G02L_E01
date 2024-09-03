
namespace GUI
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
            clienteTextBox = new TextBox();
            label2 = new Label();
            idTextBox = new TextBox();
            DescripcionTextBox = new TextBox();
            label3 = new Label();
            PrecioTextBox1 = new TextBox();
            label4 = new Label();
            CantidadTextBox2 = new TextBox();
            label5 = new Label();
            btnAgregar = new Button();
            dtg = new DataGridView();
            btnPagar = new Button();
            btnAsignar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente:";
            // 
            // clienteTextBox
            // 
            clienteTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clienteTextBox.Location = new Point(80, 28);
            clienteTextBox.Name = "clienteTextBox";
            clienteTextBox.Size = new Size(437, 23);
            clienteTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 82);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 2;
            label2.Text = "ID:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(80, 82);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(76, 23);
            idTextBox.TabIndex = 3;
            // 
            // DescripcionTextBox
            // 
            DescripcionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescripcionTextBox.Location = new Point(237, 82);
            DescripcionTextBox.Name = "DescripcionTextBox";
            DescripcionTextBox.Size = new Size(280, 23);
            DescripcionTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 85);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 4;
            label3.Text = "Descripcion";
            // 
            // PrecioTextBox1
            // 
            PrecioTextBox1.Location = new Point(80, 125);
            PrecioTextBox1.Name = "PrecioTextBox1";
            PrecioTextBox1.Size = new Size(76, 23);
            PrecioTextBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 128);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Precio:";
            label4.Click += label4_Click;
            // 
            // CantidadTextBox2
            // 
            CantidadTextBox2.Location = new Point(228, 120);
            CantidadTextBox2.Name = "CantidadTextBox2";
            CantidadTextBox2.Size = new Size(73, 23);
            CantidadTextBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 123);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 8;
            label5.Text = "Cantidad:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(307, 116);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 29);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtg
            // 
            dtg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg.Location = new Point(32, 166);
            dtg.Name = "dtg";
            dtg.Size = new Size(679, 195);
            dtg.TabIndex = 11;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(411, 116);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(95, 29);
            btnPagar.TabIndex = 12;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnAsignar
            // 
            btnAsignar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAsignar.Location = new Point(512, 116);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(93, 29);
            btnAsignar.TabIndex = 13;
            btnAsignar.Text = "Asignar";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(258, 367);
            button1.Name = "button1";
            button1.Size = new Size(184, 60);
            button1.TabIndex = 14;
            button1.Text = "Salir del programa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnAsignar);
            Controls.Add(btnPagar);
            Controls.Add(dtg);
            Controls.Add(btnAgregar);
            Controls.Add(CantidadTextBox2);
            Controls.Add(label5);
            Controls.Add(PrecioTextBox1);
            Controls.Add(label4);
            Controls.Add(DescripcionTextBox);
            Controls.Add(label3);
            Controls.Add(idTextBox);
            Controls.Add(label2);
            Controls.Add(clienteTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)dtg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private TextBox clienteTextBox;
        private Label label2;
        private TextBox idTextBox;
        private TextBox DescripcionTextBox;
        private Label label3;
        private TextBox PrecioTextBox1;
        private Label label4;
        private TextBox CantidadTextBox2;
        private Label label5;
        private Button btnAgregar;
        private DataGridView dtg;
        private Button btnPagar;
        private Button btnAsignar;
        private Button button1;
    }
}
