namespace El1te_Spr1nt_Track_Core.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; } // Parent, Athlete, Track Meet Visitor
        public string Content { get; set; }
        public string? PhotoUrl { get; set; } // Optional
        public bool IsApproved { get; set; } = false; // Requires admin approval
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Constructor
        public Testimonial(int id, string role, string name,  string content, bool isApproved, string? photoUrl = null)
        {

            Id = id;
            Role = role;
            Name = name;            
            Content = content;
            PhotoUrl = photoUrl;
            IsApproved = isApproved;
        }
    }
}
