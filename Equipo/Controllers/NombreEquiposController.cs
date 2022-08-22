using Equipo.Models;
using Microsoft.AspNetCore.Mvc;
namespace Equipo.Controllers
{
    public class NombreEquiposController :Controller
    {
        public IActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Crear(NombreEquipos nombreEquipos)
            {
            if (!ModelState.IsValid)
            {
                return View(nombreEquipos);
            }
            return View();
        }
    }
}

