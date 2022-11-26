using SmartQuiz.Migrations;
using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public int ReviewQuiz { get; set; }
        public virtual Player Player { get; set; }
    }
}
