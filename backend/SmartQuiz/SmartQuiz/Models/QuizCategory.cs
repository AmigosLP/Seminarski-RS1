using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class QuizCategory
    {
        [Key]
        public int QuizCategoryId { get; set; }
        public string Name { get; set; }
        public bool Approve { get; set; }
        public virtual Supporter Supporter { get; set; }
    }
}
