#pragma checksum "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\Shared\_GetArticles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4eb97b09f592fba56106f0afdfc6ff9e170481a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GetArticles), @"mvc.1.0.view", @"/Views/Shared/_GetArticles.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\_ViewImports.cshtml"
using ProgrammingArticles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\_ViewImports.cshtml"
using ProgrammingArticles.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4eb97b09f592fba56106f0afdfc6ff9e170481a", @"/Views/Shared/_GetArticles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27caa7f73e0b23b3375508653ad3b95da5ff7f83", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__GetArticles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Article>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Article", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\Shared\_GetArticles.cshtml"
 foreach (var article in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"element\">\r\n    <div class=\"element__inner\">\r\n        <div class=\"element__top\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4eb97b09f592fba56106f0afdfc6ff9e170481a4145", async() => {
                WriteLiteral("\r\n                <div class=\"element__img ibg\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 319, "\"", 359, 2);
#nullable restore
#line 10 "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\Shared\_GetArticles.cshtml"
WriteAttributeValue("", 325, article.Content.LogoPicture.Path, 325, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 358, "", 359, 1, true);
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 360, "\"", 366, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\Shared\_GetArticles.cshtml"
                                                            WriteLiteral(article.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"element__title\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4eb97b09f592fba56106f0afdfc6ff9e170481a7321", async() => {
                WriteLiteral("\r\n                <h2>");
#nullable restore
#line 16 "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\Shared\_GetArticles.cshtml"
               Write(article.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\Shared\_GetArticles.cshtml"
                                                            WriteLiteral(article.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"element__data\">\r\n            <div class=\"element__data-inner\">\r\n                <div class=\"element__data-creator element__data-icon\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\Shared\_GetArticles.cshtml"
               Write(article.Author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                </div>\r\n                <div class=\"element__data-calendar element__data-icon\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\Shared\_GetArticles.cshtml"
               Write(article.TimeOfCreation.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"element__text\">\r\n            <p>\r\n                ");
#nullable restore
#line 31 "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\Shared\_GetArticles.cshtml"
           Write(article.Content.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n            </p>\r\n        </div>\r\n        <div class=\"element__data-rating\">\r\n            <div class=\"element__data__like element__data-icon\">\r\n                ");
#nullable restore
#line 36 "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\Shared\_GetArticles.cshtml"
           Write(article.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"element__data__comment element__data-icon\">\r\n                ");
#nullable restore
#line 39 "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\Shared\_GetArticles.cshtml"
           Write(article.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 44 "C:\Users\Дима\source\repos\ProgrammingArticles\ProgrammingArticles\Views\Shared\_GetArticles.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Article>> Html { get; private set; }
    }
}
#pragma warning restore 1591
