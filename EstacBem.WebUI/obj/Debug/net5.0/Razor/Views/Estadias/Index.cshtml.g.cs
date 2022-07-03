#pragma checksum "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eda575145565d8fd38b2a05f3c3741d10226b9e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estadias_Index), @"mvc.1.0.view", @"/Views/Estadias/Index.cshtml")]
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
#line 1 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\_ViewImports.cshtml"
using EstacBem.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\_ViewImports.cshtml"
using EstacBem.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
using EstacBem.WebUI.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda575145565d8fd38b2a05f3c3741d10226b9e5", @"/Views/Estadias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa034d1f91dc66c5589c2be95b68d361b17f74c8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Estadias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EstacBem.WebUI.Models.EstadiaViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Estadias", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Estadia/jsEstadiaIndex.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""container"">
    <!-- Header -->
    <div class=""row"">
        <div class=""col-12 text-center mt-5"">
            <h3 class=""font-weight-lighter"">Gestão de Estadias</h3>
        </div>
    </div>
    <hr />
    <!-- Tabela com as estadias -->
    <div class=""row"">
        <div class=""col-3 mb-2"">
            <input type=""text"" class=""form-control"" id=""txtFiltro"" placeholder=""Procurar..."" />
        </div>
        <table class=""table table-sm table-hover text-center"">
            <thead class=""bg-dark text-light"">
                <tr>
                    <th scope=""col"">Placa</</th>
                    <th scope=""col"">Entrada</</th>
                    <th scope=""col"">Saída</</th>
                    <th scope=""col"">Área</</th>
                    <th scope=""col"">Tempo total</</th>
                    <th scope=""col"">Primeira hora</</th>
                    <th scope=""col"">Demais horas</</th>
                    <th scope=""col"">Valor total</</th>
                    <th sc");
            WriteLiteral("ope=\"col\">Pagamento</</th>\r\n                    <th scope=\"col\">Ações</</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                 foreach (var item in Model)
                {
                    string saidaStatus = item.Saida == null ? "aberta" : "fechada";


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"filtrohide\"");
            BeginWriteAttribute("filtro", " filtro=\"", 1456, "\"", 1534, 3);
#nullable restore
#line 38 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
WriteAttributeValue("", 1465, item.Veiculo.Placa.ToLower().Replace("-", string.Empty), 1465, 56, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1521, "|", 1521, 1, true);
#nullable restore
#line 38 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
WriteAttributeValue("", 1522, saidaStatus, 1522, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                       Write(item.Veiculo.Placa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                       Write(item.Entrada.PtBR_ddMMYYYY_HHmm());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 41 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                         if (@item.Saida == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>estadia aberta</td>\r\n");
#nullable restore
#line 44 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 47 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                           Write(item.Saida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 48 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 51 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                         if (item.NomeAntigoBolsao != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 53 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                           Write(item.NomeAntigoBolsao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 54 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 57 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                           Write(item.Bolsao.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 58 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                         if (@item.Saida == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td></td>\r\n");
#nullable restore
#line 63 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 66 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                           Write(item.TempoTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 67 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 68 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                       Write(item.ValorPrimeira);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 69 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                       Write(item.ValorDemais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 70 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                         if (@item.Saida == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td></td>\r\n");
#nullable restore
#line 73 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 76 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                           Write(item.ValorTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 77 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 78 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                       Write(item.Status.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n\r\n");
#nullable restore
#line 81 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                             if (saidaStatus == "aberta")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <!-- Editar -->\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eda575145565d8fd38b2a05f3c3741d10226b9e515189", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-pencil\" aria-hidden=\"true\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>\r\n                                <!-- Remover -->\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eda575145565d8fd38b2a05f3c3741d10226b9e518194", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                                 if (item.Saida == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span id=\"fecharEstadia\"");
            BeginWriteAttribute("idkey", " idkey=\"", 3955, "\"", 3971, 1);
#nullable restore
#line 95 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
WriteAttributeValue("", 3963, item.Id, 3963, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-sm btn-danger\">\r\n                                        <i class=\"fas fa-sack-dollar\"></i>\r\n                                    </span>\r\n");
#nullable restore
#line 98 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"btn btn-sm btn-success\">\r\n                                        <i class=\"fas fa-badge-check\"></i>\r\n                                    </span>\r\n");
#nullable restore
#line 104 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </span>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 108 "C:\Users\batis\OneDrive\Área de Trabalho\EstacBemProject\EstacBem\EstacBem.WebUI\Views\Estadias\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eda575145565d8fd38b2a05f3c3741d10226b9e523059", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EstacBem.WebUI.Models.EstadiaViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
