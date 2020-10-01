using IsMultipleOf.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace IsMultipleOf.API.Core
{
    public static class IsMultipleOfRequestExtensions
    {
        public static IsMultipleOfResponse ToIsMultipleOfResponse(this IsMultipleOfRequest isMultipleOfRequest)
        {
            var isMultipleOfResult = new IsMultipleOfResponse();

            if (isMultipleOfRequest.numbers != null && isMultipleOfRequest.numbers.Any())
            {
                isMultipleOfResult.result = isMultipleOfRequest
                    .numbers
                    .Select(n => new NumberResponse()
                    {
                        number = n,
                        isMultiple = false
                    }).ToList();
            }
            return isMultipleOfResult;
        }
    }
}
