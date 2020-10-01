using IsMultipleOf.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsMultipleOf.API.Core
{
    public class CalculatorOf11 : ICalculator
    {
        public void Calculate(IsMultipleOfResponse isMultipleOfResponse)
        {
            foreach (var numberResponse in isMultipleOfResponse?.result)
            {
                int even = 0;
                int odd = 0;
                int[] units = numberResponse.number.ToString().Select(c => int.Parse(c.ToString())).ToArray();

                for (int i = 0; i < units.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        odd += units[i];
                    }
                    else
                    {
                        even += units[i];
                    }
                }

                numberResponse.isMultiple = (odd - even == 0) || (Math.Abs((odd - even) % 11) == 0);
            }
        }
    }
}
