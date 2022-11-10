﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YachtWorld.Infrastructure.Data;

#nullable disable

namespace YachtWorld.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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

                    b.HasData(
                        new
                        {
                            Id = "dea12856-c198-4129-b3f3-b893d8395082",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9ea0b979-1f0d-4101-aba0-523b24170d8e",
                            Email = "yachtBroker@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "YACHTBROKER@MAIL.COM",
                            NormalizedUserName = "YACHTBROKER@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENcJJXhW4FrjVE76XX9i0C0Dby/IVhxtZn5ZWWbq+yBxwf4wOxnX4p6CQ4IaiQoNug==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "02059a6b-9e9c-44a9-816d-4c44d9ba1f89",
                            TwoFactorEnabled = false,
                            UserName = "yachtBroker@mail.com"
                        },
                        new
                        {
                            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "760ebcb4-a35a-4333-b893-49836af02b2d",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "GUEST@MAIL.COM",
                            NormalizedUserName = "GUEST@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKyuXp7fm8sCZOKdyQ+LAOlpSujmhcvovqQscdjW3+hcbaEM6ajeHvLFJ5ld/K10YQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "97b05428-186f-4801-989e-81cc3cc36415",
                            TwoFactorEnabled = false,
                            UserName = "guest@mail.com"
                        });
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("YachtWorld.Infrastructure.Data.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Green-Yachts"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Yacht-With-Captain"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Explorer"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Large"
                        });
                });

            modelBuilder.Entity("YachtWorld.Infrastructure.Data.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MainAttraction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("YachtId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YachtId");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("YachtWorld.Infrastructure.Data.Shipyard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("EstablishedIn")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Shipyards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EstablishedIn = 1980,
                            Location = "New Zealand",
                            Name = "Alloy Yachts"
                        },
                        new
                        {
                            Id = 2,
                            EstablishedIn = 1918,
                            Location = "Germany",
                            Name = "Amels Yachts"
                        },
                        new
                        {
                            Id = 3,
                            EstablishedIn = 1969,
                            Location = "Italy",
                            Name = "Azimut Yachts"
                        },
                        new
                        {
                            Id = 4,
                            EstablishedIn = 1854,
                            Location = "Port of Genova",
                            Name = "Baglietto"
                        },
                        new
                        {
                            Id = 5,
                            EstablishedIn = 1873,
                            Location = "Italy",
                            Name = "Benetti Yachts"
                        },
                        new
                        {
                            Id = 6,
                            EstablishedIn = 1863,
                            Location = "USA",
                            Name = "Burger"
                        },
                        new
                        {
                            Id = 7,
                            Location = "Vancouver Washington",
                            Name = "Cristensen Yachts"
                        },
                        new
                        {
                            Id = 8,
                            EstablishedIn = 1825,
                            Location = "Italy",
                            Name = "Codecasa Yachts"
                        },
                        new
                        {
                            Id = 9,
                            EstablishedIn = 1919,
                            Location = "Holland",
                            Name = "Hakvoort Yachts"
                        },
                        new
                        {
                            Id = 10,
                            EstablishedIn = 1960,
                            Location = "Brazil",
                            Name = "Inace"
                        });
                });

            modelBuilder.Entity("YachtWorld.Infrastructure.Data.Yacht", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CrewMembers")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Engines")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Generators")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Guests")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Length")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaxSpeed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PriceForRent")
                        .HasPrecision(18, 2)
                        .HasColumnType("money");

                    b.Property<string>("SailorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ShipyardId")
                        .HasColumnType("int");

                    b.Property<int>("StateRooms")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("YachtBrokerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SailorId");

                    b.HasIndex("ShipyardId");

                    b.HasIndex("YachtBrokerId");

                    b.ToTable("Yachts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CrewMembers = 33,
                            Description = "Delivered in 2020 and one of the finest jewels delivered\r\nby Benetti, 107m / 351' Frodo is a charter yacht of\r\nchoice in the 100m+/300'+ range. Built and designed by\r\nBenetti to discover every corner of the world, her striking\r\nlines are matched with an unrivaled level of luxury on all\r\ndecks.\r\nPowered by an unusual Rolls-Royce hybrid-electric\r\npropulsion, Frodo ensures wonderful fuel efficiency and a\r\nlong cruising range, making her eco-friendly with a\r\ncruising speed of 16 knots, and 18.5 knots top speed.",
                            Generators = "3 X Caterpillar",
                            Guests = 12,
                            ImageUrl = "C:\\Users\\Genko\\source\\repos\\YachtWorld\\YachtWorld\\wwwroot\\yachtImages\\Frodo.jpg",
                            Length = "107 Metres",
                            MaxSpeed = "18.5 Knots",
                            PriceForRent = 1800000.00m,
                            SailorId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            ShipyardId = 1,
                            StateRooms = 8,
                            Title = "Frodo",
                            YachtBrokerId = 1
                        });
                });

            modelBuilder.Entity("YachtWorld.Infrastructure.Data.YachtBroker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("YachtBrokers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PhoneNumber = "+359888888888",
                            UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("YachtWorld.Infrastructure.Data.Destination", b =>
                {
                    b.HasOne("YachtWorld.Infrastructure.Data.Yacht", "Yacht")
                        .WithMany("Destinations")
                        .HasForeignKey("YachtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yacht");
                });

            modelBuilder.Entity("YachtWorld.Infrastructure.Data.Yacht", b =>
                {
                    b.HasOne("YachtWorld.Infrastructure.Data.Category", "Category")
                        .WithMany("Yachts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Sailor")
                        .WithMany()
                        .HasForeignKey("SailorId");

                    b.HasOne("YachtWorld.Infrastructure.Data.Shipyard", "Shipyard")
                        .WithMany("Yachts")
                        .HasForeignKey("ShipyardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YachtWorld.Infrastructure.Data.YachtBroker", "YachtBroker")
                        .WithMany()
                        .HasForeignKey("YachtBrokerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Sailor");

                    b.Navigation("Shipyard");

                    b.Navigation("YachtBroker");
                });

            modelBuilder.Entity("YachtWorld.Infrastructure.Data.YachtBroker", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("YachtWorld.Infrastructure.Data.Category", b =>
                {
                    b.Navigation("Yachts");
                });

            modelBuilder.Entity("YachtWorld.Infrastructure.Data.Shipyard", b =>
                {
                    b.Navigation("Yachts");
                });

            modelBuilder.Entity("YachtWorld.Infrastructure.Data.Yacht", b =>
                {
                    b.Navigation("Destinations");
                });
#pragma warning restore 612, 618
        }
    }
}
