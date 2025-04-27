using System;
using System.Windows.Forms;

namespace CruisePlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbxCruiseDetails.Items.Add("Carnival (Galveston) - 3 Nights - $1000");
            lbxCruiseDetails.Items.Add("Disney (Miami) - 7 Nights - $2000");
            lbxCruiseDetails.Items.Add("Princess (Seattle) - 4 Nights - $1500");
            lbxCruiseDetails.Items.Add("Royal Caribbean (San Diego) - 5 Nights - $2500");
            lbxCruiseDetails.Items.Add("Norwegian (New Orleans) - 8 Nights - $5000");

            lbxLodging.Items.Add("Jamaica - $250 per night");
            lbxLodging.Items.Add("Hawaii - $325 per night");
            lbxLodging.Items.Add("Caribbean - $175 per night");
            lbxLodging.Items.Add("Baja - $300 per night");
            lbxLodging.Items.Add("Panama Canal - $575 per night");
            lbxLodging.Items.Add("Alaska - $150 per night");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (lbxCruiseDetails.SelectedIndex == -1 || lbxLodging.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a cruise line and a lodging option.", "Selection Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedCruise = lbxCruiseDetails.SelectedItem.ToString();
            string selectedLodging = lbxLodging.SelectedItem.ToString();

            int nights = 0;
            decimal cruiseCost = 0m;
            if (selectedCruise.Contains("Carnival (Galveston)"))
            {
                nights = 3;
                cruiseCost = 1000m;
            }
            else if (selectedCruise.Contains("Disney (Miami)"))
            {
                nights = 7;
                cruiseCost = 2000m;
            }
            else if (selectedCruise.Contains("Princess (Seattle)"))
            {
                nights = 4;
                cruiseCost = 1500m;
            }
            else if (selectedCruise.Contains("Royal Caribbean (San Diego)"))
            {
                nights = 5;
                cruiseCost = 2500m;
            }
            else if (selectedCruise.Contains("Norwegian (New Orleans)"))
            {
                nights = 8;
                cruiseCost = 5000m;
            }

            decimal lodgingCostPerNight = 0m;
            if (selectedLodging.Contains("Jamaica"))
                lodgingCostPerNight = 250m;
            else if (selectedLodging.Contains("Hawaii"))
                lodgingCostPerNight = 325m;
            else if (selectedLodging.Contains("Caribbean"))
                lodgingCostPerNight = 175m;
            else if (selectedLodging.Contains("Baja"))
                lodgingCostPerNight = 300m;
            else if (selectedLodging.Contains("Panama Canal"))
                lodgingCostPerNight = 575m;
            else if (selectedLodging.Contains("Alaska"))
                lodgingCostPerNight = 150m;

            decimal lodgingCost = lodgingCostPerNight * nights;
            decimal totalCost = cruiseCost + lodgingCost;

            lblCostResult.Text = $"Cruise: {selectedCruise}\n" +
                                 $"Lodging: {selectedLodging}\n" +
                                 $"Lodging Cost: ${lodgingCost:F2}\n" +
                                 $"Total Cost: ${totalCost:F2}";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
