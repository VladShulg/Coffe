#pragma checksum "C:\Users\Влад\source\repos\CoffeXO\CoffeXO\Views\Home\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bae0d48aa4f41a116c0d405d2a1de724bd8e19d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Admin), @"mvc.1.0.view", @"/Views/Home/Admin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Admin.cshtml", typeof(AspNetCore.Views_Home_Admin))]
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
#line 1 "C:\Users\Влад\source\repos\CoffeXO\CoffeXO\Views\_ViewImports.cshtml"
using CoffeXO;

#line default
#line hidden
#line 2 "C:\Users\Влад\source\repos\CoffeXO\CoffeXO\Views\_ViewImports.cshtml"
using CoffeXO.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bae0d48aa4f41a116c0d405d2a1de724bd8e19d", @"/Views/Home/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93c0f928332037a4bc707bd3a5963f306f0e65f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Event>>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Влад\source\repos\CoffeXO\CoffeXO\Views\Home\Admin.cshtml"
  
    ViewData["Title"] = "Кабинет администратора";

#line default
#line hidden
            BeginContext(79, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(83, 513, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7bae0d48aa4f41a116c0d405d2a1de724bd8e19d3304", async() => {
                BeginContext(89, 500, true);
                WriteLiteral(@"
        <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
        <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"">
        <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""></script>
        <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""></script>
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
            BeginContext(596, 229, true);
            WriteLiteral("\r\n<h1 class=\"text-shadow-1\">Админ панель</h1>\r\n<table class=\"table\" style=\"width:auto\">\r\n    <tr class=\"table-danger\">\r\n        <th>Название мероприятия</th>\r\n        <th></th>\r\n        <th></th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 21 "C:\Users\Влад\source\repos\CoffeXO\CoffeXO\Views\Home\Admin.cshtml"
     foreach (var ev in Model)
    {

#line default
#line hidden
            BeginContext(864, 52, true);
            WriteLiteral("        <tr class=\"table-warning\">\r\n            <td>");
            EndContext();
            BeginContext(917, 7, false);
#line 24 "C:\Users\Влад\source\repos\CoffeXO\CoffeXO\Views\Home\Admin.cshtml"
           Write(ev.Name);

#line default
#line hidden
            EndContext();
            BeginContext(924, 62, true);
            WriteLiteral("</td>\r\n            <td><button class=\"btn btn-outline-warning\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 986, "\"", 1047, 3);
            WriteAttributeValue("", 996, "window.location.assign(\'/Home/EditEvent?id=", 996, 43, true);
#line 25 "C:\Users\Влад\source\repos\CoffeXO\CoffeXO\Views\Home\Admin.cshtml"
WriteAttributeValue("", 1039, ev.Id, 1039, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 1045, "\')", 1045, 2, true);
            EndWriteAttribute();
            BeginContext(1048, 85, true);
            WriteLiteral(" >Редактировать</button></td>\r\n            <td><button class=\"btn btn-outline-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1133, "\"", 1159, 3);
            WriteAttributeValue("", 1143, "Delete(`", 1143, 8, true);
#line 26 "C:\Users\Влад\source\repos\CoffeXO\CoffeXO\Views\Home\Admin.cshtml"
WriteAttributeValue("", 1151, ev.Id, 1151, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 1157, "`)", 1157, 2, true);
            EndWriteAttribute();
            BeginContext(1160, 76, true);
            WriteLiteral(">Удалить</button></td>\r\n            <td><button class=\"btn btn-outline-info\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1236, "\"", 1293, 3);
            WriteAttributeValue("", 1246, "window.location.assign(\'/Home/Event?id=", 1246, 39, true);
#line 27 "C:\Users\Влад\source\repos\CoffeXO\CoffeXO\Views\Home\Admin.cshtml"
WriteAttributeValue("", 1285, ev.Id, 1285, 6, false);

#line default
#line hidden
            WriteAttributeValue("", 1291, "\')", 1291, 2, true);
            EndWriteAttribute();
            BeginContext(1294, 53, true);
            WriteLiteral(" >Подробная информация</button></td>\r\n        </tr>\r\n");
            EndContext();
#line 29 "C:\Users\Влад\source\repos\CoffeXO\CoffeXO\Views\Home\Admin.cshtml"
     }

#line default
#line hidden
            BeginContext(1355, 1391, true);
            WriteLiteral(@"</table>
    <a href=""/Home/AddEvent"" class=""add""></a>
    <button style=""margin-top: 30px;"" class=""btn btn-success"" onclick=""window.location.assign('/Home/AddEvent')"" >&#43; Добавить мероприятие</button>
<script>
    function Delete(id) {
        var data = {
            Id: id
        };
        console.log(data);

        $.ajax({
            type: ""POST"",
            url: ""/Home/DeleteEventApi"",
            // The key needs to match your method's input parameter (case-sensitive).
            data: data,
            //contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function () { alert(""Мероприятие удалено""); location.reload();},
            failure: function () {
                alert(""Не удалось удалить мероприятие"");
            }
        });
    }
</script>
<style>
    .buttons {
  width: 105px;
  height: 32px;
  text-decoration: none;
  padding-top: 9px;
  color: green;
  text-align: center;
  line-height: 20px;
  displ");
            WriteLiteral(@"ay: block;
  margin: 20px auto;
  font: normal 14px arial;
}
.text-shadow-1 {
            background: powderblue;
            color: wheat;
            text-shadow: -2px -2px 0 #4D4644, 2px -2px 0 #4D4644, -2px 2px 0 #4D4644, 2px 2px 0 #4D4644, 4px 4px 0 white, 5px 5px 0 white, 6px 6px 0 white;
            letter-spacing: 0.1em;
        }

</style>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591