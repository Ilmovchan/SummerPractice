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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OriginalCurrencyField = new System.Windows.Forms.ComboBox();
            this.ResultField = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ConvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.CashAmountField.Location = new System.Drawing.Point(47, 79);
            this.CashAmountField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CashAmountField.Name = "CashAmountField";
            this.CashAmountField.Size = new System.Drawing.Size(216, 128);
            this.CashAmountField.TabIndex = 1;
            this.CashAmountField.Text = "";
            // 
            // ExchangeField
            // 
            this.ExchangeField.BackColor = System.Drawing.Color.LightSteelBlue;
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
            this.SecondCurrencyField.Size = new System.Drawing.Size(412, 23);
            this.SecondCurrencyField.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Результат:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(322, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Оберіть необхідну валюту з якої хочете конвертувати";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(322, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Оберіть валюту до якої хочете перейти";
            // 
            // OriginalCurrencyField
            // 
            this.OriginalCurrencyField.BackColor = System.Drawing.SystemColors.ScrollBar;
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
            this.OriginalCurrencyField.Location = new System.Drawing.Point(325, 79);
            this.OriginalCurrencyField.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OriginalCurrencyField.Name = "OriginalCurrencyField";
            this.OriginalCurrencyField.Size = new System.Drawing.Size(412, 23);
            this.OriginalCurrencyField.TabIndex = 15;
            // 
            // ResultField
            // 
            this.ResultField.BackColor = System.Drawing.Color.LightSteelBlue;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(519, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Курс на сьогодні:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Введіть кількість грошей:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(767, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 27);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(816, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ResultField);
            this.Controls.Add(this.OriginalCurrencyField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.RichTextBox CashAmountField;
        private System.Windows.Forms.RichTextBox ExchangeField;
        private System.Windows.Forms.ComboBox SecondCurrencyField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox OriginalCurrencyField;
        private System.Windows.Forms.RichTextBox ResultField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

