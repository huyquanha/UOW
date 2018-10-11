using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UOW.Models;
//using UOW.Areas.Identity.Data;

namespace UOW.Models
{
    public class UOWContext : IdentityDbContext<Student> { 
        public UOWContext(DbContextOptions<UOWContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            /*builder.Entity<Enrolment>()
            .HasKey(e => new { e.StudentID, e.SubjectCode });*/
        }

        public DbSet<Subject> Subject { get; set; }

        public DbSet<Enrolment> Enrolment { get; set; }

        public DbSet<Student> Student { get; set; }
    }
}
