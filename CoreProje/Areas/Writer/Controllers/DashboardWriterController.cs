using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardWriterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardWriterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v1 = values.Name + " " + values.Surname;

            //Statistic
            Context c = new Context();
            ViewBag.v2 = c.WriterMessages.Where(x=>x.Receiver == values.Email).Count();
            ViewBag.v3 = c.Announcements.Count();
            ViewBag.v4 = c.Users.Count();
            ViewBag.v5 = c.Skills.Count();


            return View();
        }
    }
}
