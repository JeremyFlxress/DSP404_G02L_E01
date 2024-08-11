using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class LenguajesProgra : Form
    {
        public LenguajesProgra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSinopsis.Clear();
            txtIProtagonistas.Clear();
            txtPaisOrigen.Clear();
            txtCreadoPor.Clear();
            txtTemporadas.Clear();
            txtEpisodios.Clear();

            lblTitulo1.Text = "Python";
            lblTituloEspañol.Text = "Desarrollador(es): Python Software Foundation";
            txtSinopsis.Text = "1991";
            txtIProtagonistas.Text = ".py, .pyc, .pyd, .pyo, .pyw, .pyz";
            txtPaisOrigen.Text = "Multiplataforma";
            txtCreadoPor.Text = "Multiparadigma: orientado a objetos, imperativo, funcional, reflexivo";
            txtTemporadas.Text = "3.8.3";
            txtEpisodios.Text = "Python Software Foundation License";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSinopsis.Clear();
            txtIProtagonistas.Clear();
            txtPaisOrigen.Clear();
            txtCreadoPor.Clear();
            txtTemporadas.Clear();
            txtEpisodios.Clear();

            lblTitulo1.Text = "Java";
            lblTituloEspañol.Text = "Desarrollador(es): James Gosling y Sun Microsystems";
            txtSinopsis.Text = "1996";
            txtIProtagonistas.Text = ".java, .class, .jar, .jad, .jmod";
            txtPaisOrigen.Text = "Multiplataforma";
            txtCreadoPor.Text = "Orientado a objetos, imperativo";
            txtTemporadas.Text = "Última versión estable: 14.01";
            txtEpisodios.Text = "GNU GPL / Java Community Process";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSinopsis.Clear();
            txtIProtagonistas.Clear();
            txtPaisOrigen.Clear();
            txtCreadoPor.Clear();
            txtTemporadas.Clear();
            txtEpisodios.Clear();

            lblTitulo1.Text = "JavaScript";
            lblTituloEspañol.Text = "--";
            txtSinopsis.Text = "1995";
            txtIProtagonistas.Text = ".js";
            txtPaisOrigen.Text = "--";
            txtCreadoPor.Text = "Multiparadigma: funcional, basada en prototipos, imperativo, interpretado (scripting)";
            txtTemporadas.Text = "ECMAScript 2016";
            txtEpisodios.Text = "--";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Close();
        }
    }
}
