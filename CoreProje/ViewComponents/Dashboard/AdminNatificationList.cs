using Microsoft.AspNetCore.Mvc;

namespace CoreProje.ViewComponents.Dashboard
{
    public class AdminNatificationList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
