using System.ComponentModel.DataAnnotations.Schema;

namespace BIDSMonitor.Model
{
    [Table("flight")]
    public class Flight
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("flight_no")]
        public string? FlightNo { get; set; }
        [Column("flight_type")]
        public string? FlightType { get; set; }
        [Column("aircraft_type_icao")]
        public string? AircraftTypeICAO { get; set; }
        [Column("aircraft_type_iata")]
        public string? AircraftTypeIATA { get; set; }
        [Column("arrival_gate")]
        public string? ArrivalGate { get; set; }
        [Column("arrival_terminal")]
        public string? ArrivalTerminal { get; set; }
        [Column("departure_gate")]
        public string? DepartureGate { get; set; }
        [Column("departure_terminal")]
        public string? DepartureTerminal { get; set; }
        [Column("flight_from")]
        public string? FlightFrom { get; set; }
        [Column("flight_to")]
        public string? FlightTo { get; set; }
        [Column("sta")]
        public DateTime? STA { get; set; }
        [Column("std")]
        public DateTime? STD { get; set; }
        [Column("eta")]
        public DateTime? ETA { get; set; }
        [Column("etd")]
        public DateTime? ETD { get; set; }
        [Column("ata")]
        public DateTime? ATA { get; set; }
        [Column("atd")]
        public DateTime? ATD { get; set; }


        [Column("checkin_count")]
        public int CheckinCount { get; set; }
        [Column("sorting_count")]
        public int SortingCount { get; set; }
        [Column("brs_count")]
        public int BRSCount { get; set; }


        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }


        [NotMapped]
        public int DifferenceCount
        {
            get
            {
                if (CheckinCount > 0 && CheckinCount > BRSCount)
                {
                    return CheckinCount - BRSCount;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                // Set the CountDifference value
                CheckinCount = 0;
            }

        }

        public ICollection<FlightCarousel> FlightCarousels { get; set; } = new List<FlightCarousel>();

    }
}
