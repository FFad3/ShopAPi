using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Domain.Entities
{
    [Table("Shoppings")]
    public class Shopping: OperationsInfo
    {
        public Shopping()
        {
            Created = DateTime.UtcNow;
            if (Products==null)
            {
                TotalPrice = 0;
            }
            else
            {
                TotalPrice = Products.Sum(x => x.Count * x.Price);
            }
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public List<Product> Products { get; set; }
        [Required]
        public double TotalPrice { get; set; }
    }
}
