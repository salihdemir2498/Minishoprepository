#pragma checksum "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b6473651090eac17726da69f98fe3d812a60e59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoleEdit), @"mvc.1.0.view", @"/Views/Admin/RoleEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b6473651090eac17726da69f98fe3d812a60e59", @"/Views/Admin/RoleEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35c9e85769d47bd0cf7187da04d9af312a57049f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RoleEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h5 class=\"display-4\">Edit Role</h5>\n<hr />\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b6473651090eac17726da69f98fe3d812a60e595328", async() => {
                WriteLiteral("\n    <input type=\"hidden\" name=\"RoleId\"");
                BeginWriteAttribute("value", " value=\"", 167, "\"", 189, 1);
#nullable restore
#line 5 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 175, Model.Role.Id, 175, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n    <input type=\"hidden\" name=\"RoleName\"");
                BeginWriteAttribute("value", " value=\"", 234, "\"", 258, 1);
#nullable restore
#line 6 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 242, Model.Role.Name, 242, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n\n    <div class=\"row\">\n        <div class=\"col-md-6\">\n            <h6 class=\"bg-info text-white p-1\">Add to ");
#nullable restore
#line 10 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                                                 Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n            <table class=\"table table-bordered table-sm\">\n");
#nullable restore
#line 12 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                 if (Model.NonMembers.Count() == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <td colspan=\"2\">Bütün kullanıcılar role ait</td>\n                    </tr>\n");
#nullable restore
#line 17 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <td>User Name</td>\n                        <td width=\"100\">Select</td>\n                    </tr>\n");
#nullable restore
#line 24 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                     foreach (var user in Model.NonMembers)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 27 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                           Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>\n                                <input type=\"checkbox\" name=\"IdsToAdd\"");
                BeginWriteAttribute("value", " value=\"", 1114, "\"", 1130, 1);
#nullable restore
#line 29 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 1122, user.Id, 1122, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                            </td>\n                        </tr>\n");
#nullable restore
#line 32 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\n        </div>\n\n        <div class=\"col-md-6\">\n            <h6 class=\"bg-info text-white p-1\">Remove from ");
#nullable restore
#line 38 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                                                      Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\n            <table class=\"table table-bordered table-sm\">\n");
#nullable restore
#line 40 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                 if (Model.Members.Count() == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <td colspan=\"2\">Bu role ait kullanıcı bulunmamaktadır.</td>\n                    </tr>\n");
#nullable restore
#line 45 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                        <td>User Name</td>\n                        <td width=\"100\">Select</td>\n                    </tr>\n");
#nullable restore
#line 52 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                     foreach (var user in Model.Members)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 55 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                           Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>\n                                <input type=\"checkbox\" name=\"IdsToDelete\"");
                BeginWriteAttribute("value", " value=\"", 2117, "\"", 2133, 1);
#nullable restore
#line 57 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 2125, user.Id, 2125, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                            </td>\n                        </tr>\n");
#nullable restore
#line 60 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "D:\Users\salih\source\repos\Minishoprepository\MiniShopApp\MiniShopApp.WebUI\Views\Admin\RoleEdit.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\n        </div>\n    </div>\n    <div");
                BeginWriteAttribute("class", " class=\"", 2297, "\"", 2305, 0);
                EndWriteAttribute();
                WriteLiteral(">\n        <button type=\"submit\" class=\"btn btn-primary\">Save Changes</button>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
