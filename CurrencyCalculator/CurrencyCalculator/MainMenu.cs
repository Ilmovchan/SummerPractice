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
            ChangeDefaultOriginalCurrency(Convert.ToString(Properties.Settings.Default.OriginalCurrency));

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
            ColorThemeElements selectedColorThemeElements = typeof(ColorTheme).GetProperty(selectedColorTheme)?.GetValue(colorThemeData) as ColorThemeElements;

            if (selectedColorTheme != null)
            {
                this.BackColor = (Color)selectedColorThemeElements?.Background;

                CashAmountField.BackColor = (Color)selectedColorThemeElements?.CashAmountBg;
                OriginalCurrencyField.BackColor = (Color)selectedColorThemeElements?.OriginalCurrencyBg;
                SecondCurrencyField.BackColor = (Color)selectedColorThemeElements?.SecondCurrencyBg;

                ResultField.BackColor = (Color)selectedColorThemeElements?.ResultBg;
                ExchangeField.BackColor = (Color)selectedColorThemeElements?.ExchangeBg;

                CashAmountField.ForeColor = (Color)selectedColorThemeElements?.CashAmountText;
                OriginalCurrencyField.ForeColor = (Color)selectedColorThemeElements?.OriginalCurrencyText;
                SecondCurrencyField.ForeColor = (Color)selectedColorThemeElements?.SecondCurrencyText;

                ResultField.ForeColor = (Color)selectedColorThemeElements?.ResultText;
                ExchangeField.ForeColor = (Color)selectedColorThemeElements?.ExchangeText;

                CashAmountLabel.ForeColor = (Color)selectedColorThemeElements?.CashAmountText;
                OriginalCurrencyLabel.ForeColor = (Color)selectedColorThemeElements?.OriginalCurrencyText;
                SecondCurrencyLabel.ForeColor = (Color)selectedColorThemeElements?.SecondCurrencyText;

                ResultLabel.ForeColor = (Color)selectedColorThemeElements?.ResultText;
                ExchangeLabel.ForeColor = (Color)selectedColorThemeElements?.ExchangeText;

                ConvertButton.BackColor = (Color)selectedColorThemeElements?.ConvertBg;
                ConvertButton.ForeColor = (Color)selectedColorThemeElements?.ConvertText;
                ConvertButton.FlatAppearance.BorderColor = (Color)selectedColorThemeElements?.ConvertBorder;

                CashAmountField.BorderStyle = (BorderStyle)selectedColorThemeElements?.CashAmountBorderStyle;
            }

        }

        public void ChangeDefaultOriginalCurrency(string defaultOriginalCurrency)
        {
            OriginalCurrencyField.Text = defaultOriginalCurrency;
        }
    }
}
