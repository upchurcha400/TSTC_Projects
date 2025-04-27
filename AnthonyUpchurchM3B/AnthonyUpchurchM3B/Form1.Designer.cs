namespace AnthonyUpchurchM3B
{
    partial class frmSeasons
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lbxSeasons;
        private System.Windows.Forms.PictureBox pbxSeasons;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lbxSeasons = new System.Windows.Forms.ListBox();
            this.pbxSeasons = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeasons)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxSeasons
            // 
            this.lbxSeasons.FormattingEnabled = true;
            this.lbxSeasons.Location = new System.Drawing.Point(50, 26);
            this.lbxSeasons.Name = "lbxSeasons";
            this.lbxSeasons.Size = new System.Drawing.Size(131, 82);
            this.lbxSeasons.TabIndex = 0;
            // 
            // pbxSeasons
            // 
            this.pbxSeasons.Location = new System.Drawing.Point(200, 26);
            this.pbxSeasons.Name = "pbxSeasons";
            this.pbxSeasons.Size = new System.Drawing.Size(160, 90);
            this.pbxSeasons.TabIndex = 1;
            this.pbxSeasons.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(240, 148);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(50, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmSeasons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 223);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pbxSeasons);
            this.Controls.Add(this.lbxSeasons);
            this.Name = "frmSeasons";
            this.Text = "Select a Season";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSeasons)).EndInit();
            this.ResumeLayout(false);

        }
    }
}