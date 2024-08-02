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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                lstName.Items.Add(txtName.Text);
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstName.SelectedIndex != -1)
            {
                lstName.Items.RemoveAt(lstName.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione un nombre para borrar.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstName.SelectedIndex != -1 && !string.IsNullOrEmpty(txtName.Text))
            {
                lstName.Items[lstName.SelectedIndex] = txtName.Text;
                txtName.Clear();
            }
            else
            {
                MessageBox.Show("Seleccione un nombre y escriba el nuevo nombre.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
