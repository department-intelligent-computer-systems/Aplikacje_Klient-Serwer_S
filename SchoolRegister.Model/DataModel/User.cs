using Microsoft.AspNetCore.Identity;
using System;

namespace SchoolRegister.Model.DataModels
{
    public class User : IdentityUser<int>
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public DateTime RegistrationDate { get; set; }
    }
}