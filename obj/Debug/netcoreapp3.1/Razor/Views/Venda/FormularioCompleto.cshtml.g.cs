#pragma checksum "C:\projeto_livraria\Views\Venda\FormularioCompleto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a684e6ddf50e565798f5d146edebdfdc03e0bb03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venda_FormularioCompleto), @"mvc.1.0.view", @"/Views/Venda/FormularioCompleto.cshtml")]
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
#line 1 "C:\projeto_livraria\Views\_ViewImports.cshtml"
using AppWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projeto_livraria\Views\_ViewImports.cshtml"
using AppWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projeto_livraria\Views\_ViewImports.cshtml"
using projeto_livraria.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a684e6ddf50e565798f5d146edebdfdc03e0bb03", @"/Views/Venda/FormularioCompleto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42ec2b805c9b24af5f8b092df2ed047002ae1ec4", @"/Views/_ViewImports.cshtml")]
    public class Views_Venda_FormularioCompleto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<projeto_livraria.Controllers.VendaController>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<br />\n<div class=\"container\">\n    <div class=\"jumbotron\">\n        <h2> ");
#nullable restore
#line 6 "C:\projeto_livraria\Views\Venda\FormularioCompleto.cshtml"
        Write(ViewBag.FormularioCompletoMensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<projeto_livraria.Controllers.VendaController> Html { get; private set; }
    }
}
#pragma warning restore 1591
