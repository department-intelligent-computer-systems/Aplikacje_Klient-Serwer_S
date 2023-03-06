using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels
{
public class Student : User
{
    public Group? Group { get; set; }
    public int? GroupId { get; set; }
    public IList<Grade> Grades { get; set; }
    public Parent Parent {get; set;}
    public int? ParentId { get; set; }
    public double AverageGrade {get;}
    public string Description { get; set; }
    public IList<SubjectGroup> SubjectGroups { get; set; }
    public Teacher Teacher { get; set; }
    public int? TeacherId { get; set; }
    public IList<Grade> Grades { get; set; }

   
}

}
}