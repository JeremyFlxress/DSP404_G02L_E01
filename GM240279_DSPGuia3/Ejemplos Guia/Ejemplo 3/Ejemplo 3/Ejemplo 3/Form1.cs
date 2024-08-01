using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Ejemplo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> palabras = new Dictionary<string, string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            palabras.Add("Manzana", "Fruta pomácea comestible, fruto\n del manzano doméstico (Malus" +
            "domestica)\n, otros manzanos(especies del género\n Malus).");

            palabras.Add("Pera", "Fruta comestible que procede del Pyrus communis, un árbol que se conoce" +
            "coloquialmente como peral común.Existen, de todas maneras, muchas clases de peras, que son" +
            "producidas por otros árboles del género Pyrus.");

            palabras.Add("Melocotón", "Fruto del melocotonero. Es una drupa de olor agradable, esférica, " +
            "deseis a ocho centímetros de diámetro, con un surco profundo que ocupa media circunferencia," +
            "epicarpio delgado, velloso, de color amarillo con manchas encarnadas, mesocarpio amarillento, de" +
            "sabor agradable y adherido a un hueso pardo, duro y rugoso, que encierra una almendra muy" +
            "amarga.");

             foreach (var item in palabras.Keys)
            {
                lstPalabras.Items.Add(item);
            }
        }

        private void lstPalabras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string buscar;
            buscar = lstPalabras.Text;
            for (int i = 0; i < palabras.Count; i++)
            {
                var item = palabras.ElementAt(i);
                if (buscar == item.Key)
                {
                    lblPalabra.Text = item.Key;
                    txtSignificado.Text = item.Value;
                    break;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
