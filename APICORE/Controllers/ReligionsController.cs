using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APICORE.Bases;
using APICORE.Models;
using APICORE.Repositories.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICORE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReligionsController : BasesController<Religion, ReligionRepository>
    {
        public ReligionsController(ReligionRepository religionRepository) : base(religionRepository)
        {

        }
    }
}