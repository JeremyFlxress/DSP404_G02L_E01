namespace Zoologico
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
            this.tabControlAnimales = new System.Windows.Forms.TabControl();
            this.tabPageMamifero = new System.Windows.Forms.TabPage();
            this.tabPageReptil = new System.Windows.Forms.TabPage();
            this.tabPagePeces = new System.Windows.Forms.TabPage();
            this.tabPageVerAnimales = new System.Windows.Forms.TabPage();
            this.groupBoxFotoMamifero = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreComunMamifero = new System.Windows.Forms.TextBox();
            this.txtNombreCientificoMamifero = new System.Windows.Forms.TextBox();
            this.cmbFamiliaMamifero = new System.Windows.Forms.ComboBox();
            this.cmbHabitatMamifero = new System.Windows.Forms.ComboBox();
            this.txtTipoDesarrollo = new System.Windows.Forms.TextBox();
            this.nudMamas = new System.Windows.Forms.NumericUpDown();
            this.txtOrdenReptil = new System.Windows.Forms.TextBox();
            this.cmbHabitatReptil = new System.Windows.Forms.ComboBox();
            this.cmbFamiliaReptil = new System.Windows.Forms.ComboBox();
            this.txtNombreCientificoReptil = new System.Windows.Forms.TextBox();
            this.txtNombreComunReptil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBoxFotoReptil = new System.Windows.Forms.GroupBox();
            this.txtSistemaEsqueleticoPez = new System.Windows.Forms.TextBox();
            this.cmbHabitatPez = new System.Windows.Forms.ComboBox();
            this.cmbFamiliaPez = new System.Windows.Forms.ComboBox();
            this.txtNombreCientificoPez = new System.Windows.Forms.TextBox();
            this.txtNombreComunPez = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBoxFotoPez = new System.Windows.Forms.GroupBox();
            this.picFotoMamifero = new System.Windows.Forms.PictureBox();
            this.picFotoReptil = new System.Windows.Forms.PictureBox();
            this.picFotoPez = new System.Windows.Forms.PictureBox();
            this.txtTipoLocomocionReptil = new System.Windows.Forms.TextBox();
            this.txtDesarrolloEmbrionarioPez = new System.Windows.Forms.TextBox();
            this.rbMamiferos = new System.Windows.Forms.RadioButton();
            this.rbReptiles = new System.Windows.Forms.RadioButton();
            this.rbPeces = new System.Windows.Forms.RadioButton();
            this.dataGridViewAnimales = new System.Windows.Forms.DataGridView();
            this.tabControlAnimales.SuspendLayout();
            this.tabPageMamifero.SuspendLayout();
            this.tabPageReptil.SuspendLayout();
            this.tabPagePeces.SuspendLayout();
            this.tabPageVerAnimales.SuspendLayout();
            this.groupBoxFotoMamifero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMamas)).BeginInit();
            this.groupBoxFotoReptil.SuspendLayout();
            this.groupBoxFotoPez.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoMamifero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoReptil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAnimales
            // 
            this.tabControlAnimales.Controls.Add(this.tabPageMamifero);
            this.tabControlAnimales.Controls.Add(this.tabPageReptil);
            this.tabControlAnimales.Controls.Add(this.tabPagePeces);
            this.tabControlAnimales.Controls.Add(this.tabPageVerAnimales);
            this.tabControlAnimales.Location = new System.Drawing.Point(12, 12);
            this.tabControlAnimales.Name = "tabControlAnimales";
            this.tabControlAnimales.SelectedIndex = 0;
            this.tabControlAnimales.Size = new System.Drawing.Size(598, 296);
            this.tabControlAnimales.TabIndex = 0;
            // 
            // tabPageMamifero
            // 
            this.tabPageMamifero.Controls.Add(this.nudMamas);
            this.tabPageMamifero.Controls.Add(this.txtTipoDesarrollo);
            this.tabPageMamifero.Controls.Add(this.cmbHabitatMamifero);
            this.tabPageMamifero.Controls.Add(this.cmbFamiliaMamifero);
            this.tabPageMamifero.Controls.Add(this.txtNombreCientificoMamifero);
            this.tabPageMamifero.Controls.Add(this.txtNombreComunMamifero);
            this.tabPageMamifero.Controls.Add(this.label6);
            this.tabPageMamifero.Controls.Add(this.label5);
            this.tabPageMamifero.Controls.Add(this.label4);
            this.tabPageMamifero.Controls.Add(this.label3);
            this.tabPageMamifero.Controls.Add(this.label2);
            this.tabPageMamifero.Controls.Add(this.label1);
            this.tabPageMamifero.Controls.Add(this.groupBoxFotoMamifero);
            this.tabPageMamifero.Location = new System.Drawing.Point(4, 22);
            this.tabPageMamifero.Name = "tabPageMamifero";
            this.tabPageMamifero.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMamifero.Size = new System.Drawing.Size(590, 270);
            this.tabPageMamifero.TabIndex = 0;
            this.tabPageMamifero.Text = "Ingreso de Mamiferos";
            this.tabPageMamifero.UseVisualStyleBackColor = true;
            this.tabPageMamifero.Click += new System.EventHandler(this.tabPageMamifero_Click);
            // 
            // tabPageReptil
            // 
            this.tabPageReptil.Controls.Add(this.txtTipoLocomocionReptil);
            this.tabPageReptil.Controls.Add(this.txtOrdenReptil);
            this.tabPageReptil.Controls.Add(this.cmbHabitatReptil);
            this.tabPageReptil.Controls.Add(this.cmbFamiliaReptil);
            this.tabPageReptil.Controls.Add(this.txtNombreCientificoReptil);
            this.tabPageReptil.Controls.Add(this.txtNombreComunReptil);
            this.tabPageReptil.Controls.Add(this.label7);
            this.tabPageReptil.Controls.Add(this.label8);
            this.tabPageReptil.Controls.Add(this.label9);
            this.tabPageReptil.Controls.Add(this.label10);
            this.tabPageReptil.Controls.Add(this.label11);
            this.tabPageReptil.Controls.Add(this.label12);
            this.tabPageReptil.Controls.Add(this.groupBoxFotoReptil);
            this.tabPageReptil.Location = new System.Drawing.Point(4, 22);
            this.tabPageReptil.Name = "tabPageReptil";
            this.tabPageReptil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReptil.Size = new System.Drawing.Size(590, 270);
            this.tabPageReptil.TabIndex = 1;
            this.tabPageReptil.Text = "Ingreso de Reptiles";
            this.tabPageReptil.UseVisualStyleBackColor = true;
            // 
            // tabPagePeces
            // 
            this.tabPagePeces.Controls.Add(this.txtDesarrolloEmbrionarioPez);
            this.tabPagePeces.Controls.Add(this.txtSistemaEsqueleticoPez);
            this.tabPagePeces.Controls.Add(this.cmbHabitatPez);
            this.tabPagePeces.Controls.Add(this.cmbFamiliaPez);
            this.tabPagePeces.Controls.Add(this.txtNombreCientificoPez);
            this.tabPagePeces.Controls.Add(this.txtNombreComunPez);
            this.tabPagePeces.Controls.Add(this.label13);
            this.tabPagePeces.Controls.Add(this.label14);
            this.tabPagePeces.Controls.Add(this.label15);
            this.tabPagePeces.Controls.Add(this.label16);
            this.tabPagePeces.Controls.Add(this.label17);
            this.tabPagePeces.Controls.Add(this.label18);
            this.tabPagePeces.Controls.Add(this.groupBoxFotoPez);
            this.tabPagePeces.Location = new System.Drawing.Point(4, 22);
            this.tabPagePeces.Name = "tabPagePeces";
            this.tabPagePeces.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePeces.Size = new System.Drawing.Size(590, 270);
            this.tabPagePeces.TabIndex = 2;
            this.tabPagePeces.Text = "Ingreso de Peces";
            this.tabPagePeces.UseVisualStyleBackColor = true;
            // 
            // tabPageVerAnimales
            // 
            this.tabPageVerAnimales.Controls.Add(this.dataGridViewAnimales);
            this.tabPageVerAnimales.Controls.Add(this.rbPeces);
            this.tabPageVerAnimales.Controls.Add(this.rbReptiles);
            this.tabPageVerAnimales.Controls.Add(this.rbMamiferos);
            this.tabPageVerAnimales.Location = new System.Drawing.Point(4, 22);
            this.tabPageVerAnimales.Name = "tabPageVerAnimales";
            this.tabPageVerAnimales.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVerAnimales.Size = new System.Drawing.Size(590, 270);
            this.tabPageVerAnimales.TabIndex = 3;
            this.tabPageVerAnimales.Text = "Ver animales registrados";
            this.tabPageVerAnimales.UseVisualStyleBackColor = true;
            // 
            // groupBoxFotoMamifero
            // 
            this.groupBoxFotoMamifero.Controls.Add(this.picFotoMamifero);
            this.groupBoxFotoMamifero.Location = new System.Drawing.Point(17, 6);
            this.groupBoxFotoMamifero.Name = "groupBoxFotoMamifero";
            this.groupBoxFotoMamifero.Size = new System.Drawing.Size(207, 158);
            this.groupBoxFotoMamifero.TabIndex = 0;
            this.groupBoxFotoMamifero.TabStop = false;
            this.groupBoxFotoMamifero.Text = "Foto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre común:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre científico:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Familia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hábitat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo de desarrollo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cantidad de mamas:";
            // 
            // txtNombreComunMamifero
            // 
            this.txtNombreComunMamifero.Location = new System.Drawing.Point(382, 22);
            this.txtNombreComunMamifero.Name = "txtNombreComunMamifero";
            this.txtNombreComunMamifero.Size = new System.Drawing.Size(171, 20);
            this.txtNombreComunMamifero.TabIndex = 7;
            // 
            // txtNombreCientificoMamifero
            // 
            this.txtNombreCientificoMamifero.Location = new System.Drawing.Point(382, 52);
            this.txtNombreCientificoMamifero.Name = "txtNombreCientificoMamifero";
            this.txtNombreCientificoMamifero.Size = new System.Drawing.Size(171, 20);
            this.txtNombreCientificoMamifero.TabIndex = 8;
            // 
            // cmbFamiliaMamifero
            // 
            this.cmbFamiliaMamifero.FormattingEnabled = true;
            this.cmbFamiliaMamifero.Items.AddRange(new object[] {
            "Carnívoros",
            "",
            "Ungulados",
            "",
            "Primates",
            "",
            "Roedores",
            "",
            "Marsupiales",
            "",
            "Cetáceos",
            "",
            "Monotremas",
            "",
            "Insectívoros",
            "",
            "Quiropteros"});
            this.cmbFamiliaMamifero.Location = new System.Drawing.Point(382, 82);
            this.cmbFamiliaMamifero.Name = "cmbFamiliaMamifero";
            this.cmbFamiliaMamifero.Size = new System.Drawing.Size(171, 21);
            this.cmbFamiliaMamifero.TabIndex = 9;
            // 
            // cmbHabitatMamifero
            // 
            this.cmbHabitatMamifero.FormattingEnabled = true;
            this.cmbHabitatMamifero.Items.AddRange(new object[] {
            "Selva",
            "",
            "Sabana",
            "",
            "Desierto",
            "",
            "Bosque",
            "",
            "Montaña",
            "",
            "Pradera",
            "",
            "Zona urbana",
            "",
            "Tundra",
            "",
            "Manglar"});
            this.cmbHabitatMamifero.Location = new System.Drawing.Point(382, 112);
            this.cmbHabitatMamifero.Name = "cmbHabitatMamifero";
            this.cmbHabitatMamifero.Size = new System.Drawing.Size(171, 21);
            this.cmbHabitatMamifero.TabIndex = 10;
            // 
            // txtTipoDesarrollo
            // 
            this.txtTipoDesarrollo.Location = new System.Drawing.Point(172, 177);
            this.txtTipoDesarrollo.Name = "txtTipoDesarrollo";
            this.txtTipoDesarrollo.Size = new System.Drawing.Size(171, 20);
            this.txtTipoDesarrollo.TabIndex = 11;
            // 
            // nudMamas
            // 
            this.nudMamas.Location = new System.Drawing.Point(172, 203);
            this.nudMamas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMamas.Name = "nudMamas";
            this.nudMamas.Size = new System.Drawing.Size(171, 20);
            this.nudMamas.TabIndex = 12;
            // 
            // txtOrdenReptil
            // 
            this.txtOrdenReptil.Location = new System.Drawing.Point(172, 177);
            this.txtOrdenReptil.Name = "txtOrdenReptil";
            this.txtOrdenReptil.Size = new System.Drawing.Size(171, 20);
            this.txtOrdenReptil.TabIndex = 24;
            // 
            // cmbHabitatReptil
            // 
            this.cmbHabitatReptil.FormattingEnabled = true;
            this.cmbHabitatReptil.Items.AddRange(new object[] {
            "Selva tropical",
            "",
            "Desierto",
            "",
            "Pantano",
            "",
            "Sabana",
            "",
            "Bosque",
            "",
            "Montaña",
            "",
            "Zonas rocosas",
            "",
            "Ríos",
            "",
            "Playas"});
            this.cmbHabitatReptil.Location = new System.Drawing.Point(382, 112);
            this.cmbHabitatReptil.Name = "cmbHabitatReptil";
            this.cmbHabitatReptil.Size = new System.Drawing.Size(171, 21);
            this.cmbHabitatReptil.TabIndex = 23;
            // 
            // cmbFamiliaReptil
            // 
            this.cmbFamiliaReptil.FormattingEnabled = true;
            this.cmbFamiliaReptil.Items.AddRange(new object[] {
            "Lagartos",
            "",
            "Cocodrilos",
            "",
            "Ofidios (serpientes)",
            "",
            "Quelonios (tortugas)",
            "",
            "Anfisbenos",
            "",
            "Esfenodontes"});
            this.cmbFamiliaReptil.Location = new System.Drawing.Point(382, 82);
            this.cmbFamiliaReptil.Name = "cmbFamiliaReptil";
            this.cmbFamiliaReptil.Size = new System.Drawing.Size(171, 21);
            this.cmbFamiliaReptil.TabIndex = 22;
            // 
            // txtNombreCientificoReptil
            // 
            this.txtNombreCientificoReptil.Location = new System.Drawing.Point(382, 52);
            this.txtNombreCientificoReptil.Name = "txtNombreCientificoReptil";
            this.txtNombreCientificoReptil.Size = new System.Drawing.Size(171, 20);
            this.txtNombreCientificoReptil.TabIndex = 21;
            // 
            // txtNombreComunReptil
            // 
            this.txtNombreComunReptil.Location = new System.Drawing.Point(382, 22);
            this.txtNombreComunReptil.Name = "txtNombreComunReptil";
            this.txtNombreComunReptil.Size = new System.Drawing.Size(171, 20);
            this.txtNombreComunReptil.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tipo de locomoción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Orden:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Hábitat:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(279, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Familia:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(279, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Nombre científico:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nombre común:";
            // 
            // groupBoxFotoReptil
            // 
            this.groupBoxFotoReptil.Controls.Add(this.picFotoReptil);
            this.groupBoxFotoReptil.Location = new System.Drawing.Point(17, 6);
            this.groupBoxFotoReptil.Name = "groupBoxFotoReptil";
            this.groupBoxFotoReptil.Size = new System.Drawing.Size(207, 158);
            this.groupBoxFotoReptil.TabIndex = 13;
            this.groupBoxFotoReptil.TabStop = false;
            this.groupBoxFotoReptil.Text = "Foto";
            // 
            // txtSistemaEsqueleticoPez
            // 
            this.txtSistemaEsqueleticoPez.Location = new System.Drawing.Point(172, 177);
            this.txtSistemaEsqueleticoPez.Name = "txtSistemaEsqueleticoPez";
            this.txtSistemaEsqueleticoPez.Size = new System.Drawing.Size(171, 20);
            this.txtSistemaEsqueleticoPez.TabIndex = 37;
            // 
            // cmbHabitatPez
            // 
            this.cmbHabitatPez.FormattingEnabled = true;
            this.cmbHabitatPez.Items.AddRange(new object[] {
            "Mar",
            "",
            "Río",
            "",
            "Lago",
            "",
            "Estuario",
            "",
            "Océano profundo",
            "",
            "Arrecife de coral",
            "",
            "Manglar",
            "",
            "Laguna",
            "",
            "Zona costera"});
            this.cmbHabitatPez.Location = new System.Drawing.Point(382, 112);
            this.cmbHabitatPez.Name = "cmbHabitatPez";
            this.cmbHabitatPez.Size = new System.Drawing.Size(171, 21);
            this.cmbHabitatPez.TabIndex = 36;
            // 
            // cmbFamiliaPez
            // 
            this.cmbFamiliaPez.FormattingEnabled = true;
            this.cmbFamiliaPez.Items.AddRange(new object[] {
            "Actinopterigios (peces óseos)",
            "",
            "Condrictios (peces cartilaginosos)",
            "",
            "Dipnoos (peces pulmonados)",
            "",
            "Agnatos (peces sin mandíbula)",
            "",
            "Teleósteos",
            "",
            "Sarcopterigios"});
            this.cmbFamiliaPez.Location = new System.Drawing.Point(382, 82);
            this.cmbFamiliaPez.Name = "cmbFamiliaPez";
            this.cmbFamiliaPez.Size = new System.Drawing.Size(171, 21);
            this.cmbFamiliaPez.TabIndex = 35;
            // 
            // txtNombreCientificoPez
            // 
            this.txtNombreCientificoPez.Location = new System.Drawing.Point(382, 52);
            this.txtNombreCientificoPez.Name = "txtNombreCientificoPez";
            this.txtNombreCientificoPez.Size = new System.Drawing.Size(171, 20);
            this.txtNombreCientificoPez.TabIndex = 34;
            // 
            // txtNombreComunPez
            // 
            this.txtNombreComunPez.Location = new System.Drawing.Point(382, 22);
            this.txtNombreComunPez.Name = "txtNombreComunPez";
            this.txtNombreComunPez.Size = new System.Drawing.Size(171, 20);
            this.txtNombreComunPez.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 32;
            this.label13.Text = "Desarrollo embrionario:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Sistema esquelético:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(279, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Hábitat:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(279, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Familia:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(279, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Nombre científico:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(276, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Nombre común:";
            // 
            // groupBoxFotoPez
            // 
            this.groupBoxFotoPez.Controls.Add(this.picFotoPez);
            this.groupBoxFotoPez.Location = new System.Drawing.Point(17, 6);
            this.groupBoxFotoPez.Name = "groupBoxFotoPez";
            this.groupBoxFotoPez.Size = new System.Drawing.Size(207, 158);
            this.groupBoxFotoPez.TabIndex = 26;
            this.groupBoxFotoPez.TabStop = false;
            this.groupBoxFotoPez.Text = "Foto";
            // 
            // picFotoMamifero
            // 
            this.picFotoMamifero.Image = global::Zoologico.Properties.Resources.mamifero;
            this.picFotoMamifero.Location = new System.Drawing.Point(18, 19);
            this.picFotoMamifero.Name = "picFotoMamifero";
            this.picFotoMamifero.Size = new System.Drawing.Size(173, 117);
            this.picFotoMamifero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoMamifero.TabIndex = 0;
            this.picFotoMamifero.TabStop = false;
            // 
            // picFotoReptil
            // 
            this.picFotoReptil.Image = global::Zoologico.Properties.Resources.Reptiles;
            this.picFotoReptil.Location = new System.Drawing.Point(18, 19);
            this.picFotoReptil.Name = "picFotoReptil";
            this.picFotoReptil.Size = new System.Drawing.Size(173, 117);
            this.picFotoReptil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoReptil.TabIndex = 0;
            this.picFotoReptil.TabStop = false;
            // 
            // picFotoPez
            // 
            this.picFotoPez.Image = global::Zoologico.Properties.Resources.Peces;
            this.picFotoPez.Location = new System.Drawing.Point(18, 19);
            this.picFotoPez.Name = "picFotoPez";
            this.picFotoPez.Size = new System.Drawing.Size(173, 117);
            this.picFotoPez.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoPez.TabIndex = 0;
            this.picFotoPez.TabStop = false;
            // 
            // txtTipoLocomocionReptil
            // 
            this.txtTipoLocomocionReptil.Location = new System.Drawing.Point(172, 204);
            this.txtTipoLocomocionReptil.Name = "txtTipoLocomocionReptil";
            this.txtTipoLocomocionReptil.Size = new System.Drawing.Size(171, 20);
            this.txtTipoLocomocionReptil.TabIndex = 26;
            // 
            // txtDesarrolloEmbrionarioPez
            // 
            this.txtDesarrolloEmbrionarioPez.Location = new System.Drawing.Point(172, 204);
            this.txtDesarrolloEmbrionarioPez.Name = "txtDesarrolloEmbrionarioPez";
            this.txtDesarrolloEmbrionarioPez.Size = new System.Drawing.Size(171, 20);
            this.txtDesarrolloEmbrionarioPez.TabIndex = 38;
            // 
            // rbMamiferos
            // 
            this.rbMamiferos.AutoSize = true;
            this.rbMamiferos.Location = new System.Drawing.Point(36, 42);
            this.rbMamiferos.Name = "rbMamiferos";
            this.rbMamiferos.Size = new System.Drawing.Size(147, 17);
            this.rbMamiferos.TabIndex = 0;
            this.rbMamiferos.TabStop = true;
            this.rbMamiferos.Text = "Ver mamíferos registrados";
            this.rbMamiferos.UseVisualStyleBackColor = true;
            // 
            // rbReptiles
            // 
            this.rbReptiles.AutoSize = true;
            this.rbReptiles.Location = new System.Drawing.Point(36, 77);
            this.rbReptiles.Name = "rbReptiles";
            this.rbReptiles.Size = new System.Drawing.Size(131, 17);
            this.rbReptiles.TabIndex = 1;
            this.rbReptiles.TabStop = true;
            this.rbReptiles.Text = "Ver reptiles registrados";
            this.rbReptiles.UseVisualStyleBackColor = true;
            // 
            // rbPeces
            // 
            this.rbPeces.AutoSize = true;
            this.rbPeces.Location = new System.Drawing.Point(36, 114);
            this.rbPeces.Name = "rbPeces";
            this.rbPeces.Size = new System.Drawing.Size(127, 17);
            this.rbPeces.TabIndex = 2;
            this.rbPeces.TabStop = true;
            this.rbPeces.Text = "Ver peces registrados";
            this.rbPeces.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAnimales
            // 
            this.dataGridViewAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnimales.Location = new System.Drawing.Point(203, 17);
            this.dataGridViewAnimales.Name = "dataGridViewAnimales";
            this.dataGridViewAnimales.Size = new System.Drawing.Size(359, 234);
            this.dataGridViewAnimales.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 345);
            this.Controls.Add(this.tabControlAnimales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlAnimales.ResumeLayout(false);
            this.tabPageMamifero.ResumeLayout(false);
            this.tabPageMamifero.PerformLayout();
            this.tabPageReptil.ResumeLayout(false);
            this.tabPageReptil.PerformLayout();
            this.tabPagePeces.ResumeLayout(false);
            this.tabPagePeces.PerformLayout();
            this.tabPageVerAnimales.ResumeLayout(false);
            this.tabPageVerAnimales.PerformLayout();
            this.groupBoxFotoMamifero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMamas)).EndInit();
            this.groupBoxFotoReptil.ResumeLayout(false);
            this.groupBoxFotoPez.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoMamifero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoReptil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoPez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnimales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAnimales;
        private System.Windows.Forms.TabPage tabPageMamifero;
        private System.Windows.Forms.TabPage tabPageReptil;
        private System.Windows.Forms.TabPage tabPagePeces;
        private System.Windows.Forms.TabPage tabPageVerAnimales;
        private System.Windows.Forms.GroupBox groupBoxFotoMamifero;
        private System.Windows.Forms.PictureBox picFotoMamifero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCientificoMamifero;
        private System.Windows.Forms.TextBox txtNombreComunMamifero;
        private System.Windows.Forms.ComboBox cmbHabitatMamifero;
        private System.Windows.Forms.ComboBox cmbFamiliaMamifero;
        private System.Windows.Forms.NumericUpDown nudMamas;
        private System.Windows.Forms.TextBox txtTipoDesarrollo;
        private System.Windows.Forms.TextBox txtOrdenReptil;
        private System.Windows.Forms.ComboBox cmbHabitatReptil;
        private System.Windows.Forms.ComboBox cmbFamiliaReptil;
        private System.Windows.Forms.TextBox txtNombreCientificoReptil;
        private System.Windows.Forms.TextBox txtNombreComunReptil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBoxFotoReptil;
        private System.Windows.Forms.PictureBox picFotoReptil;
        private System.Windows.Forms.TextBox txtSistemaEsqueleticoPez;
        private System.Windows.Forms.ComboBox cmbHabitatPez;
        private System.Windows.Forms.ComboBox cmbFamiliaPez;
        private System.Windows.Forms.TextBox txtNombreCientificoPez;
        private System.Windows.Forms.TextBox txtNombreComunPez;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBoxFotoPez;
        private System.Windows.Forms.PictureBox picFotoPez;
        private System.Windows.Forms.TextBox txtTipoLocomocionReptil;
        private System.Windows.Forms.TextBox txtDesarrolloEmbrionarioPez;
        private System.Windows.Forms.RadioButton rbMamiferos;
        private System.Windows.Forms.DataGridView dataGridViewAnimales;
        private System.Windows.Forms.RadioButton rbPeces;
        private System.Windows.Forms.RadioButton rbReptiles;
    }
}

