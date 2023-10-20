using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProje.ViewComponents.Dashboard
{
    public class StatisticDashboard2:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Portfolios.Count();
            ViewBag.v2 = c.Messages.Count();
            ViewBag.v3 = c.Services.Count();
            return View();
        }
    }
}
