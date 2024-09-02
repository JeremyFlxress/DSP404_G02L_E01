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
    public partial class Form1_4 : Form
    {
        private Boolean validar(string nombre, string pwd)
        {
            string clave = nombre;
            string pasword = "usuario";
            DialogResult respuesta; 
           if (nombre == clave && pwd == pasword)
            {
                respuesta = MessageBox.Show("Bienvenido" + " " + nombre, "Acceso",
               MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (respuesta == DialogResult.OK)
                {
                    Form5 formulario2 = new Form5();
                    formulario2.Show(); 
                    return true;
                }
            }
           
            return false;

        }
        public Form1_4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar(txtUsuario.Text, txtContraseña.Text))
            {
                this.Hide();
            }
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("El campo 'Contraseña' es obligatorio.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                return;
            }
    
            if (txtContraseña.Text.Length < 8 || !txtContraseña.Text.Any(char.IsDigit) || !txtContraseña.Text.Any(char.IsLetter))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, incluyendo letras y números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                return;
            }

            MessageBox.Show("Registro exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form nuevoFormulario = new Form5(); 
            nuevoFormulario.ShowDialog();

            this.Show();
        }

        private void Form1_4_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}
