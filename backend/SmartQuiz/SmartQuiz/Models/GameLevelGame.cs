namespace SmartQuiz.Models
{
    public class GameLevelGame
    {
        public int GameId { get; set; }
        public int GameLevelId { get; set; }

        public virtual Game Game { get; set; }
        public virtual GameLevel GameLevel { get; set; }
    }
}
