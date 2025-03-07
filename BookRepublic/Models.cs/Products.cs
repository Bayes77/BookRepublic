namespace BookRepublic.Models.cs
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public bool Available { get; set; }
        public string ProductType { get; set; }

        // public Url ImageUrl { get; set; }
        public int SellerId { get; set; }
        public int OrdersId { get; set; }

    }
}
