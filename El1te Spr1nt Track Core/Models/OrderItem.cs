namespace El1te_Spr1nt_Track_Core.Models
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public OrderItem(int orderId, int productId, int quantity, decimal price)
        {
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
        }
    }
}
