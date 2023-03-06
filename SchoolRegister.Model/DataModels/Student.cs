using System.Reflection;
using System.Data.Common;
namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public Group Group {get;set;} = default!;
        public int? GroupId {get;set;}
        public IList<Grade> Grades {get;set;} = default!;
        public Parent Parent {get; set;} = default!;
        public int?  ParentId  {get; set;}
       

    }
}