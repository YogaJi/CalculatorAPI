using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Core_Web_API.Controllers
{
    //this controller is linked to the web app
    //set each calculate method as api/calculator/'method'
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        //get the input from Library
        //set the numbers are double,
        //either negative or positive number is allowed
        [HttpGet]
        public double? Add(double? valueA, double? valueB)
        {
            //add
            return valueA + valueB;
        }

        [HttpGet]
        public double Subtract(double valueA, double valueB)
        {
            //subtract
            return valueA - valueB;
        }

        [HttpGet]
        public double? Multiple(double valueA, double valueB)
        {
            //mutiple
            return valueA * valueB;
        }

        [HttpGet]
        public double? Divide(double valueA, double valueB)
        {
            //situation:  number / 0 and response 400
            if(valueB == 0)
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
