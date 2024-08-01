using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementario_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                listBoxNames.Items.Add(textBoxName.Text);
                textBoxName.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un nombre válido.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxNames.SelectedItem != null)
            {
                listBoxNames.Items.Remove(listBoxNames.SelectedItem);
            }
            else
            {
                MessageBox.Show("Seleccione un nombre para borrar.");
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (listBoxNames.SelectedItem != null && !string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                int selectedIndex = listBoxNames.SelectedIndex;
                listBoxNames.Items[selectedIndex] = textBoxName.Text;
                textBoxName.Clear();
            }
            else
            {
                MessageBox.Show("Seleccione un nombre y/o ingrese un nuevo nombre válido.");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
