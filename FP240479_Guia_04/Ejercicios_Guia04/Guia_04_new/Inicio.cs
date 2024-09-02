using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_04_new
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form selectedForm = null;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Form1":
                    selectedForm = new Form1();
                    break;
                case "Form2":
                    selectedForm = new Form2();
                    break;
                case "Form3":
                    selectedForm = new Form3();
                    break;
                case "Form4":
                    selectedForm = new Form1_4();
                    break;
                default:
                    MessageBox.Show("Por favor, selecciona un formulario.");
                    return;
            }

            selectedForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
