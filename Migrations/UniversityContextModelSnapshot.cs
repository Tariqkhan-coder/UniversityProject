﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.University_context;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(UniversityContext))]
    partial class UniversityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("webapi.Models.Department", b =>
                {
                    b.Property<long>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartDescription")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("DepartmentId");

                    b.ToTable("DepartmentDetails");
                });

            modelBuilder.Entity("webapi.Models.Employee", b =>
                {
                    b.Property<long>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EmpId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("EmpId");

                    b.ToTable("EmployeeDetails");
                });

            modelBuilder.Entity("webapi.Models.Student", b =>
                {
                    b.Property<long>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StudentId"), 1L, 1);

                    b.Property<string>("AdmissionDate")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("CNIC")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("DateofBirth")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("StudentId");

                    b.ToTable("StudentDetails");
                });

            modelBuilder.Entity("webapi.Models.Teacher", b =>
                {
                    b.Property<long>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TeacherId"), 1L, 1);

                    b.Property<string>("CNIC")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("TeacherName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("TeacherId");

                    b.ToTable("TeacherDetails");
                });

            modelBuilder.Entity("webapi.Models.University", b =>
                {
                    b.Property<long>("UniversityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UniversityId"), 1L, 1);

                    b.Property<int>("EstablishedYear")
                        .HasColumnType("int");

                    b.Property<string>("UniversityName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(50)");

                    b.HasKey("UniversityId");

                    b.ToTable("UniversityDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
