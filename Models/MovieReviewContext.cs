﻿using Microsoft.EntityFrameworkCore;

namespace TermProject.Models
{
    public class MovieReviewContext : DbContext
    {
        public MovieReviewContext(DbContextOptions<MovieReviewContext> options)
            : base(options)
        {
        }

        public DbSet<MovieReview> MovieReviews { get; set; } = null!;
        public DbSet<Subscribers> Subscribers { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MovieReview>()
                .HasOne(m => m.Genre)
                .WithMany(g => g.MovieReviews)
                .HasForeignKey(m => m.GenreId);
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Drama" },
                new Genre { Id = 3, Name = "Comedy" },
                new Genre { Id = 4, Name = "Horror" }
            );
            modelBuilder.Entity<Subscribers>().HasData(
                new Subscribers { ID = 1, FirstName = "Nick", LastName = "Petrie", GenderIdentity = Gender.Male, email = "nick@example.com", Zip="12345" },
                new Subscribers { ID = 2, FirstName = "Jon", LastName = "Doe", GenderIdentity = Gender.Male, email = "jon@example.com", Zip = "12345" }
            );
            modelBuilder.Entity<MovieReview>().HasData(
                new MovieReview
                {
                    Id = 1,
                    MovieTitle = "Inception",
                    Rating = 9,
                    ReviewText = "A brilliant, mind-bending thriller!",
                    SubscribersId = 1,
                    GenreId = 1
                },
                new MovieReview
                {
                    Id = 2,
                    MovieTitle = "The Matrix",
                    Rating = 10,
                    ReviewText = "An absolute sci-fi classic!",
                    SubscribersId = 2,
                    GenreId = 1
                }
            );
        }
    }
}