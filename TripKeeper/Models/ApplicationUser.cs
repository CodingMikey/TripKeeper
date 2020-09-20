using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TripKeeper.Models
{
    //Adding custom user properties in this class by inheriting from IdentityUser
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }
    }
}
