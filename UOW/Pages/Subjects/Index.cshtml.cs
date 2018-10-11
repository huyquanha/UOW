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

namespace UOW.Pages.Subjects
{
    public class IndexModel : Subject_BasePageModel
    {
        //private readonly UOW.Models.UOWContext _context;

        public IndexModel(UOWContext context,
            IAuthorizationService authorizationService,
            UserManager<Student> userManager) : base(context, authorizationService, userManager)
        {
            //_context = context;
        }

        public IList<Subject> Subject { get;set; }

        public async Task OnGetAsync()
        {
            Subject = await Context.Subject.ToListAsync();
            var studentID = UserManager.GetUserId(User);
            foreach (Subject s in Subject)
            {
                var relatedEnrolments = Context.Enrolment.Where(e => (e.StudentID == studentID
                                                                && e.SubjectCode == s.SubjectCode
                                                                && e.Grade==null)); //new enrolments of s
                if (relatedEnrolments.Count()>0)
                {
                    ViewData[s.SubjectCode] = relatedEnrolments.First().EnrolmentID;
                }
                else
                {
                    ViewData[s.SubjectCode] = "Not Enrolled";
                }
            }
        }
    }
}
