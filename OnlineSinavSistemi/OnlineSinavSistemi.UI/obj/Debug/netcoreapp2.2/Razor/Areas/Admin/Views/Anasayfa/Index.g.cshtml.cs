#pragma checksum "C:\Users\Lab03-16\Desktop\Hafta6_1\onlinesinavsistemi_project\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Anasayfa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc61627619188fc8833775a5a4206165336228e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Anasayfa_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Anasayfa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Anasayfa/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Anasayfa_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc61627619188fc8833775a5a4206165336228e5", @"/Areas/Admin/Views/Anasayfa/Index.cshtml")]
    public class Areas_Admin_Views_Anasayfa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Lab03-16\Desktop\Hafta6_1\onlinesinavsistemi_project\OnlineSinavSistemi\OnlineSinavSistemi.UI\Areas\Admin\Views\Anasayfa\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(107, 518, true);
            WriteLiteral(@"
<!-- BEGIN CONTENT -->
<div class=""page-content-wrapper"">
    <!-- BEGIN CONTENT BODY -->
    <div class=""page-content"">
        <!-- BEGIN PAGE HEADER-->


        <div class=""page-bar"">
            <ul class=""page-breadcrumb"">
                <li>
                    <i class=""icon-home""></i>
                    <a href=""index.html"">Sınavlar</a>
                    <i class=""fa fa-angle-right""></i>
                </li>
                <li>
                    <a href=""#"">Sınavlar Listesi</a>
");
            EndContext();
            BeginContext(684, 23, true);
            WriteLiteral("                </li>\r\n");
            EndContext();
            BeginContext(812, 3312, true);
            WriteLiteral(@"            </ul>

        </div>
        <!-- END PAGE HEADER-->
        <div class=""row"">
            <div class=""col-md-12"">
                <!-- BEGIN EXAMPLE TABLE PORTLET-->
                <div class=""portlet light "">

                    <div class=""portlet-body"">
                        <div class=""table-toolbar"">
                            <div class=""row"">
                                <div class=""col-md-4"">

                                    <!-- Button trigger modal -->
                                    <button type=""button"" class=""btn sbold green"" data-toggle=""modal"" data-target=""#exampleModal"">
                                        Sınav Yeri
                                    </button>
                                </div>

                            </div>

                        </div>

                        <table class=""table table-striped table-bordered table-hover table-checkable order-column"" id=""sample_1"">
                            <thead>
   ");
            WriteLiteral(@"                             <tr>
                                    <th>
                                        <label class=""mt-checkbox mt-checkbox-single mt-checkbox-outline"">
                                            <input type=""checkbox"" class=""group-checkable"" data-set=""#sample_1 .checkboxes"" />
                                            <span></span>
                                        </label>
                                    </th>

                                    <th> Eğitim Tarihi </th>
                                    <th> Sınav No </th>
                                    <th> Eğitim Türü </th>
                                    <th> Eğitmen-ler </th>
                                    <th> Eğitim Yeri</th>
                                    <th> Sınav Mevcudu </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr class=""odd gradeX"">
                          ");
            WriteLiteral(@"          <td>
                                        <label class=""mt-checkbox mt-checkbox-single mt-checkbox-outline"">
                                            <input type=""checkbox"" class=""checkboxes"" value=""1"" />
                                            <span></span>
                                        </label>
                                    </td>
                                    <td> shuxer </td>
                                    <td>
                                        <a href=""mailto:shuxer@gmail.com""> shuxer@gmail.com </a>
                                    </td>
                                    <td class=""center"">Approved</td>
                                    <td class=""center""> 12 Jan 2012 </td>
                                    <td class=""center""> 12 Jan 2012 </td>
                                    <td class=""center""> 12 Jan 2012 </td>
                                </tr>
                            </tbody>
                        </table>
    ");
            WriteLiteral("                </div>\r\n                </div>\r\n                <!-- END EXAMPLE TABLE PORTLET-->\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n    <!-- END CONTENT BODY -->\r\n</div>\r\n<!-- END CONTENT -->\r\n#include virtual=\"a.html\" \r\n");
            EndContext();
            BeginContext(4284, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
