﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainProjectAPI.Entities;

#nullable disable

namespace TrainProjectAPI.Migrations
{
    [DbContext(typeof(TrainReservationContext))]
    [Migration("20230220215238_mig_6")]
    partial class mig_6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrainProjectAPI.Entities.Train", b =>
                {
                    b.Property<int>("TrainId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrainId"));

                    b.Property<string>("TrainName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainId");

                    b.ToTable("Trains");
                });

            modelBuilder.Entity("TrainProjectAPI.Entities.Wagon", b =>
                {
                    b.Property<int>("WagonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WagonId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfReservedSeats")
                        .HasColumnType("int");

                    b.Property<int?>("TrainId")
                        .HasColumnType("int");

                    b.Property<string>("WagonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WagonId");

                    b.HasIndex("TrainId");

                    b.ToTable("Wagons");
                });

            modelBuilder.Entity("TrainProjectAPI.Entities.Wagon", b =>
                {
                    b.HasOne("TrainProjectAPI.Entities.Train", null)
                        .WithMany("Wagons")
                        .HasForeignKey("TrainId");
                });

            modelBuilder.Entity("TrainProjectAPI.Entities.Train", b =>
                {
                    b.Navigation("Wagons");
                });
#pragma warning restore 612, 618
        }
    }
}
