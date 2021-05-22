using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesenvolvedorIoDemoMVC.ViewComponents
{
    // Definindo o nome pelo qual este view component será chamado
    [ViewComponent(Name = "Carrinho")]
    // para criar um viewcomponent é necessário herdar de ViewComponent
    public class CarrinhoViewComponent : ViewComponent
    {
        public int ItensCarrinho { get; set; }

        public CarrinhoViewComponent()
        {
            ItensCarrinho = 3;
        }
        // este método é necessário para o funcionamento do viewcomponent
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // será necessário criar o caminho abaixo na estrutura do projeto
            // Irá retornar a view dentro de Shared/Components/Carrinho/default.cshtml
            // default.cshtml será a view que irá buscar por padrão no caminho acima
            return View(ItensCarrinho);
        }
    }
}
