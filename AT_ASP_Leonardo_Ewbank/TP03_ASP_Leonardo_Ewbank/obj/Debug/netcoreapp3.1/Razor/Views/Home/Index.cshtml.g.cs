#pragma checksum "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "525c3d433981dded2c670a94ae05aceb9228ecd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\_ViewImports.cshtml"
using TP03_ASP_Leonardo_Ewbank;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\_ViewImports.cshtml"
using TP03_ASP_Leonardo_Ewbank.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"525c3d433981dded2c670a94ae05aceb9228ecd4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90639224818ba3506d1914eba98b70993f88d1ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Aniversariantes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Lista", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Novo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n<div id=\"inicio\" class=\"text-center\">\r\n    <h2 class=\"display-4\">AT - ASP NET</h2>\r\n    <h3 class=\"display-4\">Gerenciamento de Aniversários</h3>\r\n</div>\r\n\r\n\r\n<h4>Acesso Rápido</h4>\r\n\r\n<div id=\"Menu\">\r\n    <ul>\r\n        <li><h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "525c3d433981dded2c670a94ae05aceb9228ecd44979", async() => {
                WriteLiteral("Visualize os Aniversariantes Cadastrados");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5></li>\r\n        <li><h5> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "525c3d433981dded2c670a94ae05aceb9228ecd46601", async() => {
                WriteLiteral("Cadastre um Aniversariante");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </h5></li>
    </ul>
</div>

<h4>Aniversariantes do dia</h4>
<div id=""AnivDia"">
    <table id=""Lista_Aniversario"">

        <thead>
            <tr>
                <th> Nome</th>
                <th> Data de Nascimento</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 36 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml"
             foreach (var aniversariante in Model)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml"
                 if (aniversariante.DataNascimento.Month == DateTime.Today.Month && aniversariante.DataNascimento.Day == DateTime.Today.Day)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td> ");
#nullable restore
#line 41 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml"
                        Write(aniversariante.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 41 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml"
                                              Write(aniversariante.sobrenome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td> ");
#nullable restore
#line 42 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml"
                        Write(aniversariante.DataNascimento.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>

</div>
<br />
<br />

<div id=""AnivDia"">
    <table id=""Lista_Aniversario"">
        <h4> Próximos aniversariantes</h4>
        <thead>
            <tr>
                <th> Nome</th>
                <th> Data de Nascimento</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 62 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml"
             foreach (var aniversariante in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td> ");
#nullable restore
#line 66 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml"
                    Write(aniversariante.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 66 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml"
                                          Write(aniversariante.sobrenome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 67 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml"
                    Write(aniversariante.DataNascimento.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 69 "C:\Users\leona\Documents\GitHub\FundamentosASPNET\AT_ASP_Leonardo_Ewbank\TP03_ASP_Leonardo_Ewbank\Views\Home\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>

</div>


<style>
    #inicio {
        margin-bottom: 20px;
        width: 900px;
        text-align: center;
        margin: 0 auto;
        margin-bottom: 10px;
    }

    #Menu {
        width: 600px;
        margin: 0 auto;
        margin-bottom: 30px;
        border: 1px solid red;
        border-radius: 10px;
        margin-top: 10px;
        list-style-type: none;
    }

    h4 {
        text-align: center;
    }

    #AnivDia {
        text-align: center;
        margin-bottom: 10px;
    }

    #Lista_Aniversario {
        width: 600px;
        margin: 0 auto;
        text-align: center;
        margin-top: 20px;
        border: 1px dashed red;
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
