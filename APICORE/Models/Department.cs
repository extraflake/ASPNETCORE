using APICORE.Bases;
using APICORE.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICORE.Models
{
    public class Department : BaseModel, IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department() { }

        public Department(DepartmentVM departmentVM)
        {
            this.Name = departmentVM.Name;
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public virtual void Update(DepartmentVM departmentVM)
        {
            this.Name = departmentVM.Name;
            this.UpdateDate = DateTimeOffset.Now.LocalDateTime;
        }

        public virtual void Delete()
        {
            this.DeleteDate = DateTimeOffset.Now.LocalDateTime;
            this.IsDelete = true;
        }
    }
}
