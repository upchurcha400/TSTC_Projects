namespace AnthonyUpchurchM5B
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
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.lstConversions = new System.Windows.Forms.ListBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtRed = new System.Windows.Forms.RadioButton();
            this.rbtBlue = new System.Windows.Forms.RadioButton();
            this.rbtGreen = new System.Windows.Forms.RadioButton();
            this.rbtYellow = new System.Windows.Forms.RadioButton();
            this.rbtWhite = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(12, 12);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(100, 20);
            this.tbxInput.TabIndex = 0;
            // 
            // lstConversions
            // 
            this.lstConversions.FormattingEnabled = true;
            this.lstConversions.Items.AddRange(new object[] {
            "Inches to Centimeters",
            "Feet to Meters",
            "Yards to Meters",
            "Miles to Kilometers"});
            this.lstConversions.Location = new System.Drawing.Point(12, 46);
            this.lstConversions.Name = "lstConversions";
            this.lstConversions.Size = new System.Drawing.Size(150, 56);
            this.lstConversions.TabIndex = 1;
            // 
            // lblResults
            // 
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(12, 112);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(192, 50);
            this.lblResults.TabIndex = 2;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtRed);
            this.groupBox1.Controls.Add(this.rbtBlue);
            this.groupBox1.Controls.Add(this.rbtGreen);
            this.groupBox1.Controls.Add(this.rbtYellow);
            this.groupBox1.Controls.Add(this.rbtWhite);
            this.groupBox1.Location = new System.Drawing.Point(204, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // rbtRed
            // 
            this.rbtRed.AutoSize = true;
            this.rbtRed.Location = new System.Drawing.Point(6, 22);
            this.rbtRed.Name = "rbtRed";
            this.rbtRed.Size = new System.Drawing.Size(45, 17);
            this.rbtRed.TabIndex = 0;
            this.rbtRed.TabStop = true;
            this.rbtRed.Text = "Red";
            this.rbtRed.UseVisualStyleBackColor = true;
            this.rbtRed.CheckedChanged += new System.EventHandler(this.rbtColor_CheckedChanged);
            // 
            // rbtBlue
            // 
            this.rbtBlue.AutoSize = true;
            this.rbtBlue.Location = new System.Drawing.Point(6, 47);
            this.rbtBlue.Name = "rbtBlue";
            this.rbtBlue.Size = new System.Drawing.Size(46, 17);
            this.rbtBlue.TabIndex = 1;
            this.rbtBlue.TabStop = true;
            this.rbtBlue.Text = "Blue";
            this.rbtBlue.UseVisualStyleBackColor = true;
            this.rbtBlue.CheckedChanged += new System.EventHandler(this.rbtColor_CheckedChanged);
            // 
            // rbtGreen
            // 
            this.rbtGreen.AutoSize = true;
            this.rbtGreen.Location = new System.Drawing.Point(6, 72);
            this.rbtGreen.Name = "rbtGreen";
            this.rbtGreen.Size = new System.Drawing.Size(54, 17);
            this.rbtGreen.TabIndex = 2;
            this.rbtGreen.TabStop = true;
            this.rbtGreen.Text = "Green";
            this.rbtGreen.UseVisualStyleBackColor = true;
            this.rbtGreen.CheckedChanged += new System.EventHandler(this.rbtColor_CheckedChanged);
            // 
            // rbtYellow
            // 
            this.rbtYellow.AutoSize = true;
            this.rbtYellow.Location = new System.Drawing.Point(6, 97);
            this.rbtYellow.Name = "rbtYellow";
            this.rbtYellow.Size = new System.Drawing.Size(56, 17);
            this.rbtYellow.TabIndex = 3;
            this.rbtYellow.TabStop = true;
            this.rbtYellow.Text = "Yellow";
            this.rbtYellow.UseVisualStyleBackColor = true;
            this.rbtYellow.CheckedChanged += new System.EventHandler(this.rbtColor_CheckedChanged);
            // 
            // rbtWhite
            // 
            this.rbtWhite.AutoSize = true;
            this.rbtWhite.Location = new System.Drawing.Point(6, 122);
            this.rbtWhite.Name = "rbtWhite";
            this.rbtWhite.Size = new System.Drawing.Size(53, 17);
            this.rbtWhite.TabIndex = 4;
            this.rbtWhite.TabStop = true;
            this.rbtWhite.Text = "White";
            this.rbtWhite.UseVisualStyleBackColor = true;
            this.rbtWhite.CheckedChanged += new System.EventHandler(this.rbtColor_CheckedChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(17, 175);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(121, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(225, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(315, 222);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lstConversions);
            this.Controls.Add(this.tbxInput);
            this.Name = "Form1";
            this.Text = "Unit Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.ListBox lstConversions;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtRed;
        private System.Windows.Forms.RadioButton rbtBlue;
        private System.Windows.Forms.RadioButton rbtGreen;
        private System.Windows.Forms.RadioButton rbtYellow;
        private System.Windows.Forms.RadioButton rbtWhite;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

