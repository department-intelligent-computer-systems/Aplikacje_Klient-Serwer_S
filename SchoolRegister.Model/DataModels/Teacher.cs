using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels

{
    class Teacher : User
    {
        public IList<Subject> Subjects { get; set; }
        public string Title { get; set; } = string.Empty;
    }
}
