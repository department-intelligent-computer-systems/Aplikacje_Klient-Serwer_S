using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public virtual IList<Student> Students { get; set; }= default!;
        public virtual IList<SubjectGroup> SubjectGroups { get; set; }= default!;
        
    }
}