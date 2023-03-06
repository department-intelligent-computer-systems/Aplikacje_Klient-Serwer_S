using System;
using System.Collections.Generic;

namespace SchoolRegister.Model.DataModels
{
    public class Grade
    {
    public DateTime DateOfIssue { get; set; }
    public GradeScale GradeValue { get; set; }
    public virtual Student Student { get; set; }= default!;
    public int StudentId { get; set; }
    public virtual Subject Subject { get; set; }= default!;
    public int SubjectId { get; set; }
    }
}