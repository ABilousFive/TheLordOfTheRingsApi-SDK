using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.CustomExceptions
{
    public class InvalidResponseException : Exception
    {
        public InvalidResponseException() : base("Response was in incorrect format")
        { }

        public InvalidResponseException(Exception innerException) : base("Response was in incorrect format", innerException)
        { }
    }
}
