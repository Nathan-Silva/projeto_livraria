#pragma checksum "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f2cb5d770a1fed66f6aa01ccea47059248a4e2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminLivros_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminLivros/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f2cb5d770a1fed66f6aa01ccea47059248a4e2b", @"/Areas/Admin/Views/AdminLivros/Delete.cshtml")]
    public class Areas_Admin_Views_AdminLivros_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<projeto_livraria.Models.Livro>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Deseja Deletar este Livro?</h3>\r\n<div>\r\n    <form asp-action=\"Delete\" role=\"form\">\r\n    \r\n        <dl class=\"row\">\r\n            <dt class = \"col-sm-3\">\r\n                ");
#nullable restore
#line 12 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayNameFor(@Model => @Model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-9\">\r\n                ");
#nullable restore
#line 15 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-3\">\r\n                ");
#nullable restore
#line 18 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayNameFor(@Model => @Model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-9\">\r\n                ");
#nullable restore
#line 21 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Autor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-3\">\r\n                ");
#nullable restore
#line 24 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayNameFor(@Model => @Model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-9\">\r\n                ");
#nullable restore
#line 27 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayFor(Model => Model.Descricao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-3\">\r\n                ");
#nullable restore
#line 30 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayNameFor(@model => @Model.Ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-9\">\r\n                ");
#nullable restore
#line 33 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Ano));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-3\">\r\n                ");
#nullable restore
#line 36 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayNameFor(@Model => @Model.Numero_de_Paginas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-9\">\r\n                ");
#nullable restore
#line 39 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Numero_de_Paginas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-3\">\r\n                ");
#nullable restore
#line 42 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayNameFor(@Model => @Model.Acabamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-9\">\r\n                ");
#nullable restore
#line 45 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Acabamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-3\">\r\n                ");
#nullable restore
#line 48 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayNameFor(@Model => @Model.Idioma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-9\">\r\n                ");
#nullable restore
#line 51 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Idioma));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-3\">\r\n                ");
#nullable restore
#line 54 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayNameFor(@Model => @Model.Pais));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-9\">\r\n                ");
#nullable restore
#line 57 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Pais));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-3\">\r\n                ");
#nullable restore
#line 60 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayNameFor(@Model => @Model.Altura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-9\">\r\n                ");
#nullable restore
#line 63 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Altura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-3\">\r\n                ");
#nullable restore
#line 66 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayNameFor(@Model => @Model.Largura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-9\">\r\n                ");
#nullable restore
#line 69 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Largura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-3\">\r\n                ");
#nullable restore
#line 72 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayNameFor(@Model => @Model.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-9\">\r\n                ");
#nullable restore
#line 75 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class = \"col-sm-3\">\r\n                ");
#nullable restore
#line 78 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayNameFor(@Model => @Model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class = \"col-sm-9\">\r\n                ");
#nullable restore
#line 81 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </dd>
        </dl>
    </form>    
    <hr />
    <form asp-action=""/AdminLivros/Delete"">
        <input type=""hidden"" asp-for=""IdLivro"" />
        <input class=""btn btn-danger"" type=""submit"" value=""Deletar"" /> |
        <a asp-action=""Index"" href=""https://localhost:5001/Admin/AdminLivros"" class=""btn btn-outline-info"">Retornar</a>
    </form>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<projeto_livraria.Models.Livro> Html { get; private set; }
    }
}
#pragma warning restore 1591
