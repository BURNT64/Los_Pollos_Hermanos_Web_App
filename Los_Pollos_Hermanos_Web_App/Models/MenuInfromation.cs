using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Los_Pollos_Hermanos_Web_App.Models
{
    public class MenuInfromation
    {
        [Key]
        public int FoodID { get; set; }
        public int MenuItemID { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
    }
}
