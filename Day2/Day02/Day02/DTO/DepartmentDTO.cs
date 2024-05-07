using System.Text.Json.Serialization;

namespace Day02.DTO
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? MangerId { get; set; }

        public int StudentsCount { get; set; }
    }
}
