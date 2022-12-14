using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.CustomExceptions
{
    public class NotAuthorizationException : Exception
    {
        public NotAuthorizationException()
        {
            Message = "Authorization token is needed for this endpoint";
        }

        public string Message { get; init; }
    }
}
