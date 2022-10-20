﻿// <auto-generated />
using System;
using Enzwals.api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Enzwals.api.Migrations
{
    [DbContext(typeof(Enzwalkdbcontext))]
    partial class EnzwalkdbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Enzwals.api.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Long")
                        .HasColumnType("float");

                    b.Property<double>("area")
                        .HasColumnType("float");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("lat")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("population")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("regions");
                });

            modelBuilder.Entity("Enzwals.api.Models.Domain.walk", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<Guid>("Walkdifficultyid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("did")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("regionid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("did");

                    b.HasIndex("regionid");

                    b.ToTable("walks");
                });

            modelBuilder.Entity("Enzwals.api.Models.Domain.wALK_difficulty", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("difficulties");
                });

            modelBuilder.Entity("Enzwals.api.Models.Domain.walk", b =>
                {
                    b.HasOne("Enzwals.api.Models.Domain.wALK_difficulty", "d")
                        .WithMany()
                        .HasForeignKey("did")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Enzwals.api.Models.Domain.Region", "r")
                        .WithMany("walks")
                        .HasForeignKey("regionid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("d");

                    b.Navigation("r");
                });

            modelBuilder.Entity("Enzwals.api.Models.Domain.Region", b =>
                {
                    b.Navigation("walks");
                });
#pragma warning restore 612, 618
        }
    }
}
