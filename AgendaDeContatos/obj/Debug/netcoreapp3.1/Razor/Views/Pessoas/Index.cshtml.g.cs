#pragma checksum "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d27eb23f2e2ad69a104d8ef43c2c2ae7baca8576"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoas_Index), @"mvc.1.0.view", @"/Views/Pessoas/Index.cshtml")]
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
#line 1 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\_ViewImports.cshtml"
using AgendaDeContatos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\_ViewImports.cshtml"
using AgendaDeContatos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d27eb23f2e2ad69a104d8ef43c2c2ae7baca8576", @"/Views/Pessoas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b804017694cb8635a24540d8465aa8f15bec1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AgendaDeContatos.Models.Pessoa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CriarPessoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtualizarPessoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
  
    ViewData["Title"] = "Contatos Cadastratos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"alert alert-dark row align-content-center\">\r\n    <div class=\"col-10 align-content-start\">\r\n        <h6>");
#nullable restore
#line 9 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
       Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" contatos cadastrados</h6>\r\n    </div>\r\n    <div class=\"col-2 align-content-end\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d27eb23f2e2ad69a104d8ef43c2c2ae7baca85765255", async() => {
                WriteLiteral("Novo Contato");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 16 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
     if (TempData["ContatoNovo"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-success\">");
#nullable restore
#line 18 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
                                  Write(TempData["ContatoNovo"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 19 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
     if (TempData["ContatoAtualizado"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-primary\">");
#nullable restore
#line 22 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
                                  Write(TempData["ContatoAtualizado"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 23 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
     if (TempData["ContatoExcluido"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-danger\">");
#nullable restore
#line 26 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
                                 Write(TempData["ContatoExcluido"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 27 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 46 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d27eb23f2e2ad69a104d8ef43c2c2ae7baca857611368", async() => {
                WriteLiteral("Atualizar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pessoaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
                                                        WriteLiteral(item.PessoaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pessoaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pessoaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pessoaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                <a class=\"btn btn-sm btn-outline-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1839, "\"", 1896, 6);
            WriteAttributeValue("", 1849, "ConfirmarExclusao(", 1849, 18, true);
#nullable restore
#line 59 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
WriteAttributeValue("", 1867, item.PessoaId, 1867, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1881, ",", 1881, 1, true);
            WriteAttributeValue(" ", 1882, "\'", 1883, 2, true);
#nullable restore
#line 59 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
WriteAttributeValue("", 1884, item.Nome, 1884, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1894, "\')", 1894, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 62 "C:\Users\Elioenai.costa\source\repos\AgendaDeContatos\AgendaDeContatos\Views\Pessoas\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<div class=""modal"" tabindex=""-1"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Confirmaçõa de Exclusão</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <p>Prosserguir com a exclusão do contato <text class=""nomeContato""></text> ?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline-secondary btnFechar"" data-bs-dismiss=""modal"">Não</button>
                <button type=""button"" class=""btn btn-outline-danger btnExcluir"" data-bs-dismiss=""modal"">Sim</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
    <script>
        function ConfirmarExclusao(pessoaId, nomeContato) {
            $("".nomeContato"").text(nomeContato);
            $("".modal"").modal();

            $("".btnExcluir"").on('click', function () {
                $.ajax({
                    url: 'Pessoas/ExcluirPessoa',
                    method: 'POST',
                    data: { pessoaId: pessoaId },
                    success: function (data) {
                        location.reload(true);
                    }
                });
            });

            $("".btnFechar"").on('click', function () {
                pessoaId = null;
                nomeContato = null;
                $("".modal"").modal('hide');
            })
        }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AgendaDeContatos.Models.Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591