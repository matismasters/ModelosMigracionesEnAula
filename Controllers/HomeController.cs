using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ModelosMigracionesEnAula.Data;
using ModelosMigracionesEnAula.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace ModelosMigracionesEnAula.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;


        public HomeController(ILogger<HomeController> logger,
            AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Producto> productos = _context.Productos.ToList();
            ViewData["Productos"] = productos;
            ViewBag.Productos = productos;
            return View();
        }

        public IActionResult Detalle(int id)
        {
            Producto? producto = _context.Productos.Find(id);
            // Manejar la excepcion de que no hay producto
            if (producto == null)
            {
                return NotFound();
            }

            ViewBag.Producto = producto;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
