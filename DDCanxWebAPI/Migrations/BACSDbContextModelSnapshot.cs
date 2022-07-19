﻿// <auto-generated />
using DDCanxWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DDCanxWebAPI.Migrations
{
    [DbContext(typeof(BACSDbContext))]
    partial class BACSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DDCanxWebAPI.Models.BACs", b =>
                {
                    b.Property<string>("PolicyRef")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Branch")
                        .HasColumnType("int");

                    b.Property<bool>("ChangeDate")
                        .HasColumnType("bit");

                    b.Property<bool>("ContinueDD")
                        .HasColumnType("bit");

                    b.Property<string>("DueDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaidBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PolicyRef");

                    b.ToTable("BACs");
                });
#pragma warning restore 612, 618
        }
    }
}