namespace AnthonyUpchurch3PA
{
    partial class frmTranslator
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblGerman = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.tbxEnglish = new System.Windows.Forms.TextBox();
            this.tbxGerman = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(64, 45);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(397, 27);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Enter a number between 1 and 10:";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.Location = new System.Drawing.Point(120, 113);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(93, 27);
            this.lblEnglish.TabIndex = 1;
            this.lblEnglish.Text = "English";
            // 
            // lblGerman
            // 
            this.lblGerman.AutoSize = true;
            this.lblGerman.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGerman.Location = new System.Drawing.Point(494, 113);
            this.lblGerman.Name = "lblGerman";
            this.lblGerman.Size = new System.Drawing.Size(102, 27);
            this.lblGerman.TabIndex = 2;
            this.lblGerman.Text = "German";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNumber.Location = new System.Drawing.Point(534, 45);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(125, 34);
            this.tbxNumber.TabIndex = 3;
            // 
            // tbxEnglish
            // 
            this.tbxEnglish.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEnglish.Location = new System.Drawing.Point(104, 164);
            this.tbxEnglish.Name = "tbxEnglish";
            this.tbxEnglish.Size = new System.Drawing.Size(124, 34);
            this.tbxEnglish.TabIndex = 4;
            // 
            // tbxGerman
            // 
            this.tbxGerman.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGerman.Location = new System.Drawing.Point(472, 164);
            this.tbxGerman.Name = "tbxGerman";
            this.tbxGerman.Size = new System.Drawing.Size(124, 34);
            this.tbxGerman.TabIndex = 5;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.8F);
            this.btnTranslate.Location = new System.Drawing.Point(288, 247);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(146, 45);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // frmTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 329);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.tbxGerman);
            this.Controls.Add(this.tbxEnglish);
            this.Controls.Add(this.tbxNumber);
            this.Controls.Add(this.lblGerman);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmTranslator";
            this.Text = "English German Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblGerman;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.TextBox tbxEnglish;
        private System.Windows.Forms.TextBox tbxGerman;
        private System.Windows.Forms.Button btnTranslate;
    }
}

