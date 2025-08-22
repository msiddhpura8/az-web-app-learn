using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using az_web_app_learn.Data;

namespace az_web_app_learn.Pages_Persons1
{
    public class IndexModel : PageModel
    {
        private readonly az_web_app_learn.Data.AppDbContext _context;

        public IndexModel(az_web_app_learn.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
