using System.ComponentModel;

namespace Ejemplo5
{
    public partial class frmULAM : Form
    {
        public frmULAM()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int limit = 0;
            try
            {
                limit = Convert.ToInt32(txtnumero.Text);
                if (limit <= 0)
                {
                    MessageBox.Show("Please enter a positive limit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid limit entered. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<int> ulamSequence = CalculateUlamSequence(limit);
            lstLista.Items.Clear();
            foreach (int number in ulamSequence)
            {
                lstLista.Items.Add(number.ToString());
            }
        }

        private List<int> CalculateUlamSequence(int limit)
        {
            List<int> sequence = new List<int>();
            sequence.Add(1);

            int currentNumber = 1;
            while (currentNumber <= limit)
            {
                int nextNumber = 0;

                foreach (int previousNumber in sequence)
                {
                    nextNumber += previousNumber;
                }

                sequence.Add(nextNumber);
                currentNumber = nextNumber;
            }

            return sequence;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
            txtnumero.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

