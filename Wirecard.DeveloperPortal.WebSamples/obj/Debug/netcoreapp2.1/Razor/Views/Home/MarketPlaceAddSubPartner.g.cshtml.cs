#pragma checksum "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceAddSubPartner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14949877488565fa2936d4a4b0f2ab6208a0ed1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MarketPlaceAddSubPartner), @"mvc.1.0.view", @"/Views/Home/MarketPlaceAddSubPartner.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MarketPlaceAddSubPartner.cshtml", typeof(AspNetCore.Views_Home_MarketPlaceAddSubPartner))]
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
#line 1 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceAddSubPartner.cshtml"
using Wirecard.DeveloperPortal.Core.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14949877488565fa2936d4a4b0f2ab6208a0ed1d", @"/Views/Home/MarketPlaceAddSubPartner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23a94a82472b8947a6226cfa1f60a8a26784e1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MarketPlaceAddSubPartner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wirecard.DeveloperPortal.Core.Response.ServicesXmlResponse>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(112, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceAddSubPartner.cshtml"
  
    ViewBag.Title = "Pazar Yeri Oluşturma";

#line default
#line hidden
            BeginContext(166, 1838, true);
            WriteLiteral(@"

<h2>Pazaryeri Oluşturma (Belge İle Doğrulama)</h2>


<fieldset>
    <legend><label style=""font-weight:bold;width:250px;"">MarketPlace Bilgileri</label></legend>
    <label style=""font-weight:bold;"">Servis Adı &nbsp; :   &nbsp; </label> CCMarketPlace<br>
    <label style=""font-weight:bold;"">Operasyon Adı &nbsp; :&nbsp; </label> AddSubPartner <br>
    <label style=""font-weight:bold;"">UserCode  &nbsp;:  &nbsp;</label> Wirecard tarafından verilen değer <br>
    <label style=""font-weight:bold;"">Pin &nbsp;:  &nbsp;</label> Wirecard tarafından verilen değer <br>
    <label style=""font-weight:bold;"">UniqueId &nbsp;:&nbsp;  </label> benzersiz id değeri <br>
    <label style=""font-weight:bold;"">İş Telefonu &nbsp;: &nbsp; </label>2121111111 <br>
    <label style=""font-weight:bold;"">Vergi Dairesi &nbsp;: &nbsp; </label>İstanbul <br>
    <label style=""font-weight:bold;"">Vergi Numarası &nbsp;: &nbsp; </label>11111111111 <br>
    <label style=""font-weight:bold;"">Banka Adı &nbsp;: &nbsp; </label>Ziraat Bankas");
            WriteLiteral(@"ı <br>
    <label style=""font-weight:bold;"">IBAN &nbsp;: &nbsp; </label>TR330006100519786457841326 <br>
    <label style=""font-weight:bold;"">Banka Hesap Adı &nbsp;: &nbsp; </label>Ahmet Yılmaz <br>
    <label style=""font-weight:bold;"">Mağaza Ülkesi&nbsp;:&nbsp;</label>TR<br>
    <label style=""font-weight:bold;"">Mağaza Şehri &nbsp;</label>&nbsp; 34<br>
    <label style=""font-weight:bold;"">Mağaza Açık Adresi</label>Gayrettepe Mh. Yıldız Posta Cd. D Plaza No:52 K:6 34349 Beşiktaş / İstanbul<br>
    <label style=""font-weight:bold;"">İmza Yetkilisi Adı &nbsp;: &nbsp; </label>Ahmet<br>
    <label style=""font-weight:bold;"">İmza Yetkilisi Soyadı &nbsp;: &nbsp;</label>Yılmaz<br>
    <label style=""font-weight:bold;"">İmza Yetkilisi Doğum Tarihi &nbsp;: &nbsp;</label>1970/10/29<br>

</fieldset>

<br />
");
            EndContext();
            BeginContext(2004, 2339, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb34f02889404ff0adb8269fe9da320a", async() => {
                BeginContext(2058, 412, true);
                WriteLiteral(@"
    <fieldset>
        <!-- Form Name -->
        <legend><label style=""font-weight:bold;width:250px;"">Market Place Detayları</label></legend>

        <!-- Text input-->
        <div class=""form-group"">
            <label class=""col-md-4 control-label"" for="""">Mağaza Tipi:</label>
            <div class=""col-md-4"">
               
                <select name=""subPartnerType"">
                    ");
                EndContext();
                BeginContext(2470, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "842978555843485f9e61a1bc3c60498e", async() => {
                    BeginContext(2517, 26, true);
                    WriteLiteral("Individual - Şahıs firması");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 46 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceAddSubPartner.cshtml"
                       WriteLiteral(SubPartnerTypeEnum.Individual);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2552, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2574, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abfa33dc42c14fcdbc21bb864ff08b0c", async() => {
                    BeginContext(2625, 28, true);
                    WriteLiteral("PrivateCompany - Özel şirket");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 47 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceAddSubPartner.cshtml"
                       WriteLiteral(SubPartnerTypeEnum.PrivateCompany);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2662, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(2684, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "151d604910a740e49d34a7866b56b74a", async() => {
                    BeginContext(2732, 22, true);
                    WriteLiteral("Corporation - Kurumsal");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 48 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceAddSubPartner.cshtml"
                       WriteLiteral(SubPartnerTypeEnum.Corporation);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2763, 1573, true);
                WriteLiteral(@"
                    
                   
                </select>
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-md-4 control-label"" for="""">Mağaza Adı</label>
            <div class=""col-md-4"">
                <input  name=""name"" class=""form-control input-md"">
            </div>
        </div>
      

        <div class=""form-group"">
            <label class=""col-md-4 control-label"" for="""">Mağazaya veya mağaza yetkilisine ait mobil telefon</label>
            <div class=""col-md-4"">
                <input name=""mobilePhoneNumber"" class=""form-control input-md"">
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-md-4 control-label"" for="""">Mağazaya veya mağaza yetkilisine ait email</label>
            <div class=""col-md-4"">
                <input name=""email"" class=""form-control input-md"" required=""true"">
            </div>
        </div>
        <div class=""form-group"">
            <label ");
                WriteLiteral(@"class=""col-md-4 control-label"" for="""">Mağaza sahibine veya yetkilisine ait TC kimlik numarası</label>
            <div class=""col-md-4"">
                <input name=""identityNumber"" class=""form-control input-md"">
            </div>
        </div>

    </fieldset>

   
    <!-- Button -->
    <div class=""form-group"">
        <label class=""col-md-4 control-label"" for=""""></label>
        <div class=""col-md-4"">
            <button type=""submit"" id="""" name="""" class=""btn btn-success"">Mağaza Oluştur</button>
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
            BeginContext(4343, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 93 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceAddSubPartner.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(4371, 19, true);
            WriteLiteral("    <pre>\r\n        ");
            EndContext();
            BeginContext(4391, 40, false);
#line 96 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceAddSubPartner.cshtml"
   Write(Html.Raw(Html.Encode(Model.XmlResponse)));

#line default
#line hidden
            EndContext();
            BeginContext(4431, 14, true);
            WriteLiteral("\r\n    </pre>\r\n");
            EndContext();
#line 98 "D:\Projects\WirecardDeveloperPortalPlugins\wirecardtr-net-core\Wirecard.DeveloperPortal.WebSamples\Views\Home\MarketPlaceAddSubPartner.cshtml"
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
