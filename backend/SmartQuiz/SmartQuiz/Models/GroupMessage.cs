using SmartQuiz.Migrations;
using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class GroupMessage
    {
        [Key]
        public int GroupMessageId { get; set; }
        public string Title { get; set; }
        public virtual Player Player { get; set; }
    }
}
