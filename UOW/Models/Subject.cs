using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UOW.Models
{
    public class Subject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Display(Name ="Subject Code")]
        public string SubjectCode { get; set; }

        public string Session { get; set; }

        public string Title { get; set; }
        public int Credits { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public string Description { get; set; }

        public ICollection<Enrolment> Enrolments { get; set; }
    }
}
