using El1te_Spr1nt_Track_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace El1te_Spr1nt_Track_Core.Data
{
    public class El1teDbContext :  DbContext
    {
        public El1teDbContext(DbContextOptions<El1teDbContext> options) : base(options) { }
        // Register Tables
        public DbSet<User> Users { get; set; }
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<AthleteEvent> AthleteEvents { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Many-to-Many Relationships
            modelBuilder.Entity<AthleteEvent>()
                .HasKey(ae => new { ae.AthleteId, ae.EventId });

            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId });

            modelBuilder.Entity<Athlete>()
                .HasOne(a => a.ParentUser)
                .WithMany(u => u.Athletes)
                .HasForeignKey(a => a.ParentUserId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent accidental cascading delete

            //Seed Parent Users
            modelBuilder.Entity<User>().HasData(
                new User(-1, "John", "Doe", "john.doe@example.com", "hashedpassword123", "Parent"),
                new User(-2, "Jane", "Smith", "jane.smith@example.com", "hashedpassword456", "Parent")
            );

            //Seed Athletes (Linked to Parents)
            modelBuilder.Entity<Athlete>().HasData(
                new Athlete(-1, "Michael Doe", new DateTime(2012, 6, 15), "Male", 1),
                new Athlete(-2, "Emily Smith", new DateTime(2010, 8, 22), "Female", 2)
            );

            //Seed Events
            modelBuilder.Entity<Event>().HasData(
                new Event(-1, "100m Sprint", new DateTime(2024, 7, 10), "National Stadium"),
                new Event(-2, "200m Sprint", new DateTime(2024, 8, 15), "City Sports Complex")
            );

            //Seed Products for Storefront 
            modelBuilder.Entity<Product>().HasData(
                new Product(-1, "Track Club T-Shirt", "High-quality club t-shirt", 25.99m, 50, "tshirt.jpg", "Merchandise"),
                new Product(-2, "Water Bottle", "Durable sports water bottle", 15.99m, 30, "waterbottle.jpg", "Accessories")
            );

            //Seed Testimonials (Must be approved before appearing)
            modelBuilder.Entity<Testimonial>().HasData(
                new Testimonial(-1, "Parent", "John Doe", "This club has been amazing for my son!", false, null),
                new Testimonial(-2, "Athlete", "Emily Smith", "I've improved so much since joining!", false, null)
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
