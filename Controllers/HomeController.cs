using CadastroQuarto.Context;
using Microsoft.AspNetCore.Mvc;
using Quartos.Models;
using System.Diagnostics;

namespace Quartos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _appDbContext;
        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Quarto quarto)
        {
            if (ModelState.IsValid)
               
            {
                
                _appDbContext.Quartos.Add(quarto);
                _appDbContext.SaveChanges();
                
                ViewBag.Obrigado = "Obrigado por se cadastrar";
               
                return View("~/Views/Home/Index1.cshtml", quarto);
                

            }
           
            return View(quarto);
        }

           

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}