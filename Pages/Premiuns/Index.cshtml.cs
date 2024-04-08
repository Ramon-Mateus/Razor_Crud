using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razor_Crud.Data;
using Razor_Crud.Models;

namespace Razor_Crud.Pages_Premiuns
{
    public class IndexModel : PageModel
    {
        private readonly Razor_Crud.Data.ApplicationDbContext _context;

        public IndexModel(Razor_Crud.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Premium> Premium { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Premium = await _context.Premiuns
                .Include(p => p.Student).ToListAsync();
        }
    }
}
