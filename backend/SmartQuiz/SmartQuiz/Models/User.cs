using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Token { get; set; }
    }
    public class UserCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
