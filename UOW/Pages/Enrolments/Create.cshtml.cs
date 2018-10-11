using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UOW.Authorization;
using UOW.Models;

namespace UOW.Pages.Enrolments
{
    public class CreateModel : DI_BasePageModel
    {

        public CreateModel(UOWContext context,
            IAuthorizationService authorizationService,
            UserManager<Student> userManager) : base(context,authorizationService,userManager)
        {
        }

        [BindProperty]
        public Enrolment Enrolment { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id.Equals(null))
            {
                return NotFound();
            }

            var subject = await Context.Subject.FirstOrDefaultAsync(s => s.SubjectCode.Equals(id));

            if (subject==null)
            {
                return NotFound();
            }

            /*var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                                      User, Enrolment,
                                                      EnrolmentOperations.Update);
            if (!isAuthorized.Succeeded)
            {
                return new ChallengeResult();
            }*/

            Enrolment = new Enrolment();

            Enrolment.SubjectCode = subject.SubjectCode;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Enrolment.StudentID = UserManager.GetUserId(User);

            // requires using ContactManager.Authorization;
            var isAuthorized = await AuthorizationService.AuthorizeAsync(
                                                        User, Enrolment,
                                                        EnrolmentOperations.Create);
            if (!isAuthorized.Succeeded)
            {
                return new ChallengeResult(); //redirect to login
            }

            //create enrolment only if there's not a previous new enrolment (ungraded) for the same subject
            var prevEnrolment = Context.Enrolment.Where(e => (e.StudentID == Enrolment.StudentID
                                                      && e.Subject.SubjectCode == Enrolment.SubjectCode
                                                      && e.Grade==null));
            if (prevEnrolment.Count()>0)
            {
                return NotFound();
            }

            Enrolment.EnrolDate = DateTime.Now;

            Context.Enrolment.Add(Enrolment);
            await Context.SaveChangesAsync();

            return RedirectToPage("./Index",null,null,"new");
        }
    }
}