#pragma checksum "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b72abda7bec3cbb36010de28c2c96dd0efe45bf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OffresFiltrées), @"mvc.1.0.view", @"/Views/Shared/_OffresFiltrées.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72abda7bec3cbb36010de28c2c96dd0efe45bf8", @"/Views/Shared/_OffresFiltrées.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccc65f3b60ea9dc54fae898c3f429b36bbaffc81", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__OffresFiltrées : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projet_Exam_ASP.NetCore.Models.Offre>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Offres", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("favoriAnchor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" margin-right: 5px; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b72abda7bec3cbb36010de28c2c96dd0efe45bf87168", async() => {
                WriteLiteral(@"

    <style>
        .fa-heart {
            color: #bd5757;
        }

            .fa-heart:hover {
                color: #e0393985;
            }

        .backBoutique a {
            float: right;
            display: inline-block;
            height: 50px;
            width: 350px;
            margin: 10 40px 0 16px;
            box-sizing: border-box;
            border: transparent;
            border-radius: 60px;
            font-family: 'Raleway', sans-serif;
            font-size: 16px;
            font-weight: 500;
            text-transform: uppercase;
            letter-spacing: 0.2em;
            color: #bd5757;
            cursor: pointer;
            outline: none;
            text-decoration: underline;
        }

            .backBoutique a:hover {
                color: #212529ba;
            }

        #bd h2 {
            color: #000;
            font-size: 26px;
            font-weight: 300;
            text-align: center;
            text-tran");
                WriteLiteral(@"sform: uppercase;
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
            background: #dee2e640;
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
    </style>
    <script>
        function FavoriChange(i) {
            var f = document.getElementById('favor");
                WriteLiteral(@"iAnchor' + i);
            if (f.innerHTML.includes(""fas"")) {
                f.innerHTML = f.innerHTML.replace(/fas/g, ""far"");
            }
            else {
                f.innerHTML = f.innerHTML.replace(/far/g, ""fas"");
            }
            $.get(""/Offres/AddRemoveFavoris"", { id: i });
        }
    </script>
");
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
            WriteLiteral("\r\n<div id=\"bd\" style=\" display: inline-flex; width: 1200px; flex-direction: row; flex-wrap: wrap; margin-top:50px;\">\r\n");
#nullable restore
#line 141 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
     for (int j = 0; j < Model.Count(); j++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""thumb-wrapper"">
            <table style=""width:220px"">
                <tr>
                    <td style=""align-content: center; background: #bd5757; color: white; height: 40px; vertical-align: middle; font-size: 1.5em; font-family: century; padding-top: 10px; "">
                        <H6>Favoris<span> ");
#nullable restore
#line 147 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                     Write(ViewBag.NbFavorisParOffre[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <i class=""fas fa-heart""></i></span></H6>
                    </td>
                </tr>
                <tr>
                    <td style=""padding-top: 5px ;text-align:end"">

                        <table style=""position: absolute; width: 220px; "">
                            <tr>
                                <td style=""padding-top: 5px ;text-align:end;width:220px;"">
");
#nullable restore
#line 156 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                     if (User.Identity.IsAuthenticated)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 158 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                         if (ViewBag.CurrentUser != null && ViewBag.CurrentUser.Id == Model[j].AppUserId)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b72abda7bec3cbb36010de28c2c96dd0efe45bf813898", async() => {
                WriteLiteral("\r\n                                                <i class=\"fas fa-edit\" style=\"margin-right: 5px; color: #bd5757; font-size: 1.3em\"></i>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 160 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                                                                           WriteLiteral(Model[j].Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 163 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a");
            BeginWriteAttribute("id", " id=\"", 5184, "\"", 5235, 1);
#nullable restore
#line 166 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
WriteAttributeValue("", 5189, string.Format("favoriAnchor{0}", Model[j].Id), 5189, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\" margin-right: 5px; \"");
            BeginWriteAttribute("onclick", " onclick=\"", 5265, "\"", 5302, 3);
            WriteAttributeValue("", 5275, "FavoriChange(", 5275, 13, true);
#nullable restore
#line 166 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
WriteAttributeValue("", 5288, Model[j].Id, 5288, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5300, ");", 5300, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 167 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                                 if (ViewBag.isFavorisList != null && ViewBag.isFavorisList[j] == true)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <i class=\"fas fa-heart\" style=\" font-size:1.5em\"></i>\r\n");
#nullable restore
#line 170 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <i class=\"far fa-heart\" style=\" font-size: 1.5em\"></i>\r\n");
#nullable restore
#line 174 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </a>\r\n");
#nullable restore
#line 176 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 176 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b72abda7bec3cbb36010de28c2c96dd0efe45bf819998", async() => {
                WriteLiteral("\r\n                                            <i class=\"far fa-heart\" style=\" font-size:1.5em\"></i>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 183 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </td>
                            </tr>
                        </table>
                        <table>
                            <tr>
                                <td style=""padding-top: 8px;text-align: center;width:220px;"">
                                    <h6 style=""font-size: 0.9rem; color: #bd5757"">");
#nullable restore
#line 190 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                                                             Write(Model[j].Date_Dépot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                </td>\r\n                            </tr>\r\n                        </table>\r\n\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n            <div class=\"img-box\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b72abda7bec3cbb36010de28c2c96dd0efe45bf822887", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 199 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
               WriteLiteral("~/images/Offres/" + ViewBag.images[j].Nom);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 199 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n            <div class=\"thumb-content\">\r\n                <h4 style=\"font-size: 18px;\">");
#nullable restore
#line 203 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                        Write(Model[j].Titre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 204 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                  double nouv = Model[j].prix - Model[j].reduction * Model[j].prix / 100;

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                 if (Model[j].reduction > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"item-price\"><strike>");
#nullable restore
#line 207 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                             Write(Model[j].prix);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strike> <span>");
#nullable restore
#line 207 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                                                           Write(nouv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
#nullable restore
#line 208 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"item-price\"><span style=\"color:gray\">");
#nullable restore
#line 211 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                                              Write(nouv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
#nullable restore
#line 212 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b72abda7bec3cbb36010de28c2c96dd0efe45bf827853", async() => {
                WriteLiteral("View details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 213 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
                                                                  WriteLiteral(Model[j].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 216 "C:\Users\chifa\OneDrive\Documents\Projet_Exam_ASP_.NetCore\Projet_Exam_ASP.NetCore\Views\Shared\_OffresFiltrées.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LanguageService language { get; private set; } = default!;
        #nullable disable
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
