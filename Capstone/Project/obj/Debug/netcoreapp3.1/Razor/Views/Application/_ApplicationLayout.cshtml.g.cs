#pragma checksum "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66fcd025002bfda4f8b180b0ae8b42945a56597c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Application__ApplicationLayout), @"mvc.1.0.view", @"/Views/Application/_ApplicationLayout.cshtml")]
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
#line 1 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66fcd025002bfda4f8b180b0ae8b42945a56597c", @"/Views/Application/_ApplicationLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    public class Views_Application__ApplicationLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("apple-touch-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("sizes", new global::Microsoft.AspNetCore.Html.HtmlString("76x76"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image/png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n    \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66fcd025002bfda4f8b180b0ae8b42945a56597c5827", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "66fcd025002bfda4f8b180b0ae8b42945a56597c6123", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "66fcd025002bfda4f8b180b0ae8b42945a56597c7389", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge,chrome=1\" />\r\n    <title>\r\n        ");
#nullable restore
#line 15 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </title>
    <meta content='width=device-width, initial-scale=1.0, shrink-to-fit=no' name='viewport' />
    <link rel=""stylesheet"" type=""text/css"" href=""https://fonts.googleapis.com/css?family=Roboto:300,400,500,700|Roboto+Slab:400,700|Material+Icons"" />
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css"">
    <link href=""../assets/css/material-dashboard.css?v=2.1.2"" rel=""stylesheet"" />
    <link href=""/css/material-dashboard.css"" rel=""stylesheet"" />
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66fcd025002bfda4f8b180b0ae8b42945a56597c10244", async() => {
                WriteLiteral(@"
    <div class=""wrapper "">
        <div class=""sidebar"" data-color=""purple"" data-background-color=""white"" data-image=""../assets/img/sidebar-1.jpg"">
            <div class=""logo"">
                <h3 href=""Index"" class=""simple-text logo-normal""><!--USE asp-controller & as--action methods instead!!!-->
                    Panacea
                </h3>

            </div>
            <div class=""sidebar-wrapper"">
                <ul class=""nav"">
                    <li class=""nav-item  "">
                        <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 1524, "\"", 1559, 1);
#nullable restore
#line 36 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml"
WriteAttributeValue("", 1531, Url.Action("Index", "Home"), 1531, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <i class=""material-icons"">notifications</i>
                            <p>Home</p>
                        </a>
                    </li>
                    <li class=""nav-item  "">
                        <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 1822, "\"", 1868, 1);
#nullable restore
#line 42 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml"
WriteAttributeValue("", 1829, Url.Action("Dashboard", "Application"), 1829, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <i class=""material-icons"">dashboard</i>
                            <p>Dashboard</p>
                        </a>
                    </li>
                    <li class=""nav-item "">
                        <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 2131, "\"", 2175, 1);
#nullable restore
#line 48 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml"
WriteAttributeValue("", 2138, Url.Action("AccountInfo", "Account"), 2138, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <i class=""material-icons"">person</i>
                            <p>Account</p>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 2432, "\"", 2488, 1);
#nullable restore
#line 54 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml"
WriteAttributeValue("", 2439, Url.Action("ProjectRegistration", "Application"), 2439, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <i class=""material-icons"">content_paste</i>
                            <p>Add Project</p>
                        </a>
                    </li>
                    <li class=""nav-item "">
                        <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 2757, "\"", 2807, 1);
#nullable restore
#line 60 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml"
WriteAttributeValue("", 2764, Url.Action("BugSubmission", "Application"), 2764, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <i class=""material-icons"">library_books</i>
                            <p>Submit a Bug</p>
                        </a>
                    </li>
                    <li class=""nav-item "">
                        <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 3077, "\"", 3121, 1);
#nullable restore
#line 66 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml"
WriteAttributeValue("", 3084, Url.Action("Archive", "Application"), 3084, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            <i class=""material-icons"">bubble_chart</i>
                            <p>Archive</p>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
        <div class=""main-panel"">
            <!-- Navbar -->
            <nav class=""navbar navbar-expand-lg navbar-transparent navbar-absolute fixed-top"">
                <div class=""container-fluid"">
                    <div class=""navbar-wrapper"">
                        <h2>");
#nullable restore
#line 79 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml"
                       Write(ViewBag.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                    </div>
                    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" aria-controls=""navigation-index"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <span class=""navbar-toggler-icon icon-bar""></span>
                        <span class=""navbar-toggler-icon icon-bar""></span>
                        <span class=""navbar-toggler-icon icon-bar""></span>
                    </button>
                    <div class=""collapse navbar-collapse justify-content-end"">
                        <ul class=""navbar-nav"">
                            <!--Notifications-->
                            <li class=""nav-item"">
                                <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 4477, "\"", 4523, 1);
#nullable restore
#line 91 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml"
WriteAttributeValue("", 4484, Url.Action("Dashboard", "Application"), 4484, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                    <i class=""material-icons"">notifications</i>
                                </a>
                            </li>
                            <!--Account-->
                            <li class=""nav-item"">
                                <a class=""nav-link""");
                BeginWriteAttribute("href", " href=\"", 4827, "\"", 4871, 1);
#nullable restore
#line 97 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml"
WriteAttributeValue("", 4834, Url.Action("AccountInfo", "Account"), 4834, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <i class=\"material-icons\">person</i> ");
#nullable restore
#line 98 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml"
                                                                    Write(UserMgr.GetUserName(User));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </a>
                            </li>
                            <!-- your navbar here -->
                        </ul>
                    </div>
                </div>
            </nav>
            <!-- End Navbar -->
            <!--Custom Content-->
            <div class=""content"">
                <div class=""container-fluid"">
                    ");
#nullable restore
#line 110 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\_ApplicationLayout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>

            <!--Footer-->
            <footer class=""footer"">
                <div class=""container-fluid"">
                    <div class=""copyright float-right"">
                        &copy;
                        <script>document.write(new Date().getFullYear())</script> Panacea.dev
                    </div>
                </div>
            </footer>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserMgr { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInMgr { get; private set; }
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
