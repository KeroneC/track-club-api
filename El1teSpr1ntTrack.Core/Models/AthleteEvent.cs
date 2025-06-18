namespace El1teSpr1ntTrack.Core.Models
{
        // Pivot Table (Many-to-Many Relationship between Athlete & Event)
        public class AthleteEvent
        {
            public int AthleteId { get; set; }
            public Athlete Athlete { get; set; }

            public int EventId { get; set; }
            public Event Event { get; set; }

            public string Result { get; set; } // Example: "1st Place", "12.5s 100m"
        }
    
}
