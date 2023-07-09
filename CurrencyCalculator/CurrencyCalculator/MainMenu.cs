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

            this.ResultField.Text = "EURO: " + Convert.ToString(currencyResponce.data.EUR.value);
            this.ExchangeField.Text = "UAH: " + Convert.ToString(currencyResponce.data.UAH.value);

        }
        public string getResponce()
        {
            string url = "https://api.currencyapi.com/v3/latest?apikey=t6eP1x8C2Jo6yluiIdPqGJD8XMTeEMp8bs5m0CwP";
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
