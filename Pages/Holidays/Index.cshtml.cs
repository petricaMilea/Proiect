using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Holidays
{
    public class IndexModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public IndexModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        public IList<Holiday> Holiday { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Holiday != null)
            {
                Holiday = await _context.Holiday
                .Include(h => h.Agency).ToListAsync();
            }
        }
    }
}
