using Microsoft.AspNetCore.Mvc;

namespace CoreProje.Views.Dashboard
{
    public class MapVisitor:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
