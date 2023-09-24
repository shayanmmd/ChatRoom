using ChatRoomAsp.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
