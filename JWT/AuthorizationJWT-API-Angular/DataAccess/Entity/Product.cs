﻿using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string ImageURL { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
