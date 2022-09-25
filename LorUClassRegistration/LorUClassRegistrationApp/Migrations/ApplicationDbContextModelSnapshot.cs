﻿// <auto-generated />
using System;
using LorUClassRegistrationApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LorUClassRegistrationApp.Migrations
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

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Admin", b =>
                {
                    b.Property<int>("adminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("adminId"), 1L, 1);

                    b.Property<int>("bannerFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateStarted")
                        .HasColumnType("datetime2");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("yearsWorked")
                        .HasColumnType("int");

                    b.HasKey("adminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Class", b =>
                {
                    b.Property<int>("classId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("classId"), 1L, 1);

                    b.Property<string>("classDays")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("classTime")
                        .HasColumnType("time");

                    b.Property<string>("courseTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("creditHours")
                        .HasColumnType("float");

                    b.Property<int>("departmentFk")
                        .HasColumnType("int");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.Property<int>("preReqs")
                        .HasColumnType("int");

                    b.Property<int>("section")
                        .HasColumnType("int");

                    b.HasKey("classId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Department", b =>
                {
                    b.Property<int>("deptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("deptId"), 1L, 1);

                    b.Property<string>("departmentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("deptId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.HumanBeing", b =>
                {
                    b.Property<int>("storedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("storedId"), 1L, 1);

                    b.Property<string>("actualName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("bannerId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("isHyperAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("isLor")
                        .HasColumnType("bit");

                    b.Property<bool>("isStudent")
                        .HasColumnType("bit");

                    b.Property<bool>("isTeacher")
                        .HasColumnType("bit");

                    b.Property<string>("legalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("storedId");

                    b.ToTable("HumanBeings");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Lor", b =>
                {
                    b.Property<int>("lorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("lorId"), 1L, 1);

                    b.Property<int>("bannerFk")
                        .HasColumnType("int");

                    b.HasKey("lorId");

                    b.ToTable("Lors");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Student", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("studentId"), 1L, 1);

                    b.Property<int>("bannerFk")
                        .HasColumnType("int");

                    b.Property<int>("creditsCompleted")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateStarted")
                        .HasColumnType("datetime2");

                    b.Property<string>("major")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("maxCredits")
                        .HasColumnType("int");

                    b.Property<string>("minor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("projectedGraduation")
                        .HasColumnType("datetime2");

                    b.Property<int>("semestersCompleted")
                        .HasColumnType("int");

                    b.HasKey("studentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Teacher", b =>
                {
                    b.Property<int>("teacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("teacherId"), 1L, 1);

                    b.Property<int>("bannerFk")
                        .HasColumnType("int");

                    b.Property<int>("classQty")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateStarted")
                        .HasColumnType("datetime2");

                    b.Property<int>("deptFk")
                        .HasColumnType("int");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("yearsWorked")
                        .HasColumnType("int");

                    b.HasKey("teacherId");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
