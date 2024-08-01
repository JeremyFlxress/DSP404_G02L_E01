using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        private String mensa;

        //private int conta;
        private static int conta;


        public Form1()
        {
            InitializeComponent();
            label1.Size = new Size(200, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mensa = "Aun no ha presionado botón contar";
            label1.Text = mensa;
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            //int conta = 0; 
            conta = conta + 1;
            String mensa = "Presiono botón Contar, un total de " + Convert.ToString(conta) + " veces :)";
            label1.Text = mensa;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            conta = 0;
            mensa = "Presiono boton contar, un total de " + Convert.ToString(conta) + " veces :3 ";
            label1.Text = mensa;
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
