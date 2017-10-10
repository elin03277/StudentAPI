namespace StudentAPI.Migrations.StudentMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using StudentAPI.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentAPI.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\StudentMigrations";
        }

        protected override void Seed(StudentAPI.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Students.AddOrUpdate(s => new { s.StudentID, s.FirstName, s.LastName, s.Program },
                GetStudents().ToArray()
                );
        }

        private List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    StudentID = "A00111111",
                    FirstName = "John",
                    LastName = "Archer",
                    Program = "CIT"
                },
                new Student()
                {
                    StudentID = "A00222222",
                    FirstName = "Jane",
                    LastName = "Baker",
                    Program = "CST"
                },
                new Student()
                {
                    StudentID = "A00333333",
                    FirstName = "Bill",
                    LastName = "Carter",
                    Program = "BTECH"
                },
                new Student()
                {
                    StudentID = "A00444444",
                    FirstName = "Judy",
                    LastName = "Fisher",
                    Program = "Nursing"
                }
            };

            return students;
        }

    }
}
