#pragma checksum "D:\Projects\Wirecard Developer Portal Plugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\TokenizeCCURL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c9fafc130ef850f46aa3c6813a2e22be8cc64fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TokenizeCCURL), @"mvc.1.0.view", @"/Views/Home/TokenizeCCURL.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TokenizeCCURL.cshtml", typeof(AspNetCore.Views_Home_TokenizeCCURL))]
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
#line 1 "D:\Projects\Wirecard Developer Portal Plugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples;

#line default
#line hidden
#line 2 "D:\Projects\Wirecard Developer Portal Plugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\_ViewImports.cshtml"
using Wirecard.DeveloperPortal.WebSamples.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c9fafc130ef850f46aa3c6813a2e22be8cc64fa", @"/Views/Home/TokenizeCCURL.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23a94a82472b8947a6226cfa1f60a8a26784e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TokenizeCCURL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(0, 65, true);
            WriteLiteral("odel Wirecard.DeveloperPortal.Core.Response.ServicesXmlResponse\r\n");
            EndContext();
#line 2 "D:\Projects\Wirecard Developer Portal Plugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\TokenizeCCURL.cshtml"
  
    ViewBag.Title = "Tokenize CC URL";

#line default
#line hidden
            BeginContext(112, 1315, true);
            WriteLiteral(@"
<fieldset>
    <legend><label style=""font-weight:bold;width:250px;"">Servis bilgileri</label></legend>
    <label style=""font-weight:bold;"">Servis Adı &nbsp; :   &nbsp; </label> WDTicket<br>
    <label style=""font-weight:bold;"">Operasyon Adı &nbsp; :&nbsp; </label> TokenizeCCURL <br>
    <label style=""font-weight:bold;"">UserCode  &nbsp;:  &nbsp;</label> Wirecard tarafından verilen değer <br>
    <label style=""font-weight:bold;"">Pin &nbsp;:  &nbsp;</label> Wirecard tarafından verilen değer <br>
    <label style=""font-weight:bold;"">ErrorURL &nbsp;:  &nbsp;</label> İşlem hatalı gerçekleşirse yönlendirilecek olan sayfa <br>
    <label style=""font-weight:bold;"">SuccessURL &nbsp;:  &nbsp;</label> İşlem başarılı gerçekleşirse yönlendirilecek olan sayfa <br>
    <label style=""font-weight:bold;"">CustomerId &nbsp;:  &nbsp;</label> Bu alan kredi kartıyla sizin istediğiniz degerler arasında iletisim kurulması için kullanılır. Kredi kartıyla fatura ödemesi, kredi kartıyla sipariş numarasında eşleşme için yada boş");
            WriteLiteral(@" gönderilebilir. <br>
    <label style=""font-weight:bold;"">IPAddress &nbsp;:  &nbsp;</label>İşlem sahibine ait IP adresi <br>
    <label style=""font-weight:bold;"">ValidityPeriod &nbsp;:  &nbsp;</label>Tokenize edilen sifreli kartın geçerlilik suresi <br>

</fieldset>

<br />
<br />
");
            EndContext();
            BeginContext(1427, 650, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5ad1a31d8754ed682acb56da903c17a", async() => {
                BeginContext(1481, 589, true);
                WriteLiteral(@"
    <fieldset>
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
            <button type=""submit"" id="""" name="""" class=""btn btn-danger"">Url yöntemi ile kartı sakla</button>
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
            BeginContext(2077, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 41 "D:\Projects\Wirecard Developer Portal Plugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\TokenizeCCURL.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(2105, 19, true);
            WriteLiteral("    <pre>\r\n        ");
            EndContext();
            BeginContext(2125, 40, false);
#line 44 "D:\Projects\Wirecard Developer Portal Plugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\TokenizeCCURL.cshtml"
   Write(Html.Raw(Html.Encode(Model.XmlResponse)));

#line default
#line hidden
            EndContext();
            BeginContext(2165, 14, true);
            WriteLiteral("\r\n    </pre>\r\n");
            EndContext();
#line 46 "D:\Projects\Wirecard Developer Portal Plugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\TokenizeCCURL.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
