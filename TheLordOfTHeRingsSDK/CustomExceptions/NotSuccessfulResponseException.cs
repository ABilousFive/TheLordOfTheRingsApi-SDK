using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.CustomExceptions
{
    partial class NotSuccessfulResponseException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; }

        public NotSuccessfulResponseException(HttpStatusCode httpStatusCode) : base("Request return unsuccessful status code")
        {
            HttpStatusCode = httpStatusCode;
        }
    }
}
