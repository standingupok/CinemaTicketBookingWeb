#pragma checksum "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cb373af67b9de1ff9086835de6b09237238fdb6b60f1aa5554a1cb5d1d27017b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Accounts_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Accounts/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cb373af67b9de1ff9086835de6b09237238fdb6b60f1aa5554a1cb5d1d27017b", @"/Areas/Admin/Views/Accounts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e1e06584b277df904752c97749390f3e46c20da8fc9342bf23ee0b0afcc0b352", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Accounts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<cinema_web.Models.Account>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Chi tiết</h1>\r\n\r\n<div>\r\n    <h4>Tài khoản ");
#nullable restore
#line 11 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml"
             Write(Html.DisplayFor(model => model.AccountId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Role.RoleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb373af67b9de1ff9086835de6b09237238fdb6b60f1aa5554a1cb5d1d27017b8308", async() => {
                WriteLiteral("Chỉnh sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\Accounts\Details.cshtml"
                           WriteLiteral(Model.AccountId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb373af67b9de1ff9086835de6b09237238fdb6b60f1aa5554a1cb5d1d27017b10518", async() => {
                WriteLiteral(@"
        <svg class=""back-icon"" data-slot=""icon"" fill=""none"" stroke-width=""1.5"" stroke=""currentColor"" viewBox=""0 0 24 24"" xmlns=""http://www.w3.org/2000/svg"" aria-hidden=""true"">
            <path stroke-linecap=""round"" stroke-linejoin=""round"" d=""M6.75 15.75 3 12m0 0 3.75-3.75M3 12h18""></path>
        </svg>Trở về
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<cinema_web.Models.Account> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
