using System.Collections.Generic;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        public string Description { get; set; }= default!;
        public virtual IList<Grade>? Grades { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }= string.Empty;

        public virtual IList<SubjectGroup>? SubjectGroups { get; set; }
        public virtual Teacher Teacher { get; set; }= default!;
        public int? TeacherId { get; set; } 
    }
}