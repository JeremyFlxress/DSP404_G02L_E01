using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private string noms, ape1, ape2;
        private double CUM;
        private int UV;

        //Valida que el dato recibido es un numero
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        //Evalue el CUM
        private void EvaluarCUM()
        {
            //Una vex recibido los nombres del estudiante, asi como su CUM se determina las UV solicitadas
            string nombreCompleto;
            nombreCompleto = noms + " " + ape1 + " " + ape2;

            nombreCompleto = nombreCompleto.ToUpper();

            if (CUM < 0 || CUM > 10)
            {
                MessageBox.Show("Valor de CUM fuera de rango (0.0 - 10.0)", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCUM.Focus();
            }
            else
            {
                //Usa estructura SWITCH

                switch (Convert.ToInt16(CUM))
                {
                    case 8:
                    case 9:
                    case 10:
                        UV = 32;
                        break;
                    case 7:
                        UV = 24;
                        break;
                    case 6:
                        UV = 20;
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        UV = 16;
                        break;
                    default:
                        UV = 0;
                        break;
                }
                txtResul.Text = nombreCompleto + " puede cursar " + UV + " UV";
            }
        }


        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            string name, lastName1, lastName2;

            lastName1 = txtApe1.Text;
            lastName1 = lastName1.Trim(); // Quita el espacio en blanco

            if (lastName1.Length == 0)
            {
                //Si no hay caracteres en el primer apellido
                MessageBox.Show("Digite su primer apellido", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApe1.Focus();
                return;
            }

            lastName2 = txtApe2.Text;
            lastName2 = lastName2.Trim(); // Quita el espacio en blanco

            if (lastName2.Length == 0)
            {
                //Si no hay caracteres en el segundo apellido
                MessageBox.Show("Digite su segundo apellido", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApe2.Focus();
                return;
            }


            name = txtNom.Text;
            name = name.Trim(); // Quita el espacio en blanco

            if (name.Length == 0)
            {
                //Si no hay caracteres en el nombre
                MessageBox.Show("Digite su nombre", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNom.Focus();
                return;
            }

            EvaluarCUM();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Suerte en la vida!", "Information", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void txtApe1_TextChanged(object sender, EventArgs e)
        {
            ape1 = txtApe1.Text;
        }

        private void txtApe2_TextChanged(object sender, EventArgs e)
        {
            ape2 = txtApe2.Text;
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            noms = txtNom.Text;
        }

        private void txtCUM_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCUM.Text))
            {
                CUM = 0.0; // Se asigna un valor por default
            }
            else
            {
                // Intenta convertir el texto a double
                if (!double.TryParse(txtCUM.Text, out CUM))
                {
                    // Si no se puede convertir a double, muestra un mensaje de error
                    MessageBox.Show("Por favor, introduce un número válido", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCUM.Text = "0.0";
                    txtCUM.Focus();
                }
            }
        }

    }
}
