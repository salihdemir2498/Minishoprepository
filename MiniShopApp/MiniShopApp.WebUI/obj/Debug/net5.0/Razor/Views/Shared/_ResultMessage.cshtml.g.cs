#pragma checksum "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Shared\_ResultMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "066b2256c3a09382f7f9070cc4ceeb353939825c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ResultMessage), @"mvc.1.0.view", @"/Views/Shared/_ResultMessage.cshtml")]
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
#line 2 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\_ViewImports.cshtml"
using MiniShopApp.WebUI.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"066b2256c3a09382f7f9070cc4ceeb353939825c", @"/Views/Shared/_ResultMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c9632afaa3612a2f40857bedc01ef03fe4983cf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ResultMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlertMessage>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <div");
            BeginWriteAttribute("class", " class=\"", 79, "\"", 143, 6);
            WriteAttributeValue("", 87, "alert", 87, 5, true);
            WriteAttributeValue(" ", 92, "alert-", 93, 7, true);
#nullable restore
#line 5 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Shared\_ResultMessage.cshtml"
WriteAttributeValue("", 99, Model.AlertType, 99, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 115, "alert-dismissible", 116, 18, true);
            WriteAttributeValue(" ", 133, "fade", 134, 5, true);
            WriteAttributeValue(" ", 138, "show", 139, 5, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\n            <div>");
#nullable restore
#line 6 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Shared\_ResultMessage.cshtml"
            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            <div>");
#nullable restore
#line 7 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Shared\_ResultMessage.cshtml"
            Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n            <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\n        </div>\n    </div>\n    \n</div>\n        \n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlertMessage> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
