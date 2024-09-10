using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoologico
{
    public partial class Form1 : Form
    {
        // Listas para almacenar los datos de los diferentes tipos de animales
        List<Mamifero> mamiferos = new List<Mamifero>();
        List<Reptil> reptiles = new List<Reptil>();
        List<Pez> peces = new List<Pez>();
        OpenFileDialog cuadroSeleccion = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
            cuadroSeleccion.Filter = "Imágenes de tipo JPG |*.jpg";

            prepararNuevoMamifero();
            prepararNuevoReptil();
            prepararNuevoPez();
        }

        // Lógica para la pestaña de Mamíferos
        private void prepararNuevoMamifero()
        {
            picFotoMamifero.ImageLocation = Application.StartupPath + "\\Imagenes\\MamiferoDefault.jpg"; // Imagen predeterminada
            txtNombreComunMamifero.Clear();
            txtNombreCientificoMamifero.Clear();
            cmbFamiliaMamifero.SelectedIndex = 0;
            cmbHabitatMamifero.SelectedIndex = 0;
            txtTipoDesarrollo.Clear();
            nudMamas.Value = 0;
        }

        private void btnAgregarMamifero_Click(object sender, EventArgs e)
        {
            Mamifero mamifero = new Mamifero();
            mamifero.NombreComun = txtNombreComunMamifero.Text;
            mamifero.NombreCientifico = txtNombreCientificoMamifero.Text;
            mamifero.Familia = cmbFamiliaMamifero.Text;
            mamifero.Habitat = cmbHabitatMamifero.Text;
            mamifero.TipoDesarrollo = txtTipoDesarrollo.Text;
            mamifero.CantidadMamas = Convert.ToInt32(nudMamas.Value);
            mamifero.Foto = cuadroSeleccion.FileName;

            mamiferos.Add(mamifero);
            prepararNuevoMamifero();
        }

        private void btnBuscarFotoMamifero_Click(object sender, EventArgs e)
        {
            if (cuadroSeleccion.ShowDialog() == DialogResult.OK)
            {
                picFotoMamifero.ImageLocation = cuadroSeleccion.FileName;
            }
        }

        // Lógica para la pestaña de Reptiles
        private void prepararNuevoReptil()
        {
            picFotoReptil.ImageLocation = Application.StartupPath + "\\Imagenes\\ReptilDefault.jpg"; // Imagen predeterminada
            txtNombreComunReptil.Clear();
            txtNombreCientificoReptil.Clear();
            cmbFamiliaReptil.SelectedIndex = 0;
            cmbHabitatReptil.SelectedIndex = 0;
            txtOrdenReptil.Clear();
            txtTipoLocomocionReptil.Clear();
        }

        private void btnAgregarReptil_Click(object sender, EventArgs e)
        {
            Reptil reptil = new Reptil();
            reptil.NombreComun = txtNombreComunReptil.Text;
            reptil.NombreCientifico = txtNombreCientificoReptil.Text;
            reptil.Familia = cmbFamiliaReptil.Text;
            reptil.Habitat = cmbHabitatReptil.Text;
            reptil.Orden = txtOrdenReptil.Text;
            reptil.TipoLocomocion = txtTipoLocomocionReptil.Text;
            reptil.Foto = cuadroSeleccion.FileName;

            reptiles.Add(reptil);
            prepararNuevoReptil();
        }

        private void btnBuscarFotoReptil_Click(object sender, EventArgs e)
        {
            if (cuadroSeleccion.ShowDialog() == DialogResult.OK)
            {
                picFotoReptil.ImageLocation = cuadroSeleccion.FileName;
            }
        }

        // Lógica para la pestaña de Peces
        private void prepararNuevoPez()
        {
            picFotoPez.ImageLocation = Application.StartupPath + "\\Imagenes\\PezDefault.jpg"; // Imagen predeterminada
            txtNombreComunPez.Clear();
            txtNombreCientificoPez.Clear();
            cmbFamiliaPez.SelectedIndex = 0;
            cmbHabitatPez.SelectedIndex = 0;
            txtSistemaEsqueletico.Clear();
            txtDesarrolloEmbrionario.Clear();
        }

        private void btnAgregarPez_Click(object sender, EventArgs e)
        {
            Pez pez = new Pez();
            pez.NombreComun = txtNombreComunPez.Text;
            pez.NombreCientifico = txtNombreCientificoPez.Text;
            pez.Familia = cmbFamiliaPez.Text;
            pez.Habitat = cmbHabitatPez.Text;
            pez.SistemaEsqueletico = txtSistemaEsqueletico.Text;
            pez.DesarrolloEmbrionario = txtDesarrolloEmbrionario.Text;
            pez.Foto = cuadroSeleccion.FileName;

            peces.Add(pez);
            prepararNuevoPez();
        }

        private void btnBuscarFotoPez_Click(object sender, EventArgs e)
        {
            if (cuadroSeleccion.ShowDialog() == DialogResult.OK)
            {
                picFotoPez.ImageLocation = cuadroSeleccion.FileName;
            }
        }

        // Lógica para la pestaña de Ver Animales Registrados
        private void rbMamiferos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMamiferos.Checked)
            {
                mostrarListaMamiferos();
            }
        }

        private void rbReptiles_CheckedChanged(object sender, EventArgs e)
        {
            if (rbReptiles.Checked)
            {
                mostrarListaReptiles();
            }
        }

        private void rbPeces_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPeces.Checked)
            {
                mostrarListaPeces();
            }
        }

        private void mostrarListaMamiferos()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < mamiferos.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = mamiferos[i].NombreComun;
                dataGridView1.Rows[i].Cells[2].Value = mamiferos[i].NombreCientifico;
                dataGridView1.Rows[i].Cells[3].Value = mamiferos[i].Familia;
                dataGridView1.Rows[i].Cells[4].Value = mamiferos[i].Habitat;
            }
        }

        private void mostrarListaReptiles()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < reptiles.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = reptiles[i].NombreComun;
                dataGridView1.Rows[i].Cells[2].Value = reptiles[i].NombreCientifico;
                dataGridView1.Rows[i].Cells[3].Value = reptiles[i].Familia;
                dataGridView1.Rows[i].Cells[4].Value = reptiles[i].Habitat;
            }
        }

        private void mostrarListaPeces()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < peces.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = peces[i].NombreComun;
                dataGridView1.Rows[i].Cells[2].Value = peces[i].NombreCientifico;
                dataGridView1.Rows[i].Cells[3].Value = peces[i].Familia;
                dataGridView1.Rows[i].Cells[4].Value = peces[i].Habitat;
            }
        }
    }

}
