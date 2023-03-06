using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels

{
    class Parent: User
    {
        public IList<Student> Students { get; set; }    }
}
