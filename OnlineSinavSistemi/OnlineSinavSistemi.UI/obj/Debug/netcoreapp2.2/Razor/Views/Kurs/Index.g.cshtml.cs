#pragma checksum "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1027ff8a73e1d00175c22a71a14a8e136caadd6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kurs_Index), @"mvc.1.0.view", @"/Views/Kurs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kurs/Index.cshtml", typeof(AspNetCore.Views_Kurs_Index))]
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
#line 1 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\_ViewImports.cshtml"
using OnlineSinavUI;

#line default
#line hidden
#line 2 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\_ViewImports.cshtml"
using OnlineSinavUI.Models;

#line default
#line hidden
#line 1 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
using OnlineSinavSistemi.Model;

#line default
#line hidden
#line 2 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
using OnlineSinavSistemi.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1027ff8a73e1d00175c22a71a14a8e136caadd6f", @"/Views/Kurs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26cfde4a2bc2bd0fd2fab889f7a1264616e4ab4b", @"/Views/_ViewImports.cshtml")]
    public class Views_Kurs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KursBransViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(97, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
  
    ViewData["Title"] = "DersListesi";


#line default
#line hidden
            BeginContext(150, 1110, true);
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
            WriteLiteral("abs</h2>\r\n<p>Click on the buttons inside the tabbed menu:</p>\r\n\r\n\r\n<div class=\"tab\">\r\n");
            EndContext();
#line 59 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
     foreach (var item in Model.BransListesi)
    {

#line default
#line hidden
            BeginContext(1314, 32, true);
            WriteLiteral("        <button class=\"tablinks\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1346, "\"", 1381, 3);
            WriteAttributeValue("", 1356, "openCity(event,", 1356, 15, true);
#line 61 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
WriteAttributeValue(" ", 1371, item.Id, 1372, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1380, ")", 1380, 1, true);
            EndWriteAttribute();
            BeginContext(1382, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1384, 7, false);
#line 61 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
                                                                Write(item.Ad);

#line default
#line hidden
            EndContext();
            BeginContext(1391, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 62 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1409, 16, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n");
            EndContext();
#line 68 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
 foreach (var item in Model.BransListesi)
{

#line default
#line hidden
            BeginContext(1471, 4, true);
            WriteLiteral("<div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1475, "\"", 1488, 1);
#line 70 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
WriteAttributeValue("", 1480, item.Id, 1480, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1489, 26, true);
            WriteLiteral(" class=\"tabcontent\">\r\n\r\n\r\n");
            EndContext();
#line 73 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
     foreach (var kurs in Model.KursListesi.Where(x => x.Sinav.BransId == item.Id))
    {
        

#line default
#line hidden
            BeginContext(1664, 50, true);
            WriteLiteral("        <div class=\"card\" style=\"width: 18rem;\">\r\n");
            EndContext();
            BeginContext(1814, 37, true);
            WriteLiteral("            <div class=\"card-body\">\r\n");
            EndContext();
            BeginContext(2034, 66, true);
            WriteLiteral("                <p class=\"card-text\">Başlangıç- Bitis Tarihleri : ");
            EndContext();
            BeginContext(2101, 38, false);
#line 82 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
                                                             Write(kurs.BaslamaTarihi.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2139, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(2143, 36, false);
#line 82 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
                                                                                                       Write(kurs.BitisTarihi.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2179, 24, true);
            WriteLiteral("</p>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2203, "\"", 2230, 2);
            WriteAttributeValue("", 2210, "/Kurs/Detay/", 2210, 12, true);
#line 83 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
WriteAttributeValue("", 2222, kurs.Id, 2222, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2231, 137, true);
            WriteLiteral(" class=\"btn btn-primary\">Detay Gör</a>\r\n            </div>\r\n\r\n            <p>London is the capital city of England.</p>\r\n        </div>\r\n");
            EndContext();
#line 88 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(2377, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
            EndContext();
#line 93 "Z:\Fatma Betül YILMAZ\Asp.Net 3 Öğle Branşı\Proje\Hafta7_2\OnlineSinavSistemi\OnlineSinavSistemi.UI\Views\Kurs\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2392, 617, true);
            WriteLiteral(@"
<script>
    function openCity(evt, cityName) {
        var i, tabcontent, tablinks;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KursBransViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
