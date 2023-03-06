using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public IList<SubjectGroup> SubjectGroup { get; set; }

        public Teacher Teacher { get; set; }

        public int? TeacherId { get; set; }

        public IList<Grade> Grades { get; set; }

        public Subject()
        {
            return;
        }
    }
}