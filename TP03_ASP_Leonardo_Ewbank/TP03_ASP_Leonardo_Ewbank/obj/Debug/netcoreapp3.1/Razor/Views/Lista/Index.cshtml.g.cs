#pragma checksum "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c21f61c4232690c258a106f4883366ea472a680"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lista_Index), @"mvc.1.0.view", @"/Views/Lista/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c21f61c4232690c258a106f4883366ea472a680", @"/Views/Lista/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90639224818ba3506d1914eba98b70993f88d1ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Lista_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Aniversariantes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Lista", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Novo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btn_cad"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Aniversariantes</h1>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
 if (!String.IsNullOrEmpty(ViewBag.Message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\" role=\"alert\">\r\n        ");
#nullable restore
#line 15 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Nome: ");
#nullable restore
#line 22 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
         Write(Html.TextBox("SearchName"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <input type=\"submit\" value=\"SearchName\" />\r\n    </p>\r\n");
#nullable restore
#line 25 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table id=\"Lista_Aniversario\">\r\n\r\n   <thead>\r\n        <tr>\r\n            <th> Nome</th>\r\n            <th> Data de Nascimento</th>\r\n            <th> </th>\r\n            <th> </th>\r\n            <th> </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
         foreach (var aniversariante in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 43 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
                Write(aniversariante.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 43 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
                                      Write(aniversariante.sobrenome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 44 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
                Write(aniversariante.DataNascimento.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> <a class=\"btn btn-info btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 947, "\"", 991, 2);
            WriteAttributeValue("", 954, "/Lista/Detalhes?id=", 954, 19, true);
#nullable restore
#line 45 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
WriteAttributeValue("", 973, aniversariante.Id, 973, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Detalhes </a> </td>\r\n                <td> <a class=\"btn btn-dark btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1066, "\"", 1108, 2);
            WriteAttributeValue("", 1073, "/Lista/Editar?id=", 1073, 17, true);
#nullable restore
#line 46 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
WriteAttributeValue("", 1090, aniversariante.Id, 1090, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Editar </a> </td>\r\n                <td> <a class=\"btn btn-warning  btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1185, "\"", 1228, 2);
            WriteAttributeValue("", 1192, "/Lista/Excluir?id=", 1192, 18, true);
#nullable restore
#line 47 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
WriteAttributeValue("", 1210, aniversariante.Id, 1210, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Remover </a> </td>\r\n            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\leona\Downloads\Aulas_Fundamentos Web ASP.NET\TP03_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Lista\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n\r\n\r\n\r\n</table>\r\n<div id=\"bot\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c21f61c4232690c258a106f4883366ea472a68010386", async() => {
                WriteLiteral("Cadastrar aniversariante");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<style>
    #Lista_Aniversario {
        width: 600px;
        margin: 0 auto;
        text-align: center;
        margin-top: 50px;
        border: 1px solid black;
    }

    h1 {
        text-align: center;
    }

    #bot {
        display: flex;
    }

    #btn_cad {
        margin: 0 auto;
        margin-top: 10px;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Aniversariantes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
