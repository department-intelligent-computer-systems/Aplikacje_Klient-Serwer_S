using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace SchoolRegister.Model.DataModels
{
    public class Subject
{
   // public Subject() { }
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;

    public IList<SubjectGroup> SubjectGroups { get; set; }


    public Teacher Teacher{get;set;}
    
    public int? TeacherId { get; set; }

    public IList<Grade> Grades { get; set; }



}
}