using Microsoft.Extensions.Logging;

namespace El1te_Spr1nt_Track_Core.Models
{
    public class Athlete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string? ProfilePictureUrl { get; set; }

        // Required Parent Link (Every Athlete Must Have a Parent)
        public int ParentUserId { get; set; }
        public User ParentUser { get; set; }

        // Optional Athlete Account Link (If They Activate Their Own Account)
        public int? UserId { get; set; }
        public User? User { get; set; }

        public bool IsActivated { get; set; } = false; // Tracks activation status

        public List<Event> Events { get; set; } = new();

        // Default Constructor (Required by EF Core)
        public Athlete() { }

        // Constructor for Seeding Data
        public Athlete(int id, string name, DateTime dob, string gender, int parentUserId)
        {
            Id = id;
            Name = name;
            DateOfBirth = dob;
            Gender = gender;
            ParentUserId = parentUserId;
            IsActivated = false;
        }

        // Method to Activate Athlete Account
        public void ActivateAccount(int userId)
        {
            UserId = userId;
            IsActivated = true;
        }
    }
}
