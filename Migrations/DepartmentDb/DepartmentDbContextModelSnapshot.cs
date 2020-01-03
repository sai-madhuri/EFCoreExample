﻿// <auto-generated />
using EFExample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFExample.Migrations.DepartmentDb
{
    [DbContext(typeof(DepartmentDbContext))]
    partial class DepartmentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFExample.Department", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptLocation");

                    b.Property<string>("DeptManager");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("DeptId");

                    b.ToTable("Departments");

                    b.HasData(
                        new { DeptId = 1, DeptLocation = "Hyderabad", DeptManager = "PadmaRaju Sir", DeptName = "CSE" }
                    );
                });

            modelBuilder.Entity("EFExample.MainDept", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptLocation");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("DeptId");

                    b.ToTable("MainDept");
                });
#pragma warning restore 612, 618
        }
    }
}
