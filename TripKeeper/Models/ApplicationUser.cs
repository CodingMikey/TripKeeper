using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripKeeper.Models
{
    //Adding custom user data in this class by inheriting from IdentityUser
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
