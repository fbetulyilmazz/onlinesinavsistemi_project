#pragma checksum "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c3c8a83ecc236d6b524366fd2046ea8f13a8863"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Kurs_Listele), @"mvc.1.0.view", @"/Areas/Admin/Views/Kurs/Listele.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Kurs/Listele.cshtml", typeof(AspNetCore.Areas_Admin_Views_Kurs_Listele))]
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
#line 2 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineSinavUI;

#line default
#line hidden
#line 3 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\_ViewImports.cshtml"
using OnlineSinavUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c3c8a83ecc236d6b524366fd2046ea8f13a8863", @"/Areas/Admin/Views/Kurs/Listele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a42d186337a122ea1b1fd05613dcf466f58175", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Kurs_Listele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineSinavSistemi.Model.Data.Kurs>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
  
    ViewData["Title"] = "Listele";

#line default
#line hidden
            BeginContext(101, 156, true);
            WriteLiteral("\r\n                      <div class=\"container\">\r\n                          <h2>Listele</h2>\r\n\r\n                          <p>\r\n                              ");
            EndContext();
            BeginContext(257, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c3c8a83ecc236d6b524366fd2046ea8f13a88634275", async() => {
                BeginContext(280, 10, true);
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
            BeginContext(294, 248, true);
            WriteLiteral("\r\n                          </p>\r\n                          <table class=\"table\">\r\n                              <thead>\r\n                                  <tr>\r\n                                      <th>\r\n                                          ");
            EndContext();
            BeginContext(543, 49, false);
#line 17 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                     Write(Html.DisplayNameFor(model => model.BaslamaTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(592, 133, true);
            WriteLiteral("\r\n                                      </th>\r\n                                      <th>\r\n                                          ");
            EndContext();
            BeginContext(726, 47, false);
#line 20 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                     Write(Html.DisplayNameFor(model => model.BitisTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(773, 133, true);
            WriteLiteral("\r\n                                      </th>\r\n                                      <th>\r\n                                          ");
            EndContext();
            BeginContext(907, 43, false);
#line 23 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                     Write(Html.DisplayNameFor(model => model.BittiMi));

#line default
#line hidden
            EndContext();
            BeginContext(950, 133, true);
            WriteLiteral("\r\n                                      </th>\r\n                                      <th>\r\n                                          ");
            EndContext();
            BeginContext(1084, 43, false);
#line 26 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                     Write(Html.DisplayNameFor(model => model.SinavId));

#line default
#line hidden
            EndContext();
            BeginContext(1127, 133, true);
            WriteLiteral("\r\n                                      </th>\r\n                                      <th>\r\n                                          ");
            EndContext();
            BeginContext(1261, 51, false);
#line 29 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                     Write(Html.DisplayNameFor(model => model.HaftalikCalisma));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 133, true);
            WriteLiteral("\r\n                                      </th>\r\n                                      <th>\r\n                                          ");
            EndContext();
            BeginContext(1446, 38, false);
#line 32 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 133, true);
            WriteLiteral("\r\n                                      </th>\r\n                                      <th>\r\n                                          ");
            EndContext();
            BeginContext(1618, 45, false);
#line 35 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                     Write(Html.DisplayNameFor(model => model.SilindiMi));

#line default
#line hidden
            EndContext();
            BeginContext(1663, 133, true);
            WriteLiteral("\r\n                                      </th>\r\n                                      <th>\r\n                                          ");
            EndContext();
            BeginContext(1797, 47, false);
#line 38 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                     Write(Html.DisplayNameFor(model => model.KayitTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 133, true);
            WriteLiteral("\r\n                                      </th>\r\n                                      <th>\r\n                                          ");
            EndContext();
            BeginContext(1978, 52, false);
#line 41 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                     Write(Html.DisplayNameFor(model => model.GuncellemeTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(2030, 216, true);
            WriteLiteral("\r\n                                      </th>\r\n                                      <th></th>\r\n                                  </tr>\r\n                              </thead>\r\n                              <tbody>\r\n");
            EndContext();
#line 47 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                   foreach (var item in Model)
                                  {

#line default
#line hidden
            BeginContext(2347, 138, true);
            WriteLiteral("                                      <tr>\r\n                                          <td>\r\n                                              ");
            EndContext();
            BeginContext(2486, 48, false);
#line 51 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.BaslamaTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(2534, 145, true);
            WriteLiteral("\r\n                                          </td>\r\n                                          <td>\r\n                                              ");
            EndContext();
            BeginContext(2680, 46, false);
#line 54 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.BitisTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(2726, 145, true);
            WriteLiteral("\r\n                                          </td>\r\n                                          <td>\r\n                                              ");
            EndContext();
            BeginContext(2872, 42, false);
#line 57 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.BittiMi));

#line default
#line hidden
            EndContext();
            BeginContext(2914, 145, true);
            WriteLiteral("\r\n                                          </td>\r\n                                          <td>\r\n                                              ");
            EndContext();
            BeginContext(3060, 42, false);
#line 60 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.SinavId));

#line default
#line hidden
            EndContext();
            BeginContext(3102, 145, true);
            WriteLiteral("\r\n                                          </td>\r\n                                          <td>\r\n                                              ");
            EndContext();
            BeginContext(3248, 50, false);
#line 63 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.HaftalikCalisma));

#line default
#line hidden
            EndContext();
            BeginContext(3298, 145, true);
            WriteLiteral("\r\n                                          </td>\r\n                                          <td>\r\n                                              ");
            EndContext();
            BeginContext(3444, 37, false);
#line 66 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(3481, 145, true);
            WriteLiteral("\r\n                                          </td>\r\n                                          <td>\r\n                                              ");
            EndContext();
            BeginContext(3627, 44, false);
#line 69 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.SilindiMi));

#line default
#line hidden
            EndContext();
            BeginContext(3671, 145, true);
            WriteLiteral("\r\n                                          </td>\r\n                                          <td>\r\n                                              ");
            EndContext();
            BeginContext(3817, 46, false);
#line 72 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.KayitTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(3863, 145, true);
            WriteLiteral("\r\n                                          </td>\r\n                                          <td>\r\n                                              ");
            EndContext();
            BeginContext(4009, 51, false);
#line 75 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.GuncellemeTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(4060, 145, true);
            WriteLiteral("\r\n                                          </td>\r\n                                          <td>\r\n                                              ");
            EndContext();
            BeginContext(4206, 65, false);
#line 78 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                         Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(4271, 50, true);
            WriteLiteral(" |\r\n                                              ");
            EndContext();
            BeginContext(4322, 71, false);
#line 79 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                         Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(4393, 50, true);
            WriteLiteral(" |\r\n                                              ");
            EndContext();
            BeginContext(4444, 69, false);
#line 80 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                         Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(4513, 96, true);
            WriteLiteral("\r\n                                          </td>\r\n                                      </tr>\r\n");
            EndContext();
#line 83 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kurs\Listele.cshtml"
                                  }

#line default
#line hidden
            BeginContext(4646, 104, true);
            WriteLiteral("                              </tbody>\r\n                          </table>\r\n                      </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineSinavSistemi.Model.Data.Kurs>> Html { get; private set; }
    }
}
#pragma warning restore 1591