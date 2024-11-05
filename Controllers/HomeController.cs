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


        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Producto> productosAgregar = new List<Producto>();
            productosAgregar.Add(new Producto { Nombre = "Producto 2", Precio = 99 });
            productosAgregar.Add(new Producto { Nombre = "Producto 3", Precio = 99 });

            _context.Productos.AddRange(productosAgregar);
            _context.SaveChanges();
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
