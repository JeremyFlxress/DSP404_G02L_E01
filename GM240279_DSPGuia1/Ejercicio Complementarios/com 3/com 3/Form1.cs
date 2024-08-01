using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com_3
{
    public partial class Form1 : Form
    {
        private List<decimal> positiveNumbers = new List<decimal>();
        private List<decimal> negativeNumbers = new List<decimal>();
        private int numberCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            if (numberCount < 10)
            {
                decimal number;
                if (decimal.TryParse(txtNumber.Text, out number))
                {
                    if (number >= 0)
                    {
                        positiveNumbers.Add(number);
                        lstPositiveNumbers.Items.Add(number);
                    }
                    else
                    {
                        negativeNumbers.Add(number);
                        lstNegativeNumbers.Items.Add(number);
                    }

                    numberCount++;
                    txtNumber.Clear();

                    if (numberCount == 10)
                    {
                        btnAddNumber.Enabled = false;
                        btnCalculate.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un número decimal válido.");
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (negativeNumbers.Any())
            {
                lblMinNegative.Text = $"Menor de negativos: {negativeNumbers.Min()}";
            }
            else
            {
                lblMinNegative.Text = "Menor de negativos: N/A";
            }

            if (positiveNumbers.Any())
            {
                lblAvgPositive.Text = $"Promedio de positivos: {positiveNumbers.Average():F2}";

            }
            else
            {
                lblAvgPositive.Text = "Promedio de positivos: N/A";
            }
        }
    }
    
}
