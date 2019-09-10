using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebAPI.Exceptions
{
    public class InvalidIdException:Exception
    {
        public InvalidIdException() : base("Invalid Id.Id cannot be negative")
        {

        }
    }
}
