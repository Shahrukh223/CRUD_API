﻿// <auto-generated />
using CRUDApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUDApi.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20210924064709_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("CRUDApi.Models.CustomerDto", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullName");

                    b.HasKey("InvoiceID");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}
