#pragma checksum "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\TokenizeCC.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "763e5f9e691a84dfb320d8d6d78a58836a4cd028"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TokenizeCC), @"mvc.1.0.view", @"/Views/Home/TokenizeCC.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TokenizeCC.cshtml", typeof(AspNetCore.Views_Home_TokenizeCC))]
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
#line 1 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples;

#line default
#line hidden
#line 2 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"763e5f9e691a84dfb320d8d6d78a58836a4cd028", @"/Views/Home/TokenizeCC.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23a94a82472b8947a6226cfa1f60a8a26784e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TokenizeCC : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wirecard.DeveloperPortal.Core.Response.ServicesXmlResponse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(67, 784, true);
            WriteLiteral(@"

<fieldset>
    <legend><label style=""font-weight:bold;width:250px;"">Servis bilgileri</label></legend>
    <label style=""font-weight:bold;"">Servis Adı &nbsp; :   &nbsp; </label> CCTokenizationService<br>
    <label style=""font-weight:bold;"">Operasyon Adı &nbsp; :&nbsp; </label> TokenizeCC <br>
    <label style=""font-weight:bold;"">UserCode  &nbsp;:  &nbsp;</label> Wirecard tarafından verilen değer <br>
    <label style=""font-weight:bold;"">Pin &nbsp;:  &nbsp;</label> Wirecard tarafından verilen değer <br>
    <label style=""font-weight:bold;"">IPAddress &nbsp;:  &nbsp;</label>İşlem sahibine ait IP adresi <br>
    <label style=""font-weight:bold;"">ValidityPeriod &nbsp;:  &nbsp;</label>Tokenize edilen sifreli kartın geçerlilik suresi <br>
</fieldset>

<br />
<br />
");
            EndContext();
            BeginContext(851, 2020, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b830a0a16ef4158aa32fd8ff0eafe4c", async() => {
                BeginContext(905, 1959, true);
                WriteLiteral(@"
    <fieldset>
        <!-- Form Name -->
        <legend><label style=""font-weight:bold;width:250px;"">Kart Bilgileri</label></legend>

        <!-- Text input-->
        <div class=""form-group"">
            <label class=""col-md-4 control-label"" for="""">Kart Sahibi Adı Soyadı:</label>
            <div class=""col-md-4"">
                <input value=""Ahmet Yılmaz"" name=""ownerName"" class=""form-control input-md"">
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-md-4 control-label"" for="""">  Kart Numarası:</label>
            <div class=""col-md-4"">
                <input value=""4282209004348015"" name=""creditCardNo"" class=""form-control input-md"">
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-md-4 control-label"" for="""">  Son Kullanma Tarihi Ay/Yıl: </label>
            <div class=""col-md-4"">
                <input value=""12"" name=""expireMonth"" class=""form-control input-md"" width=""50px"">
           ");
                WriteLiteral(@"     <input value=""2022"" name=""expireYear"" class=""form-control input-md"" width=""50px"">
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-md-4 control-label"" for="""">  CVC: </label>
            <div class=""col-md-4"">
                <input value=""123"" name=""cvv"" class=""form-control input-md"">
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-md-4 control-label"" for="""">  CustomerId: </label>
            <div class=""col-md-4"">
                <input value="""" name=""customerId"" class=""form-control input-md"">
            </div>
        </div>
    </fieldset>
    <!-- Button -->
    <div class=""form-group"">
        <label class=""col-md-4 control-label"" for=""""></label>
        <div class=""col-md-4"">
            <button type=""submit"" id="""" name="""" class=""btn btn-danger""> Kart Sakla</button>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2871, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 62 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\TokenizeCC.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(2897, 19, true);
            WriteLiteral("    <pre>\r\n        ");
            EndContext();
            BeginContext(2917, 40, false);
#line 65 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\TokenizeCC.cshtml"
   Write(Html.Raw(Html.Encode(Model.XmlResponse)));

#line default
#line hidden
            EndContext();
            BeginContext(2957, 14, true);
            WriteLiteral("\r\n    </pre>\r\n");
            EndContext();
#line 67 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\TokenizeCC.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wirecard.DeveloperPortal.Core.Response.ServicesXmlResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
