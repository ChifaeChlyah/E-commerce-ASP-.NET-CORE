#pragma checksum "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48bdfce4db9cc5121f44130be961cf08cfcdc8ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Offres_MesFavories), @"mvc.1.0.view", @"/Views/Offres/MesFavories.cshtml")]
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
#line 1 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\_ViewImports.cshtml"
using Projet_Exam_ASP.NetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\_ViewImports.cshtml"
using Projet_Exam_ASP.NetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48bdfce4db9cc5121f44130be961cf08cfcdc8ac", @"/Views/Offres/MesFavories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc65f3b60ea9dc54fae898c3f429b36bbaffc81", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Offres_MesFavories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projet_Exam_ASP.NetCore.Models.Offre>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Offres", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>


    #bd h2 {
        color: #000;
        font-size: 26px;
        font-weight: 300;
        text-align: center;
        text-transform: uppercase;
        position: relative;
        margin: 30px 0 80px;
    }

        #bd h2 b {
            color: #ffc000;
        }





    .img-box {
        height: 160px;
        width: 100%;
        position: relative;
    }

    img {
        max-width: 100%;
        max-height: 100%;
        display: inline-block;
        /*position: absolute;*/
        bottom: 0;
        margin: 0 auto;
        left: 0;
        right: 0;
    }

    #bd h4 {
        font-size: 18px;
        margin: 10px 0;
    }

    .btn {
        color: #333;
        border-radius: 0;
        font-size: 11px;
        text-transform: uppercase;
        font-weight: bold;
        background: none;
        border: 1px solid #ccc;
        padding: 5px 10px;
        margin-top: 5px;
        line-height: 16px;
    }

        .btn:hover {
 ");
            WriteLiteral(@"           color: #fff;
            background: #000;
            border-color: #000;
            box-shadow: none;
        }

        .btn i {
            font-size: 14px;
            font-weight: bold;
            margin-left: 5px;
        }

    .thumb-wrapper {
        text-align: center;
        background: #fef8f6b3;
        width: 220px;
        margin: 20px;
        box-shadow: 0px 14px 32px 0px rgb(0 0 0 / 15%);
    }

    .thumb-content {
        padding: 15px;
    }

    .item-price {
        font-size: 1.3em;
        padding: 2px 0;
    }

        .item-price strike {
            color: #999;
            margin-right: 5px;
        }

        .item-price span {
            color: #bd5757;
            font-size: 110%;
        }
        .fa-heart {
            color: #e03939;
        }
        .fa-heart:hover {
            color: #e0393985;
        }
</style>
<script>
    $('.carousel').carousel({
        interval: 100000
    })
    function FavoriChan");
            WriteLiteral("ge(i) {\r\n        var f = document.getElementById(\'offre\' + i);\r\n        f.style.display = \'none\';\r\n        $.get(\"/Offres/AddRemoveFavoris\", { id: i });\r\n    }\r\n\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48bdfce4db9cc5121f44130be961cf08cfcdc8ac8207", async() => {
                WriteLiteral("\r\n    <h2 style=\"font-family: century; margin-top: 70px; margin-bottom: 50px;\">Vos favoris</h2>\r\n    <div style=\" display: inline-flex; width: 1200px; flex-direction: row; flex-wrap: wrap; margin-left: 43px;\">\r\n");
#nullable restore
#line 118 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
         for (int j = 0; j < Model.Count(); j++)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"thumb-wrapper\"");
                BeginWriteAttribute("id", " id=\"", 2599, "\"", 2643, 1);
#nullable restore
#line 121 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
WriteAttributeValue("", 2604, string.Format("offre{0}", Model[j].Id), 2604, 39, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                <table style=""width:220px"">
                    <tr><td style=""align-content: center; background: #bd5757; color: white; height: 40px; vertical-align: middle; font-size: 1.5em; font-family: century; padding-top: 10px; ""><H6>Favoris<span> ");
#nullable restore
#line 123 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
                                                                                                                                                                                                             Write(ViewBag.NbFavorisParOffre[j]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"  <i style=""color: white;"" class=""fas fa-heart""></i></span></H6></td></tr>
                    <tr>
                        <td>

                            <table style=""position: absolute; width: 220px; "">
                                <tr>
                                    <td style=""padding-top: 5px ;text-align:end;width:220px;"">
                                        <a style=""cursor: pointer; margin-right: 5px; """);
                BeginWriteAttribute("onclick", " onclick=\"", 3366, "\"", 3403, 3);
                WriteAttributeValue("", 3376, "FavoriChange(", 3376, 13, true);
#nullable restore
#line 130 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
WriteAttributeValue("", 3389, Model[j].Id, 3389, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3401, ");", 3401, 2, true);
                EndWriteAttribute();
                WriteLiteral(@">
                                            <i class=""fas fa-heart"" style=""color: #bd5757; font-size:1.5em""></i>
                                        </a>
                                    </td>
                                </tr>
                            </table>
                            <table>
                                <tr>
                                    <td style=""padding-top: 8px;text-align: center;width:220px;"">
                                        <h6 style=""font-size: 0.9rem; color: #bd5757"">");
#nullable restore
#line 139 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
                                                                                 Write(Model[j].Date_Dépot);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h6>
                                    </td>
                                </tr>
                            </table>


                        </td>
                    </tr>
                </table>
                <div class=""img-box"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "48bdfce4db9cc5121f44130be961cf08cfcdc8ac12373", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
                   WriteLiteral("~/images/Offres/" + ViewBag.images[j].Nom);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 149 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"thumb-content\">\r\n                    <h4>");
#nullable restore
#line 153 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
                   Write(Model[j].Titre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 154 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
                      double nouv = Model[j].prix - Model[j].reduction * Model[j].prix / 100;

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
                     if (Model[j].reduction > 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p class=\"item-price\"><strike>");
#nullable restore
#line 157 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
                                                 Write(Model[j].prix);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strike> <span>");
#nullable restore
#line 157 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
                                                                               Write(nouv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n");
#nullable restore
#line 158 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p class=\"item-price\"><span style=\"color:gray\">");
#nullable restore
#line 161 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
                                                                  Write(nouv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></p>\r\n");
#nullable restore
#line 162 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48bdfce4db9cc5121f44130be961cf08cfcdc8ac17427", async() => {
                    WriteLiteral("View details");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 163 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
                                                                      WriteLiteral(Model[j].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 166 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Offres\MesFavories.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projet_Exam_ASP.NetCore.Models.Offre>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
