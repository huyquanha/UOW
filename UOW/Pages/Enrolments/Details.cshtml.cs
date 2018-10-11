using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UOW.Models;

namespace UOW.Pages.Enrolments
{
    public class DetailsModel : DI_BasePageModel
    {
        //private readonly UOW.Models.UOWContext _context;

        public DetailsModel(UOWContext context,
            IAuthorizationService authorizationService,
            UserManager<Student> userManager) : base(context,authorizationService,userManager)
        {
            //_context = context;
        }

        public Enrolment Enrolment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Enrolment = await Context.Enrolment
                //.Include(e => e.Student)
                .Include(e => e.Subject).FirstOrDefaultAsync(m => m.EnrolmentID == id);

            if (Enrolment == null)
            {
                return NotFound();
            }

            var studentID = UserManager.GetUserId(User);

            if (studentID != Enrolment.StudentID)
            {
                return new ChallengeResult();
            }

            return Page();
        }
    }
}
