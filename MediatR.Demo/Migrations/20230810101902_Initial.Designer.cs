﻿// <auto-generated />
using MediatR.Demo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MediatR.Demo.Migrations
{
    [DbContext(typeof(ContactsContext))]
    [Migration("20230810101902_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("MediatoRDemo.Data.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("TEXT");

                    b.Property<string>("WebSite")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Steve",
                            LastName = "Michelotti",
                            WebSite = "www"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Bill",
                            LastName = "Gates",
                            WebSite = "www"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Satya",
                            LastName = "Nadella",
                            WebSite = "www"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
