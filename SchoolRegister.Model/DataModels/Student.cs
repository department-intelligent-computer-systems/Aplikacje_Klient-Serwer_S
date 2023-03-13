using System;
namespace SchoolRegister.Model.DataModels
{
     public class Student: User
    {
        public Group Group { get; set; }
        public int GroupId { get; set; }
        public IList<Grade> Grades { get; set; }
        public Parent Parent { get; set; }
        public int ParentId { get; set; }
        public double AverageGrade => Grades == null || Grades.Count == 0 ? 0.0d : Math.Round(Grades.Average(g=>(int)g.GradeValue),1);
        public IDictionary<string, double> AverageGradePerSubject;
        public IDictionary<string, List<GradeScale>> GradesPerSubject;

    }
}