using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Net_Core_Web_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
  
        [HttpGet]
        public double? Add(double valueA, double valueB)
        {
            return valueA + valueB;
        }

        [HttpGet]
        public double? Subtract(double valueA, double valueB)
        {
            return valueA - valueB;
        }

        [HttpGet]
        public double? Multiple(double valueA, double valueB)
        {
            return valueA * valueB;
        }

        [HttpGet]
        public double? Divise(double valueA, double valueB)
        {
            //situation:  number / 0
            if (valueB == 0) {
                Response.StatusCode = 400;
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "Bad Request";
                return null;
            }
            else
            {
                return valueA / valueB;
            }
        }
    }
 /*   public class Input
    {
        public int valueA { get; set; }
        public int valueB { get; set; }
    }*/
}
