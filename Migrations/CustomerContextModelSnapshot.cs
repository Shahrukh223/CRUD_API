﻿// <auto-generated />
using CRUDApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUDApi.Migrations
{
    [DbContext(typeof(CustomerContext))]
    partial class CustomerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
