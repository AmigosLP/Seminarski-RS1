﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartQuiz.Data;

#nullable disable

namespace SmartQuiz.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SmartQuiz.Models.Activation", b =>
                {
                    b.Property<int>("ActivationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("ActivationEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("ActivationStart")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("QuizCategoryId")
                        .HasColumnType("int");

                    b.HasKey("ActivationId");

                    b.HasIndex("QuizCategoryId");

                    b.ToTable("Activations");
                });

            modelBuilder.Entity("SmartQuiz.Models.Answer", b =>
                {
                    b.Property<int>("AnswersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("correctAnswer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("quizAnswer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AnswersId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("SmartQuiz.Models.Comment", b =>
                {
                    b.Property<int>("CommnetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.HasKey("CommnetId");

                    b.HasIndex("PlayerID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("SmartQuiz.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CommentCommnetId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<int>("QuizCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.Property<DateTime>("gameTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("GameId");

                    b.HasIndex("CommentCommnetId");

                    b.HasIndex("PlayerID");

                    b.HasIndex("QuizCategoryId");

                    b.HasIndex("ReviewId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("SmartQuiz.Models.GameLevel", b =>
                {
                    b.Property<int>("GameLevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GameLevels")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("GameLevelId");

                    b.ToTable("GameLevels");
                });

            modelBuilder.Entity("SmartQuiz.Models.GameLevelGame", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("GameLevelId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "GameLevelId");

                    b.HasIndex("GameLevelId");

                    b.ToTable("GameLevelGames");
                });

            modelBuilder.Entity("SmartQuiz.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("SmartQuiz.Models.GroupMessage", b =>
                {
                    b.Property<int>("GroupMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("GroupMessageId");

                    b.HasIndex("PlayerID");

                    b.ToTable("GroupMessages");
                });

            modelBuilder.Entity("SmartQuiz.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LanguageId");

                    b.HasIndex("UserId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("SmartQuiz.Models.MakeQuiz", b =>
                {
                    b.Property<int>("MakeQuizID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Approve")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.Property<int>("QuizCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("SupporterID")
                        .HasColumnType("int");

                    b.HasKey("MakeQuizID");

                    b.HasIndex("PlayerID");

                    b.HasIndex("QuizCategoryId");

                    b.HasIndex("SupporterID");

                    b.ToTable("MakeQuizzes");
                });

            modelBuilder.Entity("SmartQuiz.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GroupMessageId")
                        .HasColumnType("int");

                    b.Property<string>("MessageText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MessageId");

                    b.HasIndex("GroupMessageId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("SmartQuiz.Models.Player", b =>
                {
                    b.Property<int>("PlayerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte>("Avatar")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PlayerID");

                    b.HasIndex("GenderId");

                    b.HasIndex("UserId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("SmartQuiz.Models.PlayerAnswer", b =>
                {
                    b.Property<int>("PlayerAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnswersId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("PlayerAnswerId");

                    b.HasIndex("AnswersId");

                    b.HasIndex("GameId");

                    b.ToTable("PlayerAnswers");
                });

            modelBuilder.Entity("SmartQuiz.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GameLevelId")
                        .HasColumnType("int");

                    b.Property<int>("QuizCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("quizQuestion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("QuestionId");

                    b.HasIndex("GameLevelId");

                    b.HasIndex("QuizCategoryId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("SmartQuiz.Models.QuizCategory", b =>
                {
                    b.Property<int>("QuizCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Approve")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("SupporterID")
                        .HasColumnType("int");

                    b.HasKey("QuizCategoryId");

                    b.HasIndex("SupporterID");

                    b.ToTable("QuizCategories");
                });

            modelBuilder.Entity("SmartQuiz.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.Property<int>("ReviewQuiz")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("PlayerID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("SmartQuiz.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("PlayerID")
                        .HasColumnType("int");

                    b.Property<int>("QuizCategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("isPublic")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("RoomId");

                    b.HasIndex("PlayerID");

                    b.HasIndex("QuizCategoryId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("SmartQuiz.Models.Supporter", b =>
                {
                    b.Property<int>("SupporterID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte>("Avatar")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SupporterID");

                    b.HasIndex("GenderId");

                    b.HasIndex("UserId");

                    b.ToTable("Supporters");
                });

            modelBuilder.Entity("SmartQuiz.Models.SupporterMessage", b =>
                {
                    b.Property<int>("SupporterId")
                        .HasColumnType("int");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.HasKey("SupporterId", "MessageId");

                    b.HasIndex("MessageId");

                    b.ToTable("SupporterMessages");
                });

            modelBuilder.Entity("SmartQuiz.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SmartQuiz.Models.Activation", b =>
                {
                    b.HasOne("SmartQuiz.Models.QuizCategory", "QuizCategory")
                        .WithMany()
                        .HasForeignKey("QuizCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuizCategory");
                });

            modelBuilder.Entity("SmartQuiz.Models.Answer", b =>
                {
                    b.HasOne("SmartQuiz.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("SmartQuiz.Models.Comment", b =>
                {
                    b.HasOne("SmartQuiz.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("SmartQuiz.Models.Game", b =>
                {
                    b.HasOne("SmartQuiz.Models.Comment", "Comment")
                        .WithMany()
                        .HasForeignKey("CommentCommnetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQuiz.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQuiz.Models.QuizCategory", "QuizCategory")
                        .WithMany()
                        .HasForeignKey("QuizCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQuiz.Models.Review", "Review")
                        .WithMany()
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("Player");

                    b.Navigation("QuizCategory");

                    b.Navigation("Review");
                });

            modelBuilder.Entity("SmartQuiz.Models.GameLevelGame", b =>
                {
                    b.HasOne("SmartQuiz.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQuiz.Models.GameLevel", "GameLevel")
                        .WithMany()
                        .HasForeignKey("GameLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("GameLevel");
                });

            modelBuilder.Entity("SmartQuiz.Models.GroupMessage", b =>
                {
                    b.HasOne("SmartQuiz.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("SmartQuiz.Models.Language", b =>
                {
                    b.HasOne("SmartQuiz.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartQuiz.Models.MakeQuiz", b =>
                {
                    b.HasOne("SmartQuiz.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQuiz.Models.QuizCategory", "QuizCategory")
                        .WithMany()
                        .HasForeignKey("QuizCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQuiz.Models.Supporter", "Supporter")
                        .WithMany()
                        .HasForeignKey("SupporterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("QuizCategory");

                    b.Navigation("Supporter");
                });

            modelBuilder.Entity("SmartQuiz.Models.Message", b =>
                {
                    b.HasOne("SmartQuiz.Models.GroupMessage", "GroupMessage")
                        .WithMany()
                        .HasForeignKey("GroupMessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQuiz.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupMessage");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartQuiz.Models.Player", b =>
                {
                    b.HasOne("SmartQuiz.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQuiz.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartQuiz.Models.PlayerAnswer", b =>
                {
                    b.HasOne("SmartQuiz.Models.Answer", "Answer")
                        .WithMany()
                        .HasForeignKey("AnswersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQuiz.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("SmartQuiz.Models.Question", b =>
                {
                    b.HasOne("SmartQuiz.Models.GameLevel", "GameLevel")
                        .WithMany()
                        .HasForeignKey("GameLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQuiz.Models.QuizCategory", "QuizCategory")
                        .WithMany()
                        .HasForeignKey("QuizCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameLevel");

                    b.Navigation("QuizCategory");
                });

            modelBuilder.Entity("SmartQuiz.Models.QuizCategory", b =>
                {
                    b.HasOne("SmartQuiz.Models.Supporter", "Supporter")
                        .WithMany()
                        .HasForeignKey("SupporterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supporter");
                });

            modelBuilder.Entity("SmartQuiz.Models.Review", b =>
                {
                    b.HasOne("SmartQuiz.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");
                });

            modelBuilder.Entity("SmartQuiz.Models.Room", b =>
                {
                    b.HasOne("SmartQuiz.Models.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQuiz.Models.QuizCategory", "QuizCategory")
                        .WithMany()
                        .HasForeignKey("QuizCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Player");

                    b.Navigation("QuizCategory");
                });

            modelBuilder.Entity("SmartQuiz.Models.Supporter", b =>
                {
                    b.HasOne("SmartQuiz.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQuiz.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartQuiz.Models.SupporterMessage", b =>
                {
                    b.HasOne("SmartQuiz.Models.Message", "Message")
                        .WithMany()
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartQuiz.Models.Supporter", "Supporter")
                        .WithMany()
                        .HasForeignKey("SupporterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");

                    b.Navigation("Supporter");
                });
#pragma warning restore 612, 618
        }
    }
}
