using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private Boolean validar (string nombre, string pwd)
        {
            string clave = nombre;
            string password = "usuario";

            DialogResult respuesta; // variable para capturar el dato que me devuelve el Cuadro de dialogo
            if (nombre == clave && pwd == password)
            {
                respuesta = MessageBox.Show("Bienvenido " + nombre, "Acceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (respuesta == DialogResult.OK)
                {
                    /**
                     * Para llamar a otro formulario (Form2), se debe instancia el nuevo form.
                     * Para nuestro caso formulario 2 y luego accesamos al método Show
                     * Para mostrar el Form2
                     */

                    Form2 formulario2 = new Form2();
                    formulario2.Show();
                    return true;
                }//Fin de if
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Acceso", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return false;
        } //Fin de función

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPassword.Text;

            // Primero, validar que ambos campos no estén vacíos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Introduzca un valor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
            }
            // Luego, verificar si el nombre de usuario comienza con una letra
            else if (!char.IsLetter(username[0]))
            {
                MessageBox.Show("Introduzca un valor correcto. Empezando con una letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUser.Focus();
            }
            // Finalmente, validar las credenciales
            else if (validar(username, password))
            {
                // Se llama a la función validar declarada
                this.Hide(); // Ocultamos el Form 1
            }
        }
    }
}
