using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebAPI.Exceptions
{
    public class BookNotFoundException:Exception
    {

        public BookNotFoundException() : base("Book Not Found")
        {

        }
    }
}
