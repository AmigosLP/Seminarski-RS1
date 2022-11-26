using System.ComponentModel.DataAnnotations;
using SmartQuiz.Migrations;

namespace SmartQuiz.Models
{
    public class PlayerAnswer
    {
        [Key]
        public int PlayerAnswerId { get; set; }
        public int Points { get; set; }
        public virtual Answer Answer { get; set; }
        public virtual Game Game { get; set; }
    }
}
