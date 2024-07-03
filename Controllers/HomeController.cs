using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Servicio;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repo;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repo)
        {
            _logger = logger;
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var lista = repo.ObtenerProyectos();
            HomeIndexViewModel model = new HomeIndexViewModel() { Proyectos = lista };
            model.Persona = new Persona { Edad = 0, Nombre = "" };
            return View(model);
        }

        public IActionResult Proyectos()
        {
            var lista = repo.ObtenerProyectos();
            return View(lista);
        }

        public IActionResult Contacto()
        {
            
            return View();
        }

        public IActionResult FormularioEnviado()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Contacto(ContactoViewModel contacto)
        {
            

            return RedirectToAction("Contacto");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
