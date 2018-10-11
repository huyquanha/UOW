using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UOW.Models;

namespace UOW.Data
{
    public static class DbInitializer
    {
        public static void Initialize(UOWContext context)
        {
            // Look for any enrolments.
            if (context.Enrolment.Any())
            {
                return;   // DB has been seeded
            }

            var subjects = new Subject[]
            {
                new Subject{SubjectCode="CSIT111",Session="Both",Title="Programming Fundamentals",Credits=6,Description="Good",Price=1759.5M},
                new Subject{SubjectCode="CSIT113",Session="Both",Title="Problem Solving",Credits=6,Description="Good",Price=1825.75M},
                new Subject{SubjectCode="CSIT115",Session="Both",Title="Database&Security",Credits=6,Description="Good",Price=1600M},
                new Subject{SubjectCode="CSIT127",Session="Autumn",Title="Network&Communications",Credits=6,Description="Good",Price=1590.95M},
                new Subject{SubjectCode="CSIT128",Session="Spring",Title="Intro to Web",Credits=6,Description="Good",Price=1759.5M},
                new Subject{SubjectCode="CSIT114",Session="Autumn",Title="IT Project Management",Credits=6,Description="Good",Price=1700M},
                new Subject{SubjectCode="CSIT121",Session="Spring",Title="Advanced Java",Credits=6,Description="Good",Price=1800.2M},
            };
            if (!context.Subject.Any())
            {
                foreach (Subject s in subjects)
                {
                    context.Subject.Add(s);
                }
                context.SaveChanges();
            }
            
            var enrolments = new Enrolment[]
            {
                new Enrolment{StudentID="ead0ca4b-7364-4765-b381-1db100eeb09b",EnrolDate=DateTime.Now,SubjectCode="CSIT111",Grade=Grade.HD,Point=91},
                new Enrolment{StudentID="ead0ca4b-7364-4765-b381-1db100eeb09b",EnrolDate=DateTime.Now,SubjectCode="CSIT113",Grade=Grade.HD,Point=95},
                new Enrolment{StudentID="ead0ca4b-7364-4765-b381-1db100eeb09b",EnrolDate=DateTime.Now,SubjectCode="CSIT115",Grade=Grade.HD,Point=93},
                new Enrolment{StudentID="ead0ca4b-7364-4765-b381-1db100eeb09b",EnrolDate=DateTime.Now,SubjectCode="CSIT127",Grade=Grade.D,Point=84},
                /*new Enrolment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrolment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrolment{StudentID=3,CourseID=1050},
                new Enrolment{StudentID=4,CourseID=1050},
                new Enrolment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},*/
            };
            foreach (Enrolment e in enrolments)
            {
                context.Enrolment.Add(e);
            }
            context.SaveChanges();
        }
    }
}

