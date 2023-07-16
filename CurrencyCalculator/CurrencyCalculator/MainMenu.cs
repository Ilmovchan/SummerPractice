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
using CurrencyCalculator.Config.UI.MainMenu;
using CurrencyCalculator.Config.API;

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

            ChangeLanguage(Convert.ToString(Properties.Settings.Default.Language));
            ChangeColorTheme(Convert.ToString(Properties.Settings.Default.ColorTheme));
            ChangeDefaultOriginalCurrency(Convert.ToString(Properties.Settings.Default.DefaultOriginalCurrency));

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            double firstCurrencyValue = GetCurrencyValue(OriginalCurrencyField.Text);
            double secondCurrencyValue = GetCurrencyValue(SecondCurrencyField.Text);

            Double.TryParse(CashAmountField.Text, out double cashAmount);

            double resultValue = CurrencyConvert(firstCurrencyValue, secondCurrencyValue, cashAmount);

            ResultField.Text = Convert.ToString(Math.Round(resultValue, (int)Properties.Settings.Default.NumbersAfterSeparator));
            ExchangeField.Text = OriginalCurrencyField.Text + "/" + SecondCurrencyField.Text + ": " + Convert.ToString(Math.Round(firstCurrencyValue/secondCurrencyValue , (int)Properties.Settings.Default.NumbersAfterSeparator));
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
            if (cashAmount > 0) return cashAmount * (secondValue / firstValue);
            else return 0;
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

        public void ChangeLanguage(string language)
        {
            Language languageData = new Language();

            string selectedLanguage = language;
            LanguageElements languageText = typeof(Language).GetProperty(selectedLanguage)?.GetValue(languageData) as LanguageElements;

            this.Text = languageText?.Title;
            CashAmountLabel.Text = languageText?.CashAmount;
            OriginalCurrencyLabel.Text = languageText?.OriginalCurrency;
            SecondCurrencyLabel.Text = languageText?.SecondCurrency;
            ResultLabel.Text = languageText?.Result;
            ExchangeLabel.Text = languageText?.Exchange;
            ConvertButton.Text = languageText?.Convert;
        }

        public void ChangeColorTheme(string colorTheme)
        {

            ColorTheme colorThemeData = new ColorTheme();
            string selectedColorTheme = colorTheme;
            ColorThemeElements selectedLanguageElements = typeof(ColorTheme).GetProperty(selectedColorTheme)?.GetValue(colorThemeData) as ColorThemeElements;

            if (selectedLanguageElements != null)
            {
                this.BackColor = (Color)selectedLanguageElements?.Background;

                CashAmountField.BackColor = (Color)selectedLanguageElements?.CashAmountBg;
                OriginalCurrencyField.BackColor = (Color)selectedLanguageElements?.OriginalCurrencyBg;
                SecondCurrencyField.BackColor = (Color)selectedLanguageElements?.SecondCurrencyBg;

                ResultField.BackColor = (Color)selectedLanguageElements?.ResultBg;
                ExchangeField.BackColor = (Color)selectedLanguageElements?.ExchangeBg;

                CashAmountField.ForeColor = (Color)selectedLanguageElements?.CashAmountText;
                OriginalCurrencyField.ForeColor = (Color)selectedLanguageElements?.OriginalCurrencyText;
                SecondCurrencyField.ForeColor = (Color)selectedLanguageElements?.SecondCurrencyText;

                ResultField.ForeColor = (Color)selectedLanguageElements?.ResultText;
                ExchangeField.ForeColor = (Color)selectedLanguageElements?.ExchangeText;

                CashAmountLabel.ForeColor = (Color)selectedLanguageElements?.CashAmountText;
                OriginalCurrencyLabel.ForeColor = (Color)selectedLanguageElements?.OriginalCurrencyText;
                SecondCurrencyLabel.ForeColor = (Color)selectedLanguageElements?.SecondCurrencyText;

                ResultLabel.ForeColor = (Color)selectedLanguageElements?.ResultText;
                ExchangeLabel.ForeColor = (Color)selectedLanguageElements?.ExchangeText;

                ConvertButton.BackColor = (Color)selectedLanguageElements?.ConvertBg;
                ConvertButton.ForeColor = (Color)selectedLanguageElements?.ConvertText;
                ConvertButton.FlatAppearance.BorderColor = (Color)selectedLanguageElements?.ConvertBorder;

                CashAmountField.BorderStyle = (BorderStyle)selectedLanguageElements?.CashAmountBorderStyle;
            }

        }

        public void ChangeDefaultOriginalCurrency(string defaultOriginalCurrency)
        {
            OriginalCurrencyField.Text = defaultOriginalCurrency;
        }
    }
}
