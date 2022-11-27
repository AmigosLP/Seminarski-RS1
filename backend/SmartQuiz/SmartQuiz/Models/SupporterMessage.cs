using System.ComponentModel.DataAnnotations.Schema;

namespace SmartQuiz.Models
{
    public class SupporterMessage
    {
        public int SupporterId { get; set; }
        public int MessageId { get; set; }

        [ForeignKey("SupporterId")]
        public virtual Supporter Supporter { get; set; }
        [ForeignKey("MessageId")]
        public virtual Message Message { get; set; }
    }
}
