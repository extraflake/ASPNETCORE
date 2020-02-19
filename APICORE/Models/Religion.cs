using APICORE.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APICORE.Models
{
    public class Religion : BaseModel, IEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
