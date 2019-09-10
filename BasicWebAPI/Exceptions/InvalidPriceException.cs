using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebAPI.Exceptions
{
    public class InvalidPriceException:Exception
    {
        public InvalidPriceException() : base("Invalid Price.Price cannot be less than 50")
        {

        }
    }
}
