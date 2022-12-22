using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Los_Pollos_Hermanos_Web_App.Models
{
    public class MenuInfromation
    {
        [Key]
        public int FoodID { get; set; }
        [Required]
        public int MenuItemID { get; set; }
        [Required]
        public DateTime Startdate { get; set; }
        [Required]
        public DateTime Enddate { get; set; }
    }
}
