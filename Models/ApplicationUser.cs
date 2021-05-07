using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string NameUSER { get; set; }

        [Required]
        public string City { get; set; }
    }
}
