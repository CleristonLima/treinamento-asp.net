using ASPNETCOREMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPNETCOREMVC.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

       /* public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        [HttpPost]
        [HttpGet]
        public IActionResult Index(HomeModel formulario)
        {
            CarregarListaDados();
            return View();
        }

        /*public IActionResult Privacy()
        {
            return View();
        }*/

        public void CarregarListaDados()
        {
            HomeModel objHomeModel = new HomeModel();
            ViewBag.Lista = objHomeModel.GetAll();
        }

       /* [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
