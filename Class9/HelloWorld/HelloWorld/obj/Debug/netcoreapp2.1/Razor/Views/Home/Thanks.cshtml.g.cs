#pragma checksum "C:\Users\philg\Documents\GitHub\Greene220B\Class9\HelloWorld\HelloWorld\Views\Home\Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b98882bfa257cb95932c171d1fe99b0ea6027445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Thanks), @"mvc.1.0.view", @"/Views/Home/Thanks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Thanks.cshtml", typeof(AspNetCore.Views_Home_Thanks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b98882bfa257cb95932c171d1fe99b0ea6027445", @"/Views/Home/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ed9e5bca706f09a342cd0ed848f609cec5aeadc", @"/Views/Home/_ViewImports.cshtml")]
    public class Views_Home_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HelloWorld.Models.GuestResponse>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\philg\Documents\GitHub\Greene220B\Class9\HelloWorld\HelloWorld\Views\Home\Thanks.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(67, 32, true);
            WriteLiteral("<!DOCTYPE html>\r\n<h1>Thank you, ");
            EndContext();
            BeginContext(100, 10, false);
#line 6 "C:\Users\philg\Documents\GitHub\Greene220B\Class9\HelloWorld\HelloWorld\Views\Home\Thanks.cshtml"
          Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(110, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 7 "C:\Users\philg\Documents\GitHub\Greene220B\Class9\HelloWorld\HelloWorld\Views\Home\Thanks.cshtml"
 if (Model.WillAttend == true)
{

#line default
#line hidden
            BeginContext(152, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(158, 19, true);
            WriteLiteral("Thanks for coming, ");
            EndContext();
            BeginContext(178, 10, false);
#line 9 "C:\Users\philg\Documents\GitHub\Greene220B\Class9\HelloWorld\HelloWorld\Views\Home\Thanks.cshtml"
                    Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(188, 9, true);
            WriteLiteral("!  \r\n    ");
            EndContext();
            BeginContext(199, 29, true);
            WriteLiteral("We will email any updates to ");
            EndContext();
            BeginContext(229, 11, false);
#line 10 "C:\Users\philg\Documents\GitHub\Greene220B\Class9\HelloWorld\HelloWorld\Views\Home\Thanks.cshtml"
                              Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(240, 3, true);
            WriteLiteral(".\r\n");
            EndContext();
#line 11 "C:\Users\philg\Documents\GitHub\Greene220B\Class9\HelloWorld\HelloWorld\Views\Home\Thanks.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(255, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(261, 26, true);
            WriteLiteral("Sorry you can\'t make it.\r\n");
            EndContext();
#line 15 "C:\Users\philg\Documents\GitHub\Greene220B\Class9\HelloWorld\HelloWorld\Views\Home\Thanks.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelloWorld.Models.GuestResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
