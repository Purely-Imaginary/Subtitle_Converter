namespace SubtitleConverter
{
    partial class MultiWindow
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
            this.DirectoryTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilesCountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.srtFilesCountLabel = new System.Windows.Forms.Label();
            this.txtListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DirectoryTextBox
            // 
            this.DirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryTextBox.Location = new System.Drawing.Point(12, 12);
            this.DirectoryTextBox.Name = "DirectoryTextBox";
            this.DirectoryTextBox.Size = new System.Drawing.Size(519, 20);
            this.DirectoryTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(537, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(537, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "GO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "TXT files:";
            // 
            // txtFilesCountLabel
            // 
            this.txtFilesCountLabel.AutoSize = true;
            this.txtFilesCountLabel.Location = new System.Drawing.Point(70, 44);
            this.txtFilesCountLabel.Name = "txtFilesCountLabel";
            this.txtFilesCountLabel.Size = new System.Drawing.Size(19, 13);
            this.txtFilesCountLabel.TabIndex = 3;
            this.txtFilesCountLabel.Text = "99";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SRT files:";
            // 
            // srtFilesCountLabel
            // 
            this.srtFilesCountLabel.AutoSize = true;
            this.srtFilesCountLabel.Location = new System.Drawing.Point(154, 44);
            this.srtFilesCountLabel.Name = "srtFilesCountLabel";
            this.srtFilesCountLabel.Size = new System.Drawing.Size(19, 13);
            this.srtFilesCountLabel.TabIndex = 3;
            this.srtFilesCountLabel.Text = "99";
            // 
            // txtListLabel
            // 
            this.txtListLabel.AutoSize = true;
            this.txtListLabel.Location = new System.Drawing.Point(12, 67);
            this.txtListLabel.Name = "txtListLabel";
            this.txtListLabel.Size = new System.Drawing.Size(0, 13);
            this.txtListLabel.TabIndex = 4;
            this.txtListLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // MultiWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 269);
            this.Controls.Add(this.txtListLabel);
            this.Controls.Add(this.srtFilesCountLabel);
            this.Controls.Add(this.txtFilesCountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DirectoryTextBox);
            this.Name = "MultiWindow";
            this.Text = "MultiWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DirectoryTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtFilesCountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label srtFilesCountLabel;
        private System.Windows.Forms.Label txtListLabel;
    }
}