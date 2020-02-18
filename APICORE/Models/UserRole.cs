using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APICORE.Models
{
    public class UserRole
    {
        public int Id { get; set; }

        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User User { get; set; }

        public int Role_Id { get; set; }
        [ForeignKey("Role_Id")]
        public Role Role { get; set; }
    }
}
