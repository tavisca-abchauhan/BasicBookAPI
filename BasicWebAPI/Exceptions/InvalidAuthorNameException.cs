using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebAPI.Exceptions
{
    public class InvalidAuthorNameException:Exception
    {
        public InvalidAuthorNameException() : base("Invalid author name.Name should contain only alphabets")
        {

        }
    }
}
