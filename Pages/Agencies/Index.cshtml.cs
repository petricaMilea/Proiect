using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect.Data;
using Proiect.Models;
using Proiect.Models.ViewModels;

namespace Proiect.Pages.Agencies
{
    public class IndexModel : PageModel
    {
        private readonly Proiect.Data.ProiectContext _context;

        public IndexModel(Proiect.Data.ProiectContext context)
        {
            _context = context;
        }

        public IList<Agency> Agency { get;set; } = default!;

        public AgencyIndexData AgencyData { get;set; }
        public int AgencyID { get; set; }
        public int HolidayID { get; set; }


        public async Task OnGetAsync(int? id, int? holidayID)
        {
            AgencyData = new AgencyIndexData();
            AgencyData.Agencies = await _context.Agency
                .Include(a => a.Holidays)
                .OrderBy(a => a.Name)
                .ToListAsync();

            if (id != null)
            {
                AgencyID = id.Value;
                Agency agency = AgencyData.Agencies
                    .Where(a => a.ID == id.Value).Single();

                AgencyData.Holidays = agency.Holidays;
            }
        }



        //public async Task OnSelectButtonClicked(int? id, int? holidayID)
        //{
        //    AgencyData = new AgencyIndexData();
        //    AgencyData.Agencies = await _context.Agency
        //        .Include(a => a.Holidays)
        //        .OrderBy(a => a.Name)
        //        .ToListAsync();

        //    if (id != null)
        //    {
        //        AgencyID = id.Value;
        //        Agency agency = AgencyData.Agencies
        //            .Where(a => a.ID == id.Value).Single();

        //        AgencyData.Holidays = agency.Holidays;
        //    }
        //}

    }
}
