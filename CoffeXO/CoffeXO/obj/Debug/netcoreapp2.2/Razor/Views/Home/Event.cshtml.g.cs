#pragma checksum "C:\Users\Влад\Source\Repos\Coffe\CoffeXO\CoffeXO\Views\Home\Event.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5e554d58b5f2d9700d23a109abff8d744c9b3cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Event), @"mvc.1.0.view", @"/Views/Home/Event.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Event.cshtml", typeof(AspNetCore.Views_Home_Event))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5e554d58b5f2d9700d23a109abff8d744c9b3cc", @"/Views/Home/Event.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93c0f928332037a4bc707bd3a5963f306f0e65f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Event : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Влад\Source\Repos\Coffe\CoffeXO\CoffeXO\Views\Home\Event.cshtml"
  
    ViewData["Title"] = $"{Model.Name}";

#line default
#line hidden
            BeginContext(63, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(67, 545, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5e554d58b5f2d9700d23a109abff8d744c9b3cc3453", async() => {
                BeginContext(73, 532, true);
                WriteLiteral(@"
        <meta charset=""utf-8"">
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
            BeginContext(612, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(614, 630, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5e554d58b5f2d9700d23a109abff8d744c9b3cc5180", async() => {
                BeginContext(620, 85, true);
                WriteLiteral("\r\n    <div class=\"all\">\r\n        <h1 class=\"text-shadow-1\" style=\"text-align:center\">");
                EndContext();
                BeginContext(706, 10, false);
#line 15 "C:\Users\Влад\Source\Repos\Coffe\CoffeXO\CoffeXO\Views\Home\Event.cshtml"
                                                       Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(716, 57, true);
                WriteLiteral("</h1>\r\n        <div style=\"width:auto\">\r\n            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 773, "\"", 792, 1);
#line 17 "C:\Users\Влад\Source\Repos\Coffe\CoffeXO\CoffeXO\Views\Home\Event.cshtml"
WriteAttributeValue("", 779, Model.ImgSrc, 779, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(793, 69, true);
                WriteLiteral(" class=\"img-thumbnail\"/>\r\n        </div>\r\n        <p><b class=\"text\">");
                EndContext();
                BeginContext(863, 10, false);
#line 19 "C:\Users\Влад\Source\Repos\Coffe\CoffeXO\CoffeXO\Views\Home\Event.cshtml"
                      Write(Model.Info);

#line default
#line hidden
                EndContext();
                BeginContext(873, 260, true);
                WriteLiteral(@"</b></p>
        <h2>Расписание</h2>

        <table class=""table"">
            <tr class=""table-danger"">
                <th>День недели</th>
                <th>Время</th>
            </tr>
            <tr class=""table-warning"">
                <td>");
                EndContext();
                BeginContext(1134, 9, false);
#line 28 "C:\Users\Влад\Source\Repos\Coffe\CoffeXO\CoffeXO\Views\Home\Event.cshtml"
               Write(Model.Day);

#line default
#line hidden
                EndContext();
                BeginContext(1143, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(1171, 10, false);
#line 29 "C:\Users\Влад\Source\Repos\Coffe\CoffeXO\CoffeXO\Views\Home\Event.cshtml"
               Write(Model.Time);

#line default
#line hidden
                EndContext();
                BeginContext(1181, 56, true);
                WriteLiteral("</td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n");
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
            BeginContext(1244, 412, true);
            WriteLiteral(@"
<style>
    .all{
        height: auto;
        background: indianred;
        width:auto;
    }
    .text{font-size:22px;}
    .text-shadow-1 {
        background: indianred;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event> Html { get; private set; }
    }
}
#pragma warning restore 1591
