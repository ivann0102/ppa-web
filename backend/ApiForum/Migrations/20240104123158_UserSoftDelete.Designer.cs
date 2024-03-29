﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Repository_CodeFirst;

#nullable disable

namespace ApiForum.Migrations
{
    [DbContext(typeof(ForumContext))]
    [Migration("20240104123158_UserSoftDelete")]
    partial class UserSoftDelete
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LibrarieModele.AuthType", b =>
                {
                    b.Property<int>("AuthTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AuthTypeId"));

                    b.Property<string>("AuthTypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Limitation")
                        .HasColumnType("integer");

                    b.HasKey("AuthTypeId");

                    b.ToTable("AuthTypes");

                    b.HasData(
                        new
                        {
                            AuthTypeId = 1,
                            AuthTypeName = "Guest",
                            Limitation = 1
                        },
                        new
                        {
                            AuthTypeId = 2,
                            AuthTypeName = "Registered",
                            Limitation = 3
                        },
                        new
                        {
                            AuthTypeId = 3,
                            AuthTypeName = "EmailVerified",
                            Limitation = 5
                        });
                });

            modelBuilder.Entity("LibrarieModele.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PostId"));

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ParentPostId")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("PostDate")
                        .HasColumnType("date");

                    b.Property<string>("PostText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TopicId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("PostId");

                    b.HasIndex("ParentPostId");

                    b.HasIndex("TopicId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            Heading = "Heading1",
                            PostDate = new DateOnly(2023, 11, 15),
                            PostText = "Content1",
                            TopicId = 1,
                            UserId = 1
                        },
                        new
                        {
                            PostId = 2,
                            Heading = "Heading2",
                            PostDate = new DateOnly(2023, 11, 15),
                            PostText = "Content2",
                            TopicId = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("LibrarieModele.PostImage", b =>
                {
                    b.Property<int>("PostImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PostImageId"));

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PostId")
                        .HasColumnType("integer");

                    b.HasKey("PostImageId");

                    b.HasIndex("PostId");

                    b.ToTable("PostImages");
                });

            modelBuilder.Entity("LibrarieModele.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "User"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "Admin"
                        });
                });

            modelBuilder.Entity("LibrarieModele.Topic", b =>
                {
                    b.Property<int>("TopicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TopicId"));

                    b.Property<string>("TopicName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TopicId");

                    b.ToTable("Topics");

                    b.HasData(
                        new
                        {
                            TopicId = 1,
                            TopicName = "News"
                        },
                        new
                        {
                            TopicId = 2,
                            TopicName = "Entertainment"
                        });
                });

            modelBuilder.Entity("LibrarieModele.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<int>("AuthTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("ImageLink")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.HasIndex("AuthTypeId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            AuthTypeId = 2,
                            Email = "user1@gmail.com",
                            ImageLink = "some image",
                            IsDeleted = false,
                            PasswordHash = "hash",
                            RoleId = 1,
                            UserName = "User1"
                        },
                        new
                        {
                            UserId = 2,
                            AuthTypeId = 2,
                            Email = "user2@gmail.com",
                            ImageLink = "some image",
                            IsDeleted = false,
                            PasswordHash = "hash",
                            RoleId = 1,
                            UserName = "User2"
                        });
                });

            modelBuilder.Entity("LibrarieModele.Post", b =>
                {
                    b.HasOne("LibrarieModele.Post", "ParentPost")
                        .WithMany("ChildPosts")
                        .HasForeignKey("ParentPostId");

                    b.HasOne("LibrarieModele.Topic", "Topic")
                        .WithMany("Posts")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibrarieModele.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentPost");

                    b.Navigation("Topic");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LibrarieModele.PostImage", b =>
                {
                    b.HasOne("LibrarieModele.Post", "Post")
                        .WithMany("PostImages")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });

            modelBuilder.Entity("LibrarieModele.User", b =>
                {
                    b.HasOne("LibrarieModele.AuthType", "AuthType")
                        .WithMany("Users")
                        .HasForeignKey("AuthTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibrarieModele.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AuthType");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("LibrarieModele.AuthType", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("LibrarieModele.Post", b =>
                {
                    b.Navigation("ChildPosts");

                    b.Navigation("PostImages");
                });

            modelBuilder.Entity("LibrarieModele.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("LibrarieModele.Topic", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("LibrarieModele.User", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
