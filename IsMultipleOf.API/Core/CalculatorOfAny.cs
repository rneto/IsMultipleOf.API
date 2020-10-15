using IsMultipleOf.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsMultipleOf.API.Core
{
    public class CalculatorOfAny : ICalculator
    {
        private int divisor;

        public CalculatorOfAny(int divisor)
        {
            this.divisor = divisor;
        }

        public void Calculate(IsMultipleOfResponse isMultipleOfResponse)
        {
            foreach (var number in isMultipleOfResponse?.result)
            {
                number.isMultiple = number.number != 0 && (number.number % this.divisor == 0);
            }
        }
    }
}
