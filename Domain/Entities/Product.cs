﻿using Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Products")]
    public class Product : OperationsInfo
    {
        public Product(int id, string name, decimal price, int count)
        {
            Id = id;
            Name = name;
            Price = price;
            Count = count;
            Created = DateTime.UtcNow;
            ExpirationDate = DateTime.UtcNow.AddDays(12);
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
    }
}
