using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace Los_Pollos_Hermanos_Web_App.Models
{
    public class MenuItem
    {
        [Required]
        public int FoodID { get; set; }
        public int MenuItemID { get; set; }
        [Required]
        public string? MenuItemName { get; set; }
        [Required]
        public string? ItemDescription { get; set; }
        [Required]
        public decimal Price { get; set; } 
    }
}
