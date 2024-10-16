using System.ComponentModel.DataAnnotations.Schema;

namespace BIDSMonitor.Model
{
    [Table("flight_carousel")]
    public class FlightCarousel
    {
        [Column("flight_id")]
        public long FlightId { get; set; }
        [Column("carousel_id")]
        public long CarouselId { get; set; }
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        [NotMapped]
        public Flight Flight { get; set; } = null!;
        [NotMapped]
        public Carousel Carousel { get; set; } = null!;

    }
}
