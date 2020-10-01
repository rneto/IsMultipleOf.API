using System.Collections.Generic;

namespace IsMultipleOf.API.Core
{
    public static class DivisorCalculatorFactory
    {
        private static readonly Dictionary<int, ICalculator> calculatorList = new Dictionary<int, ICalculator>();

        static DivisorCalculatorFactory()
        {
            calculatorList.Add(11, new  CalculatorOf11());
            // Add new calculators here!
        }

        public static ICalculator Create(int divisor)
        {
            return calculatorList.ContainsKey(divisor) ?
                calculatorList[divisor] :
                new CalculatorOfAny(divisor);
        }
    }
}