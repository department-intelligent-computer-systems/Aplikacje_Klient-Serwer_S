using Microsoft.AspNetCore.Identity;
using System;
namespace SchoolRegister.Model.DataModels
{
public class RoleValue : Role
{
User = 0;
Student = 1;
Parent = 2;
Teacher = 3;
Admin = 4;

}
}