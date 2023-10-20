using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreProje.Controllers
{
    public class TestimonialController : Controller
    {
        TestimonialManager testimonialManager = new TestimonialManager(new EfTestimonialDal());
        public IActionResult Index()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            testimonialManager.TAdd(testimonial);
            return RedirectToAction("Index");
        }
        public IActionResult TestimonilaDelete(int id)
        {
            var values = testimonialManager.TGetById(id);
            testimonialManager.TDelet(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult TestimonialUpdate(int id)
        {
            var values = testimonialManager.TGetById(id);
            return View(values);    
        }
        [HttpPost]
        public IActionResult TestimonialUpdate(Testimonial testimonial)
        {
            testimonialManager.TUpdate(testimonial);
            return RedirectToAction("Index");   
        }

    }
}
