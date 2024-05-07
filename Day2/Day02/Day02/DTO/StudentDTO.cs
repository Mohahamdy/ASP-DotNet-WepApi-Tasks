using System.Text.Json.Serialization;

namespace Day02.DTO
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string DepartmentName { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string SupervisorName { get; set; }
    }
}
