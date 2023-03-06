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

        public double AverageGrade
        {
            get
            {
                double sum = 0;
                foreach(Grade grade in Grades)
                {
                    sum += (int)(grade.GradeValue);
                }
                return sum / Grades.Count;
            }
        }

        public IDictionary<string, double> AverageGradePerSubject
        {
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

        public IDictionary<string, List<GradeScale>> GradesPerSubject
        {
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
}