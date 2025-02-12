namespace MyApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }  // Navigation Property to Product
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }  // Navigation Property to Customer
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
