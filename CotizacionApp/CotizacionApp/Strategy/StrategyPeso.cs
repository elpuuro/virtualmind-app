using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace CotizacionApp.Strategy
{
    public class StrategyPeso : IStrategy
    {
        public string GetMoneda()
        {
            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }
    }
}