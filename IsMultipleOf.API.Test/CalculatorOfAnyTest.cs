using IsMultipleOf.API.Core;
using IsMultipleOf.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace IsMultipleOf.API.Test
{
    [TestClass]
    public class CalculatorOfAnyTest
    {
        [TestMethod]
        public void IsMultiple__10_Of_2()
        {
            var calculator = new CalculatorOfAny(2);
            IsMultipleOfResponse isMultipleOfResponse = new IsMultipleOfResponse()
            {
                result = new List<NumberResponse>()
                {
                    new NumberResponse()
                    {
                        number = 10
                    }
                }
            };

            calculator.Calculate(isMultipleOfResponse);

            Assert.IsTrue(isMultipleOfResponse.result.First().isMultiple);
        }

        [TestMethod]
        public void IsMultiple__97035_Of_3()
        {
            var calculator = new CalculatorOfAny(3);
            IsMultipleOfResponse isMultipleOfResponse = new IsMultipleOfResponse()
            {
                result = new List<NumberResponse>()
                {
                    new NumberResponse()
                    {
                        number = 97035
                    }
                }
            };

            calculator.Calculate(isMultipleOfResponse);

            Assert.IsTrue(isMultipleOfResponse.result.First().isMultiple);
        }

        [TestMethod]
        public void IsMultiple__81728901_Of_151()
        {
            var calculator = new CalculatorOfAny(151);
            IsMultipleOfResponse isMultipleOfResponse = new IsMultipleOfResponse()
            {
                result = new List<NumberResponse>()
                {
                    new NumberResponse()
                    {
                        number = 81728901
                    }
                }
            };

            calculator.Calculate(isMultipleOfResponse);

            Assert.IsTrue(isMultipleOfResponse.result.First().isMultiple);
        }
    }
}
