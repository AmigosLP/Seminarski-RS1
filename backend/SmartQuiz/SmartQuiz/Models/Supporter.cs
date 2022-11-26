using System.ComponentModel.DataAnnotations;

namespace SmartQuiz.Models
{
    public class Supporter
    {
        [Key]
        public int SupporterID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte Avatar { get; set; }
        public virtual User User { get; set; }
        public virtual Gender Gender { get; set; }
    }
}
