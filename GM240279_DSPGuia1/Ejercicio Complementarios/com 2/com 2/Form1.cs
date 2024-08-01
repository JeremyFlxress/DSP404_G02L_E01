using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            // Populate months
            cmbMonth.Items.AddRange(new string[]
            {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            });

            // Populate days (1-31)
            for (int i = 1; i <= 31; i++)
            {
                cmbDay.Items.Add(i.ToString());
            }

            // Populate years (1900-2100)
            for (int i = 1900; i <= 2100; i++)
            {
                cmbYear.Items.Add(i.ToString());
            }

            // Set default selected values
            cmbMonth.SelectedIndex = 0;
            cmbDay.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            // Get selected values
            string selectedMonth = cmbMonth.SelectedItem.ToString();
            int selectedDay = Convert.ToInt32(cmbDay.SelectedItem.ToString());
            int selectedYear = Convert.ToInt32(cmbYear.SelectedItem.ToString());

            // Validate the date
            if (IsValidDate(selectedMonth, selectedDay, selectedYear))
            {
                lblResult.Text = $"Fecha válida: {selectedMonth} {selectedDay}, {selectedYear}";
            }
            else
            {
                lblResult.Text = "Fecha no válida.";
            }
        }

        private bool IsValidDate(string month, int day, int year)
        {
            int maxDays = 31;

            switch (month)
            {
                case "April":
                case "June":
                case "September":
                case "November":
                    maxDays = 30;
                    break;
                case "February":
                    if (IsLeapYear(year))
                    {
                        maxDays = 29;
                    }
                    else
                    {
                        maxDays = 28;
                    }
                    break;
            }

            return day <= maxDays;
        }

        private bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    return year % 400 == 0;
                }
                return true;
            }
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
