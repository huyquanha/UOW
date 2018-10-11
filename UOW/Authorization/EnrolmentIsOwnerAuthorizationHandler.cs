using System.Threading.Tasks;
//using UOW.Data;
using UOW.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;

namespace UOW.Authorization
{
    public class EnrolmentIsOwnerAuthorizationHandler
                : AuthorizationHandler<OperationAuthorizationRequirement, Enrolment>
    {
        UserManager<Student> _userManager;

        public EnrolmentIsOwnerAuthorizationHandler(UserManager<Student>
            userManager)
        {
            _userManager = userManager;
        }

        protected override Task
            HandleRequirementAsync(AuthorizationHandlerContext context,
                                   OperationAuthorizationRequirement requirement,
                                   Enrolment resource)
        {
            if (context.User == null || resource == null)
            {
                // Return Task.FromResult(0) if targeting a version of
                // .NET Framework older than 4.6:
                return Task.CompletedTask;
            }

            // If we're not asking for CRUD permission, return.

            if (requirement.Name != Constants.CreateOperationName &&
                requirement.Name != Constants.ReadOperationName &&
                requirement.Name != Constants.UpdateOperationName &&
                requirement.Name != Constants.DeleteOperationName)
            {
                return Task.CompletedTask;
            }

            if (resource.StudentID == _userManager.GetUserId(context.User))
            {
                context.Succeed(requirement);
            }

            //compare student number instead of ID
            /*if (resource.StudentNumber == _userManager.GetUserAsync(context.User).Result.StudentNumber)
            {
                context.Succeed(requirement);
            }*/

            return Task.CompletedTask;
        }
    }
}
