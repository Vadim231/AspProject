﻿// <auto-generated />
using System;
using Headhunter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Headhunter.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190908111050_AppliesAdded")]
    partial class AppliesAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Headhunter.Models.Apply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTime");

                    b.Property<int>("UserId");

                    b.Property<int>("VacancyId");

                    b.HasKey("Id");

                    b.ToTable("Applies");
                });

            modelBuilder.Entity("Headhunter.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nur-Sultan"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Almaty"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Karaganda"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Aktau"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Atyrau"
                        });
                });

            modelBuilder.Entity("Headhunter.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("NotificationText");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Headhunter.Models.Resume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AbleToRelocate");

                    b.Property<string>("AvatarUrl");

                    b.Property<int?>("CityId");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("Description");

                    b.Property<string>("DesiredPosition");

                    b.Property<int>("DesiredSalary");

                    b.Property<bool>("HasExperience");

                    b.Property<string>("HighEducations");

                    b.Property<string>("LanguagesKnowlegde");

                    b.Property<string>("LearnedCourses");

                    b.Property<int?>("OwnerId");

                    b.Property<string>("Skills");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("Headhunter.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarSrc");

                    b.Property<int>("BirthYear");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthYear = 2001,
                            CreatedTime = new DateTime(2019, 9, 8, 17, 10, 50, 322, DateTimeKind.Local).AddTicks(8730),
                            Email = "admin@admin.kz",
                            FullName = "Administrator Adminovich",
                            Login = "admin",
                            Password = "admin"
                        },
                        new
                        {
                            Id = 2,
                            BirthYear = 2001,
                            CreatedTime = new DateTime(2019, 9, 8, 17, 10, 50, 322, DateTimeKind.Local).AddTicks(9379),
                            Email = "alibi@mail.ru",
                            FullName = "Алиби Ерланович",
                            Login = "alibi",
                            Password = "mypass123"
                        },
                        new
                        {
                            Id = 3,
                            BirthYear = 1960,
                            CreatedTime = new DateTime(2019, 9, 8, 17, 10, 50, 322, DateTimeKind.Local).AddTicks(9385),
                            Email = "ivann@gmail.com",
                            FullName = "Иван Михалыч",
                            Login = "ivan",
                            Password = "yaivan777"
                        });
                });

            modelBuilder.Entity("Headhunter.Models.Vacancy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyAddress");

                    b.Property<string>("CompanyName");

                    b.Property<string>("Conditions");

                    b.Property<DateTime?>("CreatedTime");

                    b.Property<string>("Duties");

                    b.Property<int>("OwnerId");

                    b.Property<int>("Salary");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Vacancies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyAddress = "Сейфуллина 40",
                            CompanyName = "CopyWrite",
                            Conditions = "5/2, стабильная зарплата",
                            CreatedTime = new DateTime(2019, 9, 8, 17, 10, 50, 321, DateTimeKind.Local).AddTicks(7436),
                            Duties = "Набирать текст",
                            OwnerId = 1,
                            Salary = 150000,
                            Title = "Копирайтер"
                        });
                });

            modelBuilder.Entity("Headhunter.Models.Resume", b =>
                {
                    b.HasOne("Headhunter.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Headhunter.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}
