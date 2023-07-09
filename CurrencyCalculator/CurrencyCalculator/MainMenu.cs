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
            String originalValue = OriginalValueField.Text;
            String originalCurrency = OriginalCurrencyField.Text;
            String secondaryCurrency = SecondaryCurrencyField.Text;

            String url = "https://api.currencyapi.com/v3/latest?apikey=t6eP1x8C2Jo6yluiIdPqGJD8XMTeEMp8bs5m0CwP";
            HttpWebRequest httpsWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpsWebRequest.GetResponse();

            string responce;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                responce = streamReader.ReadToEnd();
            }

            Console.WriteLine(responce);
        }
    }
}
