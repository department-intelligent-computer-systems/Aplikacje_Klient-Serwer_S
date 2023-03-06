namespace SchoolRegister.Model.DataModels
{
    public class SubjectGroup
    {
        public  Subject Subject {get;set;} = default!;
        public int SubjectId {get; set;}
        public Group? Group {get;set;}
        public int GroupId  {get;set;}

    }
}