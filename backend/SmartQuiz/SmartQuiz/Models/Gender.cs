using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class Gender
    {
        [Key]
        public int Id { get; set; }
        public string GenderName { get; set; } = string.Empty;
    }
}
