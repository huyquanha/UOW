using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UOW.Models
{
    public class Student : IdentityUser
    {
        [PersonalData]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string StudentNumber { get; set; }

        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }

        [PersonalData]
        public DateTime DOB { get; set; }

        public ICollection<Enrolment> Enrolments { get; set; }
    }
}
