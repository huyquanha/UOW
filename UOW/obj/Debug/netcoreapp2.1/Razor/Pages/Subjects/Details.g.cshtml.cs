#pragma checksum "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44db33f4a595c413e31f2d1d9bd011ab7f6d3c02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UOW.Pages.Subjects.Pages_Subjects_Details), @"mvc.1.0.razor-page", @"/Pages/Subjects/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Subjects/Details.cshtml", typeof(UOW.Pages.Subjects.Pages_Subjects_Details), null)]
namespace UOW.Pages.Subjects
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\_ViewImports.cshtml"
using UOW;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44db33f4a595c413e31f2d1d9bd011ab7f6d3c02", @"/Pages/Subjects/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8472554c8302f2a3ce11490fa03c626e40966b9f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Subjects_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Subject</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(261, 55, false);
#line 16 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Subject.SubjectCode));

#line default
#line hidden
            EndContext();
            BeginContext(316, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(360, 51, false);
#line 19 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Subject.SubjectCode));

#line default
#line hidden
            EndContext();
            BeginContext(411, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(455, 51, false);
#line 22 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Subject.Session));

#line default
#line hidden
            EndContext();
            BeginContext(506, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(550, 47, false);
#line 25 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Subject.Session));

#line default
#line hidden
            EndContext();
            BeginContext(597, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(641, 49, false);
#line 28 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Subject.Title));

#line default
#line hidden
            EndContext();
            BeginContext(690, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(734, 45, false);
#line 31 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Subject.Title));

#line default
#line hidden
            EndContext();
            BeginContext(779, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(823, 51, false);
#line 34 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Subject.Credits));

#line default
#line hidden
            EndContext();
            BeginContext(874, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(918, 47, false);
#line 37 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Subject.Credits));

#line default
#line hidden
            EndContext();
            BeginContext(965, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1009, 49, false);
#line 40 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Subject.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1102, 45, false);
#line 43 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Subject.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1191, 55, false);
#line 46 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Subject.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1246, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1290, 51, false);
#line 49 "C:\Users\hahuy\source\repos\UOW\UOW\Pages\Subjects\Details.cshtml"
       Write(Html.DisplayFor(model => model.Subject.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1388, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "090d08beb4f040a98329d2d17cd7b039", async() => {
                BeginContext(1410, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1426, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UOW.Pages.Subjects.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UOW.Pages.Subjects.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UOW.Pages.Subjects.DetailsModel>)PageContext?.ViewData;
        public UOW.Pages.Subjects.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
