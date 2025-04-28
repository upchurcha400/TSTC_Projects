using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUpchurch5PB
{
    public partial class frmPinkysPizza : Form
    {
        public frmPinkysPizza()
        {
            InitializeComponent();
        }

        private decimal PizzaCharges()
        {
            decimal totalPizzaCharges = 0;
            if (chkSmPizza.Checked) totalPizzaCharges = 8.00m;
            if (chkMedPizza.Checked) totalPizzaCharges = 12.25m;
            if (chkLgPizza.Checked) totalPizzaCharges = 16.00m;
            return totalPizzaCharges;
        }

        private decimal WingsCharges()
        {
            decimal totalWingsCharges = 0;
            if (chkSmWings.Checked) totalWingsCharges = 8.00m;
            if (chkLgWings.Checked) totalWingsCharges = 15.75m;
            return totalWingsCharges;
        }

        private decimal AppetizersCharges()
        {
            decimal totalAppetizersCharges = 0;
            if (chkMushrooms.Checked) totalAppetizersCharges = 7.50m;
            if (chkChezBread.Checked) totalAppetizersCharges = 12.00m;
            if (chkNachos.Checked) totalAppetizersCharges = 13.00m;
            return totalAppetizersCharges;
        }

        private decimal MiscCharges(decimal foodTotal)
        {
            decimal totalMiscCharges = 0;
            if (chkDelivery.Checked)
            {
                totalMiscCharges = foodTotal * 0.10m;
            }
            else if (chkTakeOut.Checked) // Use else if here
            {
                totalMiscCharges = foodTotal * 0.03m;
            }
            return totalMiscCharges;
        }
        

        private decimal TaxCharges(decimal taxableAmount)
        {
            return taxableAmount * 0.06m;
        }

        private decimal TotalCharges(decimal foodTotal, decimal miscTotal, decimal taxTotal, decimal tipTotal)
        {
            return foodTotal + miscTotal + taxTotal + tipTotal;
        }
        private void ClearPizzas()
        {
            chkSmPizza.Checked = false;
            chkMedPizza.Checked = false;
            chkLgPizza.Checked = false;
        }

        private void ClearWings()
        {
            chkSmWings.Checked = false;
            chkLgWings.Checked = false;
        }

        private void ClearMisc()
        {
            chkDelivery.Checked = false;
            chkTakeOut.Checked = false;
            tbxTipGiven.Text = "0.00";
        }

        private void ClearAppetizers()
        {
            chkMushrooms.Checked = false;
            chkChezBread.Checked = false;
            chkNachos.Checked = false;
        }

        private void ClearSummary()
        {
            lblFoodTotal.Text = "";
            lblTaxTotal.Text = "";
            lblMiscTotal.Text = "";
            lblTipTotal.Text = "";
            lblTotalAmount.Text = "";
        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal pizzaTotal = PizzaCharges();
            decimal wingsTotal = WingsCharges();
            decimal appetizersTotal = AppetizersCharges();

            decimal foodTotal = pizzaTotal + wingsTotal + appetizersTotal;
            lblFoodTotal.Text = foodTotal.ToString("C2");

            decimal tipAmount = 0.00m;
            if (tbxTipGiven.Text == "")
            {
                tipAmount = 0.00m;
                lblTipTotal.Text = tipAmount.ToString("C2");
            }
            else
            {
                try
                {
                    tipAmount = decimal.Parse(tbxTipGiven.Text);
                    lblTipTotal.Text = tipAmount.ToString("C2");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter a valid number for the tip amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxTipGiven.Text = "0.00";
                    tipAmount = 0.00m;
                    lblTipTotal.Text = tipAmount.ToString("C2");
                }
            }

            decimal miscTotal = MiscCharges(foodTotal);
            lblMiscTotal.Text = miscTotal.ToString("C2");

            decimal taxAmount = TaxCharges(foodTotal);
            lblTaxTotal.Text = taxAmount.ToString("C2");

            decimal totalAmount = TotalCharges(foodTotal, miscTotal, taxAmount, tipAmount);
            lblTotalAmount.Text = totalAmount.ToString("C2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPizzas();
            ClearWings();
            ClearAppetizers();
            ClearMisc();
            ClearSummary();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
