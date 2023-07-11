namespace CurrencyCalculator
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.ReturnButton = new System.Windows.Forms.PictureBox();
            this.AcceptButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnButton
            // 
            this.ReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnButton.Image = ((System.Drawing.Image)(resources.GetObject("ReturnButton.Image")));
            this.ReturnButton.Location = new System.Drawing.Point(12, 12);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(22, 24);
            this.ReturnButton.TabIndex = 0;
            this.ReturnButton.TabStop = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptButton.Image = ((System.Drawing.Image)(resources.GetObject("AcceptButton.Image")));
            this.AcceptButton.Location = new System.Drawing.Point(246, 12);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(24, 24);
            this.AcceptButton.TabIndex = 1;
            this.AcceptButton.TabStop = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 413);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ReturnButton);
            this.MaximumSize = new System.Drawing.Size(300, 452);
            this.MinimumSize = new System.Drawing.Size(300, 452);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ReturnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ReturnButton;
        private System.Windows.Forms.PictureBox AcceptButton;
    }
}