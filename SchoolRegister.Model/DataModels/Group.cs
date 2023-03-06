using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace SchoolRegister.Model.DataModels
{
     public class Group
    {
        //public Group() { }
        public int Id { get; set; }
        public string Name { get; set; }=default!;

        public IList<Student> Students { get; set; }

        public IList<SubjectGroup> SubjectGroups { get; set; }


    }
}