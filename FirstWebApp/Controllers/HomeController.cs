using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            //ViewResult view = new ViewResult();
            //view.ViewName = "Index";
            //return Content("Hello P223");
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact(string firstname,string surname)
        {
            string fullname = $"{firstname} {surname}";
            return Content(fullname);
            return View();
        }

        public ActionResult FAQ(int id)
        {
            return Content(id.ToString());
            return View();
        }
    }
}
