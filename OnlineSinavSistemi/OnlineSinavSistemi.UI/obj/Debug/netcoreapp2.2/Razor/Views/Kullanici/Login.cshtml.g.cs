#pragma checksum "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kullanici\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac7de934dab07d0ee615b0523785d8c47c5e4eec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kullanici_Login), @"mvc.1.0.view", @"/Views/Kullanici/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kullanici/Login.cshtml", typeof(AspNetCore.Views_Kullanici_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac7de934dab07d0ee615b0523785d8c47c5e4eec", @"/Views/Kullanici/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26cfde4a2bc2bd0fd2fab889f7a1264616e4ab4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Kullanici_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/kullanici/login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login100-form validate-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kullanici\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 39, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(68, 2046, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7de934dab07d0ee615b0523785d8c47c5e4eec5062", async() => {
                BeginContext(74, 2033, true);
                WriteLiteral(@"

    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""apple-mobile-web-app-status-bar-style"" content=""black"">
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">
    <title>İsmek Online Sınav Sistemi</title>
    <!-- Bootstrap core CSS -->
    <!--===============================================================================================-->
    <link rel=""icon"" type=""image/png"" href=""/tmp/images/icons/favicon.ico"" />
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/tmp/vendor/bootstrap/css/bootstrap.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=");
                WriteLiteral(@"""/tmp/fonts/font-awesome-4.7.0/css/font-awesome.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/tmp/vendor/animate/animate.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/tmp/vendor/css-hamburgers/hamburgers.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/tmp/vendor/select2/select2.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/tmp/css/util.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/tmp/css/main.css"">
    <!--===============================================================================================-->
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2114, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(2118, 3036, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7de934dab07d0ee615b0523785d8c47c5e4eec8392", async() => {
                BeginContext(2124, 305, true);
                WriteLiteral(@"
    <!-- Navigation -->
    <div class=""limiter"">
        <div class=""container-login100"">
            <div class=""wrap-login100"">
                <div class=""login100-pic js-tilt"" data-tilt>
                    <img src=""/tmp/images/logo.png"" alt=""IMG"">
                </div>

                ");
                EndContext();
                BeginContext(2429, 1752, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac7de934dab07d0ee615b0523785d8c47c5e4eec9093", async() => {
                    BeginContext(2511, 1663, true);
                    WriteLiteral(@"
                    <span class=""login100-form-title"" style=""width:300px;"">
                        <h3 style=""font-weight: bold;"">İsmek Online Sınav Sistemi </h3>
                    </span>

                    <div class=""wrap-input100 validate-input "" data-validate=""Email"">
                        <input class=""input100"" type=""text"" name=""EMail"" placeholder=""Email"">
                        <span class=""focus-input100""></span>
                        <span class=""symbol-input100"">
                            <i class=""fa fa-address-card"" aria-hidden=""true""></i>
                        </span>
                    </div>

                    <div class=""wrap-input100 validate-input"" data-validate=""Şifre Gerekli"">
                        <input class=""input100"" type=""password"" name=""Sifre"" placeholder=""Şifre"">
                        <span class=""focus-input100""></span>
                        <span class=""symbol-input100"">
                            <i class=""fa fa-lock"" aria-hidden=""true""");
                    WriteLiteral(@"></i>
                        </span>
                    </div>

                    <div class=""container-login100-form-btn"">
                        <button type=""submit"" class=""login100-form-btn"">
                            Gİrİş
                        </button>
                    </div>

                    <div class=""text-center p-t-12"">
                        <a class=""txt2"" href=""password_forget.html"">
                            Şifremi Unuttum
                        </a>
                    </div>


                    <div class=""text-center p-t-136"">

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
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4181, 966, true);
                WriteLiteral(@"
            </div>
        </div>
    </div>



    <!-- Bootstrap core JavaScript -->
    <script src=""/tmp/vendor/jquery/jquery.min.js""></script>
    <script src=""/tmp/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/tmp/vendor/bootstrap/js/popper.js""></script>
    <script src=""/tmp/vendor/bootstrap/js/bootstrap.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/tmp/vendor/select2/select2.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/tmp/vendor/tilt/tilt.jquery.min.js""></script>
    <script src=""/tmp/js/main.js""></script>
    <script>
        $('.js-tilt').tilt({
            scale: 1.1
        })
    </script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5154, 15, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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