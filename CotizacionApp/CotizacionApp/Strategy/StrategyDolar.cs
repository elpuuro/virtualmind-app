using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace CotizacionApp.Strategy
{
    public class StrategyDolar : IStrategy
    {
        public string GetMoneda()
        {
            var json = new WebClient().DownloadString("https://www.bancoprovincia.com.ar/Principal/Dolar");

            return json;
        }
    }
}