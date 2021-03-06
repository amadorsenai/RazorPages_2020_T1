#pragma checksum "C:\Users\naldo\OneDrive\Documentos\Gabriel Rodrigues Amador\SENAI\Monitoria\RazorPages_2020_T1\Projeto Razor\acidenteMarte\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd9b18e8df34b6788644fe31494bf6e1843b850f"
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
#line 1 "C:\Users\naldo\OneDrive\Documentos\Gabriel Rodrigues Amador\SENAI\Monitoria\RazorPages_2020_T1\Projeto Razor\acidenteMarte\Views\Home\Index.cshtml"
using acidenteMarte.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd9b18e8df34b6788644fe31494bf6e1843b850f", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\naldo\OneDrive\Documentos\Gabriel Rodrigues Amador\SENAI\Monitoria\RazorPages_2020_T1\Projeto Razor\acidenteMarte\Views\Home\Index.cshtml"
    //Para escrever código C# no arquivo razor use essa estrutura com @{}
    
    Layout = "_Layout";
    var listaAcidente = (List<RelatoModel>) ViewData["ListaAcidentes"];


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    
<section class=""sectionCadastro"">
    <div class=""divTitle"">
        <h2>Conheça a <strong class=""destaque""> Scania. </strong> Nos ajude a te ajudar</h2>
        <p>Conte-nos seu caso, nós iremos ajudar o mais rápido possivel</p>
    </div>

    <div class=""divCadastro"">
        <h3>Relate Casos de acidentes</h3>
        <form class=""formCad"" method=""POST""");
            BeginWriteAttribute("action", " action=\'", 588, "\'", 628, 1);
#nullable restore
#line 18 "C:\Users\naldo\OneDrive\Documentos\Gabriel Rodrigues Amador\SENAI\Monitoria\RazorPages_2020_T1\Projeto Razor\acidenteMarte\Views\Home\Index.cshtml"
WriteAttributeValue("", 597, Url.Action("Cadastrar","Home"), 597, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <input class=""inputCad"" type=""text"" required id=""nome"" name=""nome"" placeholder=""Nome"" />
            <input class=""inputCad"" type=""email"" required placeholder=""Email"" name=""email"" id=""email"">
            <input class=""inputCad"" type=""date"" required placeholder=""Data"" name=""data"" id=""data"">
            <input class=""inputCad textBox"" type=""text"" required placeholder=""Descreva o ocorrido.."" name=""msg"" id=""msg"">

            <input class=""btnCad"" type=""submit"" value=""Informe-nos"" />
        </form>
    </div>
</section>

<section class=""sectionLista"">
    <div class=""headerLista"">
        <h3>Veja Outros Casos</h3>
        <!-- CIRCULO VERMELHO COM AFTER E BEFORE -->
        <div>
            <span class=""circle Gray""></span>
            <span class=""circle""></span>
            <span class=""circle Gray""></span>
        </div>
    </div>

    <article class=""boxLista"">

");
#nullable restore
#line 42 "C:\Users\naldo\OneDrive\Documentos\Gabriel Rodrigues Amador\SENAI\Monitoria\RazorPages_2020_T1\Projeto Razor\acidenteMarte\Views\Home\Index.cshtml"
         foreach (var item in listaAcidente)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"itemLista\">\r\n                <div>\r\n                    <h4>");
#nullable restore
#line 46 "C:\Users\naldo\OneDrive\Documentos\Gabriel Rodrigues Amador\SENAI\Monitoria\RazorPages_2020_T1\Projeto Razor\acidenteMarte\Views\Home\Index.cshtml"
                   Write(item.NomeRelator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <p>");
#nullable restore
#line 47 "C:\Users\naldo\OneDrive\Documentos\Gabriel Rodrigues Amador\SENAI\Monitoria\RazorPages_2020_T1\Projeto Razor\acidenteMarte\Views\Home\Index.cshtml"
                  Write(item.Data.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <p>");
#nullable restore
#line 50 "C:\Users\naldo\OneDrive\Documentos\Gabriel Rodrigues Amador\SENAI\Monitoria\RazorPages_2020_T1\Projeto Razor\acidenteMarte\Views\Home\Index.cshtml"
              Write(item.Mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <hr />\r\n            </div>\r\n");
#nullable restore
#line 53 "C:\Users\naldo\OneDrive\Documentos\Gabriel Rodrigues Amador\SENAI\Monitoria\RazorPages_2020_T1\Projeto Razor\acidenteMarte\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n    </article>\r\n</section>        \r\n    \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
