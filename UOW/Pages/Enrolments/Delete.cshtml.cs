using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UOW.Authorization;
using UOW.Models;

namespace UOW.Pages.Enrolments
{
    public class DeleteModel : DI_BasePageModel
    {

        public DeleteModel(UOWContext context,
            IAuthorizationService authorizationService,
            UserManager<Student> userManager) : base(context,authorizationService,userManager)
        {
        }

        [BindProperty]
        public Enrolment Enrolment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Enrolment = await Context.Enrolment.Where(e=> e.Grade==null)
                .Include(e => e.Subject).FirstOrDefaultAsync(m => m.EnrolmentID == id);

            if (Enrolment == null)
            {
                return NotFound();
            }

            var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                                     User, Enrolment,
                                                     EnrolmentOperations.Delete);
            if (!isAuthorized.Succeeded)
            {
                return new ChallengeResult();
            }

            ViewData["Referer"] = Request.Headers["Referer"].ToString();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Enrolment = await Context.Enrolment.FindAsync(id);

            var enrolment = await Context.Enrolment.AsNoTracking()
                            .FirstOrDefaultAsync(e => e.EnrolmentID == id);

            if (enrolment==null)
            {
                return NotFound();
            }

            var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                                     User, enrolment,
                                                     EnrolmentOperations.Delete);
            if (!isAuthorized.Succeeded)
            {
                return new ChallengeResult();
            }

            if (Enrolment != null)
            {
                Context.Enrolment.Remove(Enrolment);
                await Context.SaveChangesAsync();
            }

            return RedirectToPage("./Index",null,null,"new");
        }
    }
}
