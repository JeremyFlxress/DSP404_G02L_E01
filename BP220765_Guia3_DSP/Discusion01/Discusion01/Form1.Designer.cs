namespace Discusion01
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
            btnAñadir = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            lstNombres = new ListBox();
            SuspendLayout();
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(125, 246);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(87, 27);
            btnAñadir.TabIndex = 0;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(125, 289);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(87, 27);
            btnBorrar.TabIndex = 1;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(125, 339);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(87, 27);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(125, 388);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(87, 27);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += this.btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 68);
            label1.Name = "label1";
            label1.Size = new Size(371, 17);
            label1.TabIndex = 4;
            label1.Text = "Porfavor agregar el nombre que desea agregar o modificar\r\n";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 23);
            txtNombre.TabIndex = 5;
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.ItemHeight = 15;
            lstNombres.Location = new Point(92, 156);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(202, 64);
            lstNombres.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstNombres);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(btnAñadir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAñadir;
        private Button btnBorrar;
        private Button btnModificar;
        private Button btnSalir;
        private Label label1;
        private TextBox txtNombre;
        private ListBox lstNombres;
    }
}
