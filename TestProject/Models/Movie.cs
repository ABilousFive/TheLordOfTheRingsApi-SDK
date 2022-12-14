using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestProject.Models
{
    public class Movie
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }
        public string Name { get; set; }
        public int RuntimeInMinutes { get; set; }
        public int BudgetInMillions { get; set; }
        public int BoxOfficeRevenueInMillions { get; set; }
        public int AcademyAwardNominations { get; set; }
        public int AcademyAwardWins { get; set; }
        public int RottenTomatoesScore { get; set; }
    }
}
