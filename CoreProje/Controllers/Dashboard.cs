using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProje.Controllers
{
    public class Dashboard : Controller
    {
        [Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
