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
        private CurrencyResponce currencyResponse;

        public MainMenu()
        {
            InitializeComponent();
            currencyResponse = getResponse();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            double firstCurrencyValue = getCurrencyValue(OriginalCurrencyField.Text);
            double secondCurrencyValue = getCurrencyValue(SecondCurrencyField.Text);

            Double.TryParse(CashAmountField.Text, out double cashAmount);

            ResultField.Text = Convert.ToString(currencyConvert(firstCurrencyValue, secondCurrencyValue, cashAmount));
        }

        private double currencyConvert(double firstValue, double secondValue, double cashAmount)
        {
            return cashAmount * (secondValue / firstValue);
        }

        private double getCurrencyValue(string originalCurrency)
        {
            CurrencyInfo currencyInfo = currencyResponse.rates;
            PropertyInfo[] properties = typeof(CurrencyInfo).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.Name == originalCurrency)
                {
                    object firstValue = property.GetValue(currencyInfo);
                    if (firstValue != null)
                    {
                        return Convert.ToDouble(firstValue);
                    }
                }
            }

            return 0;
        }

        private CurrencyResponce getResponse()
        {
            string url = "https://openexchangerates.org/api/latest.json?app_id=5b79ee6f285c4818b7fb7acd54c174b6";
            CurrencyResponce currencyResponse;

            HttpWebRequest httpsWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpsWebRequest.GetResponse();

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                string response = streamReader.ReadToEnd();
                currencyResponse = JsonConvert.DeserializeObject<CurrencyResponce>(response);
            }

            return currencyResponse;
        }
    }
}
