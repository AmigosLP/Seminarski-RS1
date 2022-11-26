using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public virtual User User { get; set; }
        public virtual GroupMessage GroupMessage { get; set; }
    }
}
