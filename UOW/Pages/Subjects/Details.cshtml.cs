using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UOW.Models;

namespace UOW.Pages.Subjects
{
    public class DetailsModel : PageModel
    {
        private readonly UOW.Models.UOWContext _context;

        public DetailsModel(UOW.Models.UOWContext context)
        {
            _context = context;
        }

        public Subject Subject { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Subject = await _context.Subject.FirstOrDefaultAsync(m => m.SubjectCode == id);

            if (Subject == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
