using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Shopping
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateOfPurchase { get; set; }
    }
}
