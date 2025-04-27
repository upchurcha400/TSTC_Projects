namespace AUpchurch4PC
{
    partial class frmNameReader
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
            this.lblContents = new System.Windows.Forms.Label();
            this.tbxContents = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblContents
            // 
            this.lblContents.AutoSize = true;
            this.lblContents.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContents.Location = new System.Drawing.Point(23, 29);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(362, 22);
            this.lblContents.TabIndex = 0;
            this.lblContents.Text = "The following is the contents of the file:";
            // 
            // tbxContents
            // 
            this.tbxContents.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxContents.Location = new System.Drawing.Point(36, 93);
            this.tbxContents.Multiline = true;
            this.tbxContents.Name = "tbxContents";
            this.tbxContents.Size = new System.Drawing.Size(329, 204);
            this.tbxContents.TabIndex = 1;
            
            // 
            // frmNameReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 322);
            this.Controls.Add(this.tbxContents);
            this.Controls.Add(this.lblContents);
            this.Name = "frmNameReader";
            this.Text = "Name Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContents;
        private System.Windows.Forms.TextBox tbxContents;
    }
}

