using Microsoft.AspNetCore.Mvc;

namespace NetCoreRouting_0.Controllers
{
    //Attribute Based Routing

    //[Route("simRoute")] //İcerideki yer tutucalara dikkat ediniz...Unutmayın ki Attribute Based Routing eger Middleware'de default'ta bir Controller'a denk geliyorsa o sistemi ezer
    public class HomeController : Controller
    {
        [Route("/h/deneme")] //bu sekilde de yapılabilir
        public IActionResult Index()
        {
            return View();
        }


    }
}
