using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NewProject1.Data;

namespace NewProject1.Pages.Classes
{
    public class IndexModel : PageModel
    {
        private readonly NewProject1.Data.ApplicationDbContext _context;

        public IndexModel(NewProject1.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Intro> Intro { get;set; }

        public async Task OnGetAsync()
        {
            Intro = await _context.Intro.ToListAsync();
        }
    }
}
