namespace AUpchurch4PB
{
    partial class frmNameWriter
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
            this.lblinstructions = new System.Windows.Forms.Label();
            this.lblNameEntry = new System.Windows.Forms.Label();
            this.tbxNameEntry = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblinstructions
            // 
            this.lblinstructions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinstructions.Location = new System.Drawing.Point(36, 19);
            this.lblinstructions.Name = "lblinstructions";
            this.lblinstructions.Size = new System.Drawing.Size(342, 48);
            this.lblinstructions.TabIndex = 0;
            this.lblinstructions.Text = "Please enter a name and click the Write button to add the name to the text file";
            this.lblinstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblinstructions.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNameEntry
            // 
            this.lblNameEntry.AutoSize = true;
            this.lblNameEntry.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEntry.Location = new System.Drawing.Point(36, 93);
            this.lblNameEntry.Name = "lblNameEntry";
            this.lblNameEntry.Size = new System.Drawing.Size(135, 18);
            this.lblNameEntry.TabIndex = 1;
            this.lblNameEntry.Text = "Enter the name:";
            this.lblNameEntry.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxNameEntry
            // 
            this.tbxNameEntry.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNameEntry.Location = new System.Drawing.Point(177, 85);
            this.tbxNameEntry.Name = "tbxNameEntry";
            this.tbxNameEntry.Size = new System.Drawing.Size(199, 26);
            this.tbxNameEntry.TabIndex = 2;
            this.tbxNameEntry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(68, 127);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "&Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(276, 127);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmNameWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 183);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.tbxNameEntry);
            this.Controls.Add(this.lblNameEntry);
            this.Controls.Add(this.lblinstructions);
            this.Name = "frmNameWriter";
            this.Text = "Name Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinstructions;
        private System.Windows.Forms.Label lblNameEntry;
        private System.Windows.Forms.TextBox tbxNameEntry;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnExit;
    }
}

