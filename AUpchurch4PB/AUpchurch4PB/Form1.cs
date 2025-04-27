using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUpchurch4PB
{
    public partial class frmNameWriter : Form
    {
        public frmNameWriter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNameEntry.Text))
            {
                MessageBox.Show("A name must be entered","Please try again.");
                return;
            }
            try
            {
                File.AppendAllText("name.txt", tbxNameEntry.Text + Environment.NewLine);

                tbxNameEntry.Clear();
                MessageBox.Show("Name added to file", "Transaction Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while writing to the file: " + ex.Message, "Error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
