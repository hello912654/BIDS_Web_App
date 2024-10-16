using System.ComponentModel.DataAnnotations.Schema;

namespace BIDSMonitor.Model
{
    [Table("carousel")]
    public class Carousel
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("carousel_no")]
        public string? CarouselNo { get; set; }
        [Column("status")]
        public string? Status { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        public ICollection<FlightCarousel> FlightCarousels { get; set; } = new List<FlightCarousel>();
    }
}
