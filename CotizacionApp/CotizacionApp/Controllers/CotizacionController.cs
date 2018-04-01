using CotizacionApp.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CotizacionApp.Controllers
{
    public class CotizacionController : ApiController
    {
        // GET api/<controller>/5
        public string Get(string moneda)
        {
            IStrategy sortingStrategy = null;

            moneda = moneda.ToLower();
            sortingStrategy = SelectMoneda(moneda);

            return sortingStrategy.GetMoneda();    

        }

        private static IStrategy SelectMoneda(string moneda)
        {
            IStrategy selectedMoneda = null;

            switch (moneda)
            {
                case "real":
                    selectedMoneda = new StrategyReal();
                    break;
                case "peso":
                    selectedMoneda = new StrategyPeso();
                    break;
                case "dolar":
                    selectedMoneda = new StrategyDolar();
                    break;
                default:
                    break;
            }
            return selectedMoneda;
        }
    }
}
