#pragma checksum "C:\Users\Влад\Source\Repos\Coffe\CoffeXO\CoffeXO\Views\Home\Contacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d072e74265860de3000b0922db4ddedacbbac94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contacts), @"mvc.1.0.view", @"/Views/Home/Contacts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contacts.cshtml", typeof(AspNetCore.Views_Home_Contacts))]
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
#line 1 "C:\Users\Влад\Source\Repos\Coffe\CoffeXO\CoffeXO\Views\_ViewImports.cshtml"
using CoffeXO;

#line default
#line hidden
#line 2 "C:\Users\Влад\Source\Repos\Coffe\CoffeXO\CoffeXO\Views\_ViewImports.cshtml"
using CoffeXO.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d072e74265860de3000b0922db4ddedacbbac94", @"/Views/Home/Contacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93c0f928332037a4bc707bd3a5963f306f0e65f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contacts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Влад\Source\Repos\Coffe\CoffeXO\CoffeXO\Views\Home\Contacts.cshtml"
  
    ViewData["Title"] = "Контактные данные";

#line default
#line hidden
            BeginContext(55, 489, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d072e74265860de3000b0922db4ddedacbbac943342", async() => {
                BeginContext(61, 476, true);
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
            BeginContext(544, 2063, true);
            WriteLiteral(@"


<div class=""all"">
    <h1 style=""text-align:center"" class=""beautifullh"">Контактные данные</h1>

    <div id=""wrapper-9cd199b9cc5410cd3b1ad21cab2e54d3"">
        <div id=""map-9cd199b9cc5410cd3b1ad21cab2e54d3""></div>
        <script>
            (function () {
                var setting = { ""height"": 740, ""width"": 740, ""zoom"": 17, ""queryString"": ""Лопасненская улица, 5, Чехов, Moscow Oblast, Россия"", ""place_id"": ""ChIJW5ly5zRCNUERH3e2LgU_wCw"", ""satellite"": false, ""centerCoord"": [55.14684932280359, 37.45988609999995], ""cid"": ""0x2cc03f052eb6771f"", ""cityUrl"": ""/russia/chekhov-51912"", ""id"": ""map-9cd199b9cc5410cd3b1ad21cab2e54d3"", ""embed_id"": ""115881"" };
                var d = document;
                var s = d.createElement('script');
                s.src = 'https://1map.com/js/script-for-user.js?embed_id=115881';
                s.async = true;
                s.onload = function (e) {
                    window.OneMap.initMap(setting)
                };
                var to = d.getElements");
            WriteLiteral(@"ByTagName('script')[0];
                to.parentNode.insertBefore(s, to);
            })();</script><a href=""https://1map.com/map-embed?embed_id=115881"">1map.com</a>
    </div>

    <div style=""margin-top:20px"">
        <img style=""width:30px"" src=""http://pngimg.com/uploads/phone/phone_PNG49052.png"" /><b style=""margin-left:5px"">8000000000</b> 
    </div>
    <div style=""margin-top:20px"">
        <a style=""color:black"" href=""https://mail.google.com/mail/u/0/#inbox?compose=new""><img style=""width:30px"" src=""https://image.flaticon.com/icons/png/512/9/9923.png"" /><b style=""margin-left:5px"">coffexo&#64;gmail.com</b></a>
    </div>
</div>


<style>

    .all{
        height:auto;
        background: indianred;
        width:auto
    }
    .beautifullh {
        background: indianred;
        color: wheat;
        text-shadow: -2px -2px 0 #4D4644, 2px -2px 0 #4D4644, -2px 2px 0 #4D4644, 2px 2px 0 #4D4644, 4px 4px 0 white, 5px 5px 0 white, 6px 6px 0 white;
        letter-spacing: 0.1em;
    ");
            WriteLiteral("}\r\n</style>\r\n\r\n");
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
