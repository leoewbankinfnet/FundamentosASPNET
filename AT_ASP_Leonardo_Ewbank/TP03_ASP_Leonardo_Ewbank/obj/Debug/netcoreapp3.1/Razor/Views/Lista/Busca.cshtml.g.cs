#pragma checksum "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Busca.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c885889828c64c76e4602ebcb008e05c0eef41fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lista_Busca), @"mvc.1.0.view", @"/Views/Lista/Busca.cshtml")]
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
#nullable restore
#line 1 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\_ViewImports.cshtml"
using TP03_ASP_Leonardo_Ewbank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\_ViewImports.cshtml"
using TP03_ASP_Leonardo_Ewbank.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c885889828c64c76e4602ebcb008e05c0eef41fd", @"/Views/Lista/Busca.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90639224818ba3506d1914eba98b70993f88d1ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Lista_Busca : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Aniversariantes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Busca.cshtml"
  
    ViewData["Title"] = "Busca";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h1>Resultado da Busca</h1>\r\n\r\n\r\n<ul>\r\n    <li> Nome: ");
#nullable restore
#line 13 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Busca.cshtml"
          Write(Model.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Busca.cshtml"
                      Write(Model.sobrenome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li> Data de Nascimento: ");
#nullable restore
#line 14 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Busca.cshtml"
                        Write(Model.DataNascimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n\r\n\r\n\r\n\r\n\r\n<style>\r\n    h1{\r\n        text-align:center;\r\n    }\r\n    ul{\r\n        border:1px solid black;\r\n        width:400px;\r\n        margin:0 auto;\r\n    }\r\n\r\n</style>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aniversariantes> Html { get; private set; }
    }
}
#pragma warning restore 1591
