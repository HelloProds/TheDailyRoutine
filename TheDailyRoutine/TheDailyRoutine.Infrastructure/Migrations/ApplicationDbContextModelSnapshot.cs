﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheDailyRoutine.Infrastructure.Data;

#nullable disable

namespace TheDailyRoutine.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.Completion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CompletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("UserHabitHabitId")
                        .HasColumnType("int");

                    b.Property<int>("UserHabitId")
                        .HasColumnType("int");

                    b.Property<string>("UserHabitUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserHabitUserId", "UserHabitHabitId");

                    b.ToTable("Completions");
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.Habit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("Predefined")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Habits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Пий 8 чаши вода на ден",
                            Predefined = true,
                            Title = "Хидратация"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Тренирай 30 минути",
                            Predefined = true,
                            Title = "Физическа активност"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Спи поне 7 часа",
                            Predefined = true,
                            Title = "Сън"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Измий зъбите си два пъти дневно",
                            Predefined = true,
                            Title = "Хигиена"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Яж три пъти на ден",
                            Predefined = true,
                            Title = "Балансирани хранения"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Яж поне 5 порции плодове и зеленчуци",
                            Predefined = true,
                            Title = "Консумация на плодове и зеленчуци"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Избягвай сладки изделия",
                            Predefined = true,
                            Title = "Ограничаване на захарта"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Направи дневен план сутринта",
                            Predefined = true,
                            Title = "Планиране на деня "
                        },
                        new
                        {
                            Id = 9,
                            Description = "Завърши 3 важни задачи за деня",
                            Predefined = true,
                            Title = "Изпълнение на задачи"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Обобщи успехите си вечерта",
                            Predefined = true,
                            Title = "Преглед на постигнатото"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Медитирай 10 минути",
                            Predefined = true,
                            Title = "Медитация"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Запиши 3 неща, за които си благодарен",
                            Predefined = true,
                            Title = "Дневник на благодарностите"
                        },
                        new
                        {
                            Id = 13,
                            Description = "30 минути без устройства",
                            Predefined = true,
                            Title = "Почивка от технологии"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Обади се на приятел или роднина",
                            Predefined = true,
                            Title = "Свързване с близки"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Направи нещо добро за друг човек",
                            Predefined = true,
                            Title = "Доброта"
                        },
                        new
                        {
                            Id = 16,
                            Description = "Прочети поне 10 страници книга",
                            Predefined = true,
                            Title = "Четене"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Научи нещо ново",
                            Predefined = true,
                            Title = "Ново умение"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Гледай урок или лекция",
                            Predefined = true,
                            Title = "Онлайн курсове"
                        },
                        new
                        {
                            Id = 19,
                            Description = "Подреди стаята си",
                            Predefined = true,
                            Title = "Почистване"
                        },
                        new
                        {
                            Id = 20,
                            Description = "Приготви домашна храна",
                            Predefined = true,
                            Title = "Готвене"
                        });
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<bool>("Mailable")
                        .HasColumnType("bit");

                    b.Property<string>("RelatedEntityId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelatedEntityType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("SentAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.UserHabit", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("HabitId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Frequency")
                        .HasColumnType("int");

                    b.HasKey("UserId", "HabitId");

                    b.HasIndex("HabitId");

                    b.ToTable("UsersHabits");
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.UserNotification", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("NotificationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EmailedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsEmailed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsRead")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("ReadAt")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "NotificationId");

                    b.HasIndex("NotificationId");

                    b.ToTable("UsersNotifications");
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.UserNotificationPreferences", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("AchievementNotificationsEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<bool>("DailyReminderEnabled")
                        .HasColumnType("bit");

                    b.Property<TimeSpan?>("DailyReminderTime")
                        .HasColumnType("time");

                    b.Property<bool>("EmailNotificationsEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("StreakMilestoneNotificationsEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("WeeklySummaryDay")
                        .HasColumnType("int");

                    b.Property<bool>("WeeklySummaryEnabled")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("UserNotificationPreferences");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TheDailyRoutine.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TheDailyRoutine.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheDailyRoutine.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TheDailyRoutine.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.Completion", b =>
                {
                    b.HasOne("TheDailyRoutine.Infrastructure.Data.Models.UserHabit", "UserHabit")
                        .WithMany("Completions")
                        .HasForeignKey("UserHabitUserId", "UserHabitHabitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UserHabit");
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.UserHabit", b =>
                {
                    b.HasOne("TheDailyRoutine.Infrastructure.Data.Models.Habit", "Habit")
                        .WithMany("UsersHabits")
                        .HasForeignKey("HabitId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TheDailyRoutine.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habit");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.UserNotification", b =>
                {
                    b.HasOne("TheDailyRoutine.Infrastructure.Data.Models.Notification", "Notification")
                        .WithMany("UserNotifications")
                        .HasForeignKey("NotificationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TheDailyRoutine.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Notification");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.UserNotificationPreferences", b =>
                {
                    b.HasOne("TheDailyRoutine.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithOne("NotificationPreferences")
                        .HasForeignKey("TheDailyRoutine.Infrastructure.Data.Models.UserNotificationPreferences", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("NotificationPreferences")
                        .IsRequired();
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.Habit", b =>
                {
                    b.Navigation("UsersHabits");
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.Notification", b =>
                {
                    b.Navigation("UserNotifications");
                });

            modelBuilder.Entity("TheDailyRoutine.Infrastructure.Data.Models.UserHabit", b =>
                {
                    b.Navigation("Completions");
                });
#pragma warning restore 612, 618
        }
    }
}
