﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsAffaires.DbContexts;

#nullable disable

namespace StudentsAffaires.Migrations
{
    [DbContext(typeof(UserDbContext))]
    partial class UserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentsAffaires.Models.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsGraded")
                        .HasColumnType("bit");

                    b.Property<decimal>("MaxScore")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Assignment");
                });

            modelBuilder.Entity("StudentsAffaires.Models.AssignmentSubmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Score")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubmissionContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SubmittedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("StudentId");

                    b.ToTable("AssignmentSubmission");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan?>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Level")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TutorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TutorId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDownloadable")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UploadedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsImportant")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LessonId")
                        .HasColumnType("int");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int?>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("Priority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("Todo");
                });

            modelBuilder.Entity("StudentsAffaires.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("UserType").HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("StudentsAffaires.Models.Admin", b =>
                {
                    b.HasBaseType("StudentsAffaires.Models.User");

                    b.Property<string>("AdminRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Permissions")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Student", b =>
                {
                    b.HasBaseType("StudentsAffaires.Models.User");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("GraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.Property<Guid?>("TutorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("MaterialId");

                    b.HasIndex("TutorId");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Tutor", b =>
                {
                    b.HasBaseType("StudentsAffaires.Models.User");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Tutor");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Assignment", b =>
                {
                    b.HasOne("StudentsAffaires.Models.Course", "Course")
                        .WithMany("Assignments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentsAffaires.Models.AssignmentSubmission", b =>
                {
                    b.HasOne("StudentsAffaires.Models.Assignment", "Assignment")
                        .WithMany("Submissions")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentsAffaires.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Course", b =>
                {
                    b.HasOne("StudentsAffaires.Models.Student", null)
                        .WithMany("Courses")
                        .HasForeignKey("StudentId");

                    b.HasOne("StudentsAffaires.Models.Tutor", null)
                        .WithMany("Courses")
                        .HasForeignKey("TutorId");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Material", b =>
                {
                    b.HasOne("StudentsAffaires.Models.Course", "Course")
                        .WithMany("Materials")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Note", b =>
                {
                    b.HasOne("StudentsAffaires.Models.Student", null)
                        .WithMany("Notes")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Todo", b =>
                {
                    b.HasOne("StudentsAffaires.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("StudentsAffaires.Models.Student", "Student")
                        .WithMany("Todos")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Student", b =>
                {
                    b.HasOne("StudentsAffaires.Models.Material", null)
                        .WithMany("Students")
                        .HasForeignKey("MaterialId");

                    b.HasOne("StudentsAffaires.Models.Tutor", null)
                        .WithMany("Students")
                        .HasForeignKey("TutorId");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Assignment", b =>
                {
                    b.Navigation("Submissions");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Course", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Materials");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Material", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Student", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Notes");

                    b.Navigation("Todos");
                });

            modelBuilder.Entity("StudentsAffaires.Models.Tutor", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
