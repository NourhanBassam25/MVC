using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
    
        //public string Index()
        //{
        //    return "Hello from index action";
        //} 
        //public ActionResult Index()
        //{
        //    ContentResult contentResult = new ContentResult();
        //    contentResult.Content = "Hello from content result";
        //    return contentResult;

        //}

        //or using helper Method

        //public ActionResult Index() 
        //{
        //    return Content("Hello from content result");
        //}

        //public string AboutUs()
        //{
        //    return "Hello from AboutUs action";
        //}
        //public ActionResult AboutUs()
        //{
        //    return Redirect("https://drive.google.com/drive/folders/1B4LSkY9-CsC55oExo0m5AtWAlMv6Fk1K");
        //}


        public IActionResult Index()
        {
            return View(); 
        } 
        public IActionResult ContactUs()
        {
            return View(); 
        } 
        public IActionResult AboutUs()
        {
            return View(); 
        }
        public IActionResult Privacy()
        {
            return View(); 
        }
    
    }
}
