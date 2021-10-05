using Domain.Common;
using System;

namespace Domain.Entities
{
    public class Product : OperationsInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
