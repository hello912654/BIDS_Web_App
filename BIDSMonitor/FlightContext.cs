using BIDSMonitor.Model;
using Microsoft.EntityFrameworkCore;

namespace BIDSMonitor
{
    public class FlightContext : DbContext
    {
        public FlightContext(DbContextOptions<FlightContext> options) : base(options)
        {
        }

        public DbSet<Flight> Flights { get; set; } = null!;
        public DbSet<Carousel> Carousels { get; set; } = null!;
        public DbSet<FlightCarousel> FlightCarousels { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlightCarousel>()
                .HasKey(fc => new { fc.FlightId, fc.CarouselId });
            modelBuilder.Entity<FlightCarousel>()
                .HasOne(fc => fc.Flight)
                .WithMany(f => f.FlightCarousels)
                .HasForeignKey(fc => fc.FlightId);
            modelBuilder.Entity<FlightCarousel>()
                .HasOne(fc => fc.Carousel)
                .WithMany(c => c.FlightCarousels)
                .HasForeignKey(fc => fc.CarouselId);
        }


    }
}
