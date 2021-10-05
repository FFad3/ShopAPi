using System.Collections.Generic;

namespace Domain.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Forname { get; set; }
        public List<Shopping> Shoppings { get; set; }
    }
}
