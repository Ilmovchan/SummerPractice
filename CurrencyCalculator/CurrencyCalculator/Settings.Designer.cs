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
            this.ChangeLanguageField = new System.Windows.Forms.ComboBox();
            this.ChangeThemeField = new System.Windows.Forms.ComboBox();
            this.ChangeSeparatorSymbolField = new System.Windows.Forms.ComboBox();
            this.ChangeSymbolQuantityAfterSeparatorField = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.AcceptButton.Location = new System.Drawing.Point(180, 12);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(24, 24);
            this.AcceptButton.TabIndex = 1;
            this.AcceptButton.TabStop = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // ChangeLanguageField
            // 
            this.ChangeLanguageField.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeLanguageField.FormattingEnabled = true;
            this.ChangeLanguageField.Items.AddRange(new object[] {
            "Англійська",
            "Українська"});
            this.ChangeLanguageField.Location = new System.Drawing.Point(12, 64);
            this.ChangeLanguageField.Name = "ChangeLanguageField";
            this.ChangeLanguageField.Size = new System.Drawing.Size(192, 24);
            this.ChangeLanguageField.TabIndex = 2;
            this.ChangeLanguageField.Text = "Мова";
            // 
            // ChangeThemeField
            // 
            this.ChangeThemeField.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeThemeField.FormattingEnabled = true;
            this.ChangeThemeField.Items.AddRange(new object[] {
            "Світла",
            "Темна"});
            this.ChangeThemeField.Location = new System.Drawing.Point(12, 118);
            this.ChangeThemeField.Name = "ChangeThemeField";
            this.ChangeThemeField.Size = new System.Drawing.Size(192, 24);
            this.ChangeThemeField.TabIndex = 3;
            this.ChangeThemeField.Text = "Кольорова схема";
            // 
            // ChangeSeparatorSymbolField
            // 
            this.ChangeSeparatorSymbolField.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeSeparatorSymbolField.FormattingEnabled = true;
            this.ChangeSeparatorSymbolField.Items.AddRange(new object[] {
            "Крапка",
            "Кома"});
            this.ChangeSeparatorSymbolField.Location = new System.Drawing.Point(12, 172);
            this.ChangeSeparatorSymbolField.Name = "ChangeSeparatorSymbolField";
            this.ChangeSeparatorSymbolField.Size = new System.Drawing.Size(192, 24);
            this.ChangeSeparatorSymbolField.TabIndex = 4;
            this.ChangeSeparatorSymbolField.Text = "Символ роздільника";
            // 
            // ChangeSymbolQuantityAfterSeparatorField
            // 
            this.ChangeSymbolQuantityAfterSeparatorField.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeSymbolQuantityAfterSeparatorField.FormattingEnabled = true;
            this.ChangeSymbolQuantityAfterSeparatorField.Items.AddRange(new object[] {
            ".",
            ","});
            this.ChangeSymbolQuantityAfterSeparatorField.Location = new System.Drawing.Point(12, 226);
            this.ChangeSymbolQuantityAfterSeparatorField.Name = "ChangeSymbolQuantityAfterSeparatorField";
            this.ChangeSymbolQuantityAfterSeparatorField.Size = new System.Drawing.Size(192, 24);
            this.ChangeSymbolQuantityAfterSeparatorField.TabIndex = 5;
            this.ChangeSymbolQuantityAfterSeparatorField.Text = "Символів п-я роздільника";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Hexadecimal = true;
            this.numericUpDown1.Location = new System.Drawing.Point(12, 202);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(192, 21);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(40, 25);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown1.TabIndex = 7;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 270);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ChangeSymbolQuantityAfterSeparatorField);
            this.Controls.Add(this.ChangeSeparatorSymbolField);
            this.Controls.Add(this.ChangeThemeField);
            this.Controls.Add(this.ChangeLanguageField);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ReturnButton);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ReturnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ReturnButton;
        private System.Windows.Forms.PictureBox AcceptButton;
        private System.Windows.Forms.ComboBox ChangeLanguageField;
        private System.Windows.Forms.ComboBox ChangeThemeField;
        private System.Windows.Forms.ComboBox ChangeSeparatorSymbolField;
        private System.Windows.Forms.ComboBox ChangeSymbolQuantityAfterSeparatorField;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
    }
}