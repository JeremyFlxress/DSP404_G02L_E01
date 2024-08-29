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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void PresentacInic()
        {
            //Preparando controles antes de mostrar form al usuario
            grbResult.Visible = false;
            nupBase.Focus();
        }

        private void HacerCalculos(Decimal N)
        {
            int c;
            decimal result;

            lstTabla1.Items.Clear();
            c = 1;

            do
            {
                result = N * c;
                lstTabla1.Items.Add(N.ToString() + " X " + c.ToString() + " = " + result.ToString());
                c += 1;
            } while (!(c > 10));

            //Genera la potencia de las tablas
            lstTabla2.Items.Clear();
            c = 1;

            do
            {
                result = Elevar(N, c);
                lstTabla2.Items.Add(N.ToString() + " a la " + c.ToString() + " = " + result.ToString());
                c+= 1;
            } while (c <= 10);
        }

        private decimal Elevar(decimal B, int expo)
        {
            int i = 1;
            decimal r = 1;
            do
            {
                r *= B;
                i += 1;

            } while (!(i > expo));
            return r;
        }



        private void btnCalculo_Click(object sender, EventArgs e)
        {
            //Invoca a subrutina HacerCalculos
            decimal n = nupBase.Value;
            HacerCalculos(n);

            //Muestra los resultados
            grbResult.Visible = true;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PresentacInic();
        }
    }
}
