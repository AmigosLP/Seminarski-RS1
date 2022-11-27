using System.ComponentModel.DataAnnotations;
using SmartQuiz.Migrations;

namespace SmartQuiz.Models
{
    public class MakeQuiz
    {
        [Key]
        public int MakeQuizID { get; set; }
        public bool Approve { get; set; }
        public virtual QuizCategory QuizCategory { get; set; }
        public virtual Player Player { get; set; }
        public virtual Supporter Supporter { get; set; }
    }
}
