using LaPacaJerseys.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LaPacaJerseys.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TiendaViewModel tienda = new TiendaViewModel();

            tienda.Jerseys.Add(new Jersey
            {
                Id = 1,
                SKU = "JER001",
                Nombre = "Jersey Rayados Local",
                Equipo = "Rayados",
                Talla = "M, L, XL",
                Precio = 1299,
                Imagen = "/images/rayados.jpg"
            });

            tienda.Jerseys.Add(new Jersey
            {
                Id = 2,
                SKU = "JER002",
                Nombre = "Jersey Tigres Local",
                Equipo = "Tigres",
                Talla = "S, M, L",
                Precio = 1399,
                Imagen = "/images/tigres.jpg"
            });

            tienda.Jerseys.Add(new Jersey
            {
                Id = 3,
                SKU = "JER003",
                Nombre = "Jersey América",
                Equipo = "América",
                Talla = "M, L, XL",
                Precio = 1199,
                Imagen = "/images/america.jpg"
            });

            tienda.Jerseys.Add(new Jersey
            {
                Id = 4,
                SKU = "JER004",
                Nombre = "Jersey Chivas",
                Equipo = "Chivas",
                Talla = "S, M, L",
                Precio = 1199,
                Imagen = "/images/chivas.jpg"
            });

            tienda.Jerseys.Add(new Jersey
            {
                Id = 5,
                SKU = "JER005",
                Nombre = "Jersey México",
                Equipo = "Selección Mexicana",
                Talla = "M, L, XL",
                Precio = 1499,
                Imagen = "/images/mexico.jpg"
            });

            tienda.Jerseys.Add(new Jersey
            {
                Id = 6,
                SKU = "JER006",
                Nombre = "Jersey Barcelona",
                Equipo = "FC Barcelona",
                Talla = "S, M, L, XL",
                Precio = 1599,
                Imagen = "/images/barcelona.jpg"
            });

            return View(tienda);
        }
    }
}
