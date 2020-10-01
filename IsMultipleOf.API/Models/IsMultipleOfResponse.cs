using System.Collections.Generic;

namespace IsMultipleOf.API.Models
{
    public class IsMultipleOfResponse
    {
        public IEnumerable<NumberResponse> result { get; set; }
    }
}
