namespace CurrencyCalculator
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ConvertButton = new System.Windows.Forms.Button();
            this.CashAmountField = new System.Windows.Forms.RichTextBox();
            this.ExchangeField = new System.Windows.Forms.RichTextBox();
            this.SecondCurrencyField = new System.Windows.Forms.ComboBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.OriginalCurrencyLabel = new System.Windows.Forms.Label();
            this.SecondCurrencyLabel = new System.Windows.Forms.Label();
            this.OriginalCurrencyField = new System.Windows.Forms.ComboBox();
            this.ResultField = new System.Windows.Forms.RichTextBox();
            this.ExchangeLabel = new System.Windows.Forms.Label();
            this.CashAmountLabel = new System.Windows.Forms.Label();
            this.SettingsButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.PowderBlue;
            this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConvertButton.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.ConvertButton.FlatAppearance.BorderSize = 0;
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertButton.ForeColor = System.Drawing.Color.Black;
            this.ConvertButton.Location = new System.Drawing.Point(325, 304);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(139, 97);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Конвертувати";
            this.ConvertButton.UseVisualStyleBackColor = false;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // CashAmountField
            // 
            this.CashAmountField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CashAmountField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CashAmountField.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashAmountField.Location = new System.Drawing.Point(47, 79);
            this.CashAmountField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CashAmountField.Name = "CashAmountField";
            this.CashAmountField.Size = new System.Drawing.Size(216, 128);
            this.CashAmountField.TabIndex = 1;
            this.CashAmountField.Text = "";
            // 
            // ExchangeField
            // 
            this.ExchangeField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ExchangeField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExchangeField.Cursor = System.Windows.Forms.Cursors.No;
            this.ExchangeField.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExchangeField.Location = new System.Drawing.Point(522, 304);
            this.ExchangeField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExchangeField.Name = "ExchangeField";
            this.ExchangeField.ReadOnly = true;
            this.ExchangeField.Size = new System.Drawing.Size(215, 97);
            this.ExchangeField.TabIndex = 2;
            this.ExchangeField.Text = "";
            // 
            // SecondCurrencyField
            // 
            this.SecondCurrencyField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SecondCurrencyField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondCurrencyField.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.SecondCurrencyField.Location = new System.Drawing.Point(325, 184);
            this.SecondCurrencyField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SecondCurrencyField.Name = "SecondCurrencyField";
            this.SecondCurrencyField.Size = new System.Drawing.Size(412, 25);
            this.SecondCurrencyField.TabIndex = 5;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.Color.Black;
            this.ResultLabel.Location = new System.Drawing.Point(44, 275);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(88, 17);
            this.ResultLabel.TabIndex = 10;
            this.ResultLabel.Text = "Результат:";
            // 
            // OriginalCurrencyLabel
            // 
            this.OriginalCurrencyLabel.AutoSize = true;
            this.OriginalCurrencyLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OriginalCurrencyLabel.ForeColor = System.Drawing.Color.Black;
            this.OriginalCurrencyLabel.Location = new System.Drawing.Point(322, 49);
            this.OriginalCurrencyLabel.Name = "OriginalCurrencyLabel";
            this.OriginalCurrencyLabel.Size = new System.Drawing.Size(344, 17);
            this.OriginalCurrencyLabel.TabIndex = 11;
            this.OriginalCurrencyLabel.Text = "Оберіть валюту з якої хочете конвертувати:";
            // 
            // SecondCurrencyLabel
            // 
            this.SecondCurrencyLabel.AutoSize = true;
            this.SecondCurrencyLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondCurrencyLabel.ForeColor = System.Drawing.Color.Black;
            this.SecondCurrencyLabel.Location = new System.Drawing.Point(322, 153);
            this.SecondCurrencyLabel.Name = "SecondCurrencyLabel";
            this.SecondCurrencyLabel.Size = new System.Drawing.Size(312, 17);
            this.SecondCurrencyLabel.TabIndex = 12;
            this.SecondCurrencyLabel.Text = "Оберіть валюту до якої хочете перейти:";
            // 
            // OriginalCurrencyField
            // 
            this.OriginalCurrencyField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OriginalCurrencyField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OriginalCurrencyField.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.OriginalCurrencyField.Location = new System.Drawing.Point(325, 79);
            this.OriginalCurrencyField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OriginalCurrencyField.Name = "OriginalCurrencyField";
            this.OriginalCurrencyField.Size = new System.Drawing.Size(412, 25);
            this.OriginalCurrencyField.TabIndex = 15;
            // 
            // ResultField
            // 
            this.ResultField.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ResultField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultField.Cursor = System.Windows.Forms.Cursors.No;
            this.ResultField.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultField.Location = new System.Drawing.Point(47, 304);
            this.ResultField.Name = "ResultField";
            this.ResultField.ReadOnly = true;
            this.ResultField.Size = new System.Drawing.Size(216, 97);
            this.ResultField.TabIndex = 16;
            this.ResultField.Text = "";
            // 
            // ExchangeLabel
            // 
            this.ExchangeLabel.AutoSize = true;
            this.ExchangeLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExchangeLabel.ForeColor = System.Drawing.Color.Black;
            this.ExchangeLabel.Location = new System.Drawing.Point(519, 275);
            this.ExchangeLabel.Name = "ExchangeLabel";
            this.ExchangeLabel.Size = new System.Drawing.Size(144, 17);
            this.ExchangeLabel.TabIndex = 17;
            this.ExchangeLabel.Text = "Курс на сьогодні:";
            // 
            // CashAmountLabel
            // 
            this.CashAmountLabel.AutoSize = true;
            this.CashAmountLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashAmountLabel.ForeColor = System.Drawing.Color.Black;
            this.CashAmountLabel.Location = new System.Drawing.Point(44, 49);
            this.CashAmountLabel.Name = "CashAmountLabel";
            this.CashAmountLabel.Size = new System.Drawing.Size(208, 17);
            this.CashAmountLabel.TabIndex = 18;
            this.CashAmountLabel.Text = "Введіть кількість грошей:";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(767, 22);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(25, 24);
            this.SettingsButton.TabIndex = 19;
            this.SettingsButton.TabStop = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(816, 460);
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
            this.Font = new System.Drawing.Font("Cascadia Code", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(832, 499);
            this.MinimumSize = new System.Drawing.Size(832, 499);
            this.Name = "MainMenu";
            this.Text = "Валютний калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.SettingsButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.RichTextBox CashAmountField;
        private System.Windows.Forms.RichTextBox ExchangeField;
        private System.Windows.Forms.ComboBox SecondCurrencyField;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label OriginalCurrencyLabel;
        private System.Windows.Forms.Label SecondCurrencyLabel;
        private System.Windows.Forms.ComboBox OriginalCurrencyField;
        private System.Windows.Forms.RichTextBox ResultField;
        private System.Windows.Forms.Label ExchangeLabel;
        private System.Windows.Forms.Label CashAmountLabel;
        private System.Windows.Forms.PictureBox SettingsButton;
    }
}

