﻿// <auto-generated />
using System;
using GradesService.Src.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GradesService.Src.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240914212709_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("GradesService.Src.Models.Grade", b =>
                {
                    b.Property<Guid>("Uuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Coment")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("GradeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("GradeValue")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentUuid")
                        .HasColumnType("char(36)");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Uuid");

                    b.ToTable("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}
