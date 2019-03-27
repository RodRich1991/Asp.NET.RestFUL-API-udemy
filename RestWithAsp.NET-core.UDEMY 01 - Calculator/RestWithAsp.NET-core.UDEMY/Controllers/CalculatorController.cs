using System;
using Microsoft.AspNetCore.Mvc;

namespace RestWithAsp.NET_core.UDEMY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/sum/5/5
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public ActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var result = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(result.ToString());
            }
            return BadRequest("Invalid input!");
        }

        // GET api/subtraction/5/5
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public ActionResult Subtraction(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var result = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(result.ToString());
            }
            return BadRequest("Invalid input!");
        }

        // GET api/multiplication/5/5
        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public ActionResult Multiplication(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var result = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(result.ToString());
            }
            return BadRequest("Invalid input!");
        }

        // GET api/division/5/5
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public ActionResult Division(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var result = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(result.ToString());
            }
            return BadRequest("Invalid input!");
        }

        // GET api/square-root/5
        [HttpGet("square-root/{number}")]
        public ActionResult SquareRoot(string number)
        {
            if (IsNumeric(number))
            {
                var result = Math.Sqrt(ConvertToDecimal(number));
                return Ok(result.ToString());
            }
            return BadRequest("Invalid input!");
        }

        // GET api/mean/5/5
        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public ActionResult Mean(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var result = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok(result.ToString());
            }
            return BadRequest("Invalid input!");
        }

        private double ConvertToDecimal(string stringNumber)
        {
            double doubleNumber;
            if (double.TryParse(stringNumber, out doubleNumber))
            {
                return doubleNumber;
            }
            return 0;
        }

        private bool IsNumeric(string stringNumber)
        {
            decimal number;
            return decimal.TryParse(stringNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        }
    }
}
