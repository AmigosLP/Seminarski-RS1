using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class Answer
    {
        [Key]
        public int AnswersId { get; set; }
        public string quizAnswer { get; set; }
        public string correctAnswer { get; set; }
        public int Points { get; set; }
        public virtual Question Question { get; set; }
    }
}
