#pragma checksum "D:\Khoa-Hoc-NETCore-CoBan-NangCao\UngDungDauTien\FromValidation\Views\Home\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7dabdf454272e4b3891c44d7809c473a91ffd26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Create), @"mvc.1.0.view", @"/Views/Home/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7dabdf454272e4b3891c44d7809c473a91ffd26", @"/Views/Home/Create.cshtml")]
    public class Views_Home_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FromValidation.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Khoa-Hoc-NETCore-CoBan-NangCao\UngDungDauTien\FromValidation\Views\Home\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .field-validation-error {
        color: red;
    }
    .validation-summary-errors{
        color:red
    }
</style>
<h1>Create</h1>
<div asp-validation-summary=""ModelOnly"">
    <span>Lỗi tự kiểm tra.</span>
</div>
<form method=""post"">
    <");
            WriteLiteral("label>ID: </");
            WriteLiteral(@"label>
    <input asp-for=""id"" />
    <span asp-validation-for=""id""></span>

    <label asp-for=""name""></label>
    <input asp-for=""name"" />
    <span asp-validation-for=""name""></span>

    <label asp-for=""description""></label>
    <input asp-for=""description"" />

    <label asp-for=""email""></label>
    <input asp-for=""email"" />
    <span asp-validation-for=""email""></span>

    <button type=""submit"">Gửi</button>
</form>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FromValidation.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591