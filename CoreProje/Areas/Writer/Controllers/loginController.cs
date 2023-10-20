using CoreProje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Threading.Tasks;

namespace CoreProje.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class loginController : Controller
    {
        private readonly SignInManager<WriterUser> _signInManager;

        public loginController(SignInManager<WriterUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel userLoginViewModel)  //bu metot benim login işlemimin kontrolunu sağlayacak
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(userLoginViewModel.Username, userLoginViewModel.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile");
                }
            }
            else
            {
                ModelState.AddModelError("", "Hatalı Kullanıcı Adı veya Parola");
            }
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "login");
        }
   
    }
}
