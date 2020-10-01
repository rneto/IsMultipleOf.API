using IsMultipleOf.API.Core;
using IsMultipleOf.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace IsMultipleOf.API.Test
{
    [TestClass]
    public class CalculatorOf11Test
    {
        [TestMethod]
        public void IsMultiple__11_Of_11()
        {
            var calculator = new CalculatorOf11();
            IsMultipleOfResponse isMultipleOfResponse = new IsMultipleOfResponse()
            {
                result = new List<NumberResponse>()
                {
                    new NumberResponse()
                    {
                        number = 11
                    }
                }
            };

            calculator.Calculate(isMultipleOfResponse);

            Assert.IsTrue(isMultipleOfResponse.result.First().isMultiple);
        }

        [TestMethod]
        public void IsMultiple__323455693_Of_11()
        {
            var calculator = new CalculatorOf11();
            IsMultipleOfResponse isMultipleOfResponse = new IsMultipleOfResponse()
            {
                result = new List<NumberResponse>()
                {
                    new NumberResponse()
                    {
                        number = 323455693
                    }
                }
            };

            calculator.Calculate(isMultipleOfResponse);

            Assert.IsTrue(isMultipleOfResponse.result.First().isMultiple);
        }
    }
}
