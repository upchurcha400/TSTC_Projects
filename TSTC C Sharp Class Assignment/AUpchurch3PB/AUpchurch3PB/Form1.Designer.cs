namespace CruisePlanner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTripDetails = new System.Windows.Forms.Label();
            this.lblLodgingCost = new System.Windows.Forms.Label();
            this.lblCostResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbxCruiseDetails = new System.Windows.Forms.ListBox();
            this.lbxLodging = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTripDetails
            // 
            this.lblTripDetails.AutoSize = true;
            this.lblTripDetails.Location = new System.Drawing.Point(32, 47);
            this.lblTripDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTripDetails.Name = "lblTripDetails";
            this.lblTripDetails.Size = new System.Drawing.Size(496, 27);
            this.lblTripDetails.TabIndex = 0;
            this.lblTripDetails.Text = "Cruise Line (Departure City) / Number of Nights / Initial Cost";
            // 
            // lblLodgingCost
            // 
            this.lblLodgingCost.AutoSize = true;
            this.lblLodgingCost.Location = new System.Drawing.Point(701, 47);
            this.lblLodgingCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLodgingCost.Name = "lblLodgingCost";
            this.lblLodgingCost.Size = new System.Drawing.Size(284, 27);
            this.lblLodgingCost.TabIndex = 1;
            this.lblLodgingCost.Text = "Location / Lodging Fees per Night";
            // 
            // lblCostResult
            // 
            this.lblCostResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCostResult.Location = new System.Drawing.Point(37, 341);
            this.lblCostResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCostResult.Name = "lblCostResult";
            this.lblCostResult.Size = new System.Drawing.Size(521, 130);
            this.lblCostResult.TabIndex = 2;
            this.lblCostResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(634, 341);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(129, 49);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(816, 341);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 49);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbxCruiseDetails
            // 
            this.lbxCruiseDetails.FormattingEnabled = true;
            this.lbxCruiseDetails.ItemHeight = 27;
            this.lbxCruiseDetails.Location = new System.Drawing.Point(37, 105);
            this.lbxCruiseDetails.Name = "lbxCruiseDetails";
            this.lbxCruiseDetails.Size = new System.Drawing.Size(521, 139);
            this.lbxCruiseDetails.TabIndex = 7;
            // 
            // lbxLodging
            // 
            this.lbxLodging.FormattingEnabled = true;
            this.lbxLodging.ItemHeight = 27;
            this.lbxLodging.Location = new System.Drawing.Point(699, 105);
            this.lbxLodging.Name = "lbxLodging";
            this.lbxLodging.Size = new System.Drawing.Size(341, 139);
            this.lbxLodging.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 487);
            this.Controls.Add(this.lbxLodging);
            this.Controls.Add(this.lbxCruiseDetails);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCostResult);
            this.Controls.Add(this.lblLodgingCost);
            this.Controls.Add(this.lblTripDetails);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cruise Package Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTripDetails;
        private System.Windows.Forms.Label lblLodgingCost;
        private System.Windows.Forms.Label lblCostResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbxCruiseDetails;
        private System.Windows.Forms.ListBox lbxLodging;
    }
}

