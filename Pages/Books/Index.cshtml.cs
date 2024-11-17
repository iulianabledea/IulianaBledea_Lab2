using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IulianaBledea_Lab2.Models;

namespace IulianaBledea_Lab2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly IulianaBledea_Lab2.Models.Lab2Context _context;

        public IndexModel(IulianaBledea_Lab2.Models.Lab2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Books.ToListAsync();
        }
    }
}
