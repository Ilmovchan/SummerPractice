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

namespace CurrencyCalculator
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            string originalValue = OriginalValueField.Text;
            string originalCurrency = OriginalCurrencyField.Text;
            string secondaryCurrency = SecondaryCurrencyField.Text;

            CurrencyResponce currencyResponce = JsonConvert.DeserializeObject<CurrencyResponce>(getResponce());

            PropertyInfo[] properties = typeof(CurrencyInfo).GetProperties();
            double value = 0.0;
            foreach (PropertyInfo property in properties)
            {
                if (property.Name == originalCurrency)
                {
                    ResultField.Text = "Congrats";
                    break;
                }
                else ResultField.Text = "no(";
            }

            
        }
        
        public string getResponce()
        {
            string url = "https://openexchangerates.org/api/latest.json?app_id=5b79ee6f285c4818b7fb7acd54c174b6";
            string responce;

            HttpWebRequest httpsWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpsWebRequest.GetResponse();
            
            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                responce = streamReader.ReadToEnd();
            }

            return responce;
        }
    }
}
