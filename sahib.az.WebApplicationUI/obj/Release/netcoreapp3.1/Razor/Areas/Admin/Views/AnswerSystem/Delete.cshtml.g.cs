#pragma checksum "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "358b7c139606998327de6e5714089c7ddac0e431"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AnswerSystem_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/AnswerSystem/Delete.cshtml")]
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
#line 1 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\_ViewImports.cshtml"
using sahib.az.WebApplicationUI.Models.FormModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\_ViewImports.cshtml"
using sahib.az.WebApplicationUI.Models.DataContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\_ViewImports.cshtml"
using sahib.az.WebApplicationUI.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\_ViewImports.cshtml"
using sahib.az.WebApplicationUI.Areas.Admin.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\_ViewImports.cshtml"
using sahib.az.WebApplicationUI.Areas.Admin.Models.FormModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\_ViewImports.cshtml"
using sahib.az.WebApplicationUI.Models.Entity.Membership;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"358b7c139606998327de6e5714089c7ddac0e431", @"/Areas/Admin/Views/AnswerSystem/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cbad545377818e2d282bcc5713718e01e91829f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AnswerSystem_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sahib.az.WebApplicationUI.Models.Entity.Perfume>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AnswerSystem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Brands", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:yellow;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Staff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
  
    ViewData["Title"] = "Cavablandırma sistemi";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"Assets/CSS/answer-system.min.css\" />\r\n");
            }
            );
            WriteLiteral(@"
<header id=""add-admin-header"">
    <nav id=""add-admin-nav"">
        <div class=""container add-admin-nav-container"">
            <div class=""row"">
                <div class=""col-6 add-admin-nav-left"">
                    <div class=""img-div"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "358b7c139606998327de6e5714089c7ddac0e4319044", async() => {
                WriteLiteral("\r\n                            <img src=\"uploads/logos/logo.png\" alt=\"SAHIB\">\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-6 add-admin-nav-right\">\r\n                    <ul class=\"d-flex\" style=\"margin-right: 15px;\">\r\n");
#nullable restore
#line 25 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
                         if (signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li style=\"margin-right: 10px;\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "358b7c139606998327de6e5714089c7ddac0e43111157", async() => {
                WriteLiteral("\r\n                                    Brend\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 32 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li style=\"margin-right: 10px;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "358b7c139606998327de6e5714089c7ddac0e43112991", async() => {
                WriteLiteral("\r\n                                Cavablandırma sistemi\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
                         if (signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "358b7c139606998327de6e5714089c7ddac0e43114978", async() => {
                WriteLiteral("\r\n                                    İstifadəçilər\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 45 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                    <p>");
#nullable restore
#line 47 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
                  Write(ViewBag.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "358b7c139606998327de6e5714089c7ddac0e43117097", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-sign-out-alt\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </nav>
</header>

<div class=""container"" style=""padding: 120px 0 20px 0;"">

    <h1 class=""text-center"">Cavablandırma sistemi - Silmə.</h1>

    <h3 class=""text-center"">Silmək istədiyinizə əminsinizmi?</h3>
    <div>
        <hr />
        <dl class=""row"">
            <dt class=""col-6 text-end"">
                Parfüm:
            </dt>
            <dd class=""col-6"">
                ");
#nullable restore
#line 69 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                Brend:\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 75 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Brand.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                Növ:\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 81 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Type.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                ML:\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 87 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ML));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                Tester?\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 93 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Html.DisplayFor(model => model.IsTester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                Maya:\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 99 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Maya));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                Satışı:\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 105 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                3 ay:\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 111 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ThreeMonths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                6 ay:\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 117 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Html.DisplayFor(model => model.SixMonths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                9 ay:\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 123 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Html.DisplayFor(model => model.NineMonths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                12 ay:\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 129 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Html.DisplayFor(model => model.TwelveMonths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                15 ay:\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 135 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Html.DisplayFor(model => model.FifteenMonths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                18 ay:\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 141 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Html.DisplayFor(model => model.EighteenMonths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                Əlavə olunma tarixi:\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 147 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Model.CreatedDate.ToString("dd.MM.yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-6 text-end\">\r\n                Yenilənmə tarixi:\r\n            </dt>\r\n            <dd class=\"col-6\">\r\n                ");
#nullable restore
#line 153 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
           Write(Model.UpdatedDate?.ToString("dd.MM.yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "358b7c139606998327de6e5714089c7ddac0e43126053", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "358b7c139606998327de6e5714089c7ddac0e43126324", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 158 "C:\Users\User\Desktop\sahib.az (Back-End)\sahib.az.Solution\sahib.az.WebApplicationUI\Areas\Admin\Views\AnswerSystem\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Sil\" class=\"btn btn-danger\" />\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "358b7c139606998327de6e5714089c7ddac0e43128166", async() => {
                    WriteLiteral("\r\n                <i class=\"fas fa-undo-alt\"></i> Geriyə\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script src=\"Assets/JS/answer-system.js\"></script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sahib.az.WebApplicationUI.Models.Entity.Perfume> Html { get; private set; }
    }
}
#pragma warning restore 1591
