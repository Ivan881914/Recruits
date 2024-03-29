﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recruits.Model;

#nullable disable

namespace Recruits.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220927055822_AddCategoryToDb")]
    partial class AddCategoryToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Recruits.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstInterview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HRJobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HRName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecruitJobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecruitLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecruitName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestRealizationTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestСompletionTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
