#pragma checksum "C:\Users\dylan\OneDrive\Documents\GrandCircus\Coffee Shop\Coffee_Shop\Coffee_Shop\Views\UserRegistration\DisplayUserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81031cc704fe055a90878bf1210afee31ec806ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRegistration_DisplayUserInfo), @"mvc.1.0.view", @"/Views/UserRegistration/DisplayUserInfo.cshtml")]
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
#line 1 "C:\Users\dylan\OneDrive\Documents\GrandCircus\Coffee Shop\Coffee_Shop\Coffee_Shop\Views\_ViewImports.cshtml"
using Coffee_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dylan\OneDrive\Documents\GrandCircus\Coffee Shop\Coffee_Shop\Coffee_Shop\Views\_ViewImports.cshtml"
using Coffee_Shop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81031cc704fe055a90878bf1210afee31ec806ee", @"/Views/UserRegistration/DisplayUserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb473e7b031f6336ea044efdcd6df3251d9be0ee", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRegistration_DisplayUserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Coffee_Shop.Models.UserRegistration.RegisterUserFormResultViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dylan\OneDrive\Documents\GrandCircus\Coffee Shop\Coffee_Shop\Coffee_Shop\Views\UserRegistration\DisplayUserInfo.cshtml"
  
    ViewData["Title"] = "DisplayUserInfo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<h1>");
#nullable restore
#line 10 "C:\Users\dylan\OneDrive\Documents\GrandCircus\Coffee Shop\Coffee_Shop\Coffee_Shop\Views\UserRegistration\DisplayUserInfo.cshtml"
Write(Model.user.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Info:</h1>\r\n\r\n<label>Email:</label>\r\n<p>");
#nullable restore
#line 13 "C:\Users\dylan\OneDrive\Documents\GrandCircus\Coffee Shop\Coffee_Shop\Coffee_Shop\Views\UserRegistration\DisplayUserInfo.cshtml"
Write(Model.user.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<label>Birthday:</label>\r\n<p>");
#nullable restore
#line 16 "C:\Users\dylan\OneDrive\Documents\GrandCircus\Coffee Shop\Coffee_Shop\Coffee_Shop\Views\UserRegistration\DisplayUserInfo.cshtml"
Write(Model.user.dateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n<label>Home State:</label>\r\n<p>");
#nullable restore
#line 19 "C:\Users\dylan\OneDrive\Documents\GrandCircus\Coffee Shop\Coffee_Shop\Coffee_Shop\Views\UserRegistration\DisplayUserInfo.cshtml"
Write(Model.user.homeState);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Coffee_Shop.Models.UserRegistration.RegisterUserFormResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
