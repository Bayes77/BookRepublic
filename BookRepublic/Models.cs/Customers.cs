﻿namespace BookRepublic.Models.cs
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int OrdersId { get; set; }
    }
}
