#pragma checksum "C:\Users\pc\source\repos\New folder (13)\Views\Shared\Components\Comment\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b317a2a0eb4b239d94ff176f8ba529d4f20a333"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Comment_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Comment/Default.cshtml")]
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
#line 1 "C:\Users\pc\source\repos\New folder (13)\Views\_ViewImports.cshtml"
using Project_n9ws;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\source\repos\New folder (13)\Views\_ViewImports.cshtml"
using Project_n9ws.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc\source\repos\New folder (13)\Views\_ViewImports.cshtml"
using Project_n9ws.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pc\source\repos\New folder (13)\Views\_ViewImports.cshtml"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pc\source\repos\New folder (13)\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b317a2a0eb4b239d94ff176f8ba529d4f20a333", @"/Views/Shared/Components/Comment/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a5c40e49913cc97aeb1cd64b81dd48b152bebce", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Comment_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserCommentsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pc\source\repos\New folder (13)\Views\Shared\Components\Comment\Default.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<section style=\"background-color: #f7f6f6;\">\r\n    <div class=\"container  text-dark\">\r\n        <div class=\"row d-flex justify-content-center\">\r\n");
#nullable restore
#line 7 "C:\Users\pc\source\repos\New folder (13)\Views\Shared\Components\Comment\Default.cshtml"
             foreach (var comment in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-12 col-lg-10 col-xl-8"">
                    <div class=""card mb-3"">
                        <div class=""card-body"">
                            <div class=""d-flex flex-start"">
                                <img class=""rounded-circle shadow-1-strong me-3""
                                     src=""https://mdbcdn.b-cdn.net/img/Photos/Avatars/img%20(26).webp""
                                     alt=""avatar""
                                     width=""40""
                                     height=""40"" />
                                <div class=""w-100"">
                                    <div class=""d-flex justify-content-between align-items-center mb-3"">
                                        <h6 class=""text-primary fw-bold mb-0"">
                                            ");
#nullable restore
#line 22 "C:\Users\pc\source\repos\New folder (13)\Views\Shared\Components\Comment\Default.cshtml"
                                       Write(comment.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <span class=\"text-dark ms-2\">");
#nullable restore
#line 23 "C:\Users\pc\source\repos\New folder (13)\Views\Shared\Components\Comment\Default.cshtml"
                                                                    Write(comment.CommentUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </h6>\r\n                                        <p class=\"mb-0\">");
#nullable restore
#line 25 "C:\Users\pc\source\repos\New folder (13)\Views\Shared\Components\Comment\Default.cshtml"
                                                   Write(comment.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""d-flex justify-content-between align-items-center"">
                                        <p class=""small mb-0"" style=""color: #aaa;"">
                                            <a href=""#!"" class=""link-grey"">Remove</a> •
                                        </p>
                                        <div class=""d-flex flex-row"">
                                            <i class=""fas fa-star text-warning me-2""></i>
                                            <i class=""far fa-check-circle"" style=""color: #aaa;""></i>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
");
#nullable restore
#line 42 "C:\Users\pc\source\repos\New folder (13)\Views\Shared\Components\Comment\Default.cshtml"


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 48 "C:\Users\pc\source\repos\New folder (13)\Views\Shared\Components\Comment\Default.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserCommentsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591