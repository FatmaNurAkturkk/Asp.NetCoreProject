﻿using CoreProje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CoreProje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.PictureUrl = values.ImageUrl;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel) 
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userEditViewModel.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory(); //aktif yolu al
                var extension = Path.GetExtension(userEditViewModel.Picture.FileName);
                var Imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/UserImage/" + Imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await userEditViewModel.Picture.CopyToAsync(stream);
                user.ImageUrl = Imagename;
            }
            user.Name = userEditViewModel.Name;
            user.Surname = userEditViewModel.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEditViewModel.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "login");
            }
            return View();
        }
    }
}
