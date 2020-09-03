﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XyzOfficeEmployeeTracker.Models;

namespace XyzOfficeEmployeeTracker.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("XyzOffice.Models.Employee", b =>
                {
                    b.Property<int>("empId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("deptId");

                    b.Property<string>("deptName");

                    b.Property<int>("salary");

                    b.HasKey("empId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("XyzOffice.Models.SalaryDetail", b =>
                {
                    b.Property<int>("salaryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("date");

                    b.Property<int>("empId");

                    b.Property<int>("salary");

                    b.HasKey("salaryId");

                    b.ToTable("SalaryDetails");
                });
#pragma warning restore 612, 618
        }
    }
}