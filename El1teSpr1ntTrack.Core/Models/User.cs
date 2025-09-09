namespace El1teSpr1ntTrack.Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } // Parent, Coach, Admin, (Athlete if activated)
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // A Parent Can Have Multiple Athletes
        public List<Athlete> Athletes { get; set; } = new();

        // 🔹 Default Constructor (Required by EF Core)
        public User() { }

        // Constructor - Requires Parent or Admin to Register
        public User(int id, string firstName, string lastName, string email, string passwordHash, string role)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PasswordHash = passwordHash;
            Role = role;
        }
    }
}
