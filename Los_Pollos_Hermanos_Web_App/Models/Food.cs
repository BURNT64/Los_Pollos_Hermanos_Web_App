using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Los_Pollos_Hermanos_Web_App.Models
{
    public class Food
    {
        public int FoodID { get; set; }
        public string? FoodName { get; set; }
    }
}
