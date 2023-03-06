using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace SchoolRegister.Model.DataModels
{
    public class SubjectGroup
    {
        //public SubjectGroup() { }

        public Subject Subject{get; set; }

        public int Subjectid { get;set; }

        public Group Group { get; set; }
    }
}