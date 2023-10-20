﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreProje.Controllers
{
    public class SocialMediaController : Controller
    {
        SocialMediaManager socialMediaManager = new SocialMediaManager(new EfSocialMediaDal());
        public IActionResult Index()
        {
            var values = socialMediaManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSocialMedia(SocialMedia socialMedia)
        {
            socialMedia.Status = true;
            socialMediaManager.TAdd(socialMedia);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSocialMedia(int id)
        {
            var values = socialMediaManager.TGetById(id);
            socialMediaManager.TDelet(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSocialMedia(int id)
        {
            var values = socialMediaManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            socialMediaManager.TUpdate(socialMedia);
            return RedirectToAction("Index");

        }
    }
}
