using ChatRoom.Application.DTOs.GroupNameDto;
using ChatRoomAsp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChatRoomAsp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowListGroups()
        {
            var httpClient = new HttpClient();
            var res = httpClient.GetAsync("https://localhost:44305/GroupName/GetAll").Result;
            var body = res.Content.ReadAsStringAsync().Result;
            var output = JsonConvert.DeserializeObject<GroupName>(body);
            return View(output);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
