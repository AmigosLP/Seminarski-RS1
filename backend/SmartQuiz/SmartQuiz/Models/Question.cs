using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string quizQuestion { get; set; }
        public string Type { get; set; }
        public virtual QuizCategory QuizCategory { get; set; }
        public virtual GameLevel GameLevel { get; set; }
    }
}
