using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreProje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager _announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values = _announcementManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AnnouncementDetails(int id)
        {
            Announcement announcement =  _announcementManager.TGetById(id);
            return View(announcement);
        }
    }
}
