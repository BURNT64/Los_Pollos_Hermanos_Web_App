using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Los_Pollos_Hermanos_Web_App.Data;
using Los_Pollos_Hermanos_Web_App.Models;

namespace Los_Pollos_Hermanos_Web_App.Pages.Menuitems
{
    public class IndexModel : PageModel
    {
        private readonly Los_Pollos_Hermanos_Web_App.Data.ResturantContext _context;

        public IndexModel(Los_Pollos_Hermanos_Web_App.Data.ResturantContext context)
        {
            _context = context;
        }

        public IList<MenuItem> MenuItem { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.MenuItem != null)
            {
                MenuItem = await _context.MenuItem.ToListAsync();
            }
        }
    }
}
