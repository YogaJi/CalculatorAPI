using CalculatorLibrary;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Web_API.Controllers
{
    //this controller is linked to the Calculator Library
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorLibraryController : ControllerBase
    {
        //set up
        private readonly Calculator _calculator;
        public CalculatorLibraryController()
        {
            _calculator = new Calculator();
        }

        //get CalculatorLibrary's add value and return
        [HttpGet]
        public double Add(double valueA, double valueB)
        {
            return _calculator.Add(valueA, valueB);
        }

        //get CalculatorLibrary's subtract value and return
        [HttpGet]
        public double Subtract(double valueA, double valueB)
        {
            return _calculator.Subtract(valueA, valueB);
        }

        //get CalculatorLibrary's mutiply value and return
        [HttpGet]
        public double Multiply(double valueA, double valueB)
        {
            return _calculator.Multiple(valueA, valueB);
        }

        //get CalculatorLibrary's divide value and return
        [HttpGet]
        public double? Divide(double valueA, double valueB)
        {
            //situation:  number / 0 and response 400
            if (valueB == 0)
            {
                //check valueB = 0, then send back the response 400
                Response.StatusCode = 400;
                Response.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "Bad Request";
                return null;
            }
            else
            {
                //else caculate division
                return valueA / valueB;
            }

        }

    }
}
