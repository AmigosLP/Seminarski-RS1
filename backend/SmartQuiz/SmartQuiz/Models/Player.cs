using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual User User { get; set; }
    }
}
