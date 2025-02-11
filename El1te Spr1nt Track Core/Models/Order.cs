namespace El1te_Spr1nt_Track_Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; } // Stripe, PayPal
        public string PaymentStatus { get; set; } // Pending, Completed, Failed

        public List<OrderItem> OrderItems { get; set; } = new();

        // Constructor
        public Order(int userId, decimal totalAmount, string paymentMethod, string paymentStatus)
        {
            UserId = userId;
            TotalAmount = totalAmount;
            PaymentMethod = paymentMethod;
            PaymentStatus = paymentStatus;
        }
    }
}
