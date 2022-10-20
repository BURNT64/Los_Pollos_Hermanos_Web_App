using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

namespace Los_Pollos_Hermanos_Web_App.Models
{
    public class MenuItem
    {
        public int FoodID { get; set; }
        public int MenuItemID { get; set; }
        public string? MenuItemName { get; set; }
        public string? ItemDescription { get; set; }
        public decimal Price { get; set; }
     
    }
}
