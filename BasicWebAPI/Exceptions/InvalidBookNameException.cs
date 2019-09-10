using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebAPI.Exceptions
{
    public class InvalidBookNameException:Exception
    {
        public InvalidBookNameException() : base("Invalid Book Name.Name should contain only alphabets")
        {

        }
    }
}
