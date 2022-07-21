﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using University;

#nullable disable

namespace University.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DisciplineStudent", b =>
                {
                    b.Property<int>("DisciplinesId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.HasKey("DisciplinesId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("DisciplineStudent");
                });

            modelBuilder.Entity("ParentStudent", b =>
                {
                    b.Property<int>("ChildrenId")
                        .HasColumnType("int");

                    b.Property<int>("ParentsId")
                        .HasColumnType("int");

                    b.HasKey("ChildrenId", "ParentsId");

                    b.HasIndex("ParentsId");

                    b.ToTable("ParentStudent");
                });

            modelBuilder.Entity("University.Tables.AcademicDegree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AcademicDegrees");
                });

            modelBuilder.Entity("University.Tables.Block", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BlockTypeId")
                        .HasColumnType("int");

                    b.Property<int>("DormitoryId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BlockTypeId");

                    b.HasIndex("DormitoryId");

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("University.Tables.BlockType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AmountOfSeats")
                        .HasColumnType("int");

                    b.Property<int>("ChairsAmount")
                        .HasColumnType("int");

                    b.Property<int>("TablesAmount")
                        .HasColumnType("int");

                    b.Property<int>("WardrobesAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("BlockTypes");
                });

            modelBuilder.Entity("University.Tables.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("University.Tables.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("University.Tables.Dormitory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dormitories");
                });

            modelBuilder.Entity("University.Tables.EducationForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EducationForms");
                });

            modelBuilder.Entity("University.Tables.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("University.Tables.Group", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("University.Tables.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("University.Tables.Scholarship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("ScholarshipAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Scholarships");
                });

            modelBuilder.Entity("University.Tables.Specialization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("University.Tables.Employee", b =>
                {
                    b.HasBaseType("University.Tables.Person");

                    b.Property<int>("AcademicDegreeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasIndex("AcademicDegreeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("University.Tables.Parent", b =>
                {
                    b.HasBaseType("University.Tables.Person");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("University.Tables.Student", b =>
                {
                    b.HasBaseType("University.Tables.Person");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("BlockId")
                        .HasColumnType("int");

                    b.Property<int>("DormitoryId")
                        .HasColumnType("int");

                    b.Property<int>("EducationalFormId")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("IsMarried")
                        .HasColumnType("bit");

                    b.Property<int>("ScholarshipId")
                        .HasColumnType("int");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("int");

                    b.HasIndex("BlockId");

                    b.HasIndex("DormitoryId");

                    b.HasIndex("EducationalFormId");

                    b.HasIndex("GroupName");

                    b.HasIndex("ScholarshipId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DisciplineStudent", b =>
                {
                    b.HasOne("University.Tables.Discipline", null)
                        .WithMany()
                        .HasForeignKey("DisciplinesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.Tables.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ParentStudent", b =>
                {
                    b.HasOne("University.Tables.Student", null)
                        .WithMany()
                        .HasForeignKey("ChildrenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.Tables.Parent", null)
                        .WithMany()
                        .HasForeignKey("ParentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("University.Tables.Block", b =>
                {
                    b.HasOne("University.Tables.BlockType", "BlockType")
                        .WithMany()
                        .HasForeignKey("BlockTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.Tables.Dormitory", "Dormitory")
                        .WithMany()
                        .HasForeignKey("DormitoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlockType");

                    b.Navigation("Dormitory");
                });

            modelBuilder.Entity("University.Tables.Department", b =>
                {
                    b.HasOne("University.Tables.Faculty", "Faculty")
                        .WithMany("departments")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("University.Tables.Employee", b =>
                {
                    b.HasOne("University.Tables.AcademicDegree", "AcademicDegree")
                        .WithMany("Employees")
                        .HasForeignKey("AcademicDegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.Tables.Person", null)
                        .WithOne()
                        .HasForeignKey("University.Tables.Employee", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("AcademicDegree");
                });

            modelBuilder.Entity("University.Tables.Parent", b =>
                {
                    b.HasOne("University.Tables.Person", null)
                        .WithOne()
                        .HasForeignKey("University.Tables.Parent", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("University.Tables.Student", b =>
                {
                    b.HasOne("University.Tables.Block", null)
                        .WithMany("Students")
                        .HasForeignKey("BlockId");

                    b.HasOne("University.Tables.Dormitory", "Dormitory")
                        .WithMany("Students")
                        .HasForeignKey("DormitoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.Tables.EducationForm", "EducationalForm")
                        .WithMany("Students")
                        .HasForeignKey("EducationalFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.Tables.Group", "Group")
                        .WithMany("students")
                        .HasForeignKey("GroupName");

                    b.HasOne("University.Tables.Person", null)
                        .WithOne()
                        .HasForeignKey("University.Tables.Student", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("University.Tables.Scholarship", "Scholarship")
                        .WithMany()
                        .HasForeignKey("ScholarshipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.Tables.Specialization", "Specialization")
                        .WithMany("students")
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dormitory");

                    b.Navigation("EducationalForm");

                    b.Navigation("Group");

                    b.Navigation("Scholarship");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("University.Tables.AcademicDegree", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("University.Tables.Block", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("University.Tables.Dormitory", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("University.Tables.EducationForm", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("University.Tables.Faculty", b =>
                {
                    b.Navigation("departments");
                });

            modelBuilder.Entity("University.Tables.Group", b =>
                {
                    b.Navigation("students");
                });

            modelBuilder.Entity("University.Tables.Specialization", b =>
                {
                    b.Navigation("students");
                });
#pragma warning restore 612, 618
        }
    }
}
