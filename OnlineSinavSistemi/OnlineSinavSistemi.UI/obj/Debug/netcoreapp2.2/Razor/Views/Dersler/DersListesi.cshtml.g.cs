#pragma checksum "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Dersler\DersListesi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e76f8c9baf59ff70c4992092852a616d90a10434"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dersler_DersListesi), @"mvc.1.0.view", @"/Views/Dersler/DersListesi.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dersler/DersListesi.cshtml", typeof(AspNetCore.Views_Dersler_DersListesi))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e76f8c9baf59ff70c4992092852a616d90a10434", @"/Views/Dersler/DersListesi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26cfde4a2bc2bd0fd2fab889f7a1264616e4ab4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Dersler_DersListesi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\murat.MONSTER\Desktop\Hafta9_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Dersler\DersListesi.cshtml"
  
    ViewData["Title"] = "DersListesi";


#line default
#line hidden
            BeginContext(51, 2668, true);
            WriteLiteral(@"<style>
    body {
        font-family: Arial;
    }

    /* Style the tab */
    .tab {
        overflow: hidden;
        border: 1px solid #ccc;
        background-color: #f1f1f1;
    }

        /* Style the buttons inside the tab */
        .tab button {
            background-color: inherit;
            float: left;
            border: none;
            outline: none;
            cursor: pointer;
            padding: 14px 16px;
            transition: 0.3s;
            font-size: 17px;
        }

            /* Change background color of buttons on hover */
            .tab button:hover {
                background-color: #ddd;
            }

            /* Create an active/current tablink class */
            .tab button.active {
                background-color: #ccc;
            }

    /* Style the tab content */
    .tabcontent {
        display: none;
        padding: 6px 12px;
        border: 1px solid #ccc;
        border-top: none;
    }
</style>


<h2>T");
            WriteLiteral(@"abs</h2>
<p>Click on the buttons inside the tabbed menu:</p>

<div class=""tab"">
    <button class=""tablinks"" onclick=""openCity(event, 'London')"">London</button>
    
</div>

<div id=""London"" class=""tabcontent"">


    <div class=""card"" style=""width: 18rem;"">
        <img class=""card-img-top"" src=""..."" alt=""Card image cap"">
        <div class=""card-body"">
            <h5 class=""card-title"">Card title</h5>
            <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
            <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
        </div>

        <p>London is the capital city of England.</p>
    </div>

    <div id=""Paris"" class=""tabcontent"">
        <h3>Paris</h3>
        <p>Paris is the capital of France.</p>
    </div>

    <div id=""Tokyo"" class=""tabcontent"">
        <h3>Tokyo</h3>
        <p>Tokyo is the capital of Japan.</p>
    </div>

    <script>
        function openCity(evt, cityName) {
     ");
            WriteLiteral(@"       var i, tabcontent, tablinks;
            tabcontent = document.getElementsByClassName(""tabcontent"");
            for (i = 0; i < tabcontent.length; i++) {
                tabcontent[i].style.display = ""none"";
            }
            tablinks = document.getElementsByClassName(""tablinks"");
            for (i = 0; i < tablinks.length; i++) {
                tablinks[i].className = tablinks[i].className.replace("" active"", """");
            }
            document.getElementById(cityName).style.display = ""block"";
            evt.currentTarget.className += "" active"";
        }
    </script>

</div>");
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
