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
        public Shopping(int id)
        {
            Id = id;
            DateOfPurchase = DateTime.UtcNow;
            Created = DateTime.UtcNow;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public List<Product> Products { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        [Required]
        public DateTime DateOfPurchase { get; set; }
    }
}
