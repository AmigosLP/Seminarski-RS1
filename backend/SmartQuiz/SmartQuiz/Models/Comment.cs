using SmartQuiz.Migrations;
using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class Comment
    {
        [Key]
        public int CommnetId { get; set; }
        public string CommentText { get; set; }
        public virtual Player Player { get; set; }
    }
}
