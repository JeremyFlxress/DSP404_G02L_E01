using System.Windows.Forms;

namespace Discusion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (int.TryParse(txtNumero.Text, out int maxNumber) && maxNumber >= 0)
            {
                int a = 0, b = 1, c = 0;

                listBox1.Items.Add(a);
                if (maxNumber == 0) return;

                listBox1.Items.Add(b);
                if (maxNumber == 1) return;

                while (true)
                {
                    c = a + b;
                    if (c > maxNumber) break;
                    listBox1.Items.Add(c);
                    a = b;
                    b = c;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Clear();
                txtNumero.BackColor = Color.Red;
            }
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            {
                txtNumero.Clear();
                listBox1.Items.Clear();
                txtNumero.BackColor = Color.White;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


