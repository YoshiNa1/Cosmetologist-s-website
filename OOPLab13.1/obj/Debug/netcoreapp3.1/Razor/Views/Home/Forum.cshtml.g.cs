#pragma checksum "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e99a92b2301c22051aa5797f6e5dcab4747af00d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Forum), @"mvc.1.0.view", @"/Views/Home/Forum.cshtml")]
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
#line 1 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/_ViewImports.cshtml"
using OOPLab13._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/_ViewImports.cshtml"
using OOPLab13._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e99a92b2301c22051aa5797f6e5dcab4747af00d", @"/Views/Home/Forum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1a67796f845883118ff9aec1076d1e87b56f78a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Forum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HideComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e99a92b2301c22051aa5797f6e5dcab4747af00d5711", async() => {
                WriteLiteral("\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e99a92b2301c22051aa5797f6e5dcab4747af00d6032", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <title>Success publishing</title>\n");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e99a92b2301c22051aa5797f6e5dcab4747af00d8008", async() => {
                WriteLiteral("\n\n    <div>\n        <h1>Hello, ");
#nullable restore
#line 11 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
              Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" !</h1> </br>\n\n");
#nullable restore
#line 13 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
         foreach (var comment in ViewBag.Comments)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
             if (User.Identity.IsAuthenticated && User.Identity.Name == "admin")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e99a92b2301c22051aa5797f6e5dcab4747af00d9050", async() => {
                    WriteLiteral("\n");
#nullable restore
#line 19 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                     if (comment.Hidden)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        <span>Show</span>\n");
#nullable restore
#line 22 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        <span>Hide</span>\n");
#nullable restore
#line 26 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                                                                    WriteLiteral(comment.Id);

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
                WriteLiteral("\n");
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e99a92b2301c22051aa5797f6e5dcab4747af00d12359", async() => {
                    WriteLiteral("\n");
#nullable restore
#line 31 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                     if (comment != null)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        <span>| Edit</span>\n");
#nullable restore
#line 34 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                                              WriteLiteral(comment.Id);

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
                WriteLiteral("\n");
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e99a92b2301c22051aa5797f6e5dcab4747af00d15140", async() => {
                    WriteLiteral("\n");
#nullable restore
#line 39 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                     if (comment != null)
                    {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                        <span>| Delete</span><br>\n");
#nullable restore
#line 42 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                                                                      WriteLiteral(comment.Id);

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
                WriteLiteral("\n");
                WriteLiteral("                <table>\n                    <tr>\n                        ");
#nullable restore
#line 48 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                   Write(comment.Login);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
#line 48 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                                    Write(comment.CommentDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        <h1> ");
#nullable restore
#line 49 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                        Write(comment.CommentText);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h1>\n                    </tr>\n                </table>\n");
#nullable restore
#line 52 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
             if (User.Identity.IsAuthenticated && User.Identity.Name != "admin")
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                 if (comment.Hidden)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <table>\n                        <tr>\n                            ");
#nullable restore
#line 65 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                       Write(Html.Hidden("Login", @comment.Login as string));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            ");
#nullable restore
#line 66 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                       Write(Html.Hidden("CommentText", @comment.CommentText as string));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            ");
#nullable restore
#line 67 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                       Write(Html.Hidden("CommentDate", @comment.CommentDate as string));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </tr>\n                    </table>\n");
#nullable restore
#line 70 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <table>\n                        <tr>\n                            ");
#nullable restore
#line 75 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                       Write(comment.Login);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
#line 75 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                                        Write(comment.CommentDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                            <h1> ");
#nullable restore
#line 76 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                            Write(comment.CommentText);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h1>\n                        </tr>\n                    </table>\n");
#nullable restore
#line 79 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
             


        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <p> ");
#nullable restore
#line 84 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
       Write(Html.ActionLink("Go home <= ", "Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("|");
#nullable restore
#line 84 "/Users/anastasiia/Projects/OOPLab13.1/OOPLab13.1/Views/Home/Forum.cshtml"
                                                Write(Html.ActionLink(" => Publish Comment!", "Publish"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\n    </div>\n");
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
            WriteLiteral("\n</html>\n");
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
