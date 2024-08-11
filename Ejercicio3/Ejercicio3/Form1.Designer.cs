namespace Ejercicio3
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
            lblNombreTarea = new Label();
            lblFechaLimite = new Label();
            btnAgregarTarea = new Button();
            btnEliminarTarea = new Button();
            btnEditarTarea = new Button();
            btnCompletarTarea = new Button();
            lstTareasPendientes = new ListBox();
            lstTareasCompletadas = new ListBox();
            dtpFechaLimite = new DateTimePicker();
            txtNombreTarea = new TextBox();
            btnSalir = new Button();
            btnTxt = new Button();
            SuspendLayout();
            // 
            // lblNombreTarea
            // 
            lblNombreTarea.AutoSize = true;
            lblNombreTarea.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblNombreTarea.Location = new Point(67, 39);
            lblNombreTarea.Name = "lblNombreTarea";
            lblNombreTarea.Size = new Size(146, 20);
            lblNombreTarea.TabIndex = 0;
            lblNombreTarea.Text = "Nombre de la Tarea";
            // 
            // lblFechaLimite
            // 
            lblFechaLimite.AutoSize = true;
            lblFechaLimite.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblFechaLimite.Location = new Point(272, 39);
            lblFechaLimite.Name = "lblFechaLimite";
            lblFechaLimite.Size = new Size(97, 20);
            lblFechaLimite.TabIndex = 1;
            lblFechaLimite.Text = "Fecha Limite";
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.Location = new Point(51, 313);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(112, 25);
            btnAgregarTarea.TabIndex = 2;
            btnAgregarTarea.Text = "Agregar";
            btnAgregarTarea.UseVisualStyleBackColor = true;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // btnEliminarTarea
            // 
            btnEliminarTarea.Location = new Point(182, 313);
            btnEliminarTarea.Name = "btnEliminarTarea";
            btnEliminarTarea.Size = new Size(112, 25);
            btnEliminarTarea.TabIndex = 3;
            btnEliminarTarea.Text = "Eliminar";
            btnEliminarTarea.UseVisualStyleBackColor = true;
            btnEliminarTarea.Click += btnEliminarTarea_Click;
            // 
            // btnEditarTarea
            // 
            btnEditarTarea.Location = new Point(300, 313);
            btnEditarTarea.Name = "btnEditarTarea";
            btnEditarTarea.Size = new Size(112, 25);
            btnEditarTarea.TabIndex = 4;
            btnEditarTarea.Text = "Editar";
            btnEditarTarea.UseVisualStyleBackColor = true;
            btnEditarTarea.Click += btnEditarTarea_Click;
            // 
            // btnCompletarTarea
            // 
            btnCompletarTarea.Location = new Point(418, 313);
            btnCompletarTarea.Name = "btnCompletarTarea";
            btnCompletarTarea.Size = new Size(112, 25);
            btnCompletarTarea.TabIndex = 5;
            btnCompletarTarea.Text = "Completar";
            btnCompletarTarea.UseVisualStyleBackColor = true;
            btnCompletarTarea.Click += btnCompletarTarea_Click;
            // 
            // lstTareasPendientes
            // 
            lstTareasPendientes.FormattingEnabled = true;
            lstTareasPendientes.ItemHeight = 15;
            lstTareasPendientes.Location = new Point(51, 189);
            lstTareasPendientes.Name = "lstTareasPendientes";
            lstTareasPendientes.Size = new Size(194, 64);
            lstTareasPendientes.TabIndex = 8;
            // 
            // lstTareasCompletadas
            // 
            lstTareasCompletadas.FormattingEnabled = true;
            lstTareasCompletadas.ItemHeight = 15;
            lstTareasCompletadas.Location = new Point(272, 189);
            lstTareasCompletadas.Name = "lstTareasCompletadas";
            lstTareasCompletadas.Size = new Size(194, 64);
            lstTareasCompletadas.TabIndex = 9;
            // 
            // dtpFechaLimite
            // 
            dtpFechaLimite.Location = new Point(403, 49);
            dtpFechaLimite.Name = "dtpFechaLimite";
            dtpFechaLimite.Size = new Size(207, 23);
            dtpFechaLimite.TabIndex = 10;
            // 
            // txtNombreTarea
            // 
            txtNombreTarea.Location = new Point(67, 73);
            txtNombreTarea.Name = "txtNombreTarea";
            txtNombreTarea.Size = new Size(140, 23);
            txtNombreTarea.TabIndex = 11;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(551, 313);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(109, 27);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnTxt
            // 
            btnTxt.Location = new Point(151, 371);
            btnTxt.Name = "btnTxt";
            btnTxt.Size = new Size(130, 38);
            btnTxt.TabIndex = 13;
            btnTxt.Text = "Txt";
            btnTxt.UseVisualStyleBackColor = true;
            btnTxt.Click += btnTxt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTxt);
            Controls.Add(btnSalir);
            Controls.Add(txtNombreTarea);
            Controls.Add(dtpFechaLimite);
            Controls.Add(lstTareasCompletadas);
            Controls.Add(lstTareasPendientes);
            Controls.Add(btnCompletarTarea);
            Controls.Add(btnEditarTarea);
            Controls.Add(btnEliminarTarea);
            Controls.Add(btnAgregarTarea);
            Controls.Add(lblFechaLimite);
            Controls.Add(lblNombreTarea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreTarea;
        private Label lblFechaLimite;
        private Button btnAgregarTarea;
        private Button btnEliminarTarea;
        private Button btnEditarTarea;
        private Button btnCompletarTarea;
        private ListBox lstTareasPendientes;
        private ListBox lstTareasCompletadas;
        private DateTimePicker dtpFechaLimite;
        private TextBox txtNombreTarea;
        private Button btnSalir;
        private Button btnTxt;
    }
}
