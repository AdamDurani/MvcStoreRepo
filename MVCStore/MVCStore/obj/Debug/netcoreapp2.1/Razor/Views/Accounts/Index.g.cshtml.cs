#pragma checksum "C:\www\Practice\MVCStore\MVCStore\Views\Accounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ac63c4f0ca9cf6b8e9c778c197f42c9c16647b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Index), @"mvc.1.0.view", @"/Views/Accounts/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Accounts/Index.cshtml", typeof(AspNetCore.Views_Accounts_Index))]
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
#line 1 "C:\www\Practice\MVCStore\MVCStore\Views\_ViewImports.cshtml"
using MVCStore;

#line default
#line hidden
#line 2 "C:\www\Practice\MVCStore\MVCStore\Views\_ViewImports.cshtml"
using MVCStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac63c4f0ca9cf6b8e9c778c197f42c9c16647b5", @"/Views/Accounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94bf5a3ef6c513fa382b7acfd0aee768db8c7998", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCStore.Models.Account[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 219, true);
            WriteLiteral("\r\n<h1>Accounts</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>UserName</th>\r\n        <th>First Name</th>\r\n        <th>Second Name</th>\r\n        <th>Date Of Birth</th>\r\n        <th>Membership Type</th>\r\n    </tr>\r\n");
            EndContext();
#line 13 "C:\www\Practice\MVCStore\MVCStore\Views\Accounts\Index.cshtml"
     foreach (var account in Model)
    {

#line default
#line hidden
            BeginContext(298, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(321, 16, false);
#line 16 "C:\www\Practice\MVCStore\MVCStore\Views\Accounts\Index.cshtml"
       Write(account.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(337, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(357, 24, false);
#line 17 "C:\www\Practice\MVCStore\MVCStore\Views\Accounts\Index.cshtml"
       Write(account.Holder.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(381, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(401, 25, false);
#line 18 "C:\www\Practice\MVCStore\MVCStore\Views\Accounts\Index.cshtml"
       Write(account.Holder.SecondName);

#line default
#line hidden
            EndContext();
            BeginContext(426, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(446, 31, false);
#line 19 "C:\www\Practice\MVCStore\MVCStore\Views\Accounts\Index.cshtml"
       Write(account.Holder.DateOfBirth.Date);

#line default
#line hidden
            EndContext();
            BeginContext(477, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(497, 18, false);
#line 20 "C:\www\Practice\MVCStore\MVCStore\Views\Accounts\Index.cshtml"
       Write(account.Membership);

#line default
#line hidden
            EndContext();
            BeginContext(515, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 22 "C:\www\Practice\MVCStore\MVCStore\Views\Accounts\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(542, 16, true);
            WriteLiteral("\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCStore.Models.Account[]> Html { get; private set; }
    }
}
#pragma warning restore 1591