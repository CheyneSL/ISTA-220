#pragma checksum "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a9c4b4feb42acb307f225f035c0cd5d9ac9700a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Application_Dashboard), @"mvc.1.0.view", @"/Views/Application/Dashboard.cshtml")]
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
#line 1 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\Dashboard.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\Dashboard.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a9c4b4feb42acb307f225f035c0cd5d9ac9700a", @"/Views/Application/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    public class Views_Application_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SingleBugViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/projectregistration.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 50px; height: 50px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/bug.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/backlog.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("TextSearchInput"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search Backlog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "/Views/Application/_ApplicationLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""box"">
    <div class=""container"">
        <div class=""row"">

            <!--Register Project Card-->
            <div class=""col-md-4"">
                <a href=""ProjectRegistration"">
                    <div class=""card card-chart"">
                        <div class=""card-header card-header-info"">
                            <div id=""ProjectRegistraion"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a9c4b4feb42acb307f225f035c0cd5d9ac9700a7654", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
                        </div>
                        <div class=""card-body"">
                            <h4 class=""card-title"">Add Project</h4>
                            <p class=""card-category"">
                                <span class=""text-dark""><i class=""fa fa-cog""></i></span> Register an application or API currently under development.
                            </p>
                        </div>
                        <div class=""card-footer"">
                            <div class=""stats"">
                                <i class=""material-icons"">access_time</i> Last Accessed 10 minutes ago
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <!--Bug Submission Card-->
            <div class=""col-md-4"">
                <a href=""BugSubmission"">
                    <div class=""card card-chart"">
                        <div class=""card-header card-header-danger"">
              ");
            WriteLiteral("              <div class=\"ct-chart\" id=\"BugSubmission\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a9c4b4feb42acb307f225f035c0cd5d9ac9700a9902", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
                        </div>
                        <div class=""card-body"">
                            <h4 class=""card-title"">Submit a Bug</h4>
                            <p class=""card-category"">
                                <span class=""text-dark""><i class=""fa fa-cog""></i></span> Submit a new bug or issue based on industry standards.
                            </p>
                        </div>
                        <div class=""card-footer"">
                            <div class=""stats"">
                                <i class=""material-icons"">access_time</i> Last accessed 10 minutes ago
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <!--Archive Card-->
            <div class=""col-md-4"">
                <a href=""Archive"">
                    <div class=""card card-chart"">
                        <div class=""card-header card-header-success"">
                            <d");
            WriteLiteral("iv class=\"ct-chart\" id=\"Archive\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a9c4b4feb42acb307f225f035c0cd5d9ac9700a12128", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</div>
                        </div>
                        <div class=""card-body"">
                            <h4 class=""card-title"">Archive</h4>
                            <p class=""card-category"">
                                <span class=""text-dark""><i class=""fa fa-cog""></i></span> Access closed bugs and issues for auditing.
                            </p>
                        </div>
                        <div class=""card-footer"">
                            <div class=""stats"">
                                <i class=""material-icons"">access_time</i> Last accessed 10 minutes ago
                            </div>
                        </div>
                    </div>
                </a>
            </div>

        </div>
    </div>
</div>



<div class=""col-md-12"">
    <div class=""card"">
    
        <div class=""card-header card-header-primary"">
            <h4 class=""card-title "">Backlog</h4>

            <div style=""background-color: white; width: 100%; borde");
            WriteLiteral("r-radius: calc(0.25rem - 1px) calc(0.25rem - 1px) 0 0;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a9c4b4feb42acb307f225f035c0cd5d9ac9700a14396", async() => {
                WriteLiteral("\r\n                    <div class=\"row form-group\" style=\"margin-top: 40px\">\r\n                        <div class=\"col-md-10\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0a9c4b4feb42acb307f225f035c0cd5d9ac9700a14817", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 96 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Query);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </div>
                        <div class=""col-md-2 text-center"">
                            <button class=""btn btn-outline-primary"" id=""ApplyTextSearchButton"">Search</button>
                        </div>

                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table"">
                    <tr class="" text-primary"">
                      <th></th>
                      <th>BugID</th>
                      <th>Project</th>
                      <th>Status</th>
                      <th>Severity</th>
                      <th>Summary</th>
                      </tr>
");
#nullable restore
#line 118 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\Dashboard.cshtml"
                        foreach (Bug bug in Model.Bugs)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <tr>\r\n                               <td><button class=\"btn btn-outline-primary\">");
#nullable restore
#line 121 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\Dashboard.cshtml"
                                                                      Write(Html.ActionLink("View", "BugView", "Application", bug));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></td>\r\n                               <td class=\"td-custom\"><b>");
#nullable restore
#line 122 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\Dashboard.cshtml"
                                                   Write(bug.BugID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                               <td class=\"td-custom\"><b>");
#nullable restore
#line 123 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\Dashboard.cshtml"
                                                   Write(bug.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                               <td class=\"td-custom\"><b>Open</b></td>\r\n                               <td class=\"td-custom\"><b>");
#nullable restore
#line 125 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\Dashboard.cshtml"
                                                   Write(bug.Severity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                               <td class=\"td-custom\"><b>");
#nullable restore
#line 126 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\Dashboard.cshtml"
                                                   Write(bug.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                           </tr>\r\n");
#nullable restore
#line 128 "C:\Users\cheyn\Documents\MSSA2021\Capstone\Project\Views\Application\Dashboard.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserMgr { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SingleBugViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
