using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesenvolvedorIoDemoMVC.Models;
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

        [HttpPost]
        public IActionResult Adicionar(Filme filme)
        {
            if (ModelState.IsValid)
            {

            }
            // devolvendo a model com as validações para serem exibidas na view
            return View(filme);
        }
    }
}