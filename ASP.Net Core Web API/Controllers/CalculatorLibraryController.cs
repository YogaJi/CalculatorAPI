using CalculatorLibrary;
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
    public class CalculatorLibraryController : ControllerBase
    {
        private readonly Calculator _calculator;
        public CalculatorLibraryController()
        {
            _calculator = new Calculator();
        }

        [HttpGet]
        public double Add(double valueA, double valueB)
        {
            return _calculator.Add(valueA, valueB);
        }

        [HttpGet]
        public double Subtract(double valueA, double valueB)
        {
            return _calculator.Subtract(valueA, valueB);
        }

        [HttpGet]
        public double Multiply(double valueA, double valueB)
        {
            return _calculator.Multiple(valueA, valueB);
        }
        [HttpGet]
        public double? Divide(double valueA, double valueB)
        {
            //situation:  number / 0 and response 400
            if (valueB == 0)
            {
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
}
