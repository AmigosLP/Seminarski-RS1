using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SmartQuiz.Models;

namespace SmartQuiz.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Supporter> Supporters { get; set; }
        public DbSet<GroupMessage> GroupMessages { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<GameLevel> GameLevels { get; set; }
        public DbSet<Language>Languages { get; set; }
        public DbSet<QuizCategory> QuizCategories { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Question>Questions { get; set; }
        public DbSet<MakeQuiz> MakeQuizzes { get; set; }
        public DbSet<Game> Games { set; get; }
        public DbSet<Activation> Activations { get; set; }
        public DbSet<Answer>Answers { get; set; }
        public DbSet<PlayerAnswer> PlayerAnswers { get; set; }
        public DbSet<GameLevelGame>GameLevelGames { get; set; }
        public DbSet<SupporterMessage> SupporterMessages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<GameLevelGame>().HasKey(x => new
            {
                x.GameId,
                x.GameLevelId,
            });
           modelBuilder.Entity<SupporterMessage>().HasKey(table => new
           {
               table.SupporterId,
               table.MessageId
           });

        }
    }
}
