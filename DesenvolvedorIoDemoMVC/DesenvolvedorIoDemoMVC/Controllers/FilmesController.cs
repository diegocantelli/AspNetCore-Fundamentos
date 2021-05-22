using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DesenvolvedorIoDemoMVC.Controllers
{
    public class FilmesController : Controller
    {
        // Irá devolver o formulário de adicionar filmes
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }
    }
}