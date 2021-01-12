﻿using System;
using System.ComponentModel.DataAnnotations;

namespace NG_Core_Auth.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        [Required]
        public string TotalTime { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public double Price { get; set; }

    }
}
