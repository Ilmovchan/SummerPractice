namespace CurrencyCalculator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            this.CashAmountLabel = new System.Windows.Forms.Label();
            this.ExchangeLabel = new System.Windows.Forms.Label();
            this.ResultField = new System.Windows.Forms.RichTextBox();
            this.OriginalCurrencyField = new System.Windows.Forms.ComboBox();
            this.SecondCurrencyLabel = new System.Windows.Forms.Label();
            this.OriginalCurrencyLabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SecondCurrencyField = new System.Windows.Forms.ComboBox();
            this.ExchangeField = new System.Windows.Forms.RichTextBox();
            this.CashAmountField = new System.Windows.Forms.RichTextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsButton
            // 
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(749, 36);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(25, 24);
            this.SettingsButton.TabIndex = 31;
            this.SettingsButton.TabStop = false;
            // 
            // CashAmountLabel
            // 
            this.CashAmountLabel.AutoSize = true;
            this.CashAmountLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashAmountLabel.ForeColor = System.Drawing.Color.White;
            this.CashAmountLabel.Location = new System.Drawing.Point(26, 63);
            this.CashAmountLabel.Name = "CashAmountLabel";
            this.CashAmountLabel.Size = new System.Drawing.Size(208, 17);
            this.CashAmountLabel.TabIndex = 30;
            this.CashAmountLabel.Text = "Введіть кількість грошей:";
            // 
            // ExchangeLabel
            // 
            this.ExchangeLabel.AutoSize = true;
            this.ExchangeLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExchangeLabel.ForeColor = System.Drawing.Color.White;
            this.ExchangeLabel.Location = new System.Drawing.Point(501, 289);
            this.ExchangeLabel.Name = "ExchangeLabel";
            this.ExchangeLabel.Size = new System.Drawing.Size(144, 17);
            this.ExchangeLabel.TabIndex = 29;
            this.ExchangeLabel.Text = "Курс на сьогодні:";
            // 
            // ResultField
            // 
            this.ResultField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.ResultField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultField.Cursor = System.Windows.Forms.Cursors.No;
            this.ResultField.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultField.Location = new System.Drawing.Point(29, 318);
            this.ResultField.Name = "ResultField";
            this.ResultField.ReadOnly = true;
            this.ResultField.Size = new System.Drawing.Size(216, 97);
            this.ResultField.TabIndex = 28;
            this.ResultField.Text = "";
            // 
            // OriginalCurrencyField
            // 
            this.OriginalCurrencyField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.OriginalCurrencyField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OriginalCurrencyField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OriginalCurrencyField.FormattingEnabled = true;
            this.OriginalCurrencyField.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "UAH",
            "PLN",
            "GBP",
            "AUD",
            "CZK",
            "CNY",
            "BTC"});
            this.OriginalCurrencyField.Location = new System.Drawing.Point(307, 93);
            this.OriginalCurrencyField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OriginalCurrencyField.Name = "OriginalCurrencyField";
            this.OriginalCurrencyField.Size = new System.Drawing.Size(412, 21);
            this.OriginalCurrencyField.TabIndex = 27;
            // 
            // SecondCurrencyLabel
            // 
            this.SecondCurrencyLabel.AutoSize = true;
            this.SecondCurrencyLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondCurrencyLabel.ForeColor = System.Drawing.Color.White;
            this.SecondCurrencyLabel.Location = new System.Drawing.Point(304, 167);
            this.SecondCurrencyLabel.Name = "SecondCurrencyLabel";
            this.SecondCurrencyLabel.Size = new System.Drawing.Size(304, 17);
            this.SecondCurrencyLabel.TabIndex = 26;
            this.SecondCurrencyLabel.Text = "Оберіть валюту до якої хочете перейти";
            // 
            // OriginalCurrencyLabel
            // 
            this.OriginalCurrencyLabel.AutoSize = true;
            this.OriginalCurrencyLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OriginalCurrencyLabel.ForeColor = System.Drawing.Color.White;
            this.OriginalCurrencyLabel.Location = new System.Drawing.Point(304, 63);
            this.OriginalCurrencyLabel.Name = "OriginalCurrencyLabel";
            this.OriginalCurrencyLabel.Size = new System.Drawing.Size(416, 17);
            this.OriginalCurrencyLabel.TabIndex = 25;
            this.OriginalCurrencyLabel.Text = "Оберіть необхідну валюту з якої хочете конвертувати";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.Color.White;
            this.ResultLabel.Location = new System.Drawing.Point(26, 289);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(88, 17);
            this.ResultLabel.TabIndex = 24;
            this.ResultLabel.Text = "Результат:";
            // 
            // SecondCurrencyField
            // 
            this.SecondCurrencyField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.SecondCurrencyField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondCurrencyField.FormattingEnabled = true;
            this.SecondCurrencyField.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "UAH",
            "PLN",
            "GBP",
            "AUD",
            "CZK",
            "CNY",
            "BTC"});
            this.SecondCurrencyField.Location = new System.Drawing.Point(307, 198);
            this.SecondCurrencyField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SecondCurrencyField.Name = "SecondCurrencyField";
            this.SecondCurrencyField.Size = new System.Drawing.Size(412, 21);
            this.SecondCurrencyField.TabIndex = 23;
            // 
            // ExchangeField
            // 
            this.ExchangeField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.ExchangeField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExchangeField.Cursor = System.Windows.Forms.Cursors.No;
            this.ExchangeField.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExchangeField.Location = new System.Drawing.Point(504, 318);
            this.ExchangeField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExchangeField.Name = "ExchangeField";
            this.ExchangeField.ReadOnly = true;
            this.ExchangeField.Size = new System.Drawing.Size(215, 97);
            this.ExchangeField.TabIndex = 22;
            this.ExchangeField.Text = "";
            // 
            // CashAmountField
            // 
            this.CashAmountField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.CashAmountField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CashAmountField.Location = new System.Drawing.Point(29, 93);
            this.CashAmountField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CashAmountField.Name = "CashAmountField";
            this.CashAmountField.Size = new System.Drawing.Size(216, 128);
            this.CashAmountField.TabIndex = 21;
            this.CashAmountField.Text = "";
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(74)))), ((int)(((byte)(232)))));
            this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertButton.FlatAppearance.BorderSize = 0;
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertButton.ForeColor = System.Drawing.Color.White;
            this.ConvertButton.Location = new System.Drawing.Point(307, 318);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(139, 97);
            this.ConvertButton.TabIndex = 20;
            this.ConvertButton.Text = "Конвертувати";
            this.ConvertButton.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.CashAmountLabel);
            this.Controls.Add(this.ExchangeLabel);
            this.Controls.Add(this.ResultField);
            this.Controls.Add(this.OriginalCurrencyField);
            this.Controls.Add(this.SecondCurrencyLabel);
            this.Controls.Add(this.OriginalCurrencyLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.SecondCurrencyField);
            this.Controls.Add(this.ExchangeField);
            this.Controls.Add(this.CashAmountField);
            this.Controls.Add(this.ConvertButton);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SettingsButton;
        private System.Windows.Forms.Label CashAmountLabel;
        private System.Windows.Forms.Label ExchangeLabel;
        private System.Windows.Forms.RichTextBox ResultField;
        private System.Windows.Forms.ComboBox OriginalCurrencyField;
        private System.Windows.Forms.Label SecondCurrencyLabel;
        private System.Windows.Forms.Label OriginalCurrencyLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.ComboBox SecondCurrencyField;
        private System.Windows.Forms.RichTextBox ExchangeField;
        private System.Windows.Forms.RichTextBox CashAmountField;
        private System.Windows.Forms.Button ConvertButton;
    }
}