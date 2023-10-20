using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        WriterMessageManager messageManager = new WriterMessageManager(new EfWriterMesssageDal());
        public IViewComponentResult Invoke()
        {
            string p = "admin@gmail.com";
            var values = messageManager.GetListReceiverMessage(p).OrderByDescending(x=>x.Id).Take(3).ToList();
            return View(values);
        }
    }
}
