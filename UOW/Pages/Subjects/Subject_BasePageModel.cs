using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UOW.Models;

namespace UOW.Pages.Subjects
{
    public class Subject_BasePageModel : PageModel
    {
        protected UOWContext Context { get; }
        public IAuthorizationService AuthorizationService { get; }
        protected UserManager<Student> UserManager { get; }

        public Subject_BasePageModel(
            UOWContext context,
            IAuthorizationService authorizationService,
            UserManager<Student> userManager) : base()
        {
            Context = context;
            UserManager = userManager;
            AuthorizationService = authorizationService;
        }
    }
}
