﻿using MessagePack;
using System.ComponentModel.DataAnnotations;

namespace Los_Pollos_Hermanos_Web_App.Models
{
    public class Food
    {
        public int ID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string? FoodName { get; set; }
        [Required]
        public string? ImageDescription { get; set; }
        public byte[]? ImageData { get; set; }
    }
}
