using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegister.Model.DataModel
{
    public class SubjectGroup
    {
        public string Subject { get; set; } = string.Empty;
        public int SubjectId { get; set; }
        public string Group { get; set; } = string.Empty;
        public string GroupId { get; set; } = string.Empty;
    }
}