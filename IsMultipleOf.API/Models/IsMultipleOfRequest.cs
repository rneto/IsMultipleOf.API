using System.Collections.Generic;

namespace IsMultipleOf.API.Models
{
    public class IsMultipleOfRequest
    {
        public IEnumerable<int> numbers { get; set; }
    }
}
