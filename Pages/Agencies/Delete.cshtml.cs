﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Agencies
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public DeleteModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Agency Agency { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Agency == null)
            {
                return NotFound();
            }

            var agency = await _context.Agency.FirstOrDefaultAsync(m => m.ID == id);

            if (agency == null)
            {
                return NotFound();
            }
            else 
            {
                Agency = agency;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Agency == null)
            {
                return NotFound();
            }
            var agency = await _context.Agency.FindAsync(id);

            if (agency != null)
            {
                Agency = agency;
                _context.Agency.Remove(Agency);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
