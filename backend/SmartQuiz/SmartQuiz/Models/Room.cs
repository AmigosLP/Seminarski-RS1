using SmartQuiz.Migrations;

namespace SmartQuiz.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public bool isPublic { get; set; }
        public virtual Player Player { get; set; }
        public virtual QuizCategory QuizCategory { get; set; }
    }
}
