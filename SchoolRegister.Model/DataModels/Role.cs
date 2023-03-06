using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels
{
    class Role
    {
        public RoleValue RoleValue { get; set; }
        public Role(string name, RoleValue roleValue)
        {
            this.RoleValue = roleValue;
        }
    }
}
