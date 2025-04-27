using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnthonyUpchurch5PA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGetDiscount_Click(object sender, EventArgs e)
        {

            if (tbxRegularCost.Text == "")
            {
                lblMathofProblem.Text = "Enter regular cost.";
                return;
            }

            decimal regularCost = Convert.ToDecimal(tbxRegularCost.Text);

            // Generate random discount (5%, 10%, or 25%)
            int discountPercentage = GetRandomDiscount();

            // Display the discount percentage
            lblPercentageOfSale.Text = discountPercentage + "%";

            // Calculate and display savings and sale price
            decimal savings = regularCost * discountPercentage / 100;
            decimal salePrice = regularCost - savings;

            lblSavingsAmount.Text = "$" + savings.ToString("F2");
            lblMathofProblem.Text = "$" + salePrice.ToString("F2");
        }
        private int GetRandomDiscount()
        {
            //Generate a random number between 1 and 3 to get diccout
            Random random = new Random();
            int randomValue = random.Next(1, 4); 
            if (randomValue == 1) return 5;
            if (randomValue == 2) return 10;
            return 25;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all text boxes and labels
            tbxRegularCost.Text = "";
            lblPercentageOfSale.Text = "";
            lblSavingsAmount.Text = "";
            lblMathofProblem.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
