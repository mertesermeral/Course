using Course.Models;
using Microsoft.AspNetCore.Mvc;

namespace Course.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        
        }
        
        public IActionResult Apply() //
        {
            return View();
        
        }
        [HttpPost]
        [ValidateAntiForgeryToken] //token dogrulama ile guvenlik saglar.
        public IActionResult Apply(Candidate model) //
        {
            Repository.Add(model); //model bilgisi işlendi
            return Redirect("/"); //home'a dönecek
        
        }
        
    }



    
}