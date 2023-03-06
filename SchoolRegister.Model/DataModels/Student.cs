using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace SchoolRegister.Model.DataModels
{
    public class Student : User
    {
        public Group Group { get; set; }
        public int GroupId { get; set; }
        public IList<Grade> Grades { get; set; }

        public Parent Parent { get; set; }

        public int? ParentId { get; set; }

        public double AverageGrade => Grades == null || Grades.Count == 0 ? 0.0d: Math.Round(Grades.Average(g => (int)g.GradeValue),1);
        

        public IDictionary<string, double> AverageGradePerSubject
        => Grades ==null ? new Dictionary<string, double>():
        Grades.GroupBy(g => g.Subject.Name).Select(g => new {SubjectName = g.Key, AvgGrade= Math.Round(g.Average(avg =>(int)avg.GradeValue),1)})
        .ToDictionary(avg => avg.SubjectName,avg=>avg.AvgGrade);
        /*{
           
            get
            {
                var result = new Dictionary<string, double>();

                foreach (var grade in Grades)
                {
                    var subjectName = grade.Subject.Name;
                    if (!result.ContainsKey(subjectName))
                    {
                        result[subjectName] = 0;
                    }
                    result[subjectName] += (int)grade.GradeValue;
                }

                foreach (var key in result.Keys.ToList())
                {
                    result[key] /= Grades.Count(g => g.Subject.Name == key);
                }

                return result;
            }
            

        }
        */
        public IDictionary<string, List<GradeScale>> GradesPerSubject
        => Grades==null ? new Dictionary<string, List<GradeScale>>():Grades
        .GroupBy(g=>g.Subject.Name).Select(g=> new{SubjectName = g.Key, GradeList = g.Select(x=>x.GradeValue).ToList()})
        .ToDictionary(x=> x.SubjectName,x =>x.GradeList);
        /*{
            get
            {
                var result = new Dictionary<string, List<GradeScale>>();

                foreach (var grade in Grades)
                {
                    var subjectName = grade.Subject.Name;
                    if (!result.ContainsKey(subjectName))
                    {
                        result[subjectName] = new List<GradeScale>();
                    }
                    result[subjectName].Add(grade.GradeValue);
                }

                return result;
            }
        }

       // public Student() { }
    }
    */
}
}