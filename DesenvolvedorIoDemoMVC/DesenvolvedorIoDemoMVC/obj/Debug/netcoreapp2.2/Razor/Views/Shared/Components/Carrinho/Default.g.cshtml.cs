#pragma checksum "C:\Users\pc-cantelli\Documents\Programação 2018\Asp.Net Core\Desenvolvedor.io\mvcdemo\DesenvolvedorIoDemoMVC\DesenvolvedorIoDemoMVC\Views\Shared\Components\Carrinho\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0f5560304e2e8f3d2df81e61a1a1f9ae81bcc14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Carrinho_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Carrinho/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Carrinho/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Carrinho_Default))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 4 "C:\Users\pc-cantelli\Documents\Programação 2018\Asp.Net Core\Desenvolvedor.io\mvcdemo\DesenvolvedorIoDemoMVC\DesenvolvedorIoDemoMVC\Views\_ViewImports.cshtml"
using DesenvolvedorIoDemoMVC;

#line default
#line hidden
#line 5 "C:\Users\pc-cantelli\Documents\Programação 2018\Asp.Net Core\Desenvolvedor.io\mvcdemo\DesenvolvedorIoDemoMVC\DesenvolvedorIoDemoMVC\Views\_ViewImports.cshtml"
using DesenvolvedorIoDemoMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0f5560304e2e8f3d2df81e61a1a1f9ae81bcc14", @"/Views/Shared/Components/Carrinho/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0f02e3f8c2ae7c13dbb25b98f3ecf7b1a4a6a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Carrinho_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(161, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\pc-cantelli\Documents\Programação 2018\Asp.Net Core\Desenvolvedor.io\mvcdemo\DesenvolvedorIoDemoMVC\DesenvolvedorIoDemoMVC\Views\Shared\Components\Carrinho\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(204, 65, true);
            WriteLiteral("\r\n<span class=\"text-capitalize text-center\">Carrinho de compras: ");
            EndContext();
            BeginContext(270, 5, false);
#line 9 "C:\Users\pc-cantelli\Documents\Programação 2018\Asp.Net Core\Desenvolvedor.io\mvcdemo\DesenvolvedorIoDemoMVC\DesenvolvedorIoDemoMVC\Views\Shared\Components\Carrinho\Default.cshtml"
                                                          Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(275, 7, true);
            WriteLiteral("</span>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591