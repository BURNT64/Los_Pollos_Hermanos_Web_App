using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Los_Pollos_Hermanos_Web_App.Data;
using Los_Pollos_Hermanos_Web_App.Models;

namespace Los_Pollos_Hermanos_Web_App.Pages.Menuinformation
{
    public class DeleteModel : PageModel
    {
        private readonly Los_Pollos_Hermanos_Web_App.Data.ResturantContext _context;

        public DeleteModel(Los_Pollos_Hermanos_Web_App.Data.ResturantContext context)
        {
            _context = context;
        }

        [BindProperty]
      public MenuInfromation MenuInfromation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.MenuInfromation == null)
            {
                return NotFound();
            }

            var menuinfromation = await _context.MenuInfromation.FirstOrDefaultAsync(m => m.FoodID == id);

            if (menuinfromation == null)
            {
                return NotFound();
            }
            else 
            {
                MenuInfromation = menuinfromation;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.MenuInfromation == null)
            {
                return NotFound();
            }
            var menuinfromation = await _context.MenuInfromation.FindAsync(id);

            if (menuinfromation != null)
            {
                MenuInfromation = menuinfromation;
                _context.MenuInfromation.Remove(MenuInfromation);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
