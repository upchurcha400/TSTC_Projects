using System;
using System.Windows.Forms;

namespace AnthonyUpchurch3PA
{
    public partial class frmTranslator : Form
    {
        public frmTranslator()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            tbxEnglish.Text = "";
            tbxGerman.Text = "";

            int number;

            try
            {
                number = Convert.ToInt32(tbxNumber.Text);

                if (number == 1)
                {
                    tbxEnglish.Text = "One";
                    tbxGerman.Text = "eins";
                }
                else if (number == 2)
                {
                    tbxEnglish.Text = "Two";
                    tbxGerman.Text = "zwei";
                }
                else if (number == 3)
                {
                    tbxEnglish.Text = "Three";
                    tbxGerman.Text = "drei";
                }
                else if (number == 4)
                {
                    tbxEnglish.Text = "Four";
                    tbxGerman.Text = "vier";
                }
                else if (number == 5)
                {
                    tbxEnglish.Text = "Five";
                    tbxGerman.Text = "funf";
                }
                else if (number == 6)
                {
                    tbxEnglish.Text = "Six";
                    tbxGerman.Text = "sechs";
                }
                else if (number == 7)
                {
                    tbxEnglish.Text = "Seven";
                    tbxGerman.Text = "sieben";
                }
                else if (number == 8)
                {
                    tbxEnglish.Text = "Eight";
                    tbxGerman.Text = "acht";
                }
                else if (number == 9)
                {
                    tbxEnglish.Text = "Nine";
                    tbxGerman.Text = "neun";
                }
                else if (number == 10)
                {
                    tbxEnglish.Text = "Ten";
                    tbxGerman.Text = "zehn";
                }
                else
                {
                    MessageBox.Show("Error: Number must be between 1 and 10.",
                                    "Input Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Please enter a valid whole number.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error: Number entered is too large or too small.",
                               "Input Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message,
                               "Application Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }
    }
}