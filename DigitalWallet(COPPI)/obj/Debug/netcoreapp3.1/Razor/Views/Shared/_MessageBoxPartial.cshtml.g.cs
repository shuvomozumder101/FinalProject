#pragma checksum "C:\Final Project\DigitalWallet(COPPI)\FinalProject\DigitalWallet(COPPI)\Views\Shared\_MessageBoxPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fd256c33e07b5b9fb5c42a2577177b1a8fbbed8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MessageBoxPartial), @"mvc.1.0.view", @"/Views/Shared/_MessageBoxPartial.cshtml")]
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
#line 1 "C:\Final Project\DigitalWallet(COPPI)\FinalProject\DigitalWallet(COPPI)\Views\_ViewImports.cshtml"
using DigitalWallet_COPPI_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Final Project\DigitalWallet(COPPI)\FinalProject\DigitalWallet(COPPI)\Views\_ViewImports.cshtml"
using DigitalWallet_COPPI_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fd256c33e07b5b9fb5c42a2577177b1a8fbbed8", @"/Views/Shared/_MessageBoxPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b43edf190275da8daf22276ba2fec43f222867f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MessageBoxPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""footer-card position-relative"">
    <div class=""live-chat-inner"">
        <div class=""chat-text-field"">
            <textarea class=""live-chat-field custom-scroll"" placeholder=""Text Message""></textarea>
            <button class=""chat-message-send"" type=""submit"" value=""submit"">
                <img src=""assets/images/icons/plane.png""");
            BeginWriteAttribute("alt", " alt=\"", 347, "\"", 353, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </button>
        </div>
        <div class=""chat-output-box"">
            <div class=""live-chat-title"">
                <!-- profile picture end -->
                <div class=""profile-thumb active"">
                    <a href=""#"">
                        <figure class=""profile-thumb-small"">
                            <img src=""assets/images/profile/profile-small-15.jpg"" alt=""profile picture"">
                        </figure>
                    </a>
                </div>
                <!-- profile picture end -->
                <div class=""posted-author"">
                    <h6 class=""author""><a href=""profile.html"">Robart Marloyan</a></h6>
                    <span class=""active-pro"">active now</span>
                </div>
                <div class=""live-chat-settings ml-auto"">
                    <button class=""chat-settings""><i class=""flaticon-settings""></i></button>
                    <button class=""close-btn"" data-close=""chat-output-box""><i class=""flaticon-cross-out""></i></butto");
            WriteLiteral("n>\n                </div>\n            </div>\n            <div class=\"message-list-inner\">\n                <ul class=\"message-list custom-scroll\">\n                </ul>\n            </div>\n        </div>\n    </div>\n</div>");
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
