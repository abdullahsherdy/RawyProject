using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Models
{
    public class BaseUser:BaseClass
    {

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string? ProfilePicture { get; set; }

        public DateTime DateJoined { get; set; } = DateTime.UtcNow;
        public bool IsAuthenticated { get; set; } = false;
    }
}
