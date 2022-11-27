using SmartQuiz.Migrations;
using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public int Points { get; set; }
        public DateTime gameTime { get; set; }
        public virtual QuizCategory QuizCategory { get; set; }
        public virtual Player Player { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual Review Review { get; set; }
    }
}
