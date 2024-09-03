using Microsoft.AspNetCore.Mvc;

namespace NetCoreRouting_0.Controllers
{
    public class SimulationController : Controller
    {

        //ViewBag,TempData,ViewData

        //List<string>   

        //Dictionary<int,string> sehirler = new Dictionary<int,string>() { 34,"Istanbul    };

        //Dictionary<string,object> TempData,ViewData patternidir...

        //ViewBag<string,dynamic> ViewBag

     


        public IActionResult SimulationIndex()
        {
            RouteValueDictionary routeValues= RouteData.Values;

            string controllerName = routeValues["controller"].ToString();

            ViewBag.ControllerName = controllerName;
            //ViewData["ControllerName"]  = controllerName;
          
            return View();


          
        }


       
    }
}
