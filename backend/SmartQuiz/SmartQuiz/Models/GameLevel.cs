using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class GameLevel
    {
        [Key]
        public int GameLevelId { get; set; }
        public string GameLevels { get; set; }
    }
}
