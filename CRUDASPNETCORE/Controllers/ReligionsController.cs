using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using APICORE.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CRUDASPNETCORE.Controllers
{
    public class ReligionsController : Controller
    {
        private readonly IConfiguration _configuration;

        public ReligionsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View(LoadReligion());
        }

        public JsonResult LoadReligion()
        {
            string token = _configuration.GetValue<string>("Jwt");
            ReligionVM religionVM = null;
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44372/api/")
            };
            client.DefaultRequestHeaders.Add("Authorization", _configuration.GetValue<string>("Jwt"));
            var responseTask = client.GetAsync("Religions");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                
            }
            else
            {
                // try to find something
            }
            return Json(result);
        }
    }
}