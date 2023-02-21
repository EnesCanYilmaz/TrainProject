using System;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace TrainProjectAPI.Entities
{
    public class TrainReservationContext : DbContext
    {
        public DbSet<Train> Trains { get; set; }
        public DbSet<Wagon> Wagons { get; set; }
        public DbSet<ReservationRequest> ReservationRequests { get; set; }
        public DbSet<ReservationResponse> ReservationResponses { get; set; }
        public DbSet<PlacementDetail> PlacementDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433\\Catalog=Blecy;Database=TrainDatabase;User=sa;Password=100A200b;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlacementDetail>().HasNoKey();
            modelBuilder.Entity<ReservationRequest>().HasNoKey();
            modelBuilder.Entity<ReservationResponse>().HasNoKey();
            modelBuilder.Entity<Wagon>().HasNoKey();


        }
    }
}

