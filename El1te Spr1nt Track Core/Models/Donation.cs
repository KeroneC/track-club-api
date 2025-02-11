namespace El1te_Spr1nt_Track_Core.Models
{
    public class Donation
    {
        public int Id { get; set; }
        public string DonorName { get; set; }
        public string DonorEmail { get; set; }
        public decimal Amount { get; set; }
        public DateTime DonationDate { get; set; } = DateTime.UtcNow;
        public string PaymentMethod { get; set; } // Stripe, PayPal

        // Constructor
        public Donation(string donorName, string donorEmail, decimal amount, string paymentMethod)
        {
            DonorName = donorName;
            DonorEmail = donorEmail;
            Amount = amount;
            PaymentMethod = paymentMethod;
        }
    }
}
