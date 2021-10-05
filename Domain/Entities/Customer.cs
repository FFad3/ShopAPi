using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("Customers")]
    public class Customer: OperationsInfo
    {
        public Customer(int id, string name, string forname)
        {
            Id = id;
            Name = name;
            Forname = forname;
            Created = DateTime.UtcNow;
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MaxLength(30)]
        public string Forname { get; set; }
        [Required]
        public List<Shopping> Shoppings { get; set; }
    }
}
