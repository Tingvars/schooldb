﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolDB.Data;

#nullable disable

namespace SchoolDB.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20221024113742_MarkSubject")]
    partial class MarkSubject
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolDB.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("SchoolDB.Models.Mark", b =>
                {
                    b.Property<int>("MarkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarkId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Marks")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("MarkId");

                    b.ToTable("Marks");
                });

            modelBuilder.Entity("SchoolDB.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolDB.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SchoolDB.Models.SubjectTeacher", b =>
                {
                    b.Property<int>("SubjectTeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectTeacherId"), 1L, 1);

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("SubjectTeacherId");

                    b.ToTable("SubjectTeachers");
                });

            modelBuilder.Entity("SchoolDB.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
