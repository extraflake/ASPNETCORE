using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using APICORE.Models;
using APICORE.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CLIENTCORE.Controllers
{
    public class ReligionsController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient httpClient;

        public ReligionsController(IConfiguration configuration)
        {
            _configuration = configuration;
            httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44372/api/")
            };
            httpClient.DefaultRequestHeaders.Add("Authorization", _configuration.GetValue<string>("Jwt"));
        }

        public IActionResult Index()
        {
            return View(Load());
        }

        public JsonResult Load()
        {
            IList<Religion> religion = null;
            var responseTask = httpClient.GetAsync("Religions");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<IList<Religion>>();
                readTask.Wait();
                religion = readTask.Result;
            }
            return Json(result);
        }
    }
}