﻿// <auto-generated />
using System;
using FinancialChallenge.Service.CashFlowAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinancialChallenge.Service.CashFlowAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FinancialChallenge.Service.CashFlowAPI.Models.Transaction", b =>
                {
                    b.Property<Guid>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("AmountParcels")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("TransactionDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<byte>("TransactionType")
                        .HasColumnType("tinyint");

                    b.Property<byte>("TypePayment")
                        .HasColumnType("tinyint");

                    b.Property<DateTimeOffset?>("UpdatedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("UserCreated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserUpdate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransactionId");

                    b.ToTable("Transctions");
                });
#pragma warning restore 612, 618
        }
    }
}
