using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels;
public class Role : IdentityRole<int>
{
    public RoleValue RoleValue {get; set;}
    Role(){}
    Role(string name, RoleValue roleValue){
        this.Name = name;
        this.RoleValue = roleValue;
    }
}