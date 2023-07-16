using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculator.Config.API
{

    public class CurrencyResponse
    {
        public CurrencyInfo rates { get; set; }
    }

    public class CurrencyInfo
    {
        public string UAH { get; set; }
        public string USD { get; set; }
        public string EUR { get; set; }
        public string PLN { get; set; }
        public string GBP { get; set; }
        public string AUD { get; set; }
        public string CZK { get; set; }
        public string CNY { get; set; }
        public string BTC { get; set; }
    }
}
