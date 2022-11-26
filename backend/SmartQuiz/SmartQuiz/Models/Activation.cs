using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class Activation
    {
        [Key]
        public int ActivationId { get; set; }
        public DateTime ActivationStart { get; set; }
        public DateTime ActivationEnd { get; set; }
        public virtual QuizCategory QuizCategory { get; set; }
    }
}
