#pragma checksum "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "347fa22af6e42fa78a134df17f403e8cb56379f8410ae227a785f11870099781"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Tickets_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Tickets/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\_ViewImports.cshtml"
using cinema_web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\_ViewImports.cshtml"
using cinema_web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"347fa22af6e42fa78a134df17f403e8cb56379f8410ae227a785f11870099781", @"/Areas/Admin/Views/Tickets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e1e06584b277df904752c97749390f3e46c20da8fc9342bf23ee0b0afcc0b352", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Tickets_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cinema_web.Models.Ticket>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-purple"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
  
    ViewData["Title"] = "Details";
    var currAcc = ViewData["CurrentAccount"] as Account;
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Chi tiết vé</h1>\r\n\r\n<h4>Vé ");
#nullable restore
#line 11 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
  Write(Html.DisplayFor(model => model.TicketId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TicketId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.TicketId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SeatNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.SeatNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ScreeningDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.ScreeningDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Account));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.AccountId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Screening.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Screening.StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FilmName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.FilmName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FilmId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.FilmId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TicketPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
       Write(Html.DisplayFor(model => model.TicketPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 66 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
     if (currAcc.RoleId == 1)
    {
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "347fa22af6e42fa78a134df17f403e8cb56379f8410ae227a785f1187009978111111", async() => {
                WriteLiteral("Chỉnh sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
                                                              WriteLiteral(Model.TicketId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 70 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Tickets\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "347fa22af6e42fa78a134df17f403e8cb56379f8410ae227a785f1187009978113666", async() => {
                WriteLiteral(@"
        <svg class=""back-icon"" data-slot=""icon"" fill=""none"" stroke-width=""1.5"" stroke=""currentColor"" viewBox=""0 0 24 24"" xmlns=""http://www.w3.org/2000/svg"" aria-hidden=""true"">
            <path stroke-linecap=""round"" stroke-linejoin=""round"" d=""M6.75 15.75 3 12m0 0 3.75-3.75M3 12h18""></path>
        </svg>Trở về
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cinema_web.Models.Ticket> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
