using Los_Pollos_Hermanos_Web_App.Models;

namespace Los_Pollos_Hermanos_Web_App.Data
{
    public class DbInitializer
    {
        public static void Initialize(ResturantContext context)
        {
            var Foods = new Food[]
            {
            
            };

            context.Food.AddRange(Foods);
            context.SaveChanges();

            var Menuinforamtion = new MenuInfromation[]
            {

            };

            context.MenuInfromation.AddRange(Menuinforamtion);
            context.SaveChanges();

            var Menuitems = new MenuItem[]
            {

            };

            context.MenuItem.AddRange(Menuitems);
            context.SaveChanges();


        }
    }
}
