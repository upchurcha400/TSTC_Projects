using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnthonyUpchurchM5B
{
    public partial class Form1 : Form
    {
        // Class-level variable for current background color
        private Color selectedColor = SystemColors.Control;

        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for all RadioButton CheckedChanged events
        private void rbtColor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                // Set the selectedColor based on the RadioButton's text
                switch (radioButton.Text)
                {
                    case "Red":
                        selectedColor = Color.Red;
                        break;
                    case "Blue":
                        selectedColor = Color.Blue;
                        break;
                    case "Green":
                        selectedColor = Color.Green;
                        break;
                    case "Yellow":
                        selectedColor = Color.Yellow;
                        break;
                    case "White":
                        selectedColor = Color.White;
                        break;
                }

                // Call the method to change the background color
                ColorChange();
            }
        }

        // Method to change the background color of the form
        private void ColorChange()
        {
            this.BackColor = selectedColor;
        }

        // Convert Button Click Event
        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Validate input
            if (double.TryParse(tbxInput.Text, out double value) && lstConversions.SelectedItem != null)
            {
                string conversionType = lstConversions.SelectedItem.ToString();
                double result = 0;

                switch (conversionType)
                {
                    case "Inches to Centimeters":
                        result = ConvertInchesToCentimeters(value);
                        lblResults.Text = $"{value} inches is {result} centimeters.";
                        break;
                    case "Feet to Meters":
                        result = ConvertFeetToMeters(value);
                        lblResults.Text = $"{value} feet is {result} meters.";
                        break;
                    case "Yards to Meters":
                        result = ConvertYardsToMeters(value);
                        lblResults.Text = $"{value} yards is {result} meters.";
                        break;
                    case "Miles to Kilometers":
                        result = ConvertMilesToKilometers(value);
                        lblResults.Text = $"{value} miles is {result} kilometers.";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number and select a conversion type.");
            }
        }

        // Conversion Methods
        private double ConvertInchesToCentimeters(double inches)
        {
            return inches * 2.54;
        }

        private double ConvertFeetToMeters(double feet)
        {
            return feet * 0.3048;
        }

        private double ConvertYardsToMeters(double yards)
        {
            return yards * 0.9144;
        }

        private double ConvertMilesToKilometers(double miles)
        {
            return miles * 1.60934;
        }

        // Clear Button Click Event
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearLabel();
            ClearText();
            ClearSelections();
        }

        // Void Methods for Clearing
        private void ClearLabel()
        {
            lblResults.Text = string.Empty;
        }

        private void ClearText()
        {
            tbxInput.Text = string.Empty;
        }

        private void ClearSelections()
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }

            this.BackColor = SystemColors.Control;
            lstConversions.ClearSelected();
        }

        // Exit Button Click Event
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}