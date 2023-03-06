using System.Data.Common;
namespace SchoolRegister.Model.DataModels
{
    public class Student
    {
        public Group Group {get;set;}
        public int? GroupId {get;set;}
        public IList<Grade> Grades {get;set;}
        public Parent Parent {get; set;}
        public double AverageGrade {get;}
        public IDictionary<string,double> AverageGradePerSubject {get;}
        public IDictionary<string, List<GradeScale>> GradesPerSubject{get;}
        


    }
}