#pragma checksum "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\ScreeningFilms\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9aaecf442ee4566e96f7fd891024cb50770d2297d9b5d9d2b215125309fb8382"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ScreeningFilms_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ScreeningFilms/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9aaecf442ee4566e96f7fd891024cb50770d2297d9b5d9d2b215125309fb8382", @"/Areas/Admin/Views/ScreeningFilms/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"e1e06584b277df904752c97749390f3e46c20da8fc9342bf23ee0b0afcc0b352", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ScreeningFilms_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<cinema_web.Models.ScreeningFilm>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-purple"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\ScreeningFilms\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <a class=""btn btn-outline-purple"" href=""/admin/tickets"">Vé</a>
    <a class=""btn btn-outline-purple"" href=""/admin/films"">Phim</a>
    <a class=""btn btn-outline-purple"" href=""/admin/screenings"">Suất chiếu</a>
    <a class=""btn btn-outline-purple"" href=""/admin/screeningfilms"">Suất chiếu của phim</a>
    <a class=""btn btn-outline-purple"" href=""/admin/accounts"">Tài khoản</a>
    <a class=""btn btn-outline-purple"" href=""/admin/roles"">Vai trò</a>
</div>
<h1>Quản lý suất chiếu của phim</h1>

<p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aaecf442ee4566e96f7fd891024cb50770d2297d9b5d9d2b215125309fb83825005", async() => {
                WriteLiteral("Tạo mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\ScreeningFilms\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FilmId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\ScreeningFilms\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ScreeningId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\ScreeningFilms\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\ScreeningFilms\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FilmId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\ScreeningFilms\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ScreeningId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                    ");
#nullable restore
#line 42 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\ScreeningFilms\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { filmid = item.FilmId, screeningId = item.ScreeningId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 43 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\ScreeningFilms\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { filmid = item.FilmId, screeningId = item.ScreeningId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 44 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\ScreeningFilms\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { filmid = item.FilmId, screeningId = item.ScreeningId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "D:\WEB\cinema_web_app - Sao chép\cinema_web_2\cinema_web_2\cinema_web\Areas\Admin\Views\ScreeningFilms\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<cinema_web.Models.ScreeningFilm>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
