#pragma checksum "C:\Users\ayush\Documents\GitHub\AssignmentSample\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2293ab20ade7532f5736e026de9818af1eff2831"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AssignmentSample.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AssignmentSample.Pages
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
#line 1 "C:\Users\ayush\Documents\GitHub\AssignmentSample\Pages\_ViewImports.cshtml"
using AssignmentSample;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2293ab20ade7532f5736e026de9818af1eff2831", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a2aa1141ea4087712afe988431f0d6a85d29df", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ayush\Documents\GitHub\AssignmentSample\Pages\Index.cshtml"
  
    ViewData["places"] = "Home page";

    
    var content = new [] {
        new {
            places = "Canada",
            attraction = "CN tower",
            days = "5 days",
            package = "yes"
        },
        new {
            places = "New Zealand",
            attraction = "Queens town",
            days = "7 days",
            package = "yes"
        },
        new {
            places = "India",
            attraction = "Taj Mahal",
            days = "5 days",
            package = "no"
        },
        new {
            places = "China",
            attraction = "The great wall of china",
            days = "3 days",
            package = "yes"
        },
        new {
            places = "Australia",
            attraction = "Sydney",
            days = "8 days",
            package = "no"
        }
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\ayush\Documents\GitHub\AssignmentSample\Pages\Index.cshtml"
 for(var i = 0; i < content.Length; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\">\r\n        <h3 class=\"card-header\">");
#nullable restore
#line 44 "C:\Users\ayush\Documents\GitHub\AssignmentSample\Pages\Index.cshtml"
                           Write(content[i].places);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p class=\"card-body\">");
#nullable restore
#line 45 "C:\Users\ayush\Documents\GitHub\AssignmentSample\Pages\Index.cshtml"
                        Write(content[i].attraction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div class=\"type\">");
#nullable restore
#line 46 "C:\Users\ayush\Documents\GitHub\AssignmentSample\Pages\Index.cshtml"
                     Write(content[i].days);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"tag\">");
#nullable restore
#line 47 "C:\Users\ayush\Documents\GitHub\AssignmentSample\Pages\Index.cshtml"
                    Write(content[i].package);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n");
#nullable restore
#line 49 "C:\Users\ayush\Documents\GitHub\AssignmentSample\Pages\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
