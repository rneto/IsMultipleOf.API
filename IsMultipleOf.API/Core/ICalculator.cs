using IsMultipleOf.API.Models;

namespace IsMultipleOf.API.Core
{
    public interface ICalculator
    {
        public void Calculate(IsMultipleOfResponse response);
    }
}