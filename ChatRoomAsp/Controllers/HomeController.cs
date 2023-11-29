using Microsoft.AspNetCore.Mvc;

namespace ChatRoomAsp.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
