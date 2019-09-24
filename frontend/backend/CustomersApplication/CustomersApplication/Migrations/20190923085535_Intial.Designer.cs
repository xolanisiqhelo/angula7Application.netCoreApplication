﻿// <auto-generated />
using CustomersApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomersApplication.Migrations
{
    [DbContext(typeof(CustomerDetailsContext))]
    [Migration("20190923085535_Intial")]
    partial class Intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomersApplication.Models.CustomerDetails", b =>
                {
                    b.Property<int>("PMId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("varchar(4)");

                    b.Property<string>("ResidentialAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PMId");

                    b.ToTable("CustomerDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
