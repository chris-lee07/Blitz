using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Data
{
    public class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return; // DB has been seeded
            }

            var students = new Student[]
            {
                new Student
                {
                    FirstName = "John",
                    LastName = "Smith"
                },
                new Student
                {
                    FirstName = "Jane",
                    LastName = "Smith"
                },
                new Student
                {
                    FirstName = "David",
                    LastName = "Popovich"
                },
                new Student
                {
                    FirstName = "Taylor",
                    LastName = "Maddison"
                }
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course
                {
                    CourseId = 1000, Title = "Calculus II", Credits = 4, Instructor = "Terry Crews"
                },
                new Course
                {
                    CourseId = 1050, Title = "Chemistry", Credits = 3, Instructor = "Perry Cardinal"
                },
                new Course
                {
                    CourseId = 2034, Title = "Macro Economics", Credits = 3, Instructor = "Shane Larson"
                },
                new Course
                {
                    CourseId = 2099, Title = "English 101", Credits = 3, Instructor = "Sherry Marlot"
                },
                new Course
                {
                    CourseId = 3044, Title = "Engineering", Credits = 4, Instructor = "Dayna Bartolli"
                }
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment
                {
                    StudentId = 1, CourseId = 1000
                },
                new Enrollment
                {
                    StudentId = 1, CourseId = 1050
                },
                new Enrollment
                {
                    StudentId = 1, CourseId = 2034
                },
                new Enrollment
                {
                    StudentId = 2, CourseId = 2099
                },
                new Enrollment
                {
                    StudentId = 2, CourseId = 1050
                },
                new Enrollment
                {
                    StudentId = 2, CourseId = 2034
                },
                new Enrollment
                {
                    StudentId = 3, CourseId = 3044
                },
                new Enrollment
                {
                    StudentId = 3, CourseId = 2099
                },
                new Enrollment
                {
                    StudentId = 3, CourseId = 2034
                },
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
