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
            this.LanguageField = new System.Windows.Forms.ComboBox();
            this.ColorThemeField = new System.Windows.Forms.ComboBox();
            this.DefaultOriginalCurrencyField = new System.Windows.Forms.ComboBox();
            this.ChangeNumbersAfterSeparatorField = new System.Windows.Forms.NumericUpDown();
            this.NumbersAfterSeparatorLabel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeNumbersAfterSeparatorField)).BeginInit();
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
            // LanguageField
            // 
            this.LanguageField.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanguageField.FormattingEnabled = true;
            this.LanguageField.Items.AddRange(new object[] {
            "Українська",
            "Англійська"});
            this.LanguageField.Location = new System.Drawing.Point(12, 64);
            this.LanguageField.Name = "LanguageField";
            this.LanguageField.Size = new System.Drawing.Size(192, 24);
            this.LanguageField.TabIndex = 2;
            this.LanguageField.Text = "Мова";
            // 
            // ColorThemeField
            // 
            this.ColorThemeField.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorThemeField.FormattingEnabled = true;
            this.ColorThemeField.Items.AddRange(new object[] {
            "Світла",
            "Темна"});
            this.ColorThemeField.Location = new System.Drawing.Point(12, 118);
            this.ColorThemeField.Name = "ColorThemeField";
            this.ColorThemeField.Size = new System.Drawing.Size(192, 24);
            this.ColorThemeField.TabIndex = 3;
            this.ColorThemeField.Text = "Кольорова схема";
            // 
            // DefaultOriginalCurrencyField
            // 
            this.DefaultOriginalCurrencyField.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DefaultOriginalCurrencyField.FormattingEnabled = true;
            this.DefaultOriginalCurrencyField.Items.AddRange(new object[] {
            "Default currency",
            "UAH",
            "USD",
            "EUR",
            "PLN",
            "GBP",
            "AUD",
            "CZK",
            "CNY",
            "BTC"});
            this.DefaultOriginalCurrencyField.Location = new System.Drawing.Point(12, 172);
            this.DefaultOriginalCurrencyField.Name = "DefaultOriginalCurrencyField";
            this.DefaultOriginalCurrencyField.Size = new System.Drawing.Size(192, 24);
            this.DefaultOriginalCurrencyField.TabIndex = 4;
            this.DefaultOriginalCurrencyField.Text = "Валюта за замовчуванням";
            // 
            // ChangeNumbersAfterSeparatorField
            // 
            this.ChangeNumbersAfterSeparatorField.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeNumbersAfterSeparatorField.Hexadecimal = true;
            this.ChangeNumbersAfterSeparatorField.Location = new System.Drawing.Point(171, 226);
            this.ChangeNumbersAfterSeparatorField.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.ChangeNumbersAfterSeparatorField.Name = "ChangeNumbersAfterSeparatorField";
            this.ChangeNumbersAfterSeparatorField.Size = new System.Drawing.Size(33, 21);
            this.ChangeNumbersAfterSeparatorField.TabIndex = 6;
            this.ChangeNumbersAfterSeparatorField.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // NumbersAfterSeparatorLabel
            // 
            this.NumbersAfterSeparatorLabel.BackColor = System.Drawing.SystemColors.Window;
            this.NumbersAfterSeparatorLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.NumbersAfterSeparatorLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumbersAfterSeparatorLabel.Location = new System.Drawing.Point(12, 227);
            this.NumbersAfterSeparatorLabel.Name = "NumbersAfterSeparatorLabel";
            this.NumbersAfterSeparatorLabel.ReadOnly = true;
            this.NumbersAfterSeparatorLabel.Size = new System.Drawing.Size(153, 21);
            this.NumbersAfterSeparatorLabel.TabIndex = 8;
            this.NumbersAfterSeparatorLabel.Text = "С-лів п-я роздільника";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(216, 270);
            this.Controls.Add(this.NumbersAfterSeparatorLabel);
            this.Controls.Add(this.ChangeNumbersAfterSeparatorField);
            this.Controls.Add(this.DefaultOriginalCurrencyField);
            this.Controls.Add(this.ColorThemeField);
            this.Controls.Add(this.LanguageField);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ReturnButton);
            this.MaximumSize = new System.Drawing.Size(232, 309);
            this.MinimumSize = new System.Drawing.Size(232, 309);
            this.Name = "Settings";
            this.Text = "Налаштування";
            ((System.ComponentModel.ISupportInitialize)(this.ReturnButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangeNumbersAfterSeparatorField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ReturnButton;
        private System.Windows.Forms.PictureBox AcceptButton;
        private System.Windows.Forms.ComboBox LanguageField;
        private System.Windows.Forms.ComboBox ColorThemeField;
        private System.Windows.Forms.ComboBox DefaultOriginalCurrencyField;
        private System.Windows.Forms.NumericUpDown ChangeNumbersAfterSeparatorField;
        private System.Windows.Forms.TextBox NumbersAfterSeparatorLabel;
    }
}