#pragma checksum "C:\Users\Влад\source\repos\CoffeXO\CoffeXO\Views\Home\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1812e98fc3df500ffc0f9f0feef93e78c4bb3903"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Main.cshtml", typeof(AspNetCore.Views_Home_Main))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1812e98fc3df500ffc0f9f0feef93e78c4bb3903", @"/Views/Home/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93c0f928332037a4bc707bd3a5963f306f0e65f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Влад\source\repos\CoffeXO\CoffeXO\Views\Home\Main.cshtml"
  
    ViewData["Title"] = "Главная";
 

#line default
#line hidden
            BeginContext(44, 414, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1812e98fc3df500ffc0f9f0feef93e78c4bb39033318", async() => {
                BeginContext(50, 401, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js""></script>
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
            BeginContext(458, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(462, 2986, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1812e98fc3df500ffc0f9f0feef93e78c4bb39034917", async() => {
                BeginContext(468, 2973, true);
                WriteLiteral(@"
    <div class=""all"">
        <h1 style=""text-align:center; font-size:60px;"" class=""text-shadow-1"">Coffe X.O.</h1>
        <div class=""container"" style=""text-align:center; width: 1000px"">
            <div id=""myCarousel"" class=""carousel slide"" data-ride=""carousel"">
                <!-- Indicators -->
                <ol class=""carousel-indicators"">
                    <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#myCarousel"" data-slide-to=""1""></li>
                    <li data-target=""#myCarousel"" data-slide-to=""2""></li>
                </ol>

                <!-- Wrapper for slides -->
                <div class=""carousel-inner"">
                    <div class=""item active"">
                        <img src=""https://my-best-wallpapers.ru/wp-content/gallery/1024-768/1024-768-106.jpg"" alt=""Cat"" style=""width:100%;"">
                        <div class=""carousel-caption"">
                            <h3>Coffe X.O. это</h3>
           ");
                WriteLiteral(@"                 <p>Лучший кофе в городе!</p>
                        </div>
                    </div>

                    <div class=""item"">
                        <img src=""http://wallpapers-images.ru/1024x768/nature/wallpapers/wallpapers-nature-013.jpg"" alt=""Nature"" style=""width:100%;"">
                        <div class=""carousel-caption"">
                            <h3>Coffe X.O. это</h3>
                            <p>Самое уютное кафе!</p>
                        </div>
                    </div>

                    <div class=""item"">
                        <img src=""http://wallpapers-images.ru/1024x768/space/wallpapers/wallpapers-space-025.jpg"" alt=""Astronaut"" style=""width:100%;"">
                        <div class=""carousel-caption"">
                            <h3>Coffe X.O. это</h3>
                            <p>Лучшие десертики!</p>
                        </div>
                    </div>
                </div>

                <!-- Left and right controls -->
       ");
                WriteLiteral(@"         <a class=""left carousel-control"" href=""#myCarousel"" data-slide=""prev"">
                    <span class=""glyphicon glyphicon-chevron-left""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""right carousel-control"" href=""#myCarousel"" data-slide=""next"">
                    <span class=""glyphicon glyphicon-chevron-right""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>


        <h1 class=""text-shadow-1"" style=""text-align:center"">О нас</h1>

        <p><b class=""text"">Какой-то текст, который потом придумаем. Тут планируется что-то типа о самом кафе.</b></p>
        <em>Мы в инстаграмме:</em>
        <p></p>
        <a href=""https://www.instagram.com/""><img class=""insta"" src=""https://png.pngtree.com/element_our/md/20180518/md_5aff6089d3e02.png""/></a>
    </div>
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
            BeginContext(3448, 730, true);
            WriteLiteral(@"



<style>
    .text {font-size:22px;}
    .insta{width:80px}
    .all{
        height:auto;
        background: indianred;
        width:auto;
    }
    .text-shadow {
        text-shadow: 1px 1px 0 orange,1px -1px 0 orange,-1px 1px 0 orange,-1px -1px 0 orange;
        color: white;
        transition: all 1s;
        text-shadow: 1px 1px 0 tan,1px -1px 0 tan,-1px 1px 0 tan,-1px -1px 0 tan;
        color: white;
    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591