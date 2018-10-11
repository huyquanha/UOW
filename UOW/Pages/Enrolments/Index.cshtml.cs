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
    public class IndexModel : DI_BasePageModel
    {
        //private readonly UOW.Models.UOWContext _context;

        public IndexModel(UOWContext context,
            IAuthorizationService authorizationService,
            UserManager<Student> userManager) : base(context,authorizationService,userManager)
        {
            //_context = context;
        }

        public IList<Enrolment> GradedEnrolment { get;set; }
        public IList<Enrolment> NewEnrolment { get; set; }

        public async Task OnGetAsync()
        {
            var studentID = UserManager.GetUserId(User);

            GradedEnrolment = await Context.Enrolment
                .Where(e=> e.StudentID==studentID)
                .Where(e=> e.Grade!=null)
                .Include(e => e.Subject).ToListAsync();

            NewEnrolment = await Context.Enrolment
                .Where(e => e.StudentID == studentID)
                .Where(e => e.Grade == null)
                .Include(e => e.Subject).ToListAsync();
        }
    }
}
