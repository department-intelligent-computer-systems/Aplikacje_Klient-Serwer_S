using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels
{
public class role : IdentityRole<int>
{
public RoleValue RoleValue { get; set; } = default! ;
public Role { name: string, RoleValue }
}
}