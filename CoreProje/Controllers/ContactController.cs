using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreProje.Controllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = messageManager.TGetList();
            return View(values);
        }
        public IActionResult DeleteContect(int id)
        {
            var values = messageManager.TGetById(id);
            messageManager.TDelet(values);
            return RedirectToAction("Index");
        }
        public IActionResult UpdateContact(int id)
        {
            var values = messageManager.TGetById(id);
            return View(values);    
        }
    }
}
