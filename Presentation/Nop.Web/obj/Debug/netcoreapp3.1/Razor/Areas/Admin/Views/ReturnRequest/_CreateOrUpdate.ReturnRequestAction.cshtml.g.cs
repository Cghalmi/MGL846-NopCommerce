#pragma checksum "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9d5ba3d43d745e2469363ac28da1050ba09f7eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ReturnRequest__CreateOrUpdate_ReturnRequestAction), @"mvc.1.0.view", @"/Areas/Admin/Views/ReturnRequest/_CreateOrUpdate.ReturnRequestAction.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 7 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Domain.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Core.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Services.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Affiliates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Customers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Directory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Discounts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ExternalAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Forums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Payments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Plugins.Marketplace;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Reports;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Shipping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Stores;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Tax;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Templates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Areas.Admin.Models.Vendors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models.DataTables;

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9d5ba3d43d745e2469363ac28da1050ba09f7eb", @"/Areas/Admin/Views/ReturnRequest/_CreateOrUpdate.ReturnRequestAction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9afeeb77ddd3a4a2e0698ab1d31f0fa32cb5e81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ReturnRequest__CreateOrUpdate_ReturnRequestAction : Nop.Web.Framework.Mvc.Razor.NopRazorPage<ReturnRequestActionModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-required", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper __Nop_Web_Framework_TagHelpers_Public_InputTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9d5ba3d43d745e2469363ac28da1050ba09f7eb16927", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 3 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9d5ba3d43d745e2469363ac28da1050ba09f7eb18534", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
#nullable restore
#line 4 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"panel-group\">\r\n    ");
#nullable restore
#line 7 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.ReturnRequestActionSettingsTop }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"panel panel-default\">\r\n        <div class=\"panel-body\">\r\n            ");
#nullable restore
#line 10 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
        Write(Html.LocalizedEditor<ReturnRequestActionModel, ReturnRequestActionLocalizedModel>("returnrequestaction-localized",
            item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("<div>\r\n                <div class=\"form-group\">\r\n                    <div class=\"col-md-3\">\r\n                        ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9d5ba3d43d745e2469363ac28da1050ba09f7eb22006", async() => {
    }
    );
    __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
    __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 14 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Locales[item].Name);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-editor", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9d5ba3d43d745e2469363ac28da1050ba09f7eb23539", async() => {
    }
    );
    __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper>();
    __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper);
#nullable restore
#line 17 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Locales[item].Name);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                        ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9d5ba3d43d745e2469363ac28da1050ba09f7eb25000", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 18 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Locales[item].Name);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9d5ba3d43d745e2469363ac28da1050ba09f7eb26565", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
    __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
    __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
    __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 21 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Locales[item].LanguageId);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For;
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n            </div>\r\n");
    PopWriter();
}
)    ,
            item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("<div>\r\n                <div class=\"form-group\">\r\n                    <div class=\"col-md-3\">\r\n                        ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9d5ba3d43d745e2469363ac28da1050ba09f7eb29081", async() => {
    }
    );
    __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
    __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 27 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-9\">\r\n                        ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-editor", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9d5ba3d43d745e2469363ac28da1050ba09f7eb30602", async() => {
    }
    );
    __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper>();
    __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper);
#nullable restore
#line 30 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.IsRequired = (string)__tagHelperAttribute_1.Value;
    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                        ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9d5ba3d43d745e2469363ac28da1050ba09f7eb32243", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 31 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
    PopWriter();
}
)    ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"col-md-3\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9d5ba3d43d745e2469363ac28da1050ba09f7eb34032", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopLabelTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper);
#nullable restore
#line 38 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DisplayOrder);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopLabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-9\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-editor", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b9d5ba3d43d745e2469363ac28da1050ba09f7eb35661", async() => {
            }
            );
            __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Admin.NopEditorTagHelper>();
            __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper);
#nullable restore
#line 41 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
__Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DisplayOrder);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Admin_NopEditorTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9d5ba3d43d745e2469363ac28da1050ba09f7eb37226", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 42 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DisplayOrder);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
#nullable restore
#line 47 "C:\Users\cghalmi\Documents\apprendre\nopcommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Areas\Admin\Views\ReturnRequest\_CreateOrUpdate.ReturnRequestAction.cshtml"
Write(await Component.InvokeAsync("AdminWidget", new { widgetZone = AdminWidgetZones.ReturnRequestActionSettingsBottom }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWorkContext workContext { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Nop.Services.Common.IGenericAttributeService genericAttributeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReturnRequestActionModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
