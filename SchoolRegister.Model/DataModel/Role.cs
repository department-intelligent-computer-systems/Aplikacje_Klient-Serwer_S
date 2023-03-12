using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels
{
    public class Role : IdentityRole<int>
    {
          public RoleValue RoleValue { get; set;}
       
        public Role(string name, RoleValue rolevalue) 
        {
            name = this.Name;
            roleValue = this.RoleValue;

        }
    }
    
}