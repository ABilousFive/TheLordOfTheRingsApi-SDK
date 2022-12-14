using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class Response <T> where T : class
    {
        public List<T> Docs { get; set; }
        public int Total { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public int Page { get; set; }
        public int Pages { get; set; }
    }
}
