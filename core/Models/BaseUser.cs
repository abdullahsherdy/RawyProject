using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Models
{
    public class BaseUser:IdentityUser
    {

        public string? ProfilePicture { get; set; }
        public string DisplayName { get; set; }

        public DateTime DateJoined { get; set; } = DateTime.UtcNow;
    }
}
