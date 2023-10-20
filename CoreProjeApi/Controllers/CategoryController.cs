using CoreProjeApi.DAL.ApiContext;
using CoreProjeApi.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProjeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
           using var c = new Context();
            return Ok(c.Categories.ToList());    //apilerde sonucun başarılı olduğunun (200 kodunun döndüğü) method
        
        }
        [HttpGet("{id}")]
        public IActionResult CategoryById(int id)
        {
            using var c = new Context();
            var values = c.Categories.Find(id);
            if(values == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(values);
            }
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            using var c = new Context();
            c.Add(category);
            c.SaveChanges();
            return Created("", category);
        }
        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            using var c = new Context();
            var values = c.Categories.Find(id);
            if(values == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(values);
                c.SaveChanges();
                return NoContent();
            }
        }
        [HttpPut]
        public IActionResult CategoryUpdate(Category category)
        {
            using var c = new Context();
            var values = c.Find<Category>(category.CategoryId);
            if(values == null)
            {
                return NotFound();
            }
            else
            {
                values.CategoryName = category.CategoryName;
                c.Update(values);
                c.SaveChanges();
                return NoContent();
            }
        }

    }
}
