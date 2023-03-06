using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModel
{
    public class Grade
    {
        public string DateOfIssue { get; set; } = string.Empty;
        public string GradeValue { get; set; } = string.Empty;
        public string Subject { get; set; } = string.Empty;
        public int SubjectId { get; set; }
        public int StudentId { get; set; }
        public string StudentId { get; set; } = string.Empty;
    }
}