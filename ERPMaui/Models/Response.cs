using Newtonsoft.Json;

namespace ERPMaui.Models
{
    public class Response
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("errors")]
        public object Errors { get; set; }
    }

    public class Data
    {
        [JsonProperty("jwtToken")]
        public JwtToken JwtToken { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

    public class JwtToken
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("expiresIn")]
        public int ExpiresIn { get; set; }
    }

    public class User
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("departmentId")]
        public int DepartmentId { get; set; }

        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        [JsonProperty("sectionId")]
        public int SectionId { get; set; }

        [JsonProperty("sectionName")]
        public string SectionName { get; set; }
    }
}
