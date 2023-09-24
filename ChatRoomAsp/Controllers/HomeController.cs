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
            var res = await _groupNameService.GetAllAsync();
            return View(res);
        }
    }
}
