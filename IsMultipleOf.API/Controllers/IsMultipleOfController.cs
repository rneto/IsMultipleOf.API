using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using IsMultipleOf.API.Core;
using IsMultipleOf.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IsMultipleOf.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IsMultipleOfController : ControllerBase
    {
        [Route("{divisor}")]
        [HttpPost]
        public ActionResult<IsMultipleOfResponse> Post([Range(1, int.MaxValue)] int divisor,
            IsMultipleOfRequest isMultipleOfRequest)
        {
            var isMultipleOfResult = new IsMultipleOfResponse();
            isMultipleOfResult  = isMultipleOfRequest.ToIsMultipleOfResponse();

            var divisorCalculator = DivisorCalculatorFactory.Create(divisor);
            divisorCalculator.Calculate(isMultipleOfResult);

            return Ok(isMultipleOfResult);
        }
    }
}
