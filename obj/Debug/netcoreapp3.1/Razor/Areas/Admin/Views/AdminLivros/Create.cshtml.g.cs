#pragma checksum "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ece191175bb3a441277cb7fd2013765d79eb0b31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminLivros_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminLivros/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ece191175bb3a441277cb7fd2013765d79eb0b31", @"/Areas/Admin/Views/AdminLivros/Create.cshtml")]
    public class Areas_Admin_Views_AdminLivros_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<projeto_livraria.Models.Livro>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row orderForm"">

    <h3 class=""text-center""> Insira as informações do novo livro <span class=""glyphicon glyphicon-ok""></span></h3>

    <form asp-action=""Create"" method=""Post"" class=""form-horizontal"">

        <div class=""form-group"">
            <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 304, "\"", 327, 1);
#nullable restore
#line 10 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 314, Model.Titulo, 314, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-md-2 control-label\"></label>\n            <div class=\"col-md-5\">\n                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 426, "\"", 449, 1);
#nullable restore
#line 12 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 436, Model.Titulo, 436, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"/>\n                <span");
            BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 495, "\"", 529, 1);
#nullable restore
#line 13 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 516, Model.Titulo, 516, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger\"></span>\n            </div>    \n        </div>\n        \n        <div class=\"form-group\">\n            <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 657, "\"", 679, 1);
#nullable restore
#line 18 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 667, Model.Autor, 667, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-md-2 control-label\"></label>\n            <div class=\"col-md-5\">\n                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 778, "\"", 800, 1);
#nullable restore
#line 20 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 788, Model.Autor, 788, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"/>\n                <span");
            BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 846, "\"", 879, 1);
#nullable restore
#line 21 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 867, Model.Autor, 867, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger\"></span>\n            </div>\n        </div>\n        <div class=\"form-group\">\n            <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 994, "\"", 1018, 1);
#nullable restore
#line 25 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 1004, Model.Editora, 1004, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-md-2 control-label\"></label>\n            <div class=\"col-md-5\">\n                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1117, "\"", 1141, 1);
#nullable restore
#line 27 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 1127, Model.Editora, 1127, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"/>\n                <span");
            BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 1187, "\"", 1222, 1);
#nullable restore
#line 28 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 1208, Model.Editora, 1208, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger\"></span>\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1338, "\"", 1364, 1);
#nullable restore
#line 33 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 1348, Model.Descricao, 1348, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-md-2 control-label\"></label>\n            <div class=\"col-md-5\">\n                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1463, "\"", 1489, 1);
#nullable restore
#line 35 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 1473, Model.Descricao, 1473, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"/>\n                <span");
            BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 1535, "\"", 1572, 1);
#nullable restore
#line 36 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 1556, Model.Descricao, 1556, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger\"></span>\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1688, "\"", 1708, 1);
#nullable restore
#line 41 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 1698, Model.Ano, 1698, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-md-2 control-label\"></label>\n            <div class=\"col-md-5\">\n                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1807, "\"", 1827, 1);
#nullable restore
#line 43 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 1817, Model.Ano, 1817, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"/>\n                <span");
            BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 1873, "\"", 1904, 1);
#nullable restore
#line 44 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 1894, Model.Ano, 1894, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger\"></span>\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 2020, "\"", 2054, 1);
#nullable restore
#line 49 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 2030, Model.Numero_de_Paginas, 2030, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-md-2 control-label\"></label>\n            <div class=\"col-md-5\">\n                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 2153, "\"", 2187, 1);
#nullable restore
#line 51 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 2163, Model.Numero_de_Paginas, 2163, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"/>\n                <span");
            BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 2233, "\"", 2278, 1);
#nullable restore
#line 52 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 2254, Model.Numero_de_Paginas, 2254, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-danger\"></span>\n            </div>\n        </div>\n\n        <div class=\"form-group\">\n            <label");
            BeginWriteAttribute("asp-for", " asp-for=\"", 2394, "\"", 2421, 1);
#nullable restore
#line 57 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 2404, Model.Acabamento, 2404, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"col-md-2 control-label\"></label>\n            <div class=\"col-md-5\">\n                <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 2520, "\"", 2547, 1);
#nullable restore
#line 59 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 2530, Model.Acabamento, 2530, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"/>\n                <span");
            BeginWriteAttribute("asp-validation-for", " asp-validation-for=\"", 2593, "\"", 2631, 1);
#nullable restore
#line 60 "C:\projeto_livraria\Areas\Admin\Views\AdminLivros\Create.cshtml"
WriteAttributeValue("", 2614, Model.Acabamento, 2614, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""text-danger""></span>
            </div>
        </div>

        <div class=""form-group"">
            <div class=""btn-group col-md-offset-2 col-md-8"">
                <input class=""btn btn-success"" type=""submit"" value=""Concluir Compra""/>
            </div>
        </div>    
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
