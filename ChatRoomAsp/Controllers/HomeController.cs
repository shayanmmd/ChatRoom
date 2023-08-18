using ChatRoom.Application.DTOs.GroupNameDto;
using ChatRoomAsp.Contracts;
using ChatRoomAsp.Models;
using ChatRoomAsp.Services;
using ChatRoomAsp.Services.Base;
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
        private readonly IGroupNameService _groupNameService;

        public HomeController(ILogger<HomeController> logger, IGroupNameService groupNameService)
        {
            _logger = logger;
            _groupNameService = groupNameService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ShowListGroups()
        {
            var res = await _groupNameService.GetAsync(Guid.Parse("aec6cbb9-34c4-4d3a-a8a2-0f1256a0c297"));
            return View(res);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
