namespace El1te_Spr1nt_Track_Core.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }

        // Many-to-Many: Athletes participating in the event
        public List<AthleteEvent> AthleteEvents { get; set; } = new();

        // Constructor
        public Event(int id, string name, DateTime eventDate, string location)
        {
            Id = id;
            Name = name;
            EventDate = eventDate;
            Location = location;
        }
    }

    
}
