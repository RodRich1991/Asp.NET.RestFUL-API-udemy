﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace RestWithAsp.NET_core.UDEMY.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/sum/5/5
        [HttpGet("{firstNumber}/{secondNumber}")]
        public ActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid input!");
        }

        private decimal ConvertToDecimal(string stringNumber)
        {
            decimal decimalNumber;
            if (decimal.TryParse(stringNumber, out decimalNumber))
            {
                return decimalNumber;
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
