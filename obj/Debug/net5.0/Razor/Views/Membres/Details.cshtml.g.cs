#pragma checksum "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\Membres\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e27113d4722f11664d689a1cc3f62e82ad31e741"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Membres_Details), @"mvc.1.0.view", @"/Views/Membres/Details.cshtml")]
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
#line 1 "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\_ViewImports.cshtml"
using appli_gest_assoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\_ViewImports.cshtml"
using appli_gest_assoc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27113d4722f11664d689a1cc3f62e82ad31e741", @"/Views/Membres/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e774f7543d1cce8ed40ebd0f3e22cbd242eae720", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Membres_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<appli_gest_assoc.Models.Membre>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\Membres\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
    <div class=""wraper container-fluid"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""bg-light text-center"">
                    <div class=""bg-picture text-center"" style=""background-image:url('images/big/bg.jpg')""></div>
                    <div class=""profile-info-name"">
                        <!-- <img src=""images/avatar-1.jpg"" class=""thumb-lg img-circle img-thumbnail"" alt=""profile-image""> -->
                        <h3 class=""text-dark mb-auto"">");
#nullable restore
#line 15 "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\Membres\Details.cshtml"
                                                 Write(Model.PrenomMembre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\Membres\Details.cshtml"
                                                                     Write(Model.NomMembre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    </div>
                </div>
                <!--/ meta -->
            </div>
        </div>
        <div class=""row user-tabs"">
            <div class=""col-lg-6 col-md-9 col-sm-9"">
                <ul class=""nav nav-tabs tabs"">
                    <li class=""active tab"">
                        <a href=""#home-2"" data-toggle=""tab"" aria-expanded=""false"" class=""active"">
                            <span class=""visible-xs""><i class=""fa fa-home""></i></span>
                            <span class=""hidden-xs"">Infos</span>
                        </a>
                    </li>
");
            WriteLiteral(@"                    <div class=""indicator""></div>
                </ul>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">

                <div class=""tab-content profile-tab-content"">
                    <div class=""tab-pane active"" id=""home-2"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <!-- Personal-Information -->
                                <div class=""panel panel-default panel-fill"">
                                    <div class=""panel-heading"">
                                        <h3 class=""panel-title"">Informations sur le membre</h3>
                                    </div>
                                    <div class=""panel-body"">
                                        <div class=""about-info-p"">
                                            <strong>Nom</strong>
                                            <br />
                                            <p clas");
            WriteLiteral("s=\"text-muted\">");
#nullable restore
#line 56 "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\Membres\Details.cshtml"
                                                             Write(Model.PrenomMembre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 56 "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\Membres\Details.cshtml"
                                                                                 Write(Model.NomMembre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        <div class=""about-info-p"">
                                            <strong>Sexe</strong>
                                            <br />
                                            <p class=""text-muted"">");
#nullable restore
#line 61 "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\Membres\Details.cshtml"
                                                             Write(Model.Sexe);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        <div class=""about-info-p"">
                                            <strong>Date de naissance</strong>
                                            <br />
                                            <p class=""text-muted"">");
#nullable restore
#line 66 "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\Membres\Details.cshtml"
                                                             Write(Model.DateNaiss);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        <div class=""about-info-p"">
                                            <strong>Lieu de naissance</strong>
                                            <br />
                                            <p class=""text-muted"">");
#nullable restore
#line 71 "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\Membres\Details.cshtml"
                                                             Write(Model.LieuNaiss);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        <div class=""about-info-p"">
                                            <strong>Télephone</strong>
                                            <br />
                                            <p class=""text-muted"">");
#nullable restore
#line 76 "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\Membres\Details.cshtml"
                                                             Write(Model.Tel);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        <div class=""about-info-p"">
                                            <strong>Email</strong>
                                            <br />
                                            <p class=""text-muted"">");
#nullable restore
#line 81 "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\Membres\Details.cshtml"
                                                             Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                        <div class=""about-info-p m-b-0"">
                                            <strong>Adresse</strong>
                                            <br />
                                            <p class=""text-muted"">");
#nullable restore
#line 86 "C:\Users\Unknown\source\gest_assoc_final_master-main\appli_gest_assoc\Views\Membres\Details.cshtml"
                                                             Write(Model.Adresse);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        </div>
                                    </div>
                                </div>
                                <!-- Personal-Information -->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<appli_gest_assoc.Models.Membre> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
