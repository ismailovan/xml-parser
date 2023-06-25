﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Parser.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20230625081615_UpdateDates")]
    partial class UpdateDates
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("Entities.Models.MetData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("domain_longTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("domain_meteosiId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("domain_shortTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("domain_title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sunrise")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("sunset")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("tsUpdated_RFC822")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MetData");
                });
#pragma warning restore 612, 618
        }
    }
}