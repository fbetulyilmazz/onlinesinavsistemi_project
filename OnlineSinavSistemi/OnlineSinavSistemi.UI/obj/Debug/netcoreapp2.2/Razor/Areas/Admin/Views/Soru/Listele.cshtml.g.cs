#pragma checksum "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8567eb3431fe85600fa14bf487654db2cc65541"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Soru_Listele), @"mvc.1.0.view", @"/Areas/Admin/Views/Soru/Listele.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Soru/Listele.cshtml", typeof(AspNetCore.Areas_Admin_Views_Soru_Listele))]
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
#line 2 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineSinavUI;

#line default
#line hidden
#line 3 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineSinavUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8567eb3431fe85600fa14bf487654db2cc65541", @"/Areas/Admin/Views/Soru/Listele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a42d186337a122ea1b1fd05613dcf466f58175", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Soru_Listele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineSinavSistemi.Model.Data.Soru>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
  
    ViewData["Title"] = "Listele";
      Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";


#line default
#line hidden
            BeginContext(169, 31, true);
            WriteLiteral("\r\n<h2>Listele</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(200, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8567eb3431fe85600fa14bf487654db2cc655415039", async() => {
                BeginContext(223, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(237, 184, true);
            WriteLiteral("\r\n    <button id=\"btnyenile\" onclick=\"ApidenYenile()\"  class=\"btn btn-info\" >Yenile</button>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(422, 45, false);
#line 19 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.SoruMetni));

#line default
#line hidden
            EndContext();
            BeginContext(467, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(523, 41, false);
#line 22 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.Cevap));

#line default
#line hidden
            EndContext();
            BeginContext(564, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(620, 50, false);
#line 25 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.ZorlukSeviyesi));

#line default
#line hidden
            EndContext();
            BeginContext(670, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(726, 43, false);
#line 28 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.BransId));

#line default
#line hidden
            EndContext();
            BeginContext(769, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(825, 44, false);
#line 31 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.Aciklama));

#line default
#line hidden
            EndContext();
            BeginContext(869, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(925, 47, false);
#line 34 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.KullaniciId));

#line default
#line hidden
            EndContext();
            BeginContext(972, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1028, 47, false);
#line 37 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.OnaylandiMi));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1131, 45, false);
#line 40 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.SilindiMi));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1232, 47, false);
#line 43 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.KayitTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1335, 52, false);
#line 46 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayNameFor(model => model.GuncellemeTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 52 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1505, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1554, 44, false);
#line 55 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.SoruMetni));

#line default
#line hidden
            EndContext();
            BeginContext(1598, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1654, 40, false);
#line 58 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cevap));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1750, 49, false);
#line 61 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.ZorlukSeviyesi));

#line default
#line hidden
            EndContext();
            BeginContext(1799, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1855, 42, false);
#line 64 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.BransId));

#line default
#line hidden
            EndContext();
            BeginContext(1897, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1953, 43, false);
#line 67 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.Aciklama));

#line default
#line hidden
            EndContext();
            BeginContext(1996, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2052, 46, false);
#line 70 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.KullaniciId));

#line default
#line hidden
            EndContext();
            BeginContext(2098, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2154, 46, false);
#line 73 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.OnaylandiMi));

#line default
#line hidden
            EndContext();
            BeginContext(2200, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2256, 44, false);
#line 76 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.SilindiMi));

#line default
#line hidden
            EndContext();
            BeginContext(2300, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2356, 46, false);
#line 79 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.KayitTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(2402, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2458, 51, false);
#line 82 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
           Write(Html.DisplayFor(modelItem => item.GuncellemeTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(2509, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2564, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8567eb3431fe85600fa14bf487654db2cc6554116222", async() => {
                BeginContext(2609, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2617, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2637, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8567eb3431fe85600fa14bf487654db2cc6554118607", async() => {
                BeginContext(2685, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 86 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2696, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2716, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8567eb3431fe85600fa14bf487654db2cc6554120998", async() => {
                BeginContext(2763, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 87 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2773, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 90 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Soru\Listele.cshtml"
}

#line default
#line hidden
            BeginContext(2812, 257, true);
            WriteLiteral(@"    </tbody>
</table>

<script>
    function ApidenYenile() {

        $.get(""http://localhost:51407/api/soru"", function (data) {
            console.log(data);
         alert(""yeni veirler çekildi. Consolea bakabilirsiniz."");
});
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineSinavSistemi.Model.Data.Soru>> Html { get; private set; }
    }
}
#pragma warning restore 1591
