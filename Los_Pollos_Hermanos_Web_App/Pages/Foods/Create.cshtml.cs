using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Los_Pollos_Hermanos_Web_App.Data;
using Los_Pollos_Hermanos_Web_App.Models;

namespace Los_Pollos_Hermanos_Web_App.Pages.Foods
{
    public class CreateModel : PageModel
    {
        private readonly Los_Pollos_Hermanos_Web_App.Data.ResturantContext _context;

        public CreateModel(Los_Pollos_Hermanos_Web_App.Data.ResturantContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Food Food { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) { return Page(); }
            foreach (var file in Request.Form.Files)
            {
                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms);
                Food.ImageData = ms.ToArray();

                ms.Close();
                ms.Dispose();
            }
            _context.Food.Add(Food);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Foods/Index");
        }
    }
}
