using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AnthonyUpchurchM3B
{
    public partial class frmSeasons : Form
    {
        public frmSeasons()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
          
            this.Text = "Select a Season";
            this.Size = new Size(423, 262);

            pbxSeasons.Image = Image.FromFile(@"..\Debug\NoSeason.png");
            lbxSeasons.Items.Add("Winter");
            lbxSeasons.Items.Add("Spring");
            lbxSeasons.Items.Add("Summer");
            lbxSeasons.Items.Add("Fall");
            lbxSeasons.SelectedIndexChanged += new EventHandler(lbxSeasons_SelectedIndexChanged);

            btnClear.Click += new EventHandler(btnClear_Click);

            
            btnExit.Click += new EventHandler(btnExit_Click);
        }

        private void lbxSeasons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxSeasons.SelectedItem != null) // Needed to check if an item is selected
            {
                string selectedSeason = lbxSeasons.SelectedItem.ToString();

                if (selectedSeason == "Winter")
                {
                    this.BackColor = Color.LightBlue;
                    this.ForeColor = Color.DarkBlue;
                    this.Text = "Winter";
                    pbxSeasons.Image = Image.FromFile(@"..\Debug\winter.png");
                }
                else if (selectedSeason == "Spring")
                {
                    this.BackColor = Color.LightGreen;
                    this.ForeColor = Color.DarkGreen;
                    this.Text = "Spring";
                    pbxSeasons.Image = Image.FromFile(@"..\Debug\spring.png");
                }
                else if (selectedSeason == "Summer")
                {
                    this.BackColor = Color.LightYellow;
                    this.ForeColor = Color.DarkOrange;
                    this.Text = "Summer";
                    pbxSeasons.Image = Image.FromFile(@"..\Debug\summer.png");
                }
                else if (selectedSeason == "Fall")
                {
                    this.BackColor = Color.Orange;
                    this.ForeColor = Color.Brown;
                    this.Text = "Fall";
                    pbxSeasons.Image = Image.FromFile(@"..\Debug\fall.png");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            this.ForeColor = SystemColors.ControlText;
            this.Text = "Select a Season";
            pbxSeasons.Image = Image.FromFile(@"..\Debug\NoSeason.png");
            lbxSeasons.BackColor = SystemColors.Window;
            lbxSeasons.ForeColor = SystemColors.WindowText;
            btnClear.BackColor = SystemColors.Control;
            btnClear.ForeColor = SystemColors.ControlText;
            lbxSeasons.ClearSelected();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}