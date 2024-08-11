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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCajero = new System.Windows.Forms.Panel();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnConsignar = new System.Windows.Forms.Button();
            this.btnRetirarFondos = new System.Windows.Forms.Button();
            this.btnConsultarSaldo = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlInicio.SuspendLayout();
            this.pnlCajero.SuspendLayout();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(168, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cajero Electrónico UDB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite su numero de cuenta:";
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(362, 305);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(197, 29);
            this.txtCuenta.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Gold;
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Location = new System.Drawing.Point(288, 382);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(115, 39);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pnlInicio
            // 
            this.pnlInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlInicio.Controls.Add(this.txtNombreUsuario);
            this.pnlInicio.Controls.Add(this.label4);
            this.pnlInicio.Controls.Add(this.pictureBox1);
            this.pnlInicio.Controls.Add(this.btnIngresar);
            this.pnlInicio.Controls.Add(this.label1);
            this.pnlInicio.Controls.Add(this.txtCuenta);
            this.pnlInicio.Controls.Add(this.label2);
            this.pnlInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInicio.ForeColor = System.Drawing.Color.White;
            this.pnlInicio.Location = new System.Drawing.Point(0, 0);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(681, 464);
            this.pnlInicio.TabIndex = 5;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(362, 261);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(197, 29);
            this.txtNombreUsuario.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Digite su nombre:";
            // 
            // pnlCajero
            // 
            this.pnlCajero.BackColor = System.Drawing.Color.Blue;
            this.pnlCajero.Controls.Add(this.gbMenu);
            this.pnlCajero.Controls.Add(this.lblBienvenida);
            this.pnlCajero.Controls.Add(this.btnVolver);
            this.pnlCajero.Location = new System.Drawing.Point(0, 0);
            this.pnlCajero.Name = "pnlCajero";
            this.pnlCajero.Size = new System.Drawing.Size(681, 464);
            this.pnlCajero.TabIndex = 5;
            this.pnlCajero.Visible = false;
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.btnSalir);
            this.gbMenu.Controls.Add(this.btnTransferir);
            this.gbMenu.Controls.Add(this.btnConsignar);
            this.gbMenu.Controls.Add(this.btnRetirarFondos);
            this.gbMenu.Controls.Add(this.btnConsultarSaldo);
            this.gbMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMenu.ForeColor = System.Drawing.Color.White;
            this.gbMenu.Location = new System.Drawing.Point(155, 115);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(371, 230);
            this.gbMenu.TabIndex = 4;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menú de opciones";
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(124, 171);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 39);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.ForeColor = System.Drawing.Color.Black;
            this.btnTransferir.Location = new System.Drawing.Point(190, 110);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(158, 38);
            this.btnTransferir.TabIndex = 3;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnConsignar
            // 
            this.btnConsignar.ForeColor = System.Drawing.Color.Black;
            this.btnConsignar.Location = new System.Drawing.Point(19, 110);
            this.btnConsignar.Name = "btnConsignar";
            this.btnConsignar.Size = new System.Drawing.Size(158, 38);
            this.btnConsignar.TabIndex = 2;
            this.btnConsignar.Text = "Consignar";
            this.btnConsignar.UseVisualStyleBackColor = true;
            this.btnConsignar.Click += new System.EventHandler(this.btnConsignar_Click);
            // 
            // btnRetirarFondos
            // 
            this.btnRetirarFondos.ForeColor = System.Drawing.Color.Black;
            this.btnRetirarFondos.Location = new System.Drawing.Point(190, 39);
            this.btnRetirarFondos.Name = "btnRetirarFondos";
            this.btnRetirarFondos.Size = new System.Drawing.Size(158, 43);
            this.btnRetirarFondos.TabIndex = 1;
            this.btnRetirarFondos.Text = "Retirar Fondos";
            this.btnRetirarFondos.UseVisualStyleBackColor = true;
            this.btnRetirarFondos.Click += new System.EventHandler(this.btnRetirarFondos_Click);
            // 
            // btnConsultarSaldo
            // 
            this.btnConsultarSaldo.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarSaldo.Location = new System.Drawing.Point(19, 38);
            this.btnConsultarSaldo.Name = "btnConsultarSaldo";
            this.btnConsultarSaldo.Size = new System.Drawing.Size(158, 44);
            this.btnConsultarSaldo.TabIndex = 0;
            this.btnConsultarSaldo.Text = "Consultar Saldo";
            this.btnConsultarSaldo.UseVisualStyleBackColor = true;
            this.btnConsultarSaldo.Click += new System.EventHandler(this.btnConsultarSaldo_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(198, 35);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(158, 32);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "¡Bienvenido!";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Gold;
            this.btnVolver.Location = new System.Drawing.Point(273, 396);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(107, 40);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(681, 464);
            this.Controls.Add(this.pnlInicio);
            this.Controls.Add(this.pnlCajero);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cajero electrónico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlInicio.ResumeLayout(false);
            this.pnlInicio.PerformLayout();
            this.pnlCajero.ResumeLayout(false);
            this.pnlCajero.PerformLayout();
            this.gbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel pnlInicio;
        private System.Windows.Forms.Panel pnlCajero;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnConsignar;
        private System.Windows.Forms.Button btnRetirarFondos;
        private System.Windows.Forms.Button btnConsultarSaldo;
        private System.Windows.Forms.Button btnSalir;
    }
}

