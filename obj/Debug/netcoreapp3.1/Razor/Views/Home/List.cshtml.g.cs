#pragma checksum "C:\projeto_livraria\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "009a0d2d0b99c1a80658ff3351321e58d23bad02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"009a0d2d0b99c1a80658ff3351321e58d23bad02", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42ec2b805c9b24af5f8b092df2ed047002ae1ec4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LivroListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\projeto_livraria\Views\Home\List.cshtml"
  
    ViewData ["Title"] = "Livros";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section class=\"container-fluid bg-light\" id=\"livros\">\n            <div class=\"row justify-content-center\">\n");
#nullable restore
#line 8 "C:\projeto_livraria\Views\Home\List.cshtml"
                 foreach (var livro in Model.Livros)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\projeto_livraria\Views\Home\List.cshtml"
                   Write(Html.Partial("LivroResumo", livro));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\projeto_livraria\Views\Home\List.cshtml"
                                                                                 
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LivroListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
