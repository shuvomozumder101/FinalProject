#pragma checksum "C:\Final Project\New folder\DigitalWallet(COPPI)\Views\Profile\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7619cd49f72b5cde971a75be089ba88ca45b073"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_About), @"mvc.1.0.view", @"/Views/Profile/About.cshtml")]
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
#line 1 "C:\Final Project\New folder\DigitalWallet(COPPI)\Views\_ViewImports.cshtml"
using DigitalWallet_COPPI_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Final Project\New folder\DigitalWallet(COPPI)\Views\_ViewImports.cshtml"
using DigitalWallet_COPPI_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7619cd49f72b5cde971a75be089ba88ca45b073", @"/Views/Profile/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b43edf190275da8daf22276ba2fec43f222867f", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DigitalWallet_COPPI_.Models.Profile.AboutModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProfileHeaderBarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"main-wrapper\">\n    <!-- profile menu area start -->\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f7619cd49f72b5cde971a75be089ba88ca45b0733503", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 4 "C:\Final Project\New folder\DigitalWallet(COPPI)\Views\Profile\About.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.ProfileHeaderBarModel;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <!-- profile menu area end -->
    <!-- sendary menu start -->
    <div class=""menu-secondary"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""secondary-menu-wrapper bg-white"">
                        <div class=""page-title-inner"">
                            <h4 class=""page-title"">about</h4>
                        </div>
                        <div class=""main-menu-inner header-top-navigation"">
                            <nav>
                                <ul class=""main-menu"">
                                    <li><a href=""#""><span>facebook</span> <i class=""flaticon-facebook""></i></a></li>
                                    <li><a href=""#""><span>twitter</span> <i class=""flaticon-twitter-logo-silhouette""></i></a></li>
                                    <li><a href=""#""><span>google</span> <i class=""flaticon-google-plus""></i></a></li>
                                    <li class=""d-inline-block d-md-none""><a ");
            WriteLiteral(@"href=""profile.html"">edit profile</a></li>
                                </ul>
                            </nav>
                        </div>
                        <div class=""post-settings-bar"">
                            <span></span>
                            <span></span>
                            <span></span>
                            <div class=""post-settings arrow-shape"">
                                <ul>
                                    <li><button>edit profile</button></li>
                                    <li><button>activity log</button></li>
                                    <li><button>embed adda</button></li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- sendary menu end -->
    <!-- about author details start -->
    <div class=""about-author-details"">
        <div class=""container"">
            <div class=""row""");
            WriteLiteral(@">
                <div class=""col-lg-3"">
                    <div class=""card widget-item"">
                        <div class=""about-me"">
                            <ul class=""nav flex-column about-author-menu"">
                                <li><a href=""#one"" data-toggle=""tab"" class=""active"">Something About Me</a></li>
                                <li><a href=""#two"" data-toggle=""tab"">Working Zone</a></li>
                                <li><a href=""#three"" data-toggle=""tab"">Educational Qualification</a></li>
                                <li><a href=""#four"" data-toggle=""tab"">Work & Education</a></li>
                                <li><a href=""#five"" data-toggle=""tab"">Friends & Family</a></li>
                                <li><a href=""#six"" data-toggle=""tab"">Contact Details</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-9"">
                    <div class=""about-description"">
         ");
            WriteLiteral(@"               <div class=""tab-content"">
                            <div class=""tab-pane fade active show"" id=""one"">
                                <div class=""work-zone"">
                                    <div class=""author-desc-title d-flex"">
                                        <h6 class=""author""><a href=""profile.html"">Mili Raoulin</a></h6>
                                        <div class=""post-settings-bar"">
                                            <span></span>
                                            <span></span>
                                            <span></span>
                                            <div class=""post-settings arrow-shape"">
                                                <ul>
                                                    <li><button>edit post</button></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
     ");
            WriteLiteral(@"                               <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.</p>
                                    <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search</p>
                                </div>
                            </div>
                            <div class=""tab-pane fade"" id=""two"">
                                <div class=""work-zone"">
                                    <div class=""author-desc-title d-flex"">");
            WriteLiteral(@"
                                        <h6 class=""author""><a href=""profile.html"">Mili Raoulin</a></h6>
                                        <div class=""post-settings-bar"">
                                            <span></span>
                                            <span></span>
                                            <span></span>
                                            <div class=""post-settings arrow-shape"">
                                                <ul>
                                                    <li><button>copy link to adda</button></li>
                                                    <li><button>edit post</button></li>
                                                    <li><button>embed adda</button></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <p>Many desktop publishing packa");
            WriteLiteral(@"ges and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.</p>
                                    <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search</p>
                                </div>
                            </div>
                            <div class=""tab-pane fade"" id=""three"">
                                <div class=""work-zone"">
                                    <div class=""author-desc-title d-flex"">
                                        <h6 class=""author""><");
            WriteLiteral(@"a href=""profile.html"">Mili Raoulin</a></h6>
                                        <div class=""post-settings-bar"">
                                            <span></span>
                                            <span></span>
                                            <span></span>
                                            <div class=""post-settings arrow-shape"">
                                                <ul>
                                                    <li><button>copy link to adda</button></li>
                                                    <li><button>edit post</button></li>
                                                    <li><button>embed adda</button></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default");
            WriteLiteral(@" model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.</p>
                                    <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search</p>
                                </div>
                            </div>
                            <div class=""tab-pane fade"" id=""four"">
                                <div class=""work-zone"">
                                    <div class=""author-desc-title d-flex"">
                                        <h6 class=""author""><a href=""profile.html"">Mili Raoulin</a></h6>
                  ");
            WriteLiteral(@"                      <div class=""post-settings-bar"">
                                            <span></span>
                                            <span></span>
                                            <span></span>
                                            <div class=""post-settings arrow-shape"">
                                                <ul>
                                                    <li><button>copy link to adda</button></li>
                                                    <li><button>edit post</button></li>
                                                    <li><button>embed adda</button></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many ");
            WriteLiteral(@"web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.</p>
                                    <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search</p>
                                </div>
                            </div>
                            <div class=""tab-pane fade"" id=""five"">
                                <div class=""work-zone"">
                                    <div class=""author-desc-title d-flex"">
                                        <h6 class=""author""><a href=""profile.html"">Mili Raoulin</a></h6>
                                        <div class=""post-settings-bar"">
        ");
            WriteLiteral(@"                                    <span></span>
                                            <span></span>
                                            <span></span>
                                            <div class=""post-settings arrow-shape"">
                                                <ul>
                                                    <li><button>copy link to adda</button></li>
                                                    <li><button>edit post</button></li>
                                                    <li><button>embed adda</button></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing pack");
            WriteLiteral(@"ages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.</p>
                                    <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search</p>
                                </div>
                            </div>
                            <div class=""tab-pane fade"" id=""six"">
                                <div class=""work-zone"">
                                    <div class=""author-desc-title d-flex"">
                                        <h6 class=""author""><a href=""profile.html"">Mili Raoulin</a></h6>
                                        <div class=""post-settings-bar"">
                                            <span></span>
             ");
            WriteLiteral(@"                               <span></span>
                                            <span></span>
                                            <div class=""post-settings arrow-shape"">
                                                <ul>
                                                    <li><button>copy link to adda</button></li>
                                                    <li><button>edit post</button></li>
                                                    <li><button>embed adda</button></li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default ");
            WriteLiteral(@"model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.</p>
                                    <p>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigitalWallet_COPPI_.Models.Profile.AboutModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
