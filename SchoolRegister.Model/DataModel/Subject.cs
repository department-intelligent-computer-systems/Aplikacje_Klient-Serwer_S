using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModel
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Descripton { get; set; } = string.Empty;
        public IList<SubjectGroup> SubjectGroups { get; set; }
        public string Teacher { get; set; } = string.Empty;
        public int? TeacherId { get; set; }
        public IList<Grade> Grades { get; set; }
    }
}