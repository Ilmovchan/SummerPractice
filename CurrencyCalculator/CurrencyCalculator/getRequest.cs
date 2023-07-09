using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCalculator
{
    public class getRequest
    {
        HttpWebRequest _request;
        string _address;
        public getRequest(string address)
        {
            string _address = address;
        }
        public void Run()
        {
            _request = (HttpWebRequest)WebRequest.Create(_address);
            _request.Method = "GET";

            HttpWebResponse response = (HttpWebResponse)_request.GetResponse();
        }
    }
}
