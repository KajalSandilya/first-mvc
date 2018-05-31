using Microsoft.AspNetCore.Mvc;

namespace MovieProject.Controllers
{
    public class KajuController:Controller
    {
         public IActionResult Index()
        {
            return View();
        }


         public IActionResult greeting()
        {
            return View();
        }


        
    }
}