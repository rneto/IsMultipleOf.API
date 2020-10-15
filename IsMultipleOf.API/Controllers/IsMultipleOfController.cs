using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Schema;
using IsMultipleOf.API.Core;
using IsMultipleOf.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IsMultipleOf.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IsMultipleOfController : ControllerBase
    {
        private readonly ILogger _logger;

        public IsMultipleOfController(ILogger<IsMultipleOfController> logger)
        {
            _logger = logger;
        }

        [Route("{divisor}")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IsMultipleOfResponse> Post([Range(1, int.MaxValue)] int divisor,
            IsMultipleOfRequest isMultipleOfRequest)
        {
            _logger.LogInformation(LogEvents.PostIsMultipleOf, "Calculating multiple numbers of {divisor} divisor.", divisor);

            var isMultipleOfResult = new IsMultipleOfResponse();
            isMultipleOfResult  = isMultipleOfRequest.ToIsMultipleOfResponse();

            var divisorCalculator = DivisorCalculatorFactory.Create(divisor);
            divisorCalculator.Calculate(isMultipleOfResult);

            _logger.LogInformation(LogEvents.ResponseIsMultipleOf,
                "Result for calculating multiple numbers of {divisor} divisor: {isMultipleOfResult}", divisor, JsonSerializer.Serialize(isMultipleOfResult));

            return Ok(isMultipleOfResult);
        }
    }
}
