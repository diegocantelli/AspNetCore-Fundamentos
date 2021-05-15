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
        [Route("")]
        // É possível passar parâmetros via atributos de rotas
        // basta colocar o nome do atributo entre chaves. O nome do atributo deve ser o mesmo que é recebido por parâmetro
        // na controller
        // Para informar que um atributo não é obrigatório, basta adicionar "?" no final do atributo especificado na rota
        // Especificando o tipo do parâmetro via rota impede a aplicação quebre por conta do tipo de parâmetro informado na rota
        // Ex: A rota espera um inteiro, mas é passado uma string, caso seja feita alguma operação em cima deste parâmetros,
        // a aplicação pode quebrar
        [Route("pagina-inicial/{id:int}/{categorias?}")]
        public IActionResult Index(int id, string categorias)
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
