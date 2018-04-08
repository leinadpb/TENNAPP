﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TennApp.Data;

namespace TennApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180407143442_CategoryTypeNotRequiredInCategory")]
    partial class CategoryTypeNotRequiredInCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TennApp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TennApp.Models.Bill", b =>
                {
                    b.Property<int>("BillID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryID");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<double>("Mount");

                    b.Property<int>("PaymentMethodID");

                    b.Property<int>("PersonID");

                    b.HasKey("BillID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("PersonID");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("TennApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(80);

                    b.Property<int>("MaxAge");

                    b.Property<int>("MinAge");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("TennApp.Models.CategoryType", b =>
                {
                    b.Property<int>("CategoryTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<string>("Name")
                        .HasMaxLength(5);

                    b.HasKey("CategoryTypeID");

                    b.HasIndex("CategoryID")
                        .IsUnique();

                    b.ToTable("CategoryTypes");
                });

            modelBuilder.Entity("TennApp.Models.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BillID");

                    b.Property<string>("Name");

                    b.HasKey("PaymentMethodID");

                    b.HasIndex("BillID")
                        .IsUnique();

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("TennApp.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Account")
                        .HasMaxLength(20);

                    b.Property<int>("Age");

                    b.Property<string>("Biography")
                        .HasMaxLength(80);

                    b.Property<int>("CategoryID");

                    b.Property<bool>("Confirmed");

                    b.Property<string>("Email")
                        .HasMaxLength(70);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Nickname")
                        .HasMaxLength(30);

                    b.Property<bool>("Payment");

                    b.Property<string>("Phone")
                        .HasMaxLength(13);

                    b.Property<string>("SecondLastName")
                        .HasMaxLength(30);

                    b.Property<string>("SecondName")
                        .HasMaxLength(30);

                    b.Property<int>("TShirtID");

                    b.Property<int>("TourneyID");

                    b.HasKey("PersonID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("TShirtID");

                    b.HasIndex("TourneyID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("TennApp.Models.ReportType", b =>
                {
                    b.Property<int>("ReportTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(45);

                    b.Property<string>("ReferenceCode")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.HasKey("ReportTypeID");

                    b.ToTable("ReportTypes");
                });

            modelBuilder.Entity("TennApp.Models.Tourney", b =>
                {
                    b.Property<int>("TourneyID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(120);

                    b.Property<string>("FechaFin")
                        .IsRequired();

                    b.Property<string>("FechaInicio")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("TourneyID");

                    b.ToTable("Tourneys");
                });

            modelBuilder.Entity("TennApp.Models.TShirt", b =>
                {
                    b.Property<int>("TShirtID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(7);

                    b.HasKey("TShirtID");

                    b.ToTable("TShirts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TennApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TennApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TennApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TennApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TennApp.Models.Bill", b =>
                {
                    b.HasOne("TennApp.Models.Category")
                        .WithMany("Bills")
                        .HasForeignKey("CategoryID");

                    b.HasOne("TennApp.Models.Person", "Person")
                        .WithMany("Bills")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TennApp.Models.CategoryType", b =>
                {
                    b.HasOne("TennApp.Models.Category", "Category")
                        .WithOne("Type")
                        .HasForeignKey("TennApp.Models.CategoryType", "CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TennApp.Models.PaymentMethod", b =>
                {
                    b.HasOne("TennApp.Models.Bill", "Bill")
                        .WithOne("PaymentMethod")
                        .HasForeignKey("TennApp.Models.PaymentMethod", "BillID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TennApp.Models.Person", b =>
                {
                    b.HasOne("TennApp.Models.Category", "Category")
                        .WithMany("Persons")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TennApp.Models.TShirt", "TShirt")
                        .WithMany("Persons")
                        .HasForeignKey("TShirtID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TennApp.Models.Tourney", "Tourney")
                        .WithMany("Persons")
                        .HasForeignKey("TourneyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
