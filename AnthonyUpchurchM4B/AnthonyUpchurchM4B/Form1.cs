using System;
using System.IO;
using System.Windows.Forms;

namespace AnthonyUpchurchM4B
{
    public partial class frmSalesReporting : Form
    {
        private string fileName = "auSales.txt";

        public frmSalesReporting()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSalesAmount.Text))
            {
                MessageBox.Show("Please enter a sales amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxSalesAmount.Focus();
                return;
            }

            if (!decimal.TryParse(tbxSalesAmount.Text, out decimal salesAmount) || salesAmount <= 0)
            {
                MessageBox.Show("Please enter a valid positive sales amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxSalesAmount.Focus();
                return;
            }

            File.AppendAllText(fileName, salesAmount + Environment.NewLine);

            MessageBox.Show("Sales amount written to file.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbxSalesAmount.Clear();
            tbxSalesAmount.Focus();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lbxBoxSales.Items.Clear();

            if (!File.Exists(fileName))
            {
                MessageBox.Show("Sales file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                lbxBoxSales.Items.Add(line);
            }

            MessageBox.Show("Sales amounts loaded.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (lbxBoxSales.Items.Count == 0)
            {
                MessageBox.Show("No sales amounts to calculate total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal total = 0;

            foreach (string item in lbxBoxSales.Items)
            {
                if (decimal.TryParse(item, out decimal value))
                {
                    total += value;
                }
            }

            lblTotalValue.Text = total.ToString("C");
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            if (lbxBoxSales.Items.Count == 0)
            {
                MessageBox.Show("No sales amounts to calculate average.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal total = 0;
            int count = lbxBoxSales.Items.Count;

            foreach (string item in lbxBoxSales.Items)
            {
                if (decimal.TryParse(item, out decimal value))
                {
                    total += value;
                }
            }

            decimal average = total / count;
            lblAverageValue.Text = average.ToString("C");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxSalesAmount.Clear();
            lbxBoxSales.Items.Clear();
            lblTotalValue.Text = string.Empty;
            lblAverageValue.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}