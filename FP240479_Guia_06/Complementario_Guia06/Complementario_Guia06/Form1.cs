using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementario_Guia06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private List<Animales> animalesRegistrados = new List<Animales>(); 
        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            dataGridViewInforme.Rows.Clear();  
            foreach (var animal in animalesRegistrados)
            {
                dataGridViewInforme.Rows.Add(animal.NombreComun, animal.NombreCientifico, animal.Familia, animal.Habitat, animal.FechaRegistro.ToShortDateString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName; 
                button1.Text = openFileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbTipoAnimal.SelectedItem.ToString() == "Mamífero")
            {
                Mamifero mamifero = new Mamifero
                {
                    NombreComun = txtNombreComun.Text,
                    NombreCientifico = txtNombreCientifico.Text,
                    Familia = cmbFamilia.SelectedItem.ToString(),
                    Habitat = cmbHabitat.SelectedItem.ToString(),
                    FechaRegistro = dtpFechaRegistro.Value,
                    Foto = pictureBox1.Text,
                    DesarrolloEmbrionario = cmbDesarrolloEmbrionarioPez.SelectedItem.ToString(),
                    CantidadMamas = int.Parse(txtCantidadMamas.Text)
                };
                animalesRegistrados.Add(mamifero);
            }
        }
    }
}
