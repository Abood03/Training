using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class InvalidAddressExeption:Exception
    {
        public InvalidAddressExeption(string message):base(message) 
        {

        }
    }
}
