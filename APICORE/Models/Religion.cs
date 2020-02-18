using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APICORE.Models
{
    public class Religion
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
