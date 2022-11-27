namespace SmartQuiz.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public virtual User User { get; set; }
    }
}
