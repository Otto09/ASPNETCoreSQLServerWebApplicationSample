#pragma checksum "C:\dotnetcoreprojects\dotnetcorewebappsqlserverdatabasefirst.com\www\ASPNETCoreSQLServerWebApplicationSample\ASPNETCoreSQLServerWebApplicationSample\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59c7e7ec57da7f633c0604f8460661d295664741"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\dotnetcoreprojects\dotnetcorewebappsqlserverdatabasefirst.com\www\ASPNETCoreSQLServerWebApplicationSample\ASPNETCoreSQLServerWebApplicationSample\Views\_ViewImports.cshtml"
using ASPNETCoreSQLServerWebApplicationSample;

#line default
#line hidden
#line 2 "C:\dotnetcoreprojects\dotnetcorewebappsqlserverdatabasefirst.com\www\ASPNETCoreSQLServerWebApplicationSample\ASPNETCoreSQLServerWebApplicationSample\Views\_ViewImports.cshtml"
using ASPNETCoreSQLServerWebApplicationSample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59c7e7ec57da7f633c0604f8460661d295664741", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"386463a34ecde8da198ae3aa7af41df381d8a1cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\dotnetcoreprojects\dotnetcorewebappsqlserverdatabasefirst.com\www\ASPNETCoreSQLServerWebApplicationSample\ASPNETCoreSQLServerWebApplicationSample\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(43, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(48, 17, false);
#line 4 "C:\dotnetcoreprojects\dotnetcorewebappsqlserverdatabasefirst.com\www\ASPNETCoreSQLServerWebApplicationSample\ASPNETCoreSQLServerWebApplicationSample\Views\Home\Contact.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(65, 297, true);
            WriteLiteral(@"</h2>
<h3>My contact page</h3>

<address>
    1, Prunilor St.<br />
    Cluj-Napoca, Cluj 400344, Romania<br />
    <abbr title=""Phone"">P:</abbr>
    (+40) 74 000 2657
</address>

<address>
    <strong>Support:</strong> <a href=""mailto:ttgoga@yahoo.com"">ttgoga@yahoo.com</a>
</address>");
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
