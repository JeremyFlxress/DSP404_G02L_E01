﻿namespace Complementario_Guia06
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.cmbHabitat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFamilia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCientifico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreComun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbOrdenReptil = new System.Windows.Forms.ComboBox();
            this.txtCantidadMamas = new System.Windows.Forms.TextBox();
            this.cmbDesarroEmbrionario = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Des = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoAnimal = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbLocomocionReptil = new System.Windows.Forms.ComboBox();
            this.cmbDesarrolloEmbrionarioPez = new System.Windows.Forms.ComboBox();
            this.cmbSistemaEsqueletico = new System.Windows.Forms.ComboBox();
            this.txtCantidadPatas = new System.Windows.Forms.TextBox();
            this.txtCantidadAntenas = new System.Windows.Forms.TextBox();
            this.cmbTipoArtrópodo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridViewInforme = new System.Windows.Forms.DataGridView();
            this.btnVerInforme = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInforme)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(30, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Animal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpFechaRegistro);
            this.groupBox1.Controls.Add(this.cmbHabitat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbFamilia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombreCientifico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreComun);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 391);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(255, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 215);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(266, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Explorar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cargue la imagen del animal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de Registro:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(28, 250);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRegistro.TabIndex = 8;
            // 
            // cmbHabitat
            // 
            this.cmbHabitat.FormattingEnabled = true;
            this.cmbHabitat.Location = new System.Drawing.Point(534, 97);
            this.cmbHabitat.Name = "cmbHabitat";
            this.cmbHabitat.Size = new System.Drawing.Size(154, 21);
            this.cmbHabitat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hábitat";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbFamilia
            // 
            this.cmbFamilia.FormattingEnabled = true;
            this.cmbFamilia.Location = new System.Drawing.Point(534, 44);
            this.cmbFamilia.Name = "cmbFamilia";
            this.cmbFamilia.Size = new System.Drawing.Size(154, 21);
            this.cmbFamilia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Familia";
            // 
            // txtNombreCientifico
            // 
            this.txtNombreCientifico.Location = new System.Drawing.Point(159, 97);
            this.txtNombreCientifico.Name = "txtNombreCientifico";
            this.txtNombreCientifico.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCientifico.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Científico";
            // 
            // txtNombreComun
            // 
            this.txtNombreComun.Location = new System.Drawing.Point(159, 40);
            this.txtNombreComun.Name = "txtNombreComun";
            this.txtNombreComun.Size = new System.Drawing.Size(100, 20);
            this.txtNombreComun.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre común:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cmbTipoArtrópodo);
            this.tabPage2.Controls.Add(this.txtCantidadAntenas);
            this.tabPage2.Controls.Add(this.txtCantidadPatas);
            this.tabPage2.Controls.Add(this.cmbSistemaEsqueletico);
            this.tabPage2.Controls.Add(this.cmbDesarrolloEmbrionarioPez);
            this.tabPage2.Controls.Add(this.cmbLocomocionReptil);
            this.tabPage2.Controls.Add(this.cmbOrdenReptil);
            this.tabPage2.Controls.Add(this.txtCantidadMamas);
            this.tabPage2.Controls.Add(this.cmbDesarroEmbrionario);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.Des);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cmbTipoAnimal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles Específicos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbOrdenReptil
            // 
            this.cmbOrdenReptil.FormattingEnabled = true;
            this.cmbOrdenReptil.Items.AddRange(new object[] {
            "lagartos",
            "cocodrilos"});
            this.cmbOrdenReptil.Location = new System.Drawing.Point(465, 110);
            this.cmbOrdenReptil.Name = "cmbOrdenReptil";
            this.cmbOrdenReptil.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenReptil.TabIndex = 16;
            // 
            // txtCantidadMamas
            // 
            this.txtCantidadMamas.Location = new System.Drawing.Point(174, 174);
            this.txtCantidadMamas.Name = "txtCantidadMamas";
            this.txtCantidadMamas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadMamas.TabIndex = 15;
            // 
            // cmbDesarroEmbrionario
            // 
            this.cmbDesarroEmbrionario.FormattingEnabled = true;
            this.cmbDesarroEmbrionario.Location = new System.Drawing.Point(174, 113);
            this.cmbDesarroEmbrionario.Name = "cmbDesarroEmbrionario";
            this.cmbDesarroEmbrionario.Size = new System.Drawing.Size(121, 21);
            this.cmbDesarroEmbrionario.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(645, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Desarrollo embrionario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(645, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Sistema esqueletico";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tipo de locomoción";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(392, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "ESCOGA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cantidad Mamas";
            // 
            // Des
            // 
            this.Des.AllowDrop = true;
            this.Des.AutoSize = true;
            this.Des.Location = new System.Drawing.Point(44, 116);
            this.Des.Name = "Des";
            this.Des.Size = new System.Drawing.Size(112, 13);
            this.Des.TabIndex = 8;
            this.Des.Text = "Desarrollo Embrionario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Seleccione el tipo de animal:";
            // 
            // cmbTipoAnimal
            // 
            this.cmbTipoAnimal.FormattingEnabled = true;
            this.cmbTipoAnimal.Items.AddRange(new object[] {
            "Mamíferos",
            "Reptiles",
            "Peces",
            "Antrópodos"});
            this.cmbTipoAnimal.Location = new System.Drawing.Point(218, 53);
            this.cmbTipoAnimal.Name = "cmbTipoAnimal";
            this.cmbTipoAnimal.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoAnimal.TabIndex = 0;
            this.cmbTipoAnimal.SelectedIndexChanged += new System.EventHandler(this.cmbTipoAnimal_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnVerInforme);
            this.tabPage3.Controls.Add(this.dataGridViewInforme);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(881, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Informe General";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbLocomocionReptil
            // 
            this.cmbLocomocionReptil.FormattingEnabled = true;
            this.cmbLocomocionReptil.Items.AddRange(new object[] {
            "lagartos",
            "cocodrilos"});
            this.cmbLocomocionReptil.Location = new System.Drawing.Point(469, 180);
            this.cmbLocomocionReptil.Name = "cmbLocomocionReptil";
            this.cmbLocomocionReptil.Size = new System.Drawing.Size(121, 21);
            this.cmbLocomocionReptil.TabIndex = 17;
            // 
            // cmbDesarrolloEmbrionarioPez
            // 
            this.cmbDesarrolloEmbrionarioPez.FormattingEnabled = true;
            this.cmbDesarrolloEmbrionarioPez.Items.AddRange(new object[] {
            "lagartos",
            "cocodrilos"});
            this.cmbDesarrolloEmbrionarioPez.Location = new System.Drawing.Point(760, 180);
            this.cmbDesarrolloEmbrionarioPez.Name = "cmbDesarrolloEmbrionarioPez";
            this.cmbDesarrolloEmbrionarioPez.Size = new System.Drawing.Size(121, 21);
            this.cmbDesarrolloEmbrionarioPez.TabIndex = 18;
            // 
            // cmbSistemaEsqueletico
            // 
            this.cmbSistemaEsqueletico.FormattingEnabled = true;
            this.cmbSistemaEsqueletico.Items.AddRange(new object[] {
            "oseos",
            "cartilaginosos"});
            this.cmbSistemaEsqueletico.Location = new System.Drawing.Point(760, 105);
            this.cmbSistemaEsqueletico.Name = "cmbSistemaEsqueletico";
            this.cmbSistemaEsqueletico.Size = new System.Drawing.Size(121, 21);
            this.cmbSistemaEsqueletico.TabIndex = 19;
            // 
            // txtCantidadPatas
            // 
            this.txtCantidadPatas.Location = new System.Drawing.Point(469, 326);
            this.txtCantidadPatas.Name = "txtCantidadPatas";
            this.txtCantidadPatas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadPatas.TabIndex = 21;
            // 
            // txtCantidadAntenas
            // 
            this.txtCantidadAntenas.Location = new System.Drawing.Point(469, 372);
            this.txtCantidadAntenas.Name = "txtCantidadAntenas";
            this.txtCantidadAntenas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadAntenas.TabIndex = 22;
            // 
            // cmbTipoArtrópodo
            // 
            this.cmbTipoArtrópodo.FormattingEnabled = true;
            this.cmbTipoArtrópodo.Items.AddRange(new object[] {
            "Terrestre",
            "Marino"});
            this.cmbTipoArtrópodo.Location = new System.Drawing.Point(469, 280);
            this.cmbTipoArtrópodo.Name = "cmbTipoArtrópodo";
            this.cmbTipoArtrópodo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoArtrópodo.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tipo de animal";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(350, 326);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Cantidad de patas";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(353, 375);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Cantidad de Antenas";
            // 
            // dataGridViewInforme
            // 
            this.dataGridViewInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInforme.Location = new System.Drawing.Point(22, 134);
            this.dataGridViewInforme.Name = "dataGridViewInforme";
            this.dataGridViewInforme.Size = new System.Drawing.Size(845, 267);
            this.dataGridViewInforme.TabIndex = 0;
            // 
            // btnVerInforme
            // 
            this.btnVerInforme.Location = new System.Drawing.Point(381, 71);
            this.btnVerInforme.Name = "btnVerInforme";
            this.btnVerInforme.Size = new System.Drawing.Size(75, 23);
            this.btnVerInforme.TabIndex = 1;
            this.btnVerInforme.Text = "Ver Informe:";
            this.btnVerInforme.UseVisualStyleBackColor = true;
            this.btnVerInforme.Click += new System.EventHandler(this.btnVerInforme_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(752, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(931, 513);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInforme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreComun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtNombreCientifico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHabitat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFamilia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Des;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoAnimal;
        private System.Windows.Forms.ComboBox cmbDesarroEmbrionario;
        private System.Windows.Forms.TextBox txtCantidadMamas;
        private System.Windows.Forms.ComboBox cmbOrdenReptil;
        private System.Windows.Forms.ComboBox cmbSistemaEsqueletico;
        private System.Windows.Forms.ComboBox cmbDesarrolloEmbrionarioPez;
        private System.Windows.Forms.ComboBox cmbLocomocionReptil;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoArtrópodo;
        private System.Windows.Forms.TextBox txtCantidadAntenas;
        private System.Windows.Forms.TextBox txtCantidadPatas;
        private System.Windows.Forms.Button btnVerInforme;
        private System.Windows.Forms.DataGridView dataGridViewInforme;
        private System.Windows.Forms.Button button2;
    }
}
