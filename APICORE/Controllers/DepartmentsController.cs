using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICORE.Bases;
using APICORE.Context;
using APICORE.Models;
using APICORE.Repositories;
using APICORE.Repositories.Data;
using APICORE.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : BasesController<Department, DepartmentRepository>
    {
        public DepartmentsController(DepartmentRepository departmentRepository) : base(departmentRepository)
        {
            
        }
    }
}