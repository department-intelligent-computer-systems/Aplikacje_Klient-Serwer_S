namespace SchoolRegister.Model.DataModels
{
    public class Subject
    {
        
        public int Id {get;set;} 
        public string Name {get;set;} = string.Empty;
        public string? Description {get;set;}
        public IList<SubjectGroup>? SubjectGroups {get;set;}
        public string? Teacher {get;set;}
        public int TeacherId {get;set;}
        public IList<Grade>? Grades {get;set;}

    }
}