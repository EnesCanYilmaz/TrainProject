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
    [Migration("20230221103340_mig_10")]
    partial class mig_10
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TrainProjectAPI.Entities.PlacementDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NumberOfPeople")
                        .HasColumnType("int");

                    b.Property<int?>("ReservationResponseId")
                        .HasColumnType("int");

                    b.Property<string>("WagonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationResponseId");

                    b.ToTable("PlacementDetails");
                });

            modelBuilder.Entity("TrainProjectAPI.Entities.ReservationRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("NumberofPersonstoReservation")
                        .HasColumnType("int");

                    b.Property<bool>("PeopleCanBePlacedOnDifferentWagons")
                        .HasColumnType("bit");

                    b.Property<int>("TrainId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainId");

                    b.ToTable("ReservationRequests");
                });

            modelBuilder.Entity("TrainProjectAPI.Entities.ReservationResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ReservationAvailable")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ReservationResponses");
                });

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

                    b.Property<int>("TrainId")
                        .HasColumnType("int");

                    b.Property<string>("WagonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WagonId");

                    b.HasIndex("TrainId");

                    b.ToTable("Wagons");
                });

            modelBuilder.Entity("TrainProjectAPI.Entities.PlacementDetail", b =>
                {
                    b.HasOne("TrainProjectAPI.Entities.ReservationResponse", null)
                        .WithMany("PlacementDetail")
                        .HasForeignKey("ReservationResponseId");
                });

            modelBuilder.Entity("TrainProjectAPI.Entities.ReservationRequest", b =>
                {
                    b.HasOne("TrainProjectAPI.Entities.Train", "Train")
                        .WithMany()
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Train");
                });

            modelBuilder.Entity("TrainProjectAPI.Entities.Wagon", b =>
                {
                    b.HasOne("TrainProjectAPI.Entities.Train", "Train")
                        .WithMany("Wagons")
                        .HasForeignKey("TrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Train");
                });

            modelBuilder.Entity("TrainProjectAPI.Entities.ReservationResponse", b =>
                {
                    b.Navigation("PlacementDetail");
                });

            modelBuilder.Entity("TrainProjectAPI.Entities.Train", b =>
                {
                    b.Navigation("Wagons");
                });
#pragma warning restore 612, 618
        }
    }
}
