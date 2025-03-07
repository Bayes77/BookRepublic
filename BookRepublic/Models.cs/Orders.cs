namespace BookRepublic.Models.cs
{
    public class Orders
    {
        public int Id { get; set; }
        public int ProductsId { get; set; }
        public int CustomersId { get; set; }
        public int SellersId { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; internal set; }
        public string PaymentType { get; internal set; }
        public int ProductId { get; internal set; }
        public int SellerId { get; internal set; }
        public bool Sold { get; internal set; }
    }
}
