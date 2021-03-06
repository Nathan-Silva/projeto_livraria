#pragma checksum "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f111f01c4ac1e9a8521cf21c8dfeb9887c9f26ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminLivros_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminLivros/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f111f01c4ac1e9a8521cf21c8dfeb9887c9f26ae", @"/Areas/Admin/Views/AdminLivros/Index.cshtml")]
    public class Areas_Admin_Views_AdminLivros_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<projeto_livraria.Models.Livro>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Livros</h3>\r\n\r\n<form method=\"get\" class=\"form-inline\">\r\n    <input name=\"filter\" class=\"form-control\" placeholder=\"filtro\"");
            BeginWriteAttribute("value", "\r\n           value=\"", 245, "\"", 292, 1);
#nullable restore
#line 11 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
WriteAttributeValue("", 265, Model.RouteValue["Filter"], 265, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <button type=\"submit\" class=\"btn btn-info\">\r\n        <span class=\"glyphicon glyphicon-search\" aria-hidden=\"true\"></span> Procurar\r\n    </button>\r\n</form>\r\n\r\nTotal de Livros : ");
#nullable restore
#line 17 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
             Write(Model.TotalRecordCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <vc:pager");
            BeginWriteAttribute("paging-list", " paging-list=\"", 522, "\"", 542, 1);
#nullable restore
#line 19 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
WriteAttributeValue("", 536, Model, 536, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></vc:pager>
</div>
<p>
    <a href=""https://localhost:5001/Admin/AdminLivros/Create"" class=""btn btn-outline"" asp-action=""Create"">Adicionar novo Livro</a>
</p>
<div class=""row"">
    <div class=""col-md-10"">
        <table class=""table"">
             <thead>
                <tr>
                    <th>
");
            WriteLiteral("                    </th>\r\n");
            WriteLiteral("                    <th></th>\r\n                </tr>\r\n            </thead> \r\n            <tbody>\r\n");
#nullable restore
#line 49 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 53 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 56 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 59 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Editora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 62 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 65 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a asp-action=\"Edit\" href=\"/Admin/AdminLivros/Edit/5\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2527, "\"", 2555, 1);
#nullable restore
#line 68 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
WriteAttributeValue("", 2542, item.IdLivro, 2542, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edita</a> |\r\n                            <a asp-action=\"Details\" href=\"/Admin/AdminLivros/Details/5\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2657, "\"", 2685, 1);
#nullable restore
#line 69 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
WriteAttributeValue("", 2672, item.IdLivro, 2672, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Detalhes</a> |\r\n                            <a asp-action=\"Delete\" href=\"/Admin/AdminLivros/Delete/5\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2788, "\"", 2816, 1);
#nullable restore
#line 70 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
WriteAttributeValue("", 2803, item.IdLivro, 2803, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Deleta</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 73 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n        <div>\r\n            <vc:pager");
            BeginWriteAttribute("paging-list", " paging-list=\"", 2985, "\"", 3005, 1);
#nullable restore
#line 78 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Index.cshtml"
WriteAttributeValue("", 2999, Model, 2999, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></vc:pager>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<projeto_livraria.Models.Livro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
