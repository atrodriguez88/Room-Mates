﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Room_Mates.Persistent;
using System;

namespace RoomMates.Migrations
{
    [DbContext(typeof(RoomDbContext))]
    partial class RoomDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
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

            modelBuilder.Entity("Room_Mates.Core.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("AdDescription")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("AdTitle")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<bool>("NotificationViaEmail");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("ShowPhone");

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

            modelBuilder.Entity("Room_Mates.Core.Models.Ocupation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Ocupations");
                });

            modelBuilder.Entity("Room_Mates.Core.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("Age");

                    b.Property<string>("Comentarios");

                    b.Property<string>("Gender");

                    b.Property<string>("MaxRentMonth")
                        .IsRequired();

                    b.Property<DateTime>("MovingDate");

                    b.Property<int>("OcupationId");

                    b.Property<int>("UserId");

                    b.Property<string>("UserId1");

                    b.HasKey("Id");

                    b.HasIndex("OcupationId");

                    b.HasIndex("UserId1");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Room_Mates.Core.Models.PropertyFeatures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PropertyFeatures");
                });

            modelBuilder.Entity("Room_Mates.Core.Models.PropertyRules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PropertyRules");
                });

            modelBuilder.Entity("Room_Mates.Core.Models.PropertyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PropertyTypes");
                });

            modelBuilder.Entity("Room_Mates.Core.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("AvailableFrom");

                    b.Property<string>("Cleanliness");

                    b.Property<bool>("IsFurnished");

                    b.Property<bool>("IsUtilityIncluded");

                    b.Property<int>("MinStayMonths");

                    b.Property<int>("NumberBathrooms");

                    b.Property<int>("NumberBedrooms");

                    b.Property<int>("NumberRoomatesAlready");

                    b.Property<int>("OcupationId");

                    b.Property<string>("Pet");

                    b.Property<string>("PrefGender");

                    b.Property<int>("PrefMaxAge");

                    b.Property<int>("PrefMinAge");

                    b.Property<int>("PropertyId");

                    b.Property<int?>("PropertyTypeId");

                    b.Property<float>("RentPerMonth");

                    b.Property<float>("RoomSquareMeters");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("RoomsToRent");

                    b.Property<string>("Smoking");

                    b.Property<int>("UserId");

                    b.Property<string>("UserId1");

                    b.HasKey("Id");

                    b.HasIndex("OcupationId");

                    b.HasIndex("PropertyTypeId");

                    b.HasIndex("UserId1");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Room_Mates.Core.Models.RoomFeatures", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("RoomFeatures");
                });

            modelBuilder.Entity("Room_Mates.Core.Models.RoomRoomFeatures", b =>
                {
                    b.Property<int>("RoomId");

                    b.Property<int>("RoomFeaturesId");

                    b.HasKey("RoomId", "RoomFeaturesId");

                    b.HasIndex("RoomFeaturesId");

                    b.ToTable("RoomRoomFeatures");
                });

            modelBuilder.Entity("Room_Mates.Core.Models.RoomsPropertyFeatures", b =>
                {
                    b.Property<int>("RoomId");

                    b.Property<int>("PropertyFeaturesId");

                    b.HasKey("RoomId", "PropertyFeaturesId");

                    b.HasIndex("PropertyFeaturesId");

                    b.ToTable("RoomsPropertyFeatures");
                });

            modelBuilder.Entity("Room_Mates.Core.Models.RoomsPropertyRules", b =>
                {
                    b.Property<int>("RoomId");

                    b.Property<int>("PropertyRulesId");

                    b.HasKey("RoomId", "PropertyRulesId");

                    b.HasIndex("PropertyRulesId");

                    b.ToTable("RoomsPropertyRules");
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
                    b.HasOne("Room_Mates.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Room_Mates.Core.Models.ApplicationUser")
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

                    b.HasOne("Room_Mates.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Room_Mates.Core.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Room_Mates.Core.Models.Profile", b =>
                {
                    b.HasOne("Room_Mates.Core.Models.Ocupation", "Ocupation")
                        .WithMany()
                        .HasForeignKey("OcupationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Room_Mates.Core.Models.ApplicationUser", "User")
                        .WithMany("Profiles")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("Room_Mates.Core.Models.Room", b =>
                {
                    b.HasOne("Room_Mates.Core.Models.Ocupation", "PrefOcuppations")
                        .WithMany()
                        .HasForeignKey("OcupationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Room_Mates.Core.Models.PropertyType", "PropertyType")
                        .WithMany()
                        .HasForeignKey("PropertyTypeId");

                    b.HasOne("Room_Mates.Core.Models.ApplicationUser", "User")
                        .WithMany("Rooms")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("Room_Mates.Core.Models.RoomRoomFeatures", b =>
                {
                    b.HasOne("Room_Mates.Core.Models.RoomFeatures", "RoomFeatures")
                        .WithMany("Room")
                        .HasForeignKey("RoomFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Room_Mates.Core.Models.Room", "Room")
                        .WithMany("RoomFeatures")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Room_Mates.Core.Models.RoomsPropertyFeatures", b =>
                {
                    b.HasOne("Room_Mates.Core.Models.PropertyFeatures", "PropertyFeatures")
                        .WithMany("Rooms")
                        .HasForeignKey("PropertyFeaturesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Room_Mates.Core.Models.Room", "Room")
                        .WithMany("PropertyFeatures")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Room_Mates.Core.Models.RoomsPropertyRules", b =>
                {
                    b.HasOne("Room_Mates.Core.Models.PropertyRules", "PropertyRules")
                        .WithMany("Rooms")
                        .HasForeignKey("PropertyRulesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Room_Mates.Core.Models.Room", "Room")
                        .WithMany("Rules")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
