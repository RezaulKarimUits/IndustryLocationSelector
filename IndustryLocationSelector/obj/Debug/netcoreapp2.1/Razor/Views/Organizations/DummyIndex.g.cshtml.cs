#pragma checksum "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0adc1e0b9075c012ff187faa1c6622f3f58d5010"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Organizations_DummyIndex), @"mvc.1.0.view", @"/Views/Organizations/DummyIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Organizations/DummyIndex.cshtml", typeof(AspNetCore.Views_Organizations_DummyIndex))]
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
#line 1 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\_ViewImports.cshtml"
using IndustryLocationSelector;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\_ViewImports.cshtml"
using IndustryLocationSelector.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0adc1e0b9075c012ff187faa1c6622f3f58d5010", @"/Views/Organizations/DummyIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32b004ef3afbc1c28f8010cc2032607afa9d4047", @"/Views/_ViewImports.cshtml")]
    public class Views_Organizations_DummyIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IndustryLocationSelector.Data.Entity.Organizations>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
  
    //Layout = null;

#line default
#line hidden
            BeginContext(96, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(125, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b553aac8b9a94de2b2cb55cf463be7b9", async() => {
                BeginContext(131, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            BeginContext(225, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(227, 1483, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "013d287931034ac4ade7442d74e010f9", async() => {
                BeginContext(233, 63, true);
                WriteLiteral("\r\n\r\n    <div>\r\n        <h4>Organizations</h4>\r\n        <hr />\r\n");
                EndContext();
#line 19 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
         if (Model.Count == 0)
        {

#line default
#line hidden
                BeginContext(339, 38, true);
                WriteLiteral("            <p>no records found </p>\r\n");
                EndContext();
#line 22 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 25 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
             foreach (var org in Model)
            {




#line default
#line hidden
                BeginContext(475, 94, true);
                WriteLiteral("                <dl class=\"dl-horizontal\">\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(570, 26, false);
#line 32 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
                   Write(Html.DisplayName(org.Name));

#line default
#line hidden
                EndContext();
                BeginContext(596, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(676, 22, false);
#line 35 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
                   Write(Html.Display(org.Name));

#line default
#line hidden
                EndContext();
                BeginContext(698, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(778, 49, false);
#line 38 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
                   Write(Html.DisplayName(org.OrganizationType.ToString()));

#line default
#line hidden
                EndContext();
                BeginContext(827, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(907, 39, false);
#line 41 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
                   Write(Html.Display(org.OrganizationType.Name));

#line default
#line hidden
                EndContext();
                BeginContext(946, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(1026, 41, false);
#line 44 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
                   Write(Html.DisplayName(org.Latitude.ToString()));

#line default
#line hidden
                EndContext();
                BeginContext(1067, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(1147, 37, false);
#line 47 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
                   Write(Html.Display(org.Latitude.ToString()));

#line default
#line hidden
                EndContext();
                BeginContext(1184, 79, true);
                WriteLiteral("\r\n                    </dd>\r\n                    <dt>\r\n                        ");
                EndContext();
                BeginContext(1264, 42, false);
#line 50 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
                   Write(Html.DisplayName(org.Longitude.ToString()));

#line default
#line hidden
                EndContext();
                BeginContext(1306, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(1386, 38, false);
#line 53 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
                   Write(Html.Display(org.Longitude.ToString()));

#line default
#line hidden
                EndContext();
                BeginContext(1424, 95, true);
                WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n                <div>\r\n                    ");
                EndContext();
                BeginContext(1519, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b980ca9c02ab48d193f0017f9de1aa4d", async() => {
                    BeginContext(1563, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 57 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
                                           WriteLiteral(org.Id);

#line default
#line hidden
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
                EndContext();
                BeginContext(1571, 24, true);
                WriteLiteral(" |\r\n                    ");
                EndContext();
                BeginContext(1595, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89fef4c9645f43b7afeb7b7239743abe", async() => {
                    BeginContext(1617, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1633, 26, true);
                WriteLiteral("\r\n                </div>\r\n");
                EndContext();
#line 60 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
            }

#line default
#line hidden
#line 60 "C:\Users\User\source\repos\IndustryLocationSelector\IndustryLocationSelector\Views\Organizations\DummyIndex.cshtml"
             

        }

#line default
#line hidden
                BeginContext(1687, 16, true);
                WriteLiteral("\r\n    </div>\r\n\r\n");
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
            BeginContext(1710, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IndustryLocationSelector.Data.Entity.Organizations>> Html { get; private set; }
    }
}
#pragma warning restore 1591