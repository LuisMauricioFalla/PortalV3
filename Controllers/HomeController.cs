using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Portal.Data;
using Portal.Models;

namespace Portal.Controllers
{
    public class HomeController : Controller
    {
        //PASO 5
        private PortalDbContext _context;
        public HomeController(PortalDbContext c){
            _context = c;
        }

        //PASO 6
        public IActionResult Index()
        {
            var noticias = _context.Noticias.ToList();

            ViewBag.noticias = noticias;

            return View();
        }
        //Extension MySQL Jun Han 0.4.0
        //XAMPP Controller / Click en MySQL / START
        //en el nuevo tab MYSQL presionar + 
        //host : localhost, user : root, enter , enter, enter, enter.listo

        //PASO 10
        //Formulario para capturar los datos de la noticia

        public IActionResult RegistrarNoticia(){
            return View();
        }

        //Accion que recibe los datos del formulario
        [HttpPost]
        public IActionResult RegistrarNoticia(Noticia n){
            if(ModelState.IsValid){
                //cuando el modelo es valido
                //agrega la notica al contexto (en memoria)
                _context.Add(n);
                //Persiste el cambio
                _context.SaveChanges();
                //Redirigir al index
                return RedirectToAction("Index");

            }
            return View(n);
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
