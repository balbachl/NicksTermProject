﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermProject.Models;

#nullable disable

namespace TermProject.Migrations
{
    [DbContext(typeof(MovieReviewContext))]
    [Migration("20241210232524_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TermProject.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Horror"
                        });
                });

            modelBuilder.Entity("TermProject.Models.MovieReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("SubscribersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("SubscribersId");

                    b.ToTable("MovieReviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreId = 1,
                            MovieTitle = "Inception",
                            Rating = 9,
                            ReviewText = "A brilliant, mind-bending thriller!",
                            SubscribersId = 1
                        },
                        new
                        {
                            Id = 2,
                            GenreId = 1,
                            MovieTitle = "The Matrix",
                            Rating = 10,
                            ReviewText = "An absolute sci-fi classic!",
                            SubscribersId = 2
                        });
                });

            modelBuilder.Entity("TermProject.Models.Subscribers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("GenderIdentity")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("State")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Zip")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Subscriber_Email");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Subscribers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "",
                            City = "",
                            FirstName = "Nick",
                            GenderIdentity = 0,
                            LastName = "Petrie",
                            State = "",
                            Zip = "12345",
                            email = "nick@example.com",
                            phoneNumber = ""
                        },
                        new
                        {
                            ID = 2,
                            Address = "",
                            City = "",
                            FirstName = "Jon",
                            GenderIdentity = 0,
                            LastName = "Doe",
                            State = "",
                            Zip = "12345",
                            email = "jon@example.com",
                            phoneNumber = ""
                        });
                });

            modelBuilder.Entity("TermProject.Models.MovieReview", b =>
                {
                    b.HasOne("TermProject.Models.Genre", "Genre")
                        .WithMany("MovieReviews")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TermProject.Models.Subscribers", "Subscriber")
                        .WithMany("MovieReviews")
                        .HasForeignKey("SubscribersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Subscriber");
                });

            modelBuilder.Entity("TermProject.Models.Genre", b =>
                {
                    b.Navigation("MovieReviews");
                });

            modelBuilder.Entity("TermProject.Models.Subscribers", b =>
                {
                    b.Navigation("MovieReviews");
                });
#pragma warning restore 612, 618
        }
    }
}
