using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUpchurch4PC
{
    public partial class frmNameReader : Form
    {
        public frmNameReader()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmNameReader_Load);
        }
    private void frmNameReader_Load(object sender, EventArgs e)
        {
            // Read the contents of the file and display it in the TextBox
            string filePath = "name.txt";
            if (File.Exists(filePath))
            {
                try
                {
                    string contents = File.ReadAllText(filePath);
                    tbxContents.Text = contents;
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("File not found: " + filePath);
            }
        }

       
    }

}
