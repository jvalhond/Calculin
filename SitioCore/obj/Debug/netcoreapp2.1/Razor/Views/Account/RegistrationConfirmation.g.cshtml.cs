#pragma checksum "C:\Arquitectura propuesta\SitioCore\Views\Account\RegistrationConfirmation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5a34c77464814d4def5b433345d3e4033f64919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RegistrationConfirmation), @"mvc.1.0.view", @"/Views/Account/RegistrationConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/RegistrationConfirmation.cshtml", typeof(AspNetCore.Views_Account_RegistrationConfirmation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5a34c77464814d4def5b433345d3e4033f64919", @"/Views/Account/RegistrationConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be238dc68979822c90a4857d30e68fcbee35991", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RegistrationConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Arquitectura propuesta\SitioCore\Views\Account\RegistrationConfirmation.cshtml"
  
    ViewData["Title"] = "Confirmación de registro";

#line default
#line hidden
            BeginContext(60, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(67, 17, false);
#line 5 "C:\Arquitectura propuesta\SitioCore\Views\Account\RegistrationConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(84, 49, true);
            WriteLiteral(".</h2>\r\n<p>\r\n    Gracias por registrarte!\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
