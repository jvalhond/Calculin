#pragma checksum "C:\Arquitectura propuesta\SitioCore\Views\Home\ActualizarMonedas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff7d6bf458a6d3366a18904ba7a6e8566622d021"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ActualizarMonedas), @"mvc.1.0.view", @"/Views/Home/ActualizarMonedas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ActualizarMonedas.cshtml", typeof(AspNetCore.Views_Home_ActualizarMonedas))]
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
#line 1 "C:\Arquitectura propuesta\SitioCore\Views\_ViewImports.cshtml"
using SitioCore;

#line default
#line hidden
#line 2 "C:\Arquitectura propuesta\SitioCore\Views\_ViewImports.cshtml"
using SitioCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7d6bf458a6d3366a18904ba7a6e8566622d021", @"/Views/Home/ActualizarMonedas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be238dc68979822c90a4857d30e68fcbee35991", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ActualizarMonedas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SitioCore.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(46, 21, false);
#line 3 "C:\Arquitectura propuesta\SitioCore\Views\Home\ActualizarMonedas.cshtml"
Write(ViewBag.NumeroMonedas);

#line default
#line hidden
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SitioCore.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
