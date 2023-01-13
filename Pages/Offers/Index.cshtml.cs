﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;

namespace Proiect.Pages.Offers
{
    public class IndexModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public IndexModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        public IList<Offer> Offer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Offer != null)
            {
                Offer = await _context.Offer
                .Include(o => o.Customer)
                .Include(o => o.Holiday).ToListAsync();
            }
        }
    }
}
