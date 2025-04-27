using System;
using System.Windows.Forms;

namespace UpchurchA4PA
{
    partial class frmTuitionCalculatorForm
    {
        private void InitializeComponent()
        {
            this.lblTuitionCost = new System.Windows.Forms.Label();
            this.lblNumberOfHours = new System.Windows.Forms.Label();
            this.tbxTuitionCost = new System.Windows.Forms.TextBox();
            this.tbxNumberOfHours = new System.Windows.Forms.TextBox();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTuitionCost
            // 
            this.lblTuitionCost.AutoSize = true;
            this.lblTuitionCost.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuitionCost.Location = new System.Drawing.Point(24, 9);
            this.lblTuitionCost.Name = "lblTuitionCost";
            this.lblTuitionCost.Size = new System.Drawing.Size(82, 20);
            this.lblTuitionCost.TabIndex = 0;
            this.lblTuitionCost.Text = "Tuition Cost:";
            // 
            // lblNumberOfHours
            // 
            this.lblNumberOfHours.AutoSize = true;
            this.lblNumberOfHours.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfHours.Location = new System.Drawing.Point(24, 52);
            this.lblNumberOfHours.Name = "lblNumberOfHours";
            this.lblNumberOfHours.Size = new System.Drawing.Size(116, 20);
            this.lblNumberOfHours.TabIndex = 1;
            this.lblNumberOfHours.Text = "Number of Hours:";
            // 
            // tbxTuitionCost
            // 
            this.tbxTuitionCost.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTuitionCost.Location = new System.Drawing.Point(160, 9);
            this.tbxTuitionCost.Name = "tbxTuitionCost";
            this.tbxTuitionCost.Size = new System.Drawing.Size(100, 26);
            this.tbxTuitionCost.TabIndex = 2;
            // 
            // tbxNumberOfHours
            // 
            this.tbxNumberOfHours.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNumberOfHours.Location = new System.Drawing.Point(160, 52);
            this.tbxNumberOfHours.Name = "tbxNumberOfHours";
            this.tbxNumberOfHours.Size = new System.Drawing.Size(100, 26);
            this.tbxNumberOfHours.TabIndex = 3;
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 20;
            this.lstResults.Location = new System.Drawing.Point(27, 95);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(233, 104);
            this.lstResults.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(27, 226);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calc&ulate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click); // Event handler assigned here
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(137, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            //
            // frmTuitionCalculatorForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 280);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.tbxNumberOfHours);
            this.Controls.Add(this.tbxTuitionCost);
            this.Controls.Add(this.lblNumberOfHours);
            this.Controls.Add(this.lblTuitionCost);
            this.Name = "frmTuitionCalculatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        private Label lblTuitionCost;
        private Label lblNumberOfHours;
        private TextBox tbxTuitionCost;
        private TextBox tbxNumberOfHours;
        private ListBox lstResults;
        private Button btnCalculate;
        private Button btnExit;
    }
}