#pragma checksum "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\KursDuzenle\KursDuzenle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e05ab8409ac194183f905fd61467906434051fed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KursDuzenle_KursDuzenle), @"mvc.1.0.view", @"/Views/KursDuzenle/KursDuzenle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/KursDuzenle/KursDuzenle.cshtml", typeof(AspNetCore.Views_KursDuzenle_KursDuzenle))]
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
#line 1 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\_ViewImports.cshtml"
using OnlineSinavUI;

#line default
#line hidden
#line 2 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\_ViewImports.cshtml"
using OnlineSinavUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05ab8409ac194183f905fd61467906434051fed", @"/Views/KursDuzenle/KursDuzenle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26cfde4a2bc2bd0fd2fab889f7a1264616e4ab4b", @"/Views/_ViewImports.cshtml")]
    public class Views_KursDuzenle_KursDuzenle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal form-bordered"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\KursDuzenle\KursDuzenle.cshtml"
  
    ViewData["Title"] = "Index";
     

#line default
#line hidden
            BeginContext(50, 27517, true);
            WriteLiteral(@"
<!-- BEGIN CONTENT -->
<div class=""page-content-wrapper"">
    <!-- BEGIN CONTENT BODY -->
    <div class=""page-content"">
        <!-- BEGIN PAGE HEADER-->

        <h1 class=""page-title"">
            eCommercen Dashboard
            <small>recent ecommerce statistics, charts, recent orders and sales</small>
        </h1>
        <div class=""page-bar"">
            <ul class=""page-breadcrumb"">
                <li>
                    <i class=""icon-home""></i>
                    <a href=""index.html"">Home</a>
                    <i class=""fa fa-angle-right""></i>
                </li>
                <li>
                    <span>eCommerce</span>
                </li>
            </ul>
            <div class=""page-toolbar"">
                <div class=""btn-group pull-right"">
                    <button type=""button"" class=""btn btn-fit-height grey-salt dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" data-delay=""1000"" data-close-others=""true"">
                        Actions");
            WriteLiteral(@"
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
                            <a href=""#"">
                                <i class=""icon-bag""></i> Separated link
                            </a>
");
            WriteLiteral(@"                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- END PAGE HEADER-->

  
        <div class=""row"">
            <div class=""col-md-12 col-sm-12"">
                <!-- BEGIN PORTLET-->
                <div class=""portlet light "">
                    <div class=""portlet-title tabbable-line"">
                        <div class=""caption"">
                            <i class=""icon-globe font-dark hide""></i>
                            <span class=""caption-subject font-dark bold uppercase"">Kurs Düzenle</span>
                            <span class=""caption-helper"">Son performansınız</span>
                        </div>
                        <ul class=""nav nav-tabs"">
                            <li class=""active"">
                                <a href=""#tab_1_1"" class=""active"" data-toggle=""tab""> Kurs Bilgileri </a>
                            </li>
                            <li>
                                ");
            WriteLiteral(@"<a href=""#tab_1_2"" data-toggle=""tab""> Açıklama </a>
                            </li>
                            <li>
                                <a href=""#tab_1_3"" data-toggle=""tab""> Ozet Bilgiler (Kaç saat vb) </a>
                            </li>
                        </ul>
                    </div>
                    <div class=""portlet-body"">
                        <!--BEGIN TABS-->
                        <div class=""tab-content"">
                            <div class=""tab-pane active"" id=""tab_1_1"">
                                <div class=""scroller"" style=""height: 339px;"" data-always-visible=""1"" data-rail-visible=""0"">
                                    <ul class=""feeds"">
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                      ");
            WriteLiteral(@"  <div class=""label label-sm label-success"">
                                                            <i class=""fa fa-bell-o""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc"">
                                                            You have 4 pending tasks.
                                                            <span class=""label label-sm label-info"">
                                                                Take action
                                                                <i class=""fa fa-share""></i>
                                                            </span>
                                                        </div>
                                                    </div>
                                                </div>
   ");
            WriteLiteral(@"                                         </div>
                                            <div class=""col2"">
                                                <div class=""date""> Just now </div>
                                            </div>
                                        </li>
                                        <li>
                                            <a href=""javascript:;"">
                                                <div class=""col1"">
                                                    <div class=""cont"">
                                                        <div class=""cont-col1"">
                                                            <div class=""label label-sm label-success"">
                                                                <i class=""fa fa-bell-o""></i>
                                                            </div>
                                                        </div>
                                                        <div c");
            WriteLiteral(@"lass=""cont-col2"">
                                                            <div class=""desc""> New version v1.4 just lunched! </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class=""col2"">
                                                    <div class=""date""> 20 mins </div>
                                                </div>
                                            </a>
                                        </li>
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                        <div class=""label label-sm label-danger"">
                                             ");
            WriteLiteral(@"               <i class=""fa fa-bolt""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> Database server #12 overloaded. Please fix the issue. </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col2"">
                                                <div class=""date""> 24 mins </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                                   ");
            WriteLiteral(@" <div class=""cont-col1"">
                                                        <div class=""label label-sm label-info"">
                                                            <i class=""fa fa-bullhorn""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New order received. Please take care of it. </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col2"">
                                                <div class=""date""> 30 mins </div>
                                            </div>
                                        </li>
                                        <li>
                     ");
            WriteLiteral(@"                       <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                        <div class=""label label-sm label-success"">
                                                            <i class=""fa fa-bullhorn""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New order received. Please take care of it. </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col2"">
                                                <div class=""date""> 40 mins </div>
 ");
            WriteLiteral(@"                                           </div>
                                        </li>
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                        <div class=""label label-sm label-warning"">
                                                            <i class=""fa fa-plus""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New user registered. </div>
                                                    </div>
                                                </div>
                                            </div>
          ");
            WriteLiteral(@"                                  <div class=""col2"">
                                                <div class=""date""> 1.5 hours </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                        <div class=""label label-sm label-success"">
                                                            <i class=""fa fa-bell-o""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc"">
                                                            Web ");
            WriteLiteral(@"server hardware needs to be upgraded.
                                                            <span class=""label label-sm label-default ""> Overdue </span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col2"">
                                                <div class=""date""> 2 hours </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                        <div class=""label label-sm label-default"">
                              ");
            WriteLiteral(@"                              <i class=""fa fa-bullhorn""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New order received. Please take care of it. </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col2"">
                                                <div class=""date""> 3 hours </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                          ");
            WriteLiteral(@"          <div class=""cont-col1"">
                                                        <div class=""label label-sm label-warning"">
                                                            <i class=""fa fa-bullhorn""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New order received. Please take care of it. </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col2"">
                                                <div class=""date""> 5 hours </div>
                                            </div>
                                        </li>
                                        <li>
         ");
            WriteLiteral(@"                                   <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                        <div class=""label label-sm label-info"">
                                                            <i class=""fa fa-bullhorn""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New order received. Please take care of it. </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col2"">
                                                <div class=""date""> 18 hours");
            WriteLiteral(@" </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                        <div class=""label label-sm label-default"">
                                                            <i class=""fa fa-bullhorn""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New order received. Please take care of it. </div>
                                                    </div>
                                                </div>
                         ");
            WriteLiteral(@"                   </div>
                                            <div class=""col2"">
                                                <div class=""date""> 21 hours </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                        <div class=""label label-sm label-info"">
                                                            <i class=""fa fa-bullhorn""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New order received. Please tak");
            WriteLiteral(@"e care of it. </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col2"">
                                                <div class=""date""> 22 hours </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                        <div class=""label label-sm label-default"">
                                                            <i class=""fa fa-bullhorn""></i>
                                                        </div>
                                                    </div>
                ");
            WriteLiteral(@"                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New order received. Please take care of it. </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col2"">
                                                <div class=""date""> 21 hours </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                        <div class=""label label-sm label-info"">
                                                            <i class=");
            WriteLiteral(@"""fa fa-bullhorn""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New order received. Please take care of it. </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col2"">
                                                <div class=""date""> 22 hours </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
   ");
            WriteLiteral(@"                                                     <div class=""label label-sm label-default"">
                                                            <i class=""fa fa-bullhorn""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New order received. Please take care of it. </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col2"">
                                                <div class=""date""> 21 hours </div>
                                            </div>
                                        </li>
                                        <li>
                                            <d");
            WriteLiteral(@"iv class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                        <div class=""label label-sm label-info"">
                                                            <i class=""fa fa-bullhorn""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New order received. Please take care of it. </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col2"">
                                                <div class=""date""> 22 hours </div>
                            ");
            WriteLiteral(@"                </div>
                                        </li>
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                        <div class=""label label-sm label-default"">
                                                            <i class=""fa fa-bullhorn""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New order received. Please take care of it. </div>
                                                    </div>
                                                </div>
                                            </div>
          ");
            WriteLiteral(@"                                  <div class=""col2"">
                                                <div class=""date""> 21 hours </div>
                                            </div>
                                        </li>
                                        <li>
                                            <div class=""col1"">
                                                <div class=""cont"">
                                                    <div class=""cont-col1"">
                                                        <div class=""label label-sm label-info"">
                                                            <i class=""fa fa-bullhorn""></i>
                                                        </div>
                                                    </div>
                                                    <div class=""cont-col2"">
                                                        <div class=""desc""> New order received. Please take care of it. </div>
               ");
            WriteLiteral(@"                                     </div>
                                                </div>
                                            </div>
                                            <div class=""col2"">
                                                <div class=""date""> 22 hours </div>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""tab-pane"" id=""tab_1_2"">
                                <div class=""row"">
                                    <div class=""col-md-12"">
                                        <!-- BEGIN EXTRAS PORTLET-->
                                        <div class=""portlet box green"">
                                            <div class=""portlet-title"">
                                                <div class=""caption"">
                                         ");
            WriteLiteral(@"           <i class=""fa fa-gift""></i>CKEditor Editor
                                                </div>
                                                <div class=""tools"">
                                                    <a href=""javascript:;"" class=""collapse""> </a>
                                                    <a href=""#portlet-config"" data-toggle=""modal"" class=""config""> </a>
                                                    <a href=""javascript:;"" class=""reload""> </a>
                                                    <a href=""javascript:;"" class=""remove""> </a>
                                                </div>
                                            </div>
                                            <div class=""portlet-body form"">
                                                <!-- BEGIN FORM-->
                                                ");
            EndContext();
            BeginContext(27567, 1671, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e05ab8409ac194183f905fd61467906434051fed33344", async() => {
                BeginContext(27622, 1609, true);
                WriteLiteral(@"
                                                    <div class=""form-body"">
                                                        <div class=""form-group last"">
                                                            <label class=""control-label col-md-3"">CKEditor</label>
                                                            <div class=""col-md-9"">
                                                                <textarea class=""ckeditor form-control"" name=""editor1"" rows=""6""></textarea>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class=""form-actions"">
                                                        <div class=""row"">
                                                            <div class=""col-md-offset-3 col-md-9"">
                                                                <a hre");
                WriteLiteral(@"f=""javascript:;"" class=""btn green"">
                                                                    <i class=""fa fa-check""></i> Submit
                                                                </a>
                                                                <a href=""javascript:;"" class=""btn btn-outline grey-salsa"">Cancel</a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(29238, 668, true);
            WriteLiteral(@"
                                                <!-- END FORM-->
                                            </div>
                                        </div>
                                        <!-- END EXTRAS PORTLET-->
                                    </div>
                                </div>
                              
                            </div>
                        </div>
                        <!--END TABS-->
                    </div>
                </div>
                <!-- END PORTLET-->
            </div>
       
        </div>
    </div>
    <!-- END CONTENT BODY -->
</div>
<!-- END CONTENT -->
");
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
