using Microsoft.AspNetCore.Mvc;

namespace AspNET_Web_API_REST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }


        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult GetSum(string firstNumber, string secondNumber)
        {

            if(isDecimal(firstNumber) && isDecimal(secondNumber))
            {
                var sum = converttoDecimal(firstNumber) + converttoDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            
           return BadRequest("Invalid Input"); 
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult GetSub(string firstNumber, string secondNumber)
        {

            if (isDecimal(firstNumber) && isDecimal(secondNumber))
            {
                var sum = converttoDecimal(firstNumber) - converttoDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult GetDiv(string firstNumber, string secondNumber)
        {

            if (isDecimal(firstNumber) && isDecimal(secondNumber))
            {
                if (converttoDecimal(secondNumber) == 0)
                {
                    return BadRequest("Div by 0");
                }
                else 
                { 
                var sum = converttoDecimal(firstNumber) / converttoDecimal(secondNumber);
                return Ok(sum.ToString());
                }
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public IActionResult GetMult(string firstNumber, string secondNumber)
        {

            if (isDecimal(firstNumber) && isDecimal(secondNumber))
            {
                var sum = converttoDecimal(firstNumber) * converttoDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Input");
        }

        private bool isDecimal(string stringNumber)
        {
            double number;
            bool isNumber = 
                double.TryParse(stringNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return isNumber;
        }

        private double converttoDecimal(string stringNumber)
        {
            double number;
            if (double.TryParse(stringNumber,out number))
            {
                return number;
            }
            return 0;

        }
    }
}