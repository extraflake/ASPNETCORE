using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APICORE.Models
{
    public class User
    {
        [ForeignKey("Employee")]
        public int Id { get; set; }
        public string Password { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; } 
        public virtual Employee Employee { get; set; }
    }
}
