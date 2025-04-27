namespace AnthonyUpchurchM4B
{
    partial class frmSalesReporting
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
            this.panelOutput = new System.Windows.Forms.Panel();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lbxBoxSales = new System.Windows.Forms.ListBox();
            this.lblAverageValue = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOutputInstructions = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.tbxSalesAmount = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.lblSalesAmount = new System.Windows.Forms.Label();
            this.lblInputInstructions = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelOutput.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.btnAverage);
            this.panelOutput.Controls.Add(this.btnTotal);
            this.panelOutput.Controls.Add(this.btnLoad);
            this.panelOutput.Controls.Add(this.lbxBoxSales);
            this.panelOutput.Controls.Add(this.lblAverageValue);
            this.panelOutput.Controls.Add(this.lblAverage);
            this.panelOutput.Controls.Add(this.lblTotalValue);
            this.panelOutput.Controls.Add(this.lblTotal);
            this.panelOutput.Controls.Add(this.lblOutputInstructions);
            this.panelOutput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelOutput.Location = new System.Drawing.Point(16, 195);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(558, 254);
            this.panelOutput.TabIndex = 0;
            // 
            // btnAverage
            // 
            this.btnAverage.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverage.Location = new System.Drawing.Point(384, 194);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(83, 31);
            this.btnAverage.TabIndex = 8;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(246, 194);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(74, 31);
            this.btnTotal.TabIndex = 7;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(106, 194);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(74, 31);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load Sales";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lbxBoxSales
            // 
            this.lbxBoxSales.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxBoxSales.FormattingEnabled = true;
            this.lbxBoxSales.ItemHeight = 23;
            this.lbxBoxSales.Location = new System.Drawing.Point(19, 68);
            this.lbxBoxSales.Name = "lbxBoxSales";
            this.lbxBoxSales.Size = new System.Drawing.Size(257, 96);
            this.lbxBoxSales.TabIndex = 5;
            // 
            // lblAverageValue
            // 
            this.lblAverageValue.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageValue.Location = new System.Drawing.Point(417, 105);
            this.lblAverageValue.Name = "lblAverageValue";
            this.lblAverageValue.Size = new System.Drawing.Size(122, 23);
            this.lblAverageValue.TabIndex = 4;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(332, 105);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(91, 29);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Average:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(387, 51);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(126, 23);
            this.lblTotalValue.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(332, 51);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 29);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // lblOutputInstructions
            // 
            this.lblOutputInstructions.AutoSize = true;
            this.lblOutputInstructions.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputInstructions.Location = new System.Drawing.Point(0, 0);
            this.lblOutputInstructions.Name = "lblOutputInstructions";
            this.lblOutputInstructions.Size = new System.Drawing.Size(204, 23);
            this.lblOutputInstructions.TabIndex = 0;
            this.lblOutputInstructions.Text = "Sales Data and Calculations";
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.tbxSalesAmount);
            this.panelInput.Controls.Add(this.btnWrite);
            this.panelInput.Controls.Add(this.lblSalesAmount);
            this.panelInput.Controls.Add(this.lblInputInstructions);
            this.panelInput.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelInput.Location = new System.Drawing.Point(16, 12);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(321, 164);
            this.panelInput.TabIndex = 1;
            // 
            // tbxSalesAmount
            // 
            this.tbxSalesAmount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSalesAmount.Location = new System.Drawing.Point(128, 55);
            this.tbxSalesAmount.Name = "tbxSalesAmount";
            this.tbxSalesAmount.Size = new System.Drawing.Size(99, 29);
            this.tbxSalesAmount.TabIndex = 3;
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(128, 114);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(103, 28);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write to File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // lblSalesAmount
            // 
            this.lblSalesAmount.AutoSize = true;
            this.lblSalesAmount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesAmount.Location = new System.Drawing.Point(12, 61);
            this.lblSalesAmount.Name = "lblSalesAmount";
            this.lblSalesAmount.Size = new System.Drawing.Size(110, 23);
            this.lblSalesAmount.TabIndex = 1;
            this.lblSalesAmount.Text = "Sales Amount:";
            // 
            // lblInputInstructions
            // 
            this.lblInputInstructions.AutoSize = true;
            this.lblInputInstructions.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputInstructions.Location = new System.Drawing.Point(0, 0);
            this.lblInputInstructions.Name = "lblInputInstructions";
            this.lblInputInstructions.Size = new System.Drawing.Size(150, 23);
            this.lblInputInstructions.TabIndex = 0;
            this.lblInputInstructions.Text = "Enter Sales Amount:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(396, 23);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 31);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(396, 115);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSalesReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 468);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelOutput);
            this.Name = "frmSalesReporting";
            this.Text = "Sales Reporting";
            this.panelOutput.ResumeLayout(false);
            this.panelOutput.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TextBox tbxSalesAmount;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label lblSalesAmount;
        private System.Windows.Forms.Label lblInputInstructions;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListBox lbxBoxSales;
        private System.Windows.Forms.Label lblAverageValue;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOutputInstructions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

