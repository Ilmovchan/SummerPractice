using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Reflection;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace CurrencyCalculator
{
    public partial class MainMenu : Form
    {
        private static CurrencyResponse currencyResponse;
        private Settings settingsForm;

        public MainMenu()
        {
            InitializeComponent();

            if (currencyResponse == null)
            {
                currencyResponse = GetResponse();
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            double firstCurrencyValue = GetCurrencyValue(OriginalCurrencyField.Text);
            double secondCurrencyValue = GetCurrencyValue(SecondCurrencyField.Text);

            Double.TryParse(CashAmountField.Text, out double cashAmount);

            double resultValue = CurrencyConvert(firstCurrencyValue, secondCurrencyValue, cashAmount);

            ResultField.Text = resultValue.ToString("0.00");
            ExchangeField.Text = OriginalCurrencyField.Text + "/" + SecondCurrencyField.Text + ": " + Convert.ToString(Math.Round(firstCurrencyValue/secondCurrencyValue , 2));
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                settingsForm = new Settings();
                settingsForm.Show();
            }
            else
            {
                settingsForm.BringToFront();
            }
        }

        private double CurrencyConvert(double firstValue, double secondValue, double cashAmount)
        {
            return cashAmount * (secondValue / firstValue);
        }

        private double GetCurrencyValue(string originalCurrency)
        {
            CurrencyInfo currencyInfo = currencyResponse.rates;
            PropertyInfo[] properties = typeof(CurrencyInfo).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.Name == originalCurrency)
                {
                    object value = property.GetValue(currencyInfo);
                    if (value != null)
                    {
                        return Convert.ToDouble(value);
                    }
                }
            }

            return 0;
        }

        private CurrencyResponse GetResponse()
        {
            string url = "https://openexchangerates.org/api/latest.json?app_id=5b79ee6f285c4818b7fb7acd54c174b6";
            CurrencyResponse currencyResponse;

            HttpWebRequest httpsWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpsWebRequest.GetResponse();

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                string response = streamReader.ReadToEnd();
                currencyResponse = JsonConvert.DeserializeObject<CurrencyResponse>(response);
            }

            return currencyResponse;
        }

        public void ChangeColorTheme(string colorTheme)
        {
            if (colorTheme == "Світла" || colorTheme == "Light")
            {
                this.BackColor = System.Drawing.Color.WhiteSmoke;

                CashAmountField.BackColor = System.Drawing.SystemColors.ScrollBar;
                OriginalCurrencyField.BackColor = System.Drawing.SystemColors.ScrollBar;
                SecondCurrencyField.BackColor = System.Drawing.SystemColors.ScrollBar;

                ResultField.BackColor = System.Drawing.SystemColors.ScrollBar;
                ExchangeField.BackColor = System.Drawing.SystemColors.ScrollBar;

                CashAmountLabel.ForeColor = System.Drawing.Color.Black;
                OriginalCurrencyLabel.ForeColor = System.Drawing.Color.Black;
                SecondCurrencyLabel.ForeColor = System.Drawing.Color.Black;

                ResultLabel.ForeColor = System.Drawing.Color.Black;
                ExchangeLabel.ForeColor = System.Drawing.Color.Black;

                ConvertButton.BackColor = System.Drawing.Color.PowderBlue;
                ConvertButton.ForeColor = System.Drawing.Color.Black;
                ConvertButton.FlatAppearance.BorderColor = System.Drawing.Color.PowderBlue;

                CashAmountField.BorderStyle = BorderStyle.None;
            }
            else if (colorTheme == "Темна" || colorTheme == "Dark")
            {
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));

                CashAmountField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
                OriginalCurrencyField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
                SecondCurrencyField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));

                ResultField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
                ExchangeField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));

                CashAmountLabel.ForeColor = System.Drawing.Color.White;
                OriginalCurrencyLabel.ForeColor = System.Drawing.Color.White;
                SecondCurrencyLabel.ForeColor = System.Drawing.Color.White;

                ResultLabel.ForeColor = System.Drawing.Color.White;
                ExchangeLabel.ForeColor = System.Drawing.Color.White;

                ConvertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(74)))), ((int)(((byte)(232)))));
                ConvertButton.ForeColor = System.Drawing.Color.White;
                ConvertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(74)))), ((int)(((byte)(232)))));

                CashAmountField.BorderStyle = BorderStyle.FixedSingle;
            }

        }

        public void ChangeLanguage(string language)
        {
            if (language == "Українська" || language == "Ukraininan")
            {
                CashAmountLabel.Text = "Введіть кількість грошей:";
                OriginalCurrencyLabel.Text = "Оберіть валюту з якої хочете конвертувати:";
                SecondCurrencyLabel.Text = "Оберіть валюту до якої хочете перейти:";
                ResultLabel.Text = "Результат:";
                ExchangeLabel.Text = "Курс на сьогодні:";
                ConvertButton.Text = "Конвертувати";
                this.Text = "Валютний калькулятор";
            }
            else if (language == "Англійська" || language == "English")
            {
                CashAmountLabel.Text = "Enter cash amount:";
                OriginalCurrencyLabel.Text = "Choose original currency:";
                SecondCurrencyLabel.Text = "Choose second currency";
                ResultLabel.Text = "Result:";
                ExchangeLabel.Text = "Today's money rate:";
                ConvertButton.Text = "Convert";
                this.Text = "Currency calculator";
            }
        }
    }
}
