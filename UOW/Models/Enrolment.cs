using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//using UOW.Areas.Identity.Data;

namespace UOW.Models
{
    public enum Grade
    {
        TF,F, P, C, D, HD
    }

    public class Enrolment
    {
        public int EnrolmentID { get; set; }

        //taken from AspNetUsers ID
        public string StudentID { get; set; }

        public string SubjectCode { get; set; }

        [Display(Name="Enrolment Date")]
        public DateTime EnrolDate { get; set; }

        public Grade? Grade { get; set; }

        public int? Point { get; set; }

        public Subject Subject { get; set; }
        public Student Student { get; set; }
    }
}
