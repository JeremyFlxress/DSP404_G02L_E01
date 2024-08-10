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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            timer1.Interval = 15000;  
            timer1.Tick += timer1_Tick;
            timer1.Start();  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();  
            if (this.Visible) 
            {
                Form1 form1 = new Form1();  
                form1.Show();
                this.Hide();  
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }
    }
}
