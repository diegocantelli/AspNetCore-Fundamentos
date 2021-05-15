using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DesenvolvedorIoDemoMVC.Models;

namespace DesenvolvedorIoDemoMVC.Controllers
{
    // É possível utilizar sobrecarga de rotas
    // A HomeController será acessível tanto pela url vazia como através do prefixo gestao-clientes
    [Route("")]
    //Este será um prefixo para as rotas desta controller
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        //Na url aparecerá assim: gestão-clientes/index
        [Route("index")]
        public IActionResult Index()
        {
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
