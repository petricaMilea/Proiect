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
    public class DeleteModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public DeleteModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Holiday Holiday { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Holiday == null)
            {
                return NotFound();
            }

            var holiday = await _context.Holiday.FirstOrDefaultAsync(m => m.ID == id);

            if (holiday == null)
            {
                return NotFound();
            }
            else 
            {
                Holiday = holiday;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Holiday == null)
            {
                return NotFound();
            }
            var holiday = await _context.Holiday.FindAsync(id);

            if (holiday != null)
            {
                Holiday = holiday;
                _context.Holiday.Remove(Holiday);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
