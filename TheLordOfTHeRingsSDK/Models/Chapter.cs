using System.Text.Json.Serialization;

namespace TestProject.Models
{
    public class Chapter
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }
        public string ChapterName { get; set; }
        public string Book { get; set; }
    }
}
