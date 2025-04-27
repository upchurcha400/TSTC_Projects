using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpchurchA4PA
{
    public partial class frmTuitionCalculatorForm : Form
    {
        public frmTuitionCalculatorForm()
        {
            InitializeComponent();
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Clear previous results
            lstResults.Items.Clear();

            // Parse user input
            try
            {
                // Convert user input
                decimal tuitionCost = Convert.ToDecimal(tbxTuitionCost.Text);
                int numberOfHours = Convert.ToInt32(tbxNumberOfHours.Text);

                // Display calculated tuition for each hour
                for (int hour = 1; hour <= numberOfHours; hour++)
                {
                    decimal totalCost = tuitionCost * hour;
                    lstResults.Items.Add($"Hour {hour}: ${totalCost}");
                }
            }
            catch (FormatException)
            {
                // Handle invalid input
                MessageBox.Show("Please enter valid numeric values for tuition cost and hours.", "Input Error");
            }
            catch (OverflowException)
            {
                // Handle numbers that are too large
                MessageBox.Show("The numbers entered are too large. Please enter smaller values.", "Input Error");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Exit the application
            this.Close();
        }
    }
}
