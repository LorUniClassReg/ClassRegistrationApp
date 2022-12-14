// <auto-generated />
using System;
using LorUClassRegistrationApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LorUClassRegistrationApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220926032244_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("AdminInstancestoredId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateStarted")
                        .HasColumnType("datetime2");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("storedId")
                        .HasColumnType("int");

                    b.Property<int>("yearsWorked")
                        .HasColumnType("int");

                    b.HasKey("adminId");

                    b.HasIndex("AdminInstancestoredId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Class", b =>
                {
                    b.Property<int>("classId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("classId"), 1L, 1);

                    b.Property<int>("Dept")
                        .HasColumnType("int");

                    b.Property<int?>("PreReqsclassId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherstoredId")
                        .HasColumnType("int");

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

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.Property<int?>("preReqId")
                        .HasColumnType("int");

                    b.Property<int>("section")
                        .HasColumnType("int");

                    b.Property<int>("storedId")
                        .HasColumnType("int");

                    b.Property<int?>("studentId")
                        .HasColumnType("int");

                    b.HasKey("classId");

                    b.HasIndex("PreReqsclassId");

                    b.HasIndex("TeacherstoredId");

                    b.HasIndex("studentId");

                    b.ToTable("Classes");
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

                    b.Property<int>("LorInTheFleshstoredId")
                        .HasColumnType("int");

                    b.Property<int>("storedId")
                        .HasColumnType("int");

                    b.HasKey("lorId");

                    b.HasIndex("LorInTheFleshstoredId");

                    b.ToTable("Lors");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Student", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("studentId"), 1L, 1);

                    b.Property<int>("StudentInstancestoredId")
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

                    b.Property<int>("storedId")
                        .HasColumnType("int");

                    b.HasKey("studentId");

                    b.HasIndex("StudentInstancestoredId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Teacher", b =>
                {
                    b.Property<int>("teacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("teacherId"), 1L, 1);

                    b.Property<int>("Dept")
                        .HasColumnType("int");

                    b.Property<int>("TeacherInstancestoredId")
                        .HasColumnType("int");

                    b.Property<int>("classQty")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateStarted")
                        .HasColumnType("datetime2");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("storedId")
                        .HasColumnType("int");

                    b.Property<int>("yearsWorked")
                        .HasColumnType("int");

                    b.HasKey("teacherId");

                    b.HasIndex("TeacherInstancestoredId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Admin", b =>
                {
                    b.HasOne("LorUClassRegistrationApp.Models.HumanBeing", "AdminInstance")
                        .WithMany()
                        .HasForeignKey("AdminInstancestoredId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdminInstance");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Class", b =>
                {
                    b.HasOne("LorUClassRegistrationApp.Models.Class", "PreReqs")
                        .WithMany()
                        .HasForeignKey("PreReqsclassId");

                    b.HasOne("LorUClassRegistrationApp.Models.HumanBeing", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherstoredId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LorUClassRegistrationApp.Models.Student", null)
                        .WithMany("classList")
                        .HasForeignKey("studentId");

                    b.Navigation("PreReqs");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Lor", b =>
                {
                    b.HasOne("LorUClassRegistrationApp.Models.HumanBeing", "LorInTheFlesh")
                        .WithMany()
                        .HasForeignKey("LorInTheFleshstoredId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LorInTheFlesh");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Student", b =>
                {
                    b.HasOne("LorUClassRegistrationApp.Models.HumanBeing", "StudentInstance")
                        .WithMany()
                        .HasForeignKey("StudentInstancestoredId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentInstance");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Teacher", b =>
                {
                    b.HasOne("LorUClassRegistrationApp.Models.HumanBeing", "TeacherInstance")
                        .WithMany()
                        .HasForeignKey("TeacherInstancestoredId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeacherInstance");
                });

            modelBuilder.Entity("LorUClassRegistrationApp.Models.Student", b =>
                {
                    b.Navigation("classList");
                });
#pragma warning restore 612, 618
        }
    }
}
