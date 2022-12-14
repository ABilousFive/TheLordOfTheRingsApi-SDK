using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class Character
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }
        public string Height { get; set; }
        public string Race { get; set; }
        public string Gender { get; set; }
        public string Birth { get; set; }
        public string Spouse { get; set; }
        public string Death { get; set; }
        public string Realm { get; set; }
        public string Hair { get; set; }
        public string Name { get; set; }
        public string WikiUrl { get; set; }
    }
}
