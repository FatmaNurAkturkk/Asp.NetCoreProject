using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreProje.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //[HttpPost]
        //public IViewComponentResult Invoke(Message m)
        //{
        //    m.Date=Convert.ToDateTime(DateTime.Now.ToShortDateString()); // mesajın kaydedildiği andaki tarihi veritabanına yansıt
        //    m.Status = true; //başlangıçtada aktif olsun okundıktan sonra false çekeriz
        //    messageManager.TAdd(m); //parametreden gelen değeri messagemanager içerisine ekle
        //    return View();
        //}
    }
}
