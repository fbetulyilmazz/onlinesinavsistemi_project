#pragma checksum "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a0e339de5dd03eefd035671c16520ea75b78db0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Kullanici_Listele), @"mvc.1.0.view", @"/Areas/Admin/Views/Kullanici/Listele.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Kullanici/Listele.cshtml", typeof(AspNetCore.Areas_Admin_Views_Kullanici_Listele))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a0e339de5dd03eefd035671c16520ea75b78db0", @"/Areas/Admin/Views/Kullanici/Listele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a42d186337a122ea1b1fd05613dcf466f58175", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Kullanici_Listele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineSinavSistemi.Model.Data.Kullanici>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn sbold green"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "~/Admin/Kullanici/Ekle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
  
    ViewData["Title"] = "Listele";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(170, 3872, true);
            WriteLiteral(@"
<h2>Listele</h2>





<!-- BEGIN CONTENT -->
<div class=""page-content-wrapper"">
    <!-- BEGIN CONTENT BODY -->
    <div class=""page-content"">
        <!-- BEGIN PAGE HEADER-->
      
        <h1 class=""page-title"">
         Kullanici Listesi
            <small>managed datatable samples</small>
        </h1>
        <div class=""page-bar"">
            <ul class=""page-breadcrumb"">
                <li>
                    <i class=""icon-home""></i>
                    <a href=""index.html"">Home</a>
                    <i class=""fa fa-angle-right""></i>
                </li>
                <li>
                    <a href=""#"">Tables</a>
                    <i class=""fa fa-angle-right""></i>
                </li>
                <li>
                    <span>Datatables</span>
                </li>
            </ul>
            <div class=""page-toolbar"">
                <div class=""btn-group pull-right"">
                    <button type=""button"" class=""btn btn-fit-height grey-salt d");
            WriteLiteral(@"ropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" data-delay=""1000"" data-close-others=""true"">
                        Actions
                        <i class=""fa fa-angle-down""></i>
                    </button>
                    <ul class=""dropdown-menu pull-right"" role=""menu"">
                        <li>
                            <a href=""#"">
                                <i class=""icon-bell""></i> Action
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <i class=""icon-shield""></i> Another action
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <i class=""icon-user""></i> Something else here
                            </a>
                        </li>
                        <li class=""divider""> </li>
                        <li>
           ");
            WriteLiteral(@"                 <a href=""#"">
                                <i class=""icon-bag""></i> Separated link
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- END PAGE HEADER-->
       
        <div class=""row"">
            <div class=""col-md-12"">
                <!-- BEGIN EXAMPLE TABLE PORTLET-->
                <div class=""portlet light "">
                    <div class=""portlet-title"">
                        <div class=""caption font-dark"">
                            <i class=""icon-settings font-dark""></i>
                            <span class=""caption-subject bold uppercase"">Kullanici Listesi</span>
                        </div>
                        <div class=""actions"">
                            <div class=""btn-group btn-group-devided"" data-toggle=""buttons"">
                                <label class=""btn btn-transparent dark btn-outline btn-circle btn-sm active"">
      ");
            WriteLiteral(@"                              <input type=""radio"" name=""options"" class=""toggle"" id=""option1"">Actions
                                </label>
                                <label class=""btn btn-transparent dark btn-outline btn-circle btn-sm"">
                                    <input type=""radio"" name=""options"" class=""toggle"" id=""option2"">Settings
                                </label>
                            </div>
                        </div>
                    </div>
                    <div class=""portlet-body"">
                        <div class=""table-toolbar"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <div class=""btn-group"">
                                        ");
            EndContext();
            BeginContext(4042, 278, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a0e339de5dd03eefd035671c16520ea75b78db08931", async() => {
                BeginContext(4112, 204, true);
                WriteLiteral("\r\n                                           Ekle\r\n                                            <i class=\"fa fa-plus\"></i>                                         \r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4320, 2515, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""btn-group pull-right"">
                                        <button class=""btn green  btn-outline dropdown-toggle"" data-toggle=""dropdown"">
                                            Tools
                                            <i class=""fa fa-angle-down""></i>
                                        </button>
                                        <ul class=""dropdown-menu pull-right"">
                                            <li>
                                                <a href=""javascript:;"">
                                                    <i class=""fa fa-print""></i> Print
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""javascrip");
            WriteLiteral(@"t:;"">
                                                    <i class=""fa fa-file-pdf-o""></i> Save as PDF
                                                </a>
                                            </li>
                                            <li>
                                                <a href=""javascript:;"">
                                                    <i class=""fa fa-file-excel-o""></i> Export to Excel
                                                </a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <table class=""table table-striped table-bordered table-hover table-checkable order-column"" id=""sample_1"">
                            

                            <thead>
                                <tr>
                                    <th>
   ");
            WriteLiteral(@"                                     <label class=""mt-checkbox mt-checkbox-single mt-checkbox-outline"">
                                            <input type=""checkbox"" class=""group-checkable"" data-set=""#sample_1 .checkboxes"" />
                                            <span></span>
                                        </label>
                                    </th>
                                    <th>
                                        ");
            EndContext();
            BeginContext(6836, 38, false);
#line 143 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Ad));

#line default
#line hidden
            EndContext();
            BeginContext(6874, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(7002, 41, false);
#line 146 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Soyad));

#line default
#line hidden
            EndContext();
            BeginContext(7043, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(7171, 38, false);
#line 149 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Tc));

#line default
#line hidden
            EndContext();
            BeginContext(7209, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(7337, 47, false);
#line 152 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                                   Write(Html.DisplayNameFor(model => model.DogumTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(7384, 127, true);
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(7512, 41, false);
#line 155 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                                   Write(Html.DisplayNameFor(model => model.EMail));

#line default
#line hidden
            EndContext();
            BeginContext(7553, 163, true);
            WriteLiteral("\r\n                                    </th>\r\n                                  \r\n                                    <th>\r\n                                        ");
            EndContext();
            BeginContext(7717, 43, false);
#line 159 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                                   Write(Html.DisplayNameFor(model => model.FotoUrl));

#line default
#line hidden
            EndContext();
            BeginContext(7760, 274, true);
            WriteLiteral(@"
                                    </th>
                                 
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                               
");
            EndContext();
#line 167 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(8131, 257, true);
            WriteLiteral(@"                            <tr>
                                <td>
                                    <label class=""mt-checkbox mt-checkbox-single mt-checkbox-outline"">
                                        <input type=""checkbox"" class=""checkboxes""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 8388, "\"", 8404, 1);
#line 172 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
WriteAttributeValue("", 8396, item.Id, 8396, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8405, 219, true);
            WriteLiteral(" />\r\n                                        <span></span>\r\n                                    </label>\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(8625, 37, false);
#line 177 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Ad));

#line default
#line hidden
            EndContext();
            BeginContext(8662, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(8778, 40, false);
#line 180 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Soyad));

#line default
#line hidden
            EndContext();
            BeginContext(8818, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(8934, 37, false);
#line 183 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Tc));

#line default
#line hidden
            EndContext();
            BeginContext(8971, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(9087, 46, false);
#line 186 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                               Write(Html.DisplayFor(modelItem => item.DogumTarihi));

#line default
#line hidden
            EndContext();
            BeginContext(9133, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(9249, 40, false);
#line 189 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                               Write(Html.DisplayFor(modelItem => item.EMail));

#line default
#line hidden
            EndContext();
            BeginContext(9289, 147, true);
            WriteLiteral("\r\n                                </td>\r\n                              \r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(9437, 42, false);
#line 193 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FotoUrl));

#line default
#line hidden
            EndContext();
            BeginContext(9479, 146, true);
            WriteLiteral("\r\n                                </td>\r\n                             \r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(9626, 96, false);
#line 197 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                               Write(Html.ActionLink("Edit", "Guncelle", new { kullaniciId=item.Id},new { @class="btn btn-default" }));

#line default
#line hidden
            EndContext();
            BeginContext(9722, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(9763, 67, false);
#line 198 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                               Write(Html.ActionLink("Details", "Details", new {  kullaniciId=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(9830, 40, true);
            WriteLiteral(" |\r\n                                    ");
            EndContext();
            BeginContext(9871, 61, false);
#line 199 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                               Write(Html.ActionLink("Delete", "Sil", new { kullaniciId=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(9932, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(10225, 74, true);
            WriteLiteral("                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 205 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Kullanici\Listele.cshtml"
                                }

#line default
#line hidden
            BeginContext(10334, 291, true);
            WriteLiteral(@"

                            </tbody>
                        </table>
                    </div>
                </div>
                <!-- END EXAMPLE TABLE PORTLET-->
            </div>
        </div>
   
    </div>
    <!-- END CONTENT BODY -->
</div>
<!-- END CONTENT -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineSinavSistemi.Model.Data.Kullanici>> Html { get; private set; }
    }
}
#pragma warning restore 1591
